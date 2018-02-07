using System;
using System.Linq;
using System.Windows.Forms;
using AplikacjaObslugiBazyDanych.Code.Helpers;
using AplikacjaObslugiBazyDanych.Models;
using AplikacjaObslugiBazyDanych.Resources;

namespace AplikacjaObslugiBazyDanych
{
    public partial class Login : Form
    {
        private readonly DatabaseContext context = new DatabaseContext();

        public Login()
        {
            InitializeComponent();
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            var login = TextBox_Login.Text;
            var password = UserHelper.HashPassword(TextBox_Password.Text);
            
            var employee = context.Employees.FirstOrDefault(a => a.UserName == login && a.Password == password);

            if (employee == null)
            {
                Label_Error.Text = LoginFormRes.IncorectData;
            }
            else
            {
                Label_Error.Text = GlobalRes.Empty;
                employee.Password = null;
                UserHelper.Employee = employee;

                this.Hide();
                var form2 = new MainWindow();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            
        }
    }
}
