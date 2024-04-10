using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Popova_09.Forms
{
    public partial class MainF : Form
    {
        public MainF(string login)
        {
            
            InitializeComponent();
        }

        private void MainF_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void мартышкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Monkey monkey = new Monkey();
            monkey.Show();
        }

        private void продажиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale();
            sale.Show();
        }
    }
}
