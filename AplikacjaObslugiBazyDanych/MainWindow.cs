using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplikacjaObslugiBazyDanych.Code.Helpers;
using AplikacjaObslugiBazyDanych.Models;

namespace AplikacjaObslugiBazyDanych
{
    public partial class MainWindow : Form
    {
        private DatabaseContext context = new DatabaseContext();

        public MainWindow()
        {
            InitializeComponent(); 

            RoleName.Text = UserHelper.Employee.Role.RoleName;
            UserName.Text = UserHelper.Employee.GetFullName();
        }
    }
}
