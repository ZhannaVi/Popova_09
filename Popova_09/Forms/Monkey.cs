using Popova_09.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Popova_09.Forms
{
    public partial class Monkey : Form
    {
        public Monkey()
        {
            InitializeComponent();
            LoadAndIntiData();
            var ViewMonkeys = Monk_PopovaEntities1.GetContext().ViewMonkeys.OrderBy(p => p.NameView).ToList();
            ViewMonkeys.Insert(0, new ViewMonkey
            {
                NameView = "Все типы"
            });
            g2CBView.DataSource = ViewMonkeys;
            g2CBView.DisplayMember = "NameView";
            g2CBView.ValueMember = "ViewId";
        }
        int _itemcount = 0;
        private void LoadAndIntiData()
        {
            var currentMonkey = Monk_PopovaEntities1.GetContext().Monkeys.Join
                (Monk_PopovaEntities1.GetContext().ViewMonkeys, p => p.ViewId, t => t.ViewId, (p, t) => new { p.MonkeyName,t.NameView ,p.Relaese, p.Owner, p.DatePriem, p.Cost, p.descr}).ToList();
            guna2DataGridView1.DataSource = currentMonkey;

            guna2DataGridView1.Columns[0].HeaderText = "Название";
            guna2DataGridView1.Columns[1].HeaderText = "Вид";
            guna2DataGridView1.Columns[2].HeaderText = "Год рождения";
            guna2DataGridView1.Columns[3].HeaderText = "Собственник";
            guna2DataGridView1.Columns[4].HeaderText = "Дата приема";
            guna2DataGridView1.Columns[5].HeaderText = "Цена";
            guna2DataGridView1.Columns[6].HeaderText = "Описание";
           

            _itemcount = guna2DataGridView1.Rows.Count;

            label5.Text = $"Результат запроса: {currentMonkey.Count} записей из {_itemcount}";
        }
        private void UpdateData()
        {
            var currentMonkey = Monk_PopovaEntities1.GetContext().Monkeys.Join
                (Monk_PopovaEntities1.GetContext().ViewMonkeys, p => p.ViewId, t => t.ViewId, (p, t) => new {p.ViewId, p.MonkeyName, t.NameView, p.Relaese, p.Owner, p.DatePriem, p.Cost, p.descr }).ToList();

            if(g2CBView.SelectedIndex > 0)
            
                currentMonkey = currentMonkey.Where(p=>p.ViewId == (g2CBView.SelectedItem as ViewMonkey).ViewId).ToList();
            
            currentMonkey = currentMonkey.Where(p=>p.NameView.ToLower().Contains(g2TXBName.Text.ToLower())).ToList();

            if (g2CBSale.SelectedIndex >= 0)
            {
                if(g2CBSale.SelectedIndex == 0)
                {
                    currentMonkey = currentMonkey.OrderBy(p=>p.Cost).ToList();
                }
                if(g2CBSale.SelectedIndex == 1)
                {
                    currentMonkey = currentMonkey.OrderByDescending(p=>p.Cost).ToList();
                }  
            }
                guna2DataGridView1.DataSource = currentMonkey;

                label5.Text = $"Результат запроса: {currentMonkey.Count} записей из {_itemcount}";

          

        }

        private void g2CBView_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void g2TXBName_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void g2CBSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }
    }
}
