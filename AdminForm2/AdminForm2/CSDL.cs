
using AdminForm2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV1
{
    class CSDL
    {
        public DataTable DTSV { get; set; }
        public DataTable DTLSH { get; set; }
        public static CSDL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CSDL();
                }
                return _Instance;
            }
            private set
            {
            }
        }

        private static CSDL _Instance;
        // Create Data
        private CSDL()
        {
            //Data SV
            DTSV = new DataTable();
            DTSV.Columns.AddRange(new DataColumn[]
            {
                new DataColumn ("MSSV", typeof(string)),
                new DataColumn ("NameSV", typeof(string)),
                new DataColumn ("Gender", typeof(bool)),
                new DataColumn ("NS", typeof(DateTime)),
                new DataColumn ("ID_Lop", typeof(int)),
            });
            DataRow dr = DTSV.NewRow();
            dr["MSSV"] = "001";
            dr["NameSV"] = "NVA";
            dr["Gender"] = true; 
            dr["NS"] = DateTime.Now;
            dr["ID_Lop"] = 1;
            DTSV.Rows.Add(dr);

            DataRow dr1 = DTSV.NewRow();
            dr1["MSSV"] = "002"; 
            dr1["NameSV"] = "NVB";
            dr1["Gender"] = true;
            dr1["NS"] = DateTime.Now;
            dr1["ID_Lop"] = 2;
            DTSV.Rows.Add(dr1);

            DataRow dr2 = DTSV.NewRow();
            dr2["MSSV"] = "004";
            dr2["NameSV"] = "NTB";
            dr2["Gender"] = false;
            dr2["NS"] = DateTime.Now;
            dr2["ID_Lop"] = 1;
            DTSV.Rows.Add(dr2);

            DataRow dr5 = DTSV.NewRow();
            dr5["MSSV"] = "003";
            dr5["NameSV"] = "NTC";
            dr5["Gender"] = false;
            dr5["NS"] = DateTime.Now;
            dr5["ID_Lop"] = 2;
            DTSV.Rows.Add(dr5);

            //Data LSH
            DTLSH = new DataTable();
            DTLSH.Columns.AddRange(new DataColumn[]
            {
                new DataColumn ("ID_Lop", typeof(int)),
                new DataColumn ("NameLop", typeof(string)),
            });
            DataRow dr3 = DTLSH.NewRow();
            dr3["ID_Lop"] = 1;
            dr3["NameLop"] = "19TCLC_DT1";
            DTLSH.Rows.Add(dr3);

            DataRow dr4 = DTLSH.NewRow();
            dr4["ID_Lop"] = 2; 
            dr4["NameLop"] = "19TCLC_DT2";
            DTLSH.Rows.Add(dr4);
        }
        public void setDTSV(List<SV> sv)
        {
            DTSV.Rows.Clear();
            foreach (var i in sv)
            {
                DataRow dr = DTSV.NewRow();
                dr["MSSV"] = i.MSSV;
                dr["NameSV"] = i.NameSV;
                dr["Gender"] = i.Gender;
                dr["NS"] = i.NS;
                dr["ID_Lop"] = i.ID_Lop;
                DTSV.Rows.Add(dr);

            }
        }
    }
}