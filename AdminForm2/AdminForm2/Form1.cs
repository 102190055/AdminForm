using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbbLSH.Items.Add(new CBBItem { Value = 0, Text = "All" });
            SetCBB(cbbLSH);
            cbbLSH.SelectedIndex = 0;
            SetCBBSort();
        }
        public void SetCBB(ComboBox cb)
        {
            foreach (LSH i in CSDLOOP.Instance.GetAllLSH())
            {
                cb.Items.Add(new CBBItem
                {
                    Value = i.ID_Lop,
                    Text = i.NameLop,
                });
            }
        }
        public void Show(int id_lop, string name)
        {
            if (id_lop == 0)
            {
                dataGridView1.DataSource = CSDLOOP.Instance.GetAllSV();
            }
            else
            {
                dataGridView1.DataSource = CSDLOOP.Instance.GetListSV(id_lop, null);
            }
        }
        public void Search(int id_lop, string name)
        {
            if (name != null)
            {
                dataGridView1.DataSource = CSDLOOP.Instance.GetListSV(0, name);
            }
        }
        public void Delete(List<string> MSSV)
        {
            foreach (SV s in CSDLOOP.Instance.GetListSV_ByMSSV(MSSV))
            {
                foreach (DataRow i in CSDL.Instance.DTSV.Select())
                {
                    if (i["MSSV"].ToString() == s.MSSV)
                        CSDL.Instance.DTSV.Rows.Remove(i);
                }
                CSDL.Instance.DTSV.AcceptChanges();
            }
        }
        private void btShow_Click(object sender, EventArgs e)
        {
            Show(cbbLSH.SelectedIndex, null);
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            Search(0, txbSearch.Text);
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            List<string> MSSVdel = new List<string>();
            foreach (DataGridViewRow i in r)
            {
                MSSVdel.Add(i.Cells["MSSV"].Value.ToString());
            }
            Delete(MSSVdel);
            dataGridView1.DataSource = CSDL.Instance.DTSV;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            string MSSV = "";
            int ClassID = 0;
            f2.d(MSSV, ClassID);
            dataGridView1.DataSource = CSDL.Instance.DTSV;
            cbbLSH.SelectedIndex = 0;
            f2.ShowDialog();
        }
        private void btEdit_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Form2 f2 = new Form2();
                string MSSV = dataGridView1.CurrentRow.Cells["MSSV"].Value.ToString();
                int ClassID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_Lop"].Value);
                f2.SetDetail_ByMSSV(CSDLOOP.Instance.GetRowSV_ByMSSV(dataGridView1.Rows[index].Cells["MSSV"].Value.ToString()));
                f2.d(MSSV, ClassID);
                dataGridView1.DataSource = CSDL.Instance.DTSV;
                cbbLSH.SelectedIndex = 0;
                f2.ShowDialog();
            }
        }
        public void SetCBBSort()
        {
            int dem = 0;
            foreach (DataColumn i in CSDL.Instance.DTSV.Columns)
            {
                cbSort.Items.Add(new CBBItem
                {
                    Text = i.ColumnName,
                    Value = dem++
                });
            }
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            if (cbSort.SelectedItem == null)
                MessageBox.Show("Nhap phuong thuc can xap xep");
            else
            dataGridView1.DataSource = CSDLOOP.Instance.SortSV(cbSort.SelectedItem.ToString());

        }
    }
}