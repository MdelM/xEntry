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
    public partial class frmxConn : Form
    {

        public SqlConnection _Myconn = new SqlConnection(); //Ma connexion SQL

        #region Instance du mdiMainForm// ++++++++++++++++++++++++++++++++++++++
        // ++++++++++++++++++++++++++++++++++++++
        public mdiMainForm mainform;
        public string chaineconn = "";

        public mdiMainForm mymainform
        {
            get { return this.mainform; }
            set { this.mainform = value; }
        }
        // ++++++++++++++++++++++++++++++++++++++++
        // ++++++++++++++++++++++++++++++++++++++++

        #endregion

        public frmxConn()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxConn_Click(object sender, EventArgs e)
        {

            //string sChaine;
                if(txtnomBD.Text.Equals("") || txtnomuser.Text.Equals("") || txtpwd.Text.Equals(""))
                {
                    MessageBox.Show(this,"Valeurs de connexion a la base des donnees manquantes !","Missing data ...");

                    txtnomuser.Focus();
                }

                else
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;


                        chaineconn = @"Data Source=" + txtnomserveur.Text + ";Initial Catalog=" + txtnomBD.Text.Trim() + ";User ID=" + txtnomuser.Text.Trim() + ";Password=" + txtpwd.Text;
                        _Myconn.ConnectionString = chaineconn;
                        _Myconn.Open();
                        // MessageBox.Show("Connection to the database successfully.", "Connected to the database", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        mainform.strconn = chaineconn;
                        mainform.usern = this.txtnomuser.Text.Trim();
                        mainform.LockMenu(true);

                    }
                    catch (Exception erreur)
                    {
                        MessageBox.Show(erreur.Message
                                       , ""
                                       , MessageBoxButtons.OK
                                       , MessageBoxIcon.Error);
                        mainform.xconnf = null;
                        return;
                        
                    }
                    this.Cursor = Cursors.Default;
                    _Myconn.Close();
                    this.Close();
                }
            }

        private void txtnomserveur_Enter(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.Khaki;
        }

        private void txtnomserveur_Leave(object sender, EventArgs e)
        {
            ((Control)sender).BackColor = Color.White;
        }

        private void txtpwd_TextChanged(object sender, EventArgs e)
        {
            btnxConn.Enabled = true;
        }


        private void frmxConn_Load(object sender, EventArgs e)
        {
            btnxConn.Enabled = false;
        }



        }

    }
