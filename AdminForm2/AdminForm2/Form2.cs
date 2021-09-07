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
    public partial class Form2 : Form
    {
        public delegate void Mydel(string MSSV, int ClassID);
        public Mydel d;
        string MSSV = "";
        int ClassID = 0;
        private void getCSDL(string _MSSV, int _ClassID)
        {
            MSSV = _MSSV;
            ClassID = _ClassID;
        }
        public Form2()
        {
            d = new Mydel(getCSDL);
            InitializeComponent();
            Form1 f1 = new Form1();
            f1.SetCBB(cbbLopSH2);
            cbbLopSH2.SelectedIndex = 0;
        }
        private void butOK_Click(object sender, EventArgs e)
        {
            if (MSSV == "")
            {
                CSDLOOP.Instance.SetSV(getsSV());
            }
            else
            {
                CSDLOOP.Instance.setSVByID(MSSV, getsSV());
            }
            this.Dispose();
        }
        private SV getsSV()
        {
            SV s = new SV();
            s.MSSV = txbMSSV.Text;
            s.NameSV = txbNameSV.Text;
            if (rbm.Checked)
                s.Gender = true;
            else
                s.Gender = false;
            s.NS = Convert.ToDateTime(dtNS.Value);
            s.ID_Lop = ((CBBItem)cbbLopSH2.SelectedItem).Value;
            return s;
        }
        public void SetDetail_ByMSSV(DataRow data)
        {
            txbMSSV.Text = data["MSSV"].ToString();
            txbNameSV.Text = data["NameSV"].ToString();
            dtNS.Value = Convert.ToDateTime(data["NS"].ToString());
            if (Convert.ToBoolean(data["Gender"].ToString()))
                rbm.Checked = true;
            else
                rbfe.Checked = true;
            int ID = Convert.ToInt32(data["ID_Lop"].ToString());
            for (int i = 0; i < cbbLopSH2.Items.Count; i++)
            {
                if (((CBBItem)cbbLopSH2.Items[i]).Value == ID)
                {
                    cbbLopSH2.SelectedIndex = i;
                }
            }
        }
        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //private void Form2_Load(object sender, EventArgs e)
        //{

        //}
    }
}