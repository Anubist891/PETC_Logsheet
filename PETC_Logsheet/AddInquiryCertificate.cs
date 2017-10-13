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
    public partial class AddInquiryCertificate : Form
    {
        PETC_LogsheetEntities db_LogsheetUtil = new PETC_LogsheetEntities();
        
        public AddInquiryCertificate()
        {
            InitializeComponent();
        }

        //private void btnSave_Click(TBL_LOGSHEET_INQUIRY tbl)
        //{
            
            



        //}

        private void btnSave_Click(object sender, EventArgs e)
        {
            TBL_LOGSHEET_INQUIRY tbl_Inquiry = new TBL_LOGSHEET_INQUIRY();
            tbl_Inquiry.LOG_DATE = DateTime.Now;
            tbl_Inquiry.LOG_PETCCODE = cmboxPETC.Text;
            tbl_Inquiry.LOG_RECEIVEDVIA = txtReceivedvia.Text;
            tbl_Inquiry.LOG_RECEIVEDBY = txtReceivedby.Text;
            tbl_Inquiry.LOG_DTLINQUIRY = txtDetailsofInquiry.Text;
            tbl_Inquiry.LOG_DATE = dtetimeReceived.Value;
            tbl_Inquiry.LOG_ACTTAKEN = txtActionTaken.Text;
            tbl_Inquiry.LOG_TMECMPLTED = dtetmeCompleted.Value;
            tbl_Inquiry.LOG_REMARKS = richtxtRemarks.Text;

            db_LogsheetUtil.TBL_LOGSHEET_INQUIRY.Add(tbl_Inquiry);
            db_LogsheetUtil.SaveChanges();
            MessageBox.Show("Successfully Save");
            
        }
    }
}
