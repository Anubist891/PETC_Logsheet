using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PETC_Logsheet;

namespace PETC_Logsheet
{
    public partial class frmMainMenu : Form
    {
        //PETC_LogsheetEntities tbl_entities = new PETC_LogsheetEntities();
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            TBL_LOGSHEET_INQUIRY tbl_Inquiry = new TBL_LOGSHEET_INQUIRY();
            tbl_Inquiry.LOG_DATE = Convert.ToDateTime(tbl_Inquiry.LOG_DATE);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<TBL_LOGSHEET_INQUIRY> list = new List<TBL_LOGSHEET_INQUIRY>();
            List<AddInquiryCetificateClass> listo = new List<AddInquiryCetificateClass>();
            using (var db = new PETC_LogsheetEntities())
            {
                list = db.TBL_LOGSHEET_INQUIRY.ToList();
                foreach(var item in list)
                {
                    AddInquiryCetificateClass tbl = new AddInquiryCetificateClass();
                    tbl.LOG_DATE = Convert.ToDateTime(item.LOG_DATE);
                    tbl.LOG_PETCNAME = item.LOG_PETCNAME;
                    tbl.LOG_RECEIVEDVIA = item.LOG_RECEIVEDVIA;
                    tbl.LOG_RECEIVEDBY = item.LOG_DTLINQUIRY;
                    tbl.LOG_DATE = Convert.ToDateTime(item.LOG_DATE);
                    tbl.LOG_DTLINQUIRY = item.LOG_DTLINQUIRY;
                    tbl.LOG_ACTTAKEN = item.LOG_ACTTAKEN;
                    tbl.LOG_TMECMPLTED = Convert.ToDateTime(item.LOG_TMECMPLTED);
                    tbl.LOG_REMARKS = item.LOG_REMARKS;
                    var resp = item.LOG_DATE.Value - item.LOG_TMECMPLTED.Value;
                    tbl.LOG_RESPONSE = Convert.ToString(resp.Duration());
                    listo.Add(tbl);

                }
            }
            CrystalReport1 rpt = new CrystalReport1();
            rpt.SetDataSource(listo);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
