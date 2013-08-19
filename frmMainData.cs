using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace xEntry
{
    public partial class frmMainData : Form
    {

        SqlConnection _xsqlconn;
        
        mdiMainForm frmMaMdi = new mdiMainForm();

        public mdiMainForm getmdiMainForm()
        {
            return frmMaMdi;
        }

        public void setmdimainform(mdiMainForm xmain)
        {
            frmMaMdi = xmain;
        }
        
        public frmMainData()
        {
            InitializeComponent();
        }

        private void frmMainData_Load(object sender, EventArgs e)
        {
            _xsqlconn = new SqlConnection(frmMaMdi.strconn);

            dtgvFY.AutoGenerateColumns = false;
            AddColsFY();

            this.Width = 532;
            this.Height = 537;
           
        }

        private void AddColsFY()
        {
            DataGridViewTextBoxColumn IDF = new DataGridViewTextBoxColumn();
            IDF.HeaderText = "FY ID";
            IDF.Visible = true;
            IDF.Name = "idFY";
            IDF.Width = 30;

            DataGridViewTextBoxColumn LabelFY = new DataGridViewTextBoxColumn();
            LabelFY.HeaderText = "FY Label";
            LabelFY.Name = "LabelFY";
            LabelFY.Visible = true;
            LabelFY.Width = 50;

            dtgvFY.Columns.Add(IDF);
            dtgvFY.Columns.Add(LabelFY);

        }
    }
}
