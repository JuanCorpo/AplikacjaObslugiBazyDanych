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
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            using (var context = new DatabaseContext())
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
                    UserHelper.LoggedIn = true;

                    this.Hide();
                    var form2 = new MainWindow();
                    form2.ShowDialog();
                    if (UserHelper.LoggedIn == false)
                    {
                        this.Show();
                    }
                    else
                    {
                        this.Close();
                    }

                }
            }
        }
    }
}
