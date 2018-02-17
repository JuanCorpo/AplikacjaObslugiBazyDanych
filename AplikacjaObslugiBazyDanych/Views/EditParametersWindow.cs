using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplikacjaObslugiBazyDanych.Models;

namespace AplikacjaObslugiBazyDanych.Views
{
    public partial class EditParametersWindow : Form
    {
        private DatabaseContext context = new DatabaseContext();
        private List<ParameterType> parameterTypes;

        public EditParametersWindow()
        {
            InitializeComponent();

            parameterTypes = context.ParametersTypes.ToList();

            foreach (var parameterType in parameterTypes)
            {
                DataTable.RowCount++;
                DataTable.Rows[DataTable.RowCount - 1].Cells[1].Value = parameterType.ParameterName;
                DataTable.Rows[DataTable.RowCount - 1].Cells[2].Value = parameterType.ValueType;
                DataTable.Rows[DataTable.RowCount - 1].Cells[3].Value = parameterType.ParameterId;
            }
            SetIndexes();
        }

        private void AddNewRow_Click(object sender, EventArgs e)
        {
            DataTable.RowCount++;
            SetIndexes();
        }

        private void RemoveSelectedRow_Click(object sender, EventArgs e)
        {
            var selected = DataTable.SelectedCells;
            if (selected.Count > 0)
            {
                if (DataTable.Rows[selected[0].RowIndex].Cells[3].Value == null)
                {
                    DataTable.Rows.RemoveAt(selected[0].RowIndex);
                }
                else
                {
                    // TODO !!
                    // TODO Dodać sprawdzenie czy nie jest powiączany z produktami
                    // TODO !!
                    var id = (int)DataTable.Rows[selected[0].RowIndex].Cells[3].Value;
                    var element = context.ParametersTypes.SingleOrDefault(a =>
                        a.ParameterId == id);
                    if (element != null)
                    {
                        context.ParametersTypes.Remove(element);
                        context.SaveChanges();
                    }
                    DataTable.Rows.RemoveAt(selected[0].RowIndex);
                }
            }
            SetIndexes();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var newList = new List<ParameterType>();

            foreach (DataGridViewRow row in DataTable.Rows)
            {
                newList.Add(new ParameterType()
                {
                    ParameterName = row.Cells[1].Value?.ToString(),
                    ValueType = row.Cells[2].Value.ToString(),
                    ParameterId = (int?)row.Cells[3].Value ?? -1,
                });
            }

            foreach (var element in newList)
            {
                if (element.ParameterId == -1)
                    context.ParametersTypes.Add(element);
                else
                    context.ParametersTypes.AddOrUpdate(element);
            }


            context.SaveChanges();
        }

        private void SetIndexes()
        {
            for (var i = 0; i < DataTable.Rows.Count; i++)
            {
                DataTable.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
