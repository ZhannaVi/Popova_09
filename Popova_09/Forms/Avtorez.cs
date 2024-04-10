using Popova_09.Forms;
using Popova_09.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Popova_09
{
    public partial class Avtorez : Form
    {
        public Avtorez()
        {
            InitializeComponent();
        }

        private void btnVxod_Click(object sender, EventArgs e)
        {
            string username = txtLogin.Text;
            string password = txtPas.Text;
            try
            {
                List<User> users = Monk_PopovaEntities1.GetContext().Users.ToList();

                User u = users.FirstOrDefault(p => p.UserName == username && p.UserPass == password);
                if (u != null)
                {


                    MainF mainWindow = new MainF( u.UserName);
                    mainWindow.Owner = this;
                    this.Hide();
                    txtPas.Clear();
                    mainWindow.Show();
                }
                else
                {
                    MessageBox.Show("Не верный пароль или логин");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnGost_Click(object sender, EventArgs e)
        {

        }
    }
    }
