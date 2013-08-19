using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Drawing;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace xEntry
{
    public partial class jmconnect : Form
    {
        private string[] anListeServeurs;   // Liste des serveurs SQL

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

        public jmconnect()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // La liste des serveurs SQL existants


        public string[] GetSqlDataSources()
        {
            // Extraction de la listes des Serveurs SQL (services) qu'on range dans une table
            DataTable dt = System.Data.Sql.SqlDataSourceEnumerator.Instance.GetDataSources();

            string[] sServeurs = new string[dt.Rows.Count];
            int count = 0;

            foreach (DataRow dr in dt.Rows)
            {
                string sNomServeur = dr["ServerName"].ToString().Trim().ToUpper();

                string sNomInstance = null;
                if (dr["InstanceName"] != null && dr["InstanceName"] != DBNull.Value)
                    sNomInstance = dr["InstanceName"].ToString().Trim().ToUpper();
                sServeurs[count] = sNomServeur;
                if (!String.IsNullOrEmpty(sNomInstance))
                    sServeurs[count] += "\\" + sNomInstance;

                count++;
            }
            Array.Sort<string>(sServeurs);
            return sServeurs;
        }

        /// <summary>
        /// Récupération des bases de données sql
        /// </summary>
        /// <param name="connectionString">chaine de connexion</param>
        /// <param name="connectionTimeOut"></param>
        /// <returns></returns>
        public string[] recuperer_bases_donnees(string connectionString, int connectionTimeOut)
        {
            //SqlConnection osqlConnection;
            SqlCommand osqlCommand;
            SqlDataReader osqlDataReader;
            string sqlversion;
            int intsqlversion;
            string sql;
            string[] databasesArray;
            System.Collections.Specialized.StringCollection databasesCollection;

            _Myconn = new SqlConnection();
            osqlCommand = new SqlCommand();
            databasesCollection = new System.Collections.Specialized.StringCollection();

            try
            {
                _Myconn.ConnectionString = @"Data Source=" + anListeServeurs[cboServeur.SelectedIndex] + ";Integrated Security=SSPI";

                _Myconn.Open();

                sqlversion = _Myconn.ServerVersion;
                sqlversion = sqlversion.Split('.')[0];
                intsqlversion = Convert.ToInt32(sqlversion);
                sql = String.Empty;

                sql = "use master; select name from "
                    + ((intsqlversion >= 9) ? "sys.databases" : "sysdatabases")
                    + " order by name";

                osqlCommand.Connection = _Myconn;
                osqlCommand.CommandType = System.Data.CommandType.Text;
                osqlCommand.CommandText = sql;
                osqlCommand.CommandTimeout = 50; //this.SQLServerCommandTimeOut;

                osqlDataReader = osqlCommand.ExecuteReader();

                while (osqlDataReader.Read())
                    databasesCollection.Add(osqlDataReader["name"].ToString());

                osqlDataReader.Close();
                databasesArray = new string[databasesCollection.Count];

                databasesCollection.CopyTo(databasesArray, 0);

                return databasesArray;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (_Myconn != null && _Myconn.State == ConnectionState.Open)
                    _Myconn.Close();
            }

        }
        // Bouton Scan du reseau
        private void btnScan_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                cboServeur.Items.Clear();
                anListeServeurs = GetSqlDataSources();
                foreach (string sServer in anListeServeurs)
                    cboServeur.Items.Add(sServer);
                cboServeur.SelectedIndex = 0;
                cboDatabases.Items.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message
                              , "Erreur"
                              , MessageBoxButtons.OK
                              , MessageBoxIcon.Error
                              , MessageBoxDefaultButton.Button1);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        // Rempli avec la liste des bases des donnees
        private void cboDatabases_DropDown(object sender, EventArgs e)
        {
            if (cboDatabases.Items.Count == 0)
            {
                try
                {
                    string[] sBasesdD;
                    sBasesdD = recuperer_bases_donnees("", 50);
                    foreach (string sBdD in sBasesdD)
                        cboDatabases.Items.Add(sBdD);
                    cboDatabases.SelectedIndex = 0;
                }
                catch (Exception erreur)
                {
                    MessageBox.Show(""
                                   , erreur.Message
                                   , MessageBoxButtons.OK
                                   , MessageBoxIcon.Error);
                }
            }


        }
        //CONNEXION A LA BASE DES DONNEES
        public void btnConnect_Click(object sender, EventArgs e)
        {
            //string sChaine;
            if (cboDatabases.Text.Trim() != "xEntryDbz")
            {
                MessageBox.Show("Base des donnees incorrect. Reessayer SVP.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboDatabases.Focus();
            }
            else
            {
                try
                {
                    this.Cursor = Cursors.WaitCursor;


                    chaineconn = @"Data Source=" + cboServeur.Text + ";Initial Catalog=" + cboDatabases.Text.Trim() + ";User ID=" + txtUser.Text.Trim() + ";Password=" + txtPassword.Text;
                    _Myconn.ConnectionString = chaineconn;
                    _Myconn.Open();
                   // MessageBox.Show("Connection to the database successfully.", "Connected to the database", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    mainform.strconn = chaineconn;
                    mainform.usern = this.txtUser.Text.Trim();
                    mainform.LockMenu(true);

                }
                catch (Exception erreur)
                {
                    MessageBox.Show(erreur.Message
                                   , ""
                                   , MessageBoxButtons.OK
                                   , MessageBoxIcon.Error);
                }
                this.Cursor = Cursors.Default;
                _Myconn.Close();
                this.Close();
            }
        }


        private void cboDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void jmconnect_Load(object sender, EventArgs e)
        {

        }



        // ************************** END *************************************
    }
}

