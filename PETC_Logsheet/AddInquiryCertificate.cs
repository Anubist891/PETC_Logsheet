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
        int record_id = 0;
        
        public AddInquiryCertificate()
        {
            InitializeComponent();
        }

        public AddInquiryCertificate(TBL_LOGSHEET_INQUIRY tBL_LOGSHEET_INQUIRY)
        {
            // TODO: Complete member initialization
            //this.tBL_LOGSHEET_INQUIRY = tBL_LOGSHEET_INQUIRY;
        }

        private void AddInquiryCertificate_Load(object sender, EventArgs e)
        {
            //VIEWING DATA IN DATAGRID

            db_LogsheetUtil = new PETC_LogsheetEntities();
            dataGridView1.DataSource = db_LogsheetUtil.TBL_LOGSHEET_INQUIRY.ToList();
            dataGridView1.Columns["LOG_DATE"].DefaultCellStyle.Format = "yy/MM/dd";
            dataGridView1.Columns["LOG_PETCCODE"].Visible = false;
            dataGridView1.Columns["LOG_TMERECEIVE"].DefaultCellStyle.Format = "HH:mm";
            dataGridView1.Columns["LOG_TMECMPLTED"].DefaultCellStyle.Format = "HH:mm";
            dataGridView1.Columns["LOG_RESPONSE"].DefaultCellStyle.Format = "HH:mm";
            dataGridView1.Columns["LOG_ENCODED"].Visible = false;
            dataGridView1.Columns["LOG_DATELOG"].Visible = false;
            dataGridView1.Columns["LOG_REGISTRYCODE"].Visible = false;
            dataGridView1.Columns["LOG_CERTIFICATE"].Visible = false;



            dataGridView1.Columns["LOG_DATE"].HeaderText = "DATE";
            dataGridView1.Columns["LOG_PETCNAME"].HeaderText = "PETC NAME";
            dataGridView1.Columns["LOG_RECEIVEDVIA"].HeaderText = "RECEIVE VIA";
            dataGridView1.Columns["LOG_RECEIVEDBY"].HeaderText = "RECEIVE BY";
            dataGridView1.Columns["LOG_DATE"].HeaderText = "TIME RECEIVE";
            dataGridView1.Columns["LOG_DTLINQUIRY"].HeaderText = "DETAIL INQUIRY";
            dataGridView1.Columns["LOG_TMECMPLTED"].HeaderText = "TIME COMPLETED";
            dataGridView1.Columns["LOG_ACTTAKEN"].HeaderText = "ACTION TAKEN";
            dataGridView1.Columns["LOG_REMARKS"].HeaderText = "REMARKS";
            dataGridView1.Columns["LOG_RESPONSE"].HeaderText = "RESPONSE TIME";

            cmboxPETC.Text = string.Empty;
            txtReceivedvia.Text = string.Empty;
            txtReceivedby.Text = string.Empty;
            txtDetailsofInquiry.Text = string.Empty;
            txtActionTaken.Text = string.Empty;
            richtxtRemarks.Text = string.Empty;

            cmboxPETC.Enabled = false;
            txtReceivedby.Enabled = false;
            txtReceivedvia.Enabled = false;
            txtDetailsofInquiry.Enabled = false;
            txtActionTaken.Enabled = false;
            dtepckerDATE.Enabled = false;
            dtetimeReceived.Enabled = false;
            dtepckerDATE.Enabled = false;
            dtetmeCompleted.Enabled = false;
            richtxtRemarks.Enabled = false;
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
        }   




        private void btnSave_Click(object sender, EventArgs e)
        {           
            //ADDING DATA IN TABLE
          
                TBL_LOGSHEET_INQUIRY tbl_Inquiry = new TBL_LOGSHEET_INQUIRY();
                tbl_Inquiry.LOG_DATE = Convert.ToDateTime(dtepckerDATE.Text);
                tbl_Inquiry.LOG_PETCNAME = cmboxPETC.Text;
                tbl_Inquiry.LOG_RECEIVEDVIA = txtReceivedvia.Text;
                tbl_Inquiry.LOG_RECEIVEDBY = txtReceivedby.Text;
                tbl_Inquiry.LOG_DTLINQUIRY = txtDetailsofInquiry.Text;
                tbl_Inquiry.LOG_TMERECEIVE = dtetimeReceived.Value;
                tbl_Inquiry.LOG_ACTTAKEN = txtActionTaken.Text;
                tbl_Inquiry.LOG_TMECMPLTED = dtetmeCompleted.Value;
                tbl_Inquiry.LOG_REMARKS = richtxtRemarks.Text;
                tbl_Inquiry.LOG_CERTIFICATE = "CERTIFICATE";
                var minus = dtetimeReceived.Value - dtetmeCompleted.Value;

                //tbl_Inquiry.LOG_RESPONSE = minus.Duration().ToString(@"hh\:mm\:ss");

                db_LogsheetUtil.TBL_LOGSHEET_INQUIRY.Add(tbl_Inquiry);
                dataGridView1.Update();
                dataGridView1.Refresh();
                
                db_LogsheetUtil.SaveChanges();
                MessageBox.Show("Successfully Save");

                cmboxPETC.Text = string.Empty;
                txtReceivedvia.Text = string.Empty;
                txtReceivedby.Text = string.Empty;
                txtDetailsofInquiry.Text = string.Empty;
                txtActionTaken.Text = string.Empty;
                richtxtRemarks.Text = string.Empty;

                refreshList();

                cmboxPETC.Enabled = false;
                txtReceivedby.Enabled = false;
                txtReceivedvia.Enabled = false;
                txtDetailsofInquiry.Enabled = false;
                txtActionTaken.Enabled = false;
                dtepckerDATE.Enabled = false;
                dtetimeReceived.Enabled = false;
                dtepckerDATE.Enabled = false;
                dtetmeCompleted.Enabled = false;
                richtxtRemarks.Enabled = false;

                btnNew.Enabled = true;
                btnSave.Enabled = false;
                btnUpdate.Enabled = false;
            
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //UPDATING DATA IN DATAGRID

            var query = db_LogsheetUtil.TBL_LOGSHEET_INQUIRY.Where(w => w.ID == record_id).FirstOrDefault();
            {
                query.LOG_DATE = dtepckerDATE.Value.Date;
                query.LOG_PETCNAME = cmboxPETC.Text;
                query.LOG_RECEIVEDVIA = txtReceivedvia.Text;
                query.LOG_RECEIVEDBY = txtReceivedby.Text;
                query.LOG_DTLINQUIRY = txtDetailsofInquiry.Text;
                query.LOG_TMERECEIVE = dtetimeReceived.Value;
                query.LOG_ACTTAKEN = txtActionTaken.Text;
                query.LOG_TMECMPLTED = dtetmeCompleted.Value;
                query.LOG_REMARKS = richtxtRemarks.Text;
                query.LOG_RESPONSE = Convert.ToDateTime(dtetmeCompleted.Value - dtetimeReceived.Value);
                
                dataGridView1.Update();
                dataGridView1.Refresh();
                db_LogsheetUtil.SaveChanges();
                MessageBox.Show("Update Completed");


            }
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                record_id = (Int32)row.Cells["Id"].Value;
                dtepckerDATE.Value = Convert.ToDateTime(row.Cells["LOG_DATE"].Value.ToString());
                cmboxPETC.Text = row.Cells["LOG_PETCNAME"].Value.ToString();
                txtReceivedby.Text = row.Cells["LOG_RECEIVEDBY"].Value.ToString();
                txtReceivedvia.Text = row.Cells["LOG_RECEIVEDVIA"].Value.ToString();
                txtDetailsofInquiry.Text = row.Cells["LOG_DTLINQUIRY"].Value.ToString();
                dtetimeReceived.Value = Convert.ToDateTime(row.Cells["LOG_TMERECEIVE"].Value.ToString());
                txtActionTaken.Text = row.Cells["LOG_ACTTAKEN"].Value.ToString();
                dtetmeCompleted.Value = Convert.ToDateTime(row.Cells["LOG_TMECMPLTED"].Value.ToString());
                richtxtRemarks.Text = row.Cells["LOG_REMARKS"].Value.ToString();
                

                


                TBL_LOGSHEET_INQUIRY tbl = new TBL_LOGSHEET_INQUIRY();
                tbl.LOG_PETCNAME = cmboxPETC.Text;
                tbl.LOG_RECEIVEDVIA = txtReceivedvia.Text;
                tbl.LOG_RECEIVEDBY = txtReceivedby.Text;
                tbl.LOG_DTLINQUIRY = txtDetailsofInquiry.Text;
                tbl.LOG_TMERECEIVE = dtetimeReceived.Value;
                tbl.LOG_ACTTAKEN = txtActionTaken.Text;
                tbl.LOG_TMECMPLTED = dtetmeCompleted.Value;
                tbl.LOG_REMARKS = richtxtRemarks.Text;

                cmboxPETC.Enabled = true;
                txtReceivedby.Enabled = true;
                txtReceivedvia.Enabled = true;
                txtDetailsofInquiry.Enabled = true;
                txtActionTaken.Enabled = true;
                dtepckerDATE.Enabled = true;
                dtetimeReceived.Enabled = true;
                dtepckerDATE.Enabled = true;
                dtetmeCompleted.Enabled = true;
                richtxtRemarks.Enabled = true;

                btnNew.Enabled = true;
                btnSave.Enabled = false;
                btnUpdate.Enabled = true;

            }
           
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            cmboxPETC.Enabled = true;
            txtReceivedby.Enabled = true;
            txtReceivedvia.Enabled = true;
            txtDetailsofInquiry.Enabled = true;
            txtActionTaken.Enabled = true;
            dtepckerDATE.Enabled = true;
            dtetimeReceived.Enabled = true;
            dtepckerDATE.Enabled = true;
            dtetmeCompleted.Enabled = true;
            richtxtRemarks.Enabled = true;

            cmboxPETC.Text = string.Empty;
            txtReceivedvia.Text = string.Empty;
            txtReceivedby.Text = string.Empty;
            txtDetailsofInquiry.Text = string.Empty;
            txtActionTaken.Text = string.Empty;
            richtxtRemarks.Text = string.Empty;

            btnNew.Enabled = false;
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

       
        public void refreshList()
        {

            db_LogsheetUtil = new PETC_LogsheetEntities();
            dataGridView1.DataSource = db_LogsheetUtil.TBL_LOGSHEET_INQUIRY.ToList();
            //dtaGridMenu.Columns["ID"].DisplayIndex = 0;
            dataGridView1.Columns["LOG_DATE"].DefaultCellStyle.Format = "yy/MM/dd";
            dataGridView1.Columns["LOG_PETCCODE"].Visible = false;
            //dtaGridMenu.Columns["LOG_PETCNAME"].DisplayIndex = 2;
            //dtaGridMenu.Columns["LOG_RECEIVEDVIA"].DisplayIndex = 3;
            //dtaGridMenu.Columns["LOG_RECEIVEDBY"].DisplayIndex = 4;
            dataGridView1.Columns["LOG_TMERECEIVE"].DefaultCellStyle.Format = "HH:mm";
            //dtaGridMenu.Columns["LOG_DTLINQUIRY"].DisplayIndex = 6;
            dataGridView1.Columns["LOG_TMECMPLTED"].DefaultCellStyle.Format = "HH:mm";
            //dtaGridMenu.Columns["LOG_ACTTAKEN"].DisplayIndex = 8;
            //dtaGridMenu.Columns["LOG_REMARKS"].DisplayIndex = 9;
            dataGridView1.Columns["LOG_RESPONSE"].DefaultCellStyle.Format = "HH:mm";
            dataGridView1.Columns["LOG_ENCODED"].Visible = false;
            dataGridView1.Columns["LOG_DATELOG"].Visible = false;
            dataGridView1.Columns["LOG_REGISTRYCODE"].Visible = false;
            dataGridView1.Columns["LOG_CERTIFICATE"].Visible = false;



            dataGridView1.Columns["LOG_DATE"].HeaderText = "DATE";
            //dtaGridMenu.Columns["LOG_PETCCODE"].HeaderText = "PETC CODE";
            dataGridView1.Columns["LOG_PETCNAME"].HeaderText = "PETC NAME";
            dataGridView1.Columns["LOG_RECEIVEDVIA"].HeaderText = "RECEIVE VIA";
            dataGridView1.Columns["LOG_RECEIVEDBY"].HeaderText = "RECEIVE BY";
            dataGridView1.Columns["LOG_DATE"].HeaderText = "TIME RECEIVE";
            dataGridView1.Columns["LOG_DTLINQUIRY"].HeaderText = "DETAIL INQUIRY";
            dataGridView1.Columns["LOG_TMECMPLTED"].HeaderText = "TIME COMPLETED";
            dataGridView1.Columns["LOG_ACTTAKEN"].HeaderText = "ACTION TAKEN";
            dataGridView1.Columns["LOG_REMARKS"].HeaderText = "REMARKS";
            dataGridView1.Columns["LOG_RESPONSE"].HeaderText = "RESPONSE TIME";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
