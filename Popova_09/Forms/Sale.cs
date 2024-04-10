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
using Excel = Microsoft.Office.Interop.Excel;

namespace Popova_09.Forms
{
    public partial class Sale : Form
    {
        public Sale()
        {
            InitializeComponent();
            LoadAndIntiData();
        }

        private void LoadAndIntiData()
        {
            var currentSale = Monk_PopovaEntities1.GetContext().Sales.Join
                (Monk_PopovaEntities1.GetContext().Monkeys, p => p.MonkeyId, t => t.MonkeyId, (p, t) => new { t.MonkeyName, p.dateSale, p.StartPrice, p.LastPrice, p.answer, p.surname }).ToList();
            guna2DataGridView2.DataSource = currentSale;
            guna2DataGridView2.Columns[0].HeaderText = "Name";

            guna2DataGridView2.Columns[1].HeaderText = "Дата приобритения";
            guna2DataGridView2.Columns[2].HeaderText = "Начальная цена";
            guna2DataGridView2.Columns[3].HeaderText = "Конечная цена";
            guna2DataGridView2.Columns[4].HeaderText = "Ответ";
            guna2DataGridView2.Columns[5].HeaderText = "Фамилия покупателя";


        }

        private void g2BUp_Click(object sender, System.EventArgs e)
        {
            //var application = new Excel.Application();
            //application.SheetsInNewWorkbook = 1;
            //Excel.Workbook workbook = application.Workbooks.Add(Type.Missing);
            //Excel.Worksheet worksheet = application.Worksheets.Item[1];
            //worksheet.Name = "Sale";

            //worksheet.Cells[1, 1] = guna2DataGridView2.Columns[0].HeaderCell.Value;
            //worksheet.Cells[1, 2] = guna2DataGridView2.Columns[1].HeaderCell.Value;
            //worksheet.Cells[1, 3] = guna2DataGridView2.Columns[2].HeaderCell.Value;
            //worksheet.Cells[1, 4] = guna2DataGridView2.Columns[3].HeaderCell.Value;
            //worksheet.Cells[1, 5] = guna2DataGridView2.Columns[4].HeaderCell.Value;
            //worksheet.Cells[1, 6] = guna2DataGridView2.Columns[5].HeaderCell.Value;

            //for (int j = 2; j <guna2DataGridView2.ColumnCount; j++)
            //{
            //    worksheet.Cells[j,1] = guna2DataGridView2[0,j-2].Value;
            //    worksheet.Cells[j,2] = guna2DataGridView2[1, j - 2].Value;

            //}
            //application.Visible = true;

            Excel.Application ex = new Excel.Application();

            ex.SheetsInNewWorkbook = 1;
            Excel.Workbook wb = ex.Workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = ex.Worksheets.Item[1];
            worksheet.Name = "Продажи";
            for (int i = 0; i < guna2DataGridView2.ColumnCount; i++)
            {
                string columnName = guna2DataGridView2.Columns[i].HeaderText;
                worksheet.Cells[1, i + 1] = columnName;

                for (int j = 0; j < guna2DataGridView2.RowCount; j++)
                {
                    worksheet.Cells[j + 2, i + 1] = guna2DataGridView2.Rows[j].Cells[i].Value;
                }
            }
            ex.Visible = true;
        }
    }

}
