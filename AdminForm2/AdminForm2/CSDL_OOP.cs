using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV1
{
    class CSDLOOP
    {
        private static CSDLOOP _Instance;

        public static CSDLOOP Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new CSDLOOP();
                return _Instance;
            }
            private set
            {

            }
        }
        private CSDLOOP() { }
        public List<SV> GetAllSV()
        {
            List<SV> sv = new List<SV>();
            // Code : Trả về tất cả các đối tượng sv tương ứng với datatable SV
            foreach (DataRow i in CSDL.Instance.DTSV.Rows)
            {
                SV s = new SV();
                s.MSSV = i["MSSV"].ToString();
                s.NameSV = i["NameSV"].ToString();
                s.Gender = Convert.ToBoolean(i["Gender"].ToString());
                s.NS = Convert.ToDateTime(i["NS"].ToString());
                s.ID_Lop = Convert.ToInt32(i["ID_Lop"].ToString());
                sv.Add(s);
            }
            return sv;
        }
        public SV GetSV(DataRow i)
        {
            SV s = new SV();
            // Code: Trả về tất cả đối tượng SV tương ứng 1 DataRow trong DataTable SV
            s.MSSV = i["MSSV"].ToString();
            s.NameSV = i["NameSV"].ToString();
            s.Gender = Convert.ToBoolean(i["Gender"].ToString());
            s.NS = Convert.ToDateTime(i["NS"].ToString());
            s.ID_Lop = Convert.ToInt32(i["ID_Lop"].ToString());
            return s;
        }
        public List<LSH> GetAllLSH()
        {
            List<LSH> lsh = new List<LSH>();
            // Code: Trả về tất cả các đối tượng có trong datatable LSH
            foreach (DataRow i in CSDL.Instance.DTLSH.Rows)
            {
                LSH l = new LSH();
                l.ID_Lop = Convert.ToInt32(i["ID_Lop"].ToString());
                l.NameLop = i["NameLop"].ToString();
                lsh.Add(l);
            }
            return lsh;
        }
        public LSH GetLSH(DataRow i)
        {
            LSH l = new LSH();
            l.ID_Lop = Convert.ToInt32(i["ID_Lop"].ToString());
            l.NameLop = i["NameLop"].ToString();
            return l;
        }
        public List<SV> GetListSV(int ID_Lop, string Name)
        {
            List<SV> sv = new List<SV>();
            // Code: Trả về list sv tương ứng với lsh và txtsearch (name)
            foreach (SV s in GetAllSV())
            {
                if (s.ID_Lop == ID_Lop || s.NameSV == Name)
                {
                    sv.Add(s);
                }
            }
            return sv;
        }
        public List<SV> GetListSV_ByMSSV(List<string> data)
        {
            List<SV> sv = new List<SV>();
            // Code: Lay du lieu theo listsv theo MSSV
            foreach (string i in data)
            {
                foreach (DataRow j in CSDL.Instance.DTSV.Rows)
                {
                    if (i == j["MSSV"].ToString())
                    {
                        SV s = new SV();
                        s.MSSV = j["MSSV"].ToString();
                        s.NameSV = j["NameSV"].ToString();
                        s.Gender = Convert.ToBoolean(j["Gender"].ToString());
                        s.NS = Convert.ToDateTime(j["NS"].ToString());
                        s.ID_Lop = Convert.ToInt32(j["ID_Lop"].ToString());
                        sv.Add(s);
                    }
                }
            }
            return sv;
        }
        public void GetSVToList(SV sV)
        {
            List<SV> s = new List<SV>();
            foreach (DataRow i in CSDL.Instance.DTSV.Rows)
            {
                s.Add(GetSV(i));
            }
        }
        public DataRow GetRowSV_ByMSSV(string MSSV)
        {
            DataRow dt = CSDL.Instance.DTSV.NewRow();
            foreach (DataRow i in CSDL.Instance.DTSV.Rows)
            {
                if (i["MSSV"].ToString() == MSSV)
                {
                    dt = i;
                }
            }
            return dt;
        }
        public bool SetSV(SV s)
        {
            List<SV> sv = new List<SV>();
            foreach (DataRow i in CSDL.Instance.DTSV.Rows)
            {
                sv.Add(GetSV(i));
            }
            sv.Add(s);
            CSDL.Instance.setDTSV(sv);
            return true;
        }
        public bool setSVByID(string MSSV, SV sv)
        {
            List<SV> listSV = new List<SV>();
            foreach (DataRow i in CSDL.Instance.DTSV.Rows)
            {
                listSV.Add(GetSV(i));
            }
            int SVIndex = 0;
            foreach (var i in listSV)
            {
                if (listSV[SVIndex].MSSV == MSSV)
                {
                    listSV[SVIndex] = sv;
                    break;
                }
                SVIndex++;
            }
            CSDL.Instance.setDTSV(listSV);
            return true;
        }
        public List<SV> SortSV(string ColumnName)
        {
            List<SV> sv = GetAllSV();
            for (int i = 0; i < sv.Count; i++)
            {
                for (int j = 0; j < sv.Count; j++)
                {
                    switch (ColumnName)
                    {
                        case "MSSV":
                            {
                                if (String.Compare(sv[i].MSSV, sv[j].MSSV) > 0)
                                {
                                    SV temp = sv[i];
                                    sv[i] = sv[j];
                                    sv[j] = temp;
                                }
                            }
                            break;
                        case "NameSV":
                            {
                                if (String.Compare(sv[i].NameSV, sv[j].NameSV) > 0)
                                {
                                    SV temp = sv[i];
                                    sv[i] = sv[j];
                                    sv[j] = temp;
                                }
                            }
                            break;
                        case "NS":
                            {
                                if (DateTime.Compare(sv[i].NS, sv[j].NS) > 0)
                                {
                                    SV temp = sv[i];
                                    sv[i] = sv[j];
                                    sv[j] = temp;
                                }
                            }
                            break;
                        case "ID_Lop":
                            {
                                if (sv[i].ID_Lop > sv[j].ID_Lop)
                                {
                                    SV temp = sv[i];
                                    sv[i] = sv[j];
                                    sv[j] = temp;
                                }
                            }
                            break;
                    }
                }
            }
            return sv;
        }
    }
}