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
    public partial class gpsdataForm : Form
    {
        mdiMainForm myMdi=new mdiMainForm();
        EntryForm entry = new EntryForm();

        BindingSource bs;
        SqlCommand gCmd;
        SqlConnection xConn;

        #region InstanceDuMdi
        public mdiMainForm getMdiMainForm()
        {
            return myMdi;
        }
        public void setMdiMainForm(mdiMainForm maMdi)
        {
            myMdi = maMdi;
        }
        #endregion

        #region InstanceDuFormEntry
        public EntryForm getEntryForm()
        {
            return entry;
        }
        public void setEntryForm(EntryForm entrY)
        {
            entry = entrY;
        }

        #endregion

        public gpsdataForm()
        {
            InitializeComponent();
        }

        private void gpsdataForm_Load(object sender, EventArgs e)
        {
            xConn = new SqlConnection(myMdi.strconn);
            txtg_Id_Pr.Text = entry.myPrValue;

            _EmptyGpsTextBox();
            _FillBindingNavigator();

        }

        private void _EmptyGpsTextBox()
        {
            foreach (Control x in this.panel1.Controls)
            {
                if (x is TextBox)
                {
                    TextBox aa = (TextBox)x;
                    aa.Clear();
                    aa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                }
            }
            txtalt.Text = "0";
            txtepe.Text = "0";
            txtwpt.Focus();
        }

        private void _FillBindingNavigator()
        {
            try
            {
                if (xConn.State.ToString().Equals("Closed")) xConn.Open();
                gCmd = xConn.CreateCommand();
                gCmd.CommandText = "select * from COORDONNEESPR where id_pr='" + txtg_Id_Pr.Text.Trim() +"'";

                SqlDataAdapter drg = new SqlDataAdapter(gCmd);
                DataSet dsg = new DataSet();
                drg.Fill(dsg, "GPSdata");

                bs = new BindingSource();
                bs.DataSource = dsg.Tables["GPSdata"];
                bsngps.BindingSource = bs;

                dtggpsdata.DataSource = bs;

            }
            catch (SqlException d)
            {
                MessageBox.Show(this, d.Message, "Error");
            }
            xConn.Close();
        }

        private void btnquitgps_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddGpsData_Click(object sender, EventArgs e)
        {
            try
            {
                coordonneespr gpr = new coordonneespr();
                gpr.Idpr = txtg_Id_Pr.Text.Trim();
                gpr.Wptpr = int.Parse(txtwpt.Text.Trim());
                gpr.Latitude = txtlat.Text.Trim();
                gpr.Longitude = txtlong.Text.Trim();
                gpr.Altitude = int.Parse(txtalt.Text.Trim());
                gpr.Epepr = int.Parse(txtepe.Text.Trim());

                if (xConn.State.ToString().Equals("Closed")) xConn.Open();
                gCmd = xConn.CreateCommand();
                gCmd.CommandText = "insert into COORDONNEESPR(id_pr,wptpr,latitude,longitude,altitude,epepr) values(@id_pr,@wptpr,@latitude,@longitude,@altitude,@epepr)";

                gCmd.Parameters.Add("id_pr", SqlDbType.VarChar, 25, "@id_pr").Value = gpr.Idpr;
                gCmd.Parameters.Add("wptpr", SqlDbType.Int, 10, "@wptpr").Value = gpr.Wptpr;
                gCmd.Parameters.Add("latitude", SqlDbType.VarChar, 20, "@latitude").Value = gpr.Latitude;
                gCmd.Parameters.Add("longitude", SqlDbType.VarChar, 20, "@longitude").Value = gpr.Longitude;
                gCmd.Parameters.Add("altitude", SqlDbType.Int, 10, "@altitude").Value = gpr.Altitude;
                gCmd.Parameters.Add("epepr", SqlDbType.Int, 10, "@epepr").Value = gpr.Epepr;

                int y = gCmd.ExecuteNonQuery();
            }
            catch (SqlException x)
            {
                MessageBox.Show(this, x.Message, "Error");
            }
            xConn.Close();
            _EmptyGpsTextBox();
            _FillBindingNavigator();
        }

        private void btnDelGpsData_Click(object sender, EventArgs e)
        {
            try
            {
                string strx = dtggpsdata["wptpr", dtggpsdata.CurrentRow.Index].Value.ToString();

                if (xConn.State.ToString().Equals("Closed")) xConn.Open();
                gCmd = xConn.CreateCommand();
                gCmd.CommandText = "delete from COORDONNEESPR where wptpr='" + strx + "'";
                DialogResult drz = MessageBox.Show(this, "Voulez-vous reellement suprimer cette coordonnees ?", "Delete data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (drz == DialogResult.Yes)
                {
                    int y = gCmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show(this, "Deleted data cancelled !", "Cancelled");
                }
            }
            catch (SqlException x)
            {
                MessageBox.Show(this, x.Message, "Error");
            }
            xConn.Close();
            _EmptyGpsTextBox();
            _FillBindingNavigator();
        }

        private void btnUpdGpsData_Click(object sender, EventArgs e)
        {
            try
            {
                coordonneespr gpre = new coordonneespr();
                gpre.Idpr = txtg_Id_Pr.Text.Trim();
                gpre.Wptpr = int.Parse(txtwpt.Text.Trim());
                gpre.Latitude = txtlat.Text.Trim();
                gpre.Longitude = txtlong.Text.Trim();
                gpre.Altitude = int.Parse(txtalt.Text.Trim());
                gpre.Epepr = int.Parse(txtepe.Text.Trim());

                string strx = dtggpsdata["wptpr", dtggpsdata.CurrentRow.Index].Value.ToString();

                if (xConn.State.ToString().Equals("Closed")) xConn.Open();
                gCmd = xConn.CreateCommand();
                gCmd.CommandText = "update COORDONNEESPR set id_pr=@id_pr,wptpr=@wptpr,latitude=@latitude,longitude=@longitude,altitude=@altitude,epepr=@epepr where wptpr='" + strx + "'";

                gCmd.Parameters.Add("id_pr", SqlDbType.VarChar, 25, "@id_pr").Value = gpre.Idpr;
                gCmd.Parameters.Add("wptpr", SqlDbType.Int, 10, "@wptpr").Value = gpre.Wptpr;
                gCmd.Parameters.Add("latitude", SqlDbType.VarChar, 20, "@latitude").Value = gpre.Latitude;
                gCmd.Parameters.Add("longitude", SqlDbType.VarChar, 20, "@longitude").Value = gpre.Longitude;
                gCmd.Parameters.Add("altitude", SqlDbType.Int, 10, "@altitude").Value = gpre.Altitude;
                gCmd.Parameters.Add("epepr", SqlDbType.Int, 10, "@epepr").Value = gpre.Epepr;

                int y = gCmd.ExecuteNonQuery();
            }
            catch (SqlException x)
            {
                MessageBox.Show(this, x.Message, "Error");
            }
            xConn.Close();
            _EmptyGpsTextBox();
            _FillBindingNavigator();
        }

        private void dtggpsdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtggpsdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtggpsdata.RowCount > 0)
            {
                string strx = dtggpsdata["wptpr", dtggpsdata.CurrentRow.Index].Value.ToString();
                try
                {
                    if (xConn.State.ToString().Equals("Closed")) xConn.Open();
                    gCmd = xConn.CreateCommand();
                    gCmd.CommandText = "select * from COORDONNEESPR where wptpr='" + strx + "'";

                    SqlDataReader rd = null;
                    rd = gCmd.ExecuteReader();
                    while (rd.Read())
                    {
                        txtwpt.Text = rd["wptpr"].ToString();
                        txtlat.Text = rd["latitude"].ToString();
                        txtlong.Text = rd["longitude"].ToString();
                        txtalt.Text = rd["altitude"].ToString();
                        txtepe.Text = rd["epepr"].ToString();
                    }
                    txtwpt.Focus();
                }
                catch (SqlException d)
                {
                    MessageBox.Show(this, d.Message, "Error");
                }
                xConn.Close();
            }
        }
        

    }
}
