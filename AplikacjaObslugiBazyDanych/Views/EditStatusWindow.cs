using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplikacjaObslugiBazyDanych.Models;

namespace AplikacjaObslugiBazyDanych.Views
{
    public partial class EditStatusWindow : Form
    {
        private List<Status> statuses;

        public EditStatusWindow()
        {
            InitializeComponent();
            using (var context = new DatabaseContext())
            {
                statuses = context.Statuses.ToList();
            }
            foreach (var status in statuses)
            {
                DataTable.RowCount++;
                DataTable.Rows[DataTable.RowCount - 1].Cells[1].Value = status.StatusName;
                DataTable.Rows[DataTable.RowCount - 1].Cells[2].Value = status.StatusId;
            }
            SetIndexes();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            DataTable.RowCount++;
            SetIndexes();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            var selected = DataTable.SelectedCells;
            if (selected.Count > 0)
            {
                if (DataTable.Rows[selected[0].RowIndex].Cells[2].Value == null)
                {
                    DataTable.Rows.RemoveAt(selected[0].RowIndex);
                }
                else
                {
                    // TODO !!
                    // TODO Dodać sprawdzenie czy nie jest powiączany z zamówieniami
                    // TODO !!
                    var id = (int)DataTable.Rows[selected[0].RowIndex].Cells[2].Value;
                    using (var context = new DatabaseContext())
                    {
                        var element = context.Statuses.SingleOrDefault(a =>
                            a.StatusId == id);
                        if (element != null)
                        {
                            context.Statuses.Remove(element);
                        }
                    }
                    DataTable.Rows.RemoveAt(selected[0].RowIndex);
                }
            }
            SetIndexes();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var newList = new List<Status>();

            foreach (DataGridViewRow row in DataTable.Rows)
            {
                newList.Add(new Status()
                {
                    StatusName = row.Cells[1].Value?.ToString(),
                    StatusId = (int?)row.Cells[2].Value ?? -1,
                });
            }
            using (var context = new DatabaseContext())
            {
                foreach (var element in newList)
                {
                    if (element.StatusId == -1)
                        context.Statuses.Add(element);
                    else
                        context.Statuses.AddOrUpdate(element);
                }


                context.SaveChanges();
            }
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
