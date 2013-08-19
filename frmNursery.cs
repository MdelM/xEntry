using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace xEntry
{
    public partial class frmNursery : Form
    {

        mdiMainForm xMainFrm = new mdiMainForm();
       // SqlCommand zCmd;
        SqlConnection xConn;

        public mdiMainForm getMdiMainForm()
        {
            return xMainFrm;
        }
        public void setMdiMainform(mdiMainForm xmainfrm)
        {
            xMainFrm = xmainfrm;
        }


        
        public frmNursery()
        {
            InitializeComponent();
        }

        private void frmNursery_Load(object sender, EventArgs e)
        {
            xConn = new SqlConnection(xMainFrm.strconn);


        }

        private void tbIdentification_Click(object sender, EventArgs e)
        {

        }
    }
}
