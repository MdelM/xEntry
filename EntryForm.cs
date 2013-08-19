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
using Excel=Microsoft.Office.Interop.Excel;


namespace xEntry
{
    public partial class EntryForm : Form
    {
        SqlCommand xCmd;
        SqlConnection xConn;
        SqlCommand yCmd;
        
        string myValue;
        public string myPrValue;

        BindingSource _binsrc = new BindingSource();
        BindingSource _prBinsrc = new BindingSource();

        Boolean strChief;
        Boolean strExistTrees;
        Boolean strdocproperty;
        Boolean strPlanterCopie;

        mdiMainForm xMainForm = new mdiMainForm();


        public mdiMainForm getMdiMainForm()
        {
            return xMainForm;
        }
        public void setMdiMainForm(mdiMainForm xmainF)
        {
            xMainForm = xmainF;
        }

        public EntryForm()
        {
            InitializeComponent();
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {
            xConn = new SqlConnection(xMainForm.strconn);

            this.Width = 1026;
            this.Height = 652;
            this.EntryTabCtrl.Width = 1017;
            this.EntryTabCtrl.Height = 625;
            this.CenterToParent();
            //******************************************* tabEntry1 ********************************************
            txtid.Visible = false;
            _EmptyControls();
            FillComboAgent();
            FillComboSaison();
            txtIdAgent.Clear();
            txtIdAgent2.Clear();
            txtIdAsso.Clear();
            txtIdAsso2.Clear();
            txtLSP.Clear();
            txtLSP2.Clear();
            _DefaultValue();
            txtIdAgent.Clear();
            //<test 
            txtIdTar.Clear();
            txtidpr.Clear();
            txtNumContr.Clear();
            ///test>
            txtIdAgent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            bindingNavigator1.Visible = true;
            bindingNavigator2.Visible = true;
            //Relier le bindingnavigator au Datagridview
            Conn_BindingSource();
            //******************************************* tabEntry2 ***********************************************
            Conn_BindingSource_PR();

        }

        private void FillComboAgent()
        {
            try
            {
                if (xConn.State.ToString().Equals("Closed")) xConn.Open();
                xCmd = xConn.CreateCommand();

                xCmd.CommandText = "Select * from AGENTRECOLTE";

                SqlDataAdapter adrQuery = new SqlDataAdapter(xCmd);
                DataSet dsQuery = new DataSet();
                adrQuery.Fill(dsQuery, "AgentRec");

                cboAgent.DataSource = dsQuery.Tables["AgentRec"];
                cboAgent.DisplayMember = "nom_agent";
                cboAgent2.DataSource = dsQuery.Tables["AgentRec"];
                cboAgent2.DisplayMember = "nom_agent";

            }
            catch (SqlException x)
            {
                MessageBox.Show(this, x.Message, "Error");
            }
            xConn.Close();
            cboAgent.SelectedIndex = -1;
            cboAgent2.SelectedIndex = -1;
        }

        private void FillComboSaison()
        {
            try
            {
                if (xConn.State.ToString().Equals("Closed")) xConn.Open();
                xCmd = xConn.CreateCommand();
                xCmd.CommandText = "Select * from SEASON";
                SqlDataAdapter dr = new SqlDataAdapter(xCmd);
                DataSet ds = new DataSet();
                dr.Fill(ds, "saison");
                cboSaison.DataSource = ds.Tables["saison"];
                cboSaison.DisplayMember = "id_season";
                cboSaison2.DataSource = ds.Tables["saison"];
                cboSaison2.DisplayMember = "id_season";
            }
            catch (SqlException x)
            {
                MessageBox.Show(this, x.Message, "Error");
            }
            xConn.Close();
            cboSaison.SelectedIndex = -1;
            cboSaison2.SelectedIndex = -1;
        }

        private void FillComboAssoSeason()
        {
            try
            {
                if (xConn.State.ToString().Equals("Closed")) xConn.Open();
                xCmd = xConn.CreateCommand();
                xCmd.CommandText = "Select * from SEASON_ASSO where id_season='" + cboSaison.Text.Trim() + "'";
                SqlDataAdapter dr = new SqlDataAdapter(xCmd);
                DataSet ds = new DataSet();
                dr.Fill(ds, "saisonAsso");
                cboAsso.DataSource = ds.Tables["saisonAsso"];
                cboAsso.DisplayMember = "id_SaisonAsso";
                cboAsso2.DataSource = ds.Tables["saisonAsso"];
                cboAsso2.DisplayMember = "id_SaisonAsso";
            }
            catch (SqlException x)
            {
                MessageBox.Show(this, x.Message, "Error");
            }
            xConn.Close();
            cboAsso.SelectedIndex = -1;
            cboAsso2.SelectedIndex = -1;
        }

        private void Conn_BindingSource()
        {
            try
            {
                if (xConn.State.ToString().Equals("Closed")) xConn.Open();

                xCmd = xConn.CreateCommand();
                xCmd.CommandText = "select * from TAR";

                SqlDataAdapter adrQuery = new SqlDataAdapter(xCmd);
                DataSet dsQuery = new DataSet();
                adrQuery.Fill(dsQuery, "DataTar");
                //DataBinding

                _binsrc.DataSource = dsQuery.Tables["DataTar"];
                dtgvTAR.DataSource = _binsrc;
                bindingNavigator1.BindingSource = _binsrc;

                dtgvTAR.DataSource = _binsrc;
            }
            catch (SqlException exq)
            {
                MessageBox.Show(this, exq.Message);
            }
            xConn.Close();
        }

        private void Conn_BindingSource_PR()
        {
            try
            {
                if (xConn.State.ToString().Equals("Closed")) xConn.Open();

                yCmd = xConn.CreateCommand();
                yCmd.CommandText = "select * from PR";

                SqlDataAdapter adrQuery = new SqlDataAdapter(yCmd);
                DataSet dsQuery = new DataSet();
                adrQuery.Fill(dsQuery, "DataPr");
                //DataBinding

                _prBinsrc.DataSource = dsQuery.Tables["DataPr"];
                //dtgvPR.DataSource = _prBinsrc;
                bindingNavigator2.BindingSource = _prBinsrc;

                dtgvPR.DataSource = _prBinsrc;
            }
            catch (SqlException exq)
            {
                MessageBox.Show(this, exq.Message);
            }
            xConn.Close();
        }

        private void _LockedTextBox()
        {
            txtWpt.Enabled = txtLat.Enabled = txtLongi.Enabled = txtAlt.Enabled = txtEpe.Enabled = false;
            txtnumPh.Enabled = txtLatPh.Enabled = txtLongPh.Enabled = txtAzimut.Enabled = false;
            txtNameChief.Enabled = txtFunction.Enabled = false;
            txtTypeDoc.Enabled = false;
            txtNumberArbr.Enabled = false;
        }

        private void chkGis_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGis.Checked)
            {
                txtWpt.Enabled = txtLat.Enabled = txtLongi.Enabled = txtAlt.Enabled = txtEpe.Enabled = true;
                txtWpt.Clear();
                txtWpt.Focus();
            }
            if (!chkGis.Checked)
            {
                txtWpt.Enabled = txtLat.Enabled = txtLongi.Enabled = txtAlt.Enabled = txtEpe.Enabled = false;
            }
        }

        private void chkPhotoGis_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPhotoGis.Checked)
            {
                txtnumPh.Enabled = txtLatPh.Enabled = txtLongPh.Enabled = txtAzimut.Enabled = true;
                txtnumPh.Clear();
                txtnumPh.Focus();
            }
            if (!chkPhotoGis.Checked)
            {
                txtnumPh.Enabled = txtLatPh.Enabled = txtLongPh.Enabled = txtAzimut.Enabled = false;
            }
        }

        private void chkChief_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChief.Checked)
            {
                txtNameChief.Enabled = txtFunction.Enabled = true;
                Tar tempon = new Tar();
                strChief = tempon._CheckboxStatus(chkChief);
                txtNameChief.Focus();

            }
            if (!chkChief.Checked)
            {
                txtNameChief.Enabled = txtFunction.Enabled = false;
            }
        }

        private void chkDocProperty_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDocProperty.Checked)
            {
                txtTypeDoc.Enabled = true;
                Tar tempon2 = new Tar();
                strdocproperty = tempon2._CheckboxStatus(chkDocProperty);
                txtTypeDoc.Focus();
            }
            if (!chkDocProperty.Checked)
            {
                txtTypeDoc.Enabled = false;
            }
        }

        private void chkExistTrees_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExistTrees.Checked)
            {
                txtNumberArbr.Enabled = true;
                Tar tempon3 = new Tar();
                strExistTrees = tempon3._CheckboxStatus(chkExistTrees);
                txtNumberArbr.Focus();
            }
            if (!chkExistTrees.Checked)
            {
                txtNumberArbr.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _DefaultValue()
        {
            foreach (Control r in this.Controls)
            {
                if (r is TextBox)
                {
                    TextBox rr = (TextBox)r;
                    rr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                }
            }
            txtWpt.Text = "0";
            txtAlt.Text = "0";
            txtEpe.Text = "0";
            txtnumPh.Text = "0";
            txtAzimut.Text = "0";
            txtNumberArbr.Text = "0";
            txtArea.Text = "0";
            txtSupBloc1.Text = "0.0";
            txtSupBloc2.Text = "0.0";
            txtSupBloc3.Text = "0.0";
            cboAgent.SelectedIndex = -1;
            txtName.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Tar MyTar = new Tar();
                MyTar.Id_tar = txtIdTar.Text.Trim();
                MyTar.Id_asso = txtIdAsso.Text.Trim();
                MyTar.idSaisonAsso = cboAsso.Text.Trim();
                MyTar.Numerocontrat = txtNumContr.Text.Trim();
                MyTar.Nom = txtName.Text.Trim();
                MyTar.Prenom = txtPostnom.Text.Trim();
                MyTar.Lieu_plant = txtPlace.Text.Trim();
                MyTar.Village = txtVillage.Text.Trim();
                MyTar.Localite = txtLocalite.Text.Trim();
                MyTar.Groupement = txtGroupe.Text.Trim();
                MyTar.Chefferie = txtChefferie.Text.Trim();
                MyTar.Territoire = txtTerritoire.Text.Trim();
                MyTar.Wpttar = int.Parse(txtWpt.Text.Trim());
                MyTar.Latitude = txtLat.Text.Trim();
                MyTar.Longitude = txtLongi.Text.Trim();
                MyTar.Altitude = int.Parse(txtAlt.Text.Trim());
                MyTar.Epetar = int.Parse(txtEpe.Text.Trim());
                MyTar.Nphoto = int.Parse(txtnumPh.Text.Trim());
                MyTar.Azimut = txtAzimut.Text.Trim();
                MyTar.Latitude_ph = txtLatPh.Text.Trim();
                MyTar.Longitude_ph = txtLongPh.Text.Trim();
                MyTar.Id_agent = txtIdAgent.Text.Trim();
                MyTar.Superficie = float.Parse(txtArea.Text.Trim());
                MyTar.Objectifs = txtObjective.Text.Trim();
                MyTar.Chefdelocalite = strChief;
                MyTar.Nomchefdelocalite = txtNameChief.Text.Trim();
                MyTar.Fonction = txtFunction.Text.Trim();
                MyTar.Documentdepropriete = strdocproperty;
                MyTar.Typedocument = txtTypeDoc.Text.Trim();
                MyTar.Utilisationprecedente = txtPrevUse.Text.Trim();
                MyTar.Nombrearbre = int.Parse(txtNumberArbr.Text.Trim());
                MyTar.Situation = txtSituation.Text.Trim();
                MyTar.Pente = txtPente.Text.Trim();
                MyTar.Sol = txtSol.Text.Trim();
                MyTar.Superficiebloc1 = float.Parse(txtSupBloc1.Text.Trim());
                MyTar.Superficiebloc2 = float.Parse(txtSupBloc2.Text.Trim());
                MyTar.Superficiebloc3 = float.Parse(txtSupBloc3.Text.Trim());
                MyTar.Essencebloc1 = txtEssBloc1.Text.Trim();
                MyTar.Essencebloc2 = txtEssBloc2.Text.Trim();
                MyTar.Essencebloc3 = txtEssBloc3.Text.Trim();
                MyTar.Ecartement1 = txtEcartBloc1.Text.Trim();
                MyTar.Ecartement2 = txtEcartBloc2.Text.Trim();
                MyTar.Ecartement3 = txtEcartBloc3.Text.Trim();
                MyTar.Idt = int.Parse(txtid.Text.Trim());

                if (xConn.State.ToString().Equals("Closed")) xConn.Open();
                xCmd = xConn.CreateCommand();

                xCmd.CommandText = "INSERT INTO TAR(id_tar,id_asso,id_SaisonAsso,numerocontrat,nom,prenom,lieu_plant,village,localite,groupement,chefferie,territoire,wpttar,latitude,longitude,altitude,epetar,nphoto,azimut,latitude_ph,longitude_ph,id_agent,superficie,objectifs,chefdelocalite,nomchefdelocalite,fonction,documentdepropriete,typedocument,utilisationprecedente,arbreexistant,nombrearbre,situation,pente,sol," +
                        "superficiebloc1,superficiebloc2,superficiebloc3,essencebloc1,essencebloc2,essencebloc3,ecartement1,ecartement2,ecartement3,idt) VALUES (@id_tar,@id_asso,@id_SaisonAsso,@numerocontrat,@nom,@prenom,@lieu_plant,@village,@localite,@groupement,@chefferie,@territoire,@wpttar,@latitude,@longitude,@altitude,@epetar,@nphoto,@azimut,@latitude_ph,@longitude_ph," +
                        "@id_agent,@superficie,@objectifs,@chefdelocalite,@nomchefdelocalite,@fonction,@documentdepropriete,@typedocument,@utilisationprecedente,@arbreexistant,@nombrearbre,@situation,@pente,@sol,@superficiebloc1,@superficiebloc2,@superficiebloc3,@essencebloc1,@essencebloc2,@essencebloc3,@ecartement1,@ecartement2,@ecartement3,@idt)";

                xCmd.Parameters.Add("id_tar", SqlDbType.VarChar, 25, "@id_tar").Value = MyTar.Id_tar;
                xCmd.Parameters.Add("id_asso", SqlDbType.VarChar, 25, "@id_asso").Value = MyTar.Id_asso;
                xCmd.Parameters.Add("id_SaisonAsso", SqlDbType.VarChar, 32, "@id_SaisonAsso").Value = MyTar.idSaisonAsso;
                xCmd.Parameters.Add("numerocontrat", SqlDbType.VarChar, 25, "@numerocontrat").Value = MyTar.Numerocontrat;
                xCmd.Parameters.Add("nom", SqlDbType.VarChar, 75, "@nom").Value = MyTar.Nom;
                xCmd.Parameters.Add("prenom", SqlDbType.VarChar, 30, "@prenom").Value = MyTar.Prenom;
                xCmd.Parameters.Add("lieu_plant", SqlDbType.VarChar, 45, "@lieu_plant").Value = MyTar.Lieu_plant;
                xCmd.Parameters.Add("village", SqlDbType.VarChar, 45, "@village").Value = MyTar.Village;
                xCmd.Parameters.Add("localite", SqlDbType.VarChar, 45, "@localite").Value = MyTar.Localite;
                xCmd.Parameters.Add("groupement", SqlDbType.VarChar, 45, "@groupement").Value = MyTar.Groupement;
                xCmd.Parameters.Add("chefferie", SqlDbType.VarChar, 45, "@chefferie").Value = MyTar.Chefferie;
                xCmd.Parameters.Add("territoire", SqlDbType.VarChar, 45, "@territoire").Value = MyTar.Territoire;
                xCmd.Parameters.Add("wpttar", SqlDbType.Int, 10, "@wpttar").Value = MyTar.Wpttar;
                xCmd.Parameters.Add("latitude", SqlDbType.VarChar, 20, "@latitude").Value = MyTar.Latitude;
                xCmd.Parameters.Add("longitude", SqlDbType.VarChar, 20, "@longitude").Value = MyTar.Longitude;
                xCmd.Parameters.Add("altitude", SqlDbType.Int, 10, "@altitude").Value = MyTar.Altitude;
                xCmd.Parameters.Add("epetar", SqlDbType.Int, 10, "@epetar").Value = MyTar.Epetar;
                xCmd.Parameters.Add("nphoto", SqlDbType.Int, 10, "@nphoto").Value = MyTar.Nphoto;
                xCmd.Parameters.Add("azimut", SqlDbType.VarChar, 10, "@azimut").Value = MyTar.Azimut;
                xCmd.Parameters.Add("latitude_ph", SqlDbType.VarChar, 20, "@latitude_ph").Value = MyTar.Latitude_ph;
                xCmd.Parameters.Add("longitude_ph", SqlDbType.VarChar, 20, "@longitude_ph").Value = MyTar.Longitude_ph;
                xCmd.Parameters.Add("id_agent", SqlDbType.VarChar, 6, "@id_agent").Value = MyTar.Id_agent;
                xCmd.Parameters.Add("superficie", SqlDbType.Float, 4, "@superficie").Value = MyTar.Superficie;
                xCmd.Parameters.Add("objectifs", SqlDbType.VarChar, 100, "@objectifs").Value = MyTar.Objectifs;
                xCmd.Parameters.Add("chefdelocalite", SqlDbType.Bit, 1, "@chefdelocalite").Value = MyTar.Chefdelocalite;
                xCmd.Parameters.Add("nomchefdelocalite", SqlDbType.VarChar, 100, "@nomchefdelocalite").Value = MyTar.Nomchefdelocalite;
                xCmd.Parameters.Add("fonction", SqlDbType.VarChar, 45, "@fonction").Value = MyTar.Fonction;
                xCmd.Parameters.Add("documentdepropriete", SqlDbType.Bit, 1, "@documentdepropriete").Value = MyTar.Documentdepropriete;
                xCmd.Parameters.Add("typedocument", SqlDbType.VarChar, 45, "@typedocument").Value = MyTar.Typedocument;
                xCmd.Parameters.Add("utilisationprecedente", SqlDbType.VarChar, 50, "@utilisationprecedente").Value = MyTar.Utilisationprecedente;
                xCmd.Parameters.Add("arbreexistant", SqlDbType.Bit, 1, "@arbreexistant").Value = MyTar.Arbreexistant;
                xCmd.Parameters.Add("nombrearbre", SqlDbType.Int, 10, "@nombrearbre").Value = MyTar.Nombrearbre;
                xCmd.Parameters.Add("situation", SqlDbType.VarChar, 30, "@situation").Value = MyTar.Situation;
                xCmd.Parameters.Add("pente", SqlDbType.VarChar, 30, "@pente").Value = MyTar.Pente;
                xCmd.Parameters.Add("sol", SqlDbType.VarChar, 30, "@sol").Value = MyTar.Sol;
                xCmd.Parameters.Add("superficiebloc1", SqlDbType.Float, 4, "@superficiebloc1").Value = MyTar.Superficiebloc1;
                xCmd.Parameters.Add("superficiebloc2", SqlDbType.Float, 4, "@superficiebloc2").Value = MyTar.Superficiebloc2;
                xCmd.Parameters.Add("superficiebloc3", SqlDbType.Float, 4, "@superficiebloc3").Value = MyTar.Superficiebloc3;
                xCmd.Parameters.Add("essencebloc1", SqlDbType.VarChar, 45, "@essencebloc1").Value = MyTar.Essencebloc1;
                xCmd.Parameters.Add("essencebloc2", SqlDbType.VarChar, 45, "@essencebloc2").Value = MyTar.Essencebloc2;
                xCmd.Parameters.Add("essencebloc3", SqlDbType.VarChar, 45, "@essencebloc3").Value = MyTar.Essencebloc3;
                xCmd.Parameters.Add("ecartement1", SqlDbType.VarChar, 7, "@ecartement1").Value = MyTar.Ecartement1;
                xCmd.Parameters.Add("ecartement2", SqlDbType.VarChar, 7, "@ecartement2").Value = MyTar.Ecartement2;
                xCmd.Parameters.Add("ecartement3", SqlDbType.VarChar, 7, "@ecartement3").Value = MyTar.Ecartement3;
                xCmd.Parameters.Add("idt", SqlDbType.Int, 10, "@idt").Value = MyTar.Idt;


                int y = xCmd.ExecuteNonQuery();
                //Mets a jour le datagridview pour les donnees TAR
                _EmptyControls();
                _NumeroAutoTar();
                dtgvTAR.Refresh();


            }
            catch (SqlException x)
            {
                MessageBox.Show(this, x.Message, "Echec Ajout");
                _EmptyControls();
                return;
            }
            xConn.Close();
            Conn_BindingSource();
        }

        private void cboAgent_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (xConn.State.ToString().Equals("Closed")) xConn.Open();
                xCmd = xConn.CreateCommand();
                xCmd.CommandText = "Select * from AGENTRECOLTE where nom_agent='" + cboAgent.Text.Trim() + "'";

                SqlDataReader xdr = null;
                xdr = xCmd.ExecuteReader();

                while (xdr.Read())
                {
                    txtIdAgent.Clear();
                    txtIdAgent.Text = xdr["id_agent"].ToString();
                }
            }
            catch (SqlException x)
            {
                MessageBox.Show(this, x.Message, "Error");
            }
            xConn.Close();
        }

        private void cboSaison_SelectedValueChanged(object sender, EventArgs e)
        {
            FillComboAssoSeason();
            txtIdAsso.Clear();
            txtLSP.Clear();
        }

        #region _SELECT_NAME_LSP_
        private void _SelectLspName(string IdLsp)
        {
            try
            {
                if (xConn.State.ToString().Equals("Closed")) xConn.Open();
                xCmd = xConn.CreateCommand();
                xCmd.CommandText = "Select * from ASSO where id_asso='" + IdLsp + "'";
                SqlDataReader rd = null;
                rd = xCmd.ExecuteReader();
                while (rd.Read())
                {
                    txtLSP.Text = rd["name_asso"].ToString();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(this, ex.Message, "error");
            }
            xConn.Close();
            _NumeroAutoTar();
        }

        private void _SelectLspNameForPR(string IdLsp)
        {
            try
            {
                if (xConn.State.ToString().Equals("Closed")) xConn.Open();
                yCmd = xConn.CreateCommand();
                yCmd.CommandText = "Select * from ASSO where id_asso='" + IdLsp + "'";
                SqlDataReader rd = null;
                rd = yCmd.ExecuteReader();
                while (rd.Read())
                {
                    txtLSP2.Text = rd["name_asso"].ToString();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(this, ex.Message, "error");
            }
            xConn.Close();
            _NumeroAutoPR();
        }
        #endregion

        private void cboAsso_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (xConn.State.ToString().Equals("Closed")) xConn.Open();
                xCmd = xConn.CreateCommand();
                xCmd.CommandText = "Select * from SEASON_ASSO where id_SaisonAsso='" + cboAsso.Text.Trim() + "'";
                SqlDataReader rd = null;
                rd = xCmd.ExecuteReader();
                while (rd.Read())
                {
                    txtIdAsso.Focus();
                    txtIdAsso.Text = rd["id_asso"].ToString();
                }
            }
            catch (SqlException x)
            {
                MessageBox.Show(this, x.Message, "Error");
            }
            xConn.Close();
            //Appel aux methodes supplementaires
            _SelectLspName(txtIdAsso.Text.Trim());
        }


        private void _EmptyControls()
        {
            foreach (Control y in this.panel1.Controls)
            {
                if (y is TextBox)
                {
                    TextBox z = (TextBox)y;
                    z.Clear();
                }
                if (y is CheckBox)
                {
                    CheckBox t = (CheckBox)y;
                    t.Checked = false;
                }
            }
            _LockedTextBox();
            _DefaultValue();
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (xConn.State.ToString().Equals("Closed")) xConn.Open();

                myValue = dtgvTAR["Id_Tar", dtgvTAR.CurrentRow.Index].Value.ToString();
                xCmd = xConn.CreateCommand();
                xCmd.CommandText = "delete from TAR where id_tar='" + myValue + "'";

                DialogResult dres = MessageBox.Show(this, "Voulez-vous reellement supprimer ce TAR ?", "Delete data...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dres == DialogResult.Yes)
                {
                    int f = xCmd.ExecuteNonQuery();
                    _EmptyControls();
                }
                if (dres == DialogResult.No)
                {
                    MessageBox.Show(this, "Suppression annulee !", "Annulation");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(this, ex.Message, "Erreur");

            }
            xConn.Close();
            Conn_BindingSource();
        }

        #region Mise_a_Jour_des_donnees
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                Tar tar = new Tar();
                //tar.Id_tar = txtIdTar.Text.Trim();
                tar.Id_asso = txtIdAsso.Text.Trim();
                tar.idSaisonAsso = cboAsso.Text.Trim();
                tar.Numerocontrat = txtNumContr.Text.Trim();
                tar.Nom = txtName.Text.Trim();
                tar.Prenom = txtPostnom.Text.Trim();
                tar.Lieu_plant = txtPlace.Text.Trim();
                tar.Village = txtVillage.Text.Trim();
                tar.Localite = txtLocalite.Text.Trim();
                tar.Groupement = txtGroupe.Text.Trim();
                tar.Chefferie = txtChefferie.Text.Trim();
                tar.Territoire = txtTerritoire.Text.Trim();
                tar.Wpttar = int.Parse(txtWpt.Text.Trim());
                tar.Latitude = txtLat.Text.Trim();
                tar.Longitude = txtLongi.Text.Trim();
                tar.Altitude = int.Parse(txtAlt.Text.Trim());
                tar.Epetar = int.Parse(txtEpe.Text.Trim());
                tar.Nphoto = int.Parse(txtnumPh.Text.Trim());
                tar.Azimut = txtAzimut.Text.Trim();
                tar.Latitude_ph = txtLatPh.Text.Trim();
                tar.Longitude_ph = txtLongPh.Text.Trim();
                tar.Id_agent = txtIdAgent.Text.Trim();
                tar.Superficie = float.Parse(txtArea.Text.Trim());
                tar.Objectifs = txtObjective.Text.Trim();
                tar.Chefdelocalite = strChief;
                tar.Nomchefdelocalite = txtNameChief.Text.Trim();
                tar.Fonction = txtFunction.Text.Trim();
                tar.Documentdepropriete = strdocproperty;
                tar.Typedocument = txtTypeDoc.Text.Trim();
                tar.Utilisationprecedente = txtPrevUse.Text.Trim();
                tar.Nombrearbre = int.Parse(txtNumberArbr.Text.Trim());
                tar.Situation = txtSituation.Text.Trim();
                tar.Pente = txtPente.Text.Trim();
                tar.Sol = txtSol.Text.Trim();
                tar.Superficiebloc1 = float.Parse(txtSupBloc1.Text.Trim());
                tar.Superficiebloc2 = float.Parse(txtSupBloc2.Text.Trim());
                tar.Superficiebloc3 = float.Parse(txtSupBloc3.Text.Trim());
                tar.Essencebloc1 = txtEssBloc1.Text.Trim();
                tar.Essencebloc2 = txtEssBloc2.Text.Trim();
                tar.Essencebloc3 = txtEssBloc3.Text.Trim();
                tar.Ecartement1 = txtEcartBloc1.Text.Trim();
                tar.Ecartement2 = txtEcartBloc2.Text.Trim();
                tar.Ecartement3 = txtEcartBloc3.Text.Trim();
                tar.Idt = int.Parse(txtid.Text.Trim());

                myValue = dtgvTAR["Id_Tar", dtgvTAR.CurrentRow.Index].Value.ToString();

                if (xConn.State.ToString().Equals("Closed")) xConn.Open();
                xCmd = xConn.CreateCommand();

                xCmd.CommandText = "update TAR set id_asso=@id_asso,id_SaisonAsso=@id_SaisonAsso,numerocontrat=@numerocontrat,nom=@nom,prenom=@prenom,lieu_plant=@lieu_plant,village=@village,localite=@localite,groupement=@groupement,chefferie=@chefferie,territoire=@territoire,wpttar=@wpttar,latitude=@latitude,longitude=@longitude,altitude=@altitude,epetar=@epetar,nphoto=@nphoto,azimut=@azimut,latitude_ph=@latitude_ph,longitude_ph=@longitude_ph,id_agent=@id_agent,superficie=@superficie,objectifs=@objectifs,chefdelocalite=@chefdelocalite,nomchefdelocalite=@nomchefdelocalite,fonction=@fonction,documentdepropriete=@documentdepropriete," +
                        "typedocument=@typedocument,utilisationprecedente=@utilisationprecedente,arbreexistant=@arbreexistant,nombrearbre=@nombrearbre,situation=@situation,pente=@pente,sol=@sol,superficiebloc1=@superficiebloc1,superficiebloc2=@superficiebloc2,superficiebloc3=@superficiebloc3,essencebloc1=@essencebloc1,essencebloc2=@essencebloc2,essencebloc3=@essencebloc3,ecartement1=@ecartement1,ecartement2=@ecartement2,ecartement3=@ecartement3,idt=@idt where id_tar='" + myValue + "'";

                //xCmd.Parameters.Add("id_tar", SqlDbType.VarChar, 25, "@id_tar").Value = tar.Id_tar;
                xCmd.Parameters.Add("id_asso", SqlDbType.VarChar, 25, "@id_asso").Value = tar.Id_asso;
                xCmd.Parameters.Add("id_SaisonAsso", SqlDbType.VarChar, 32, "@id_SaisonAsso").Value = tar.idSaisonAsso;
                xCmd.Parameters.Add("numerocontrat", SqlDbType.VarChar, 25, "@numerocontrat").Value = tar.Numerocontrat;
                xCmd.Parameters.Add("nom", SqlDbType.VarChar, 75, "@nom").Value = tar.Nom;
                xCmd.Parameters.Add("prenom", SqlDbType.VarChar, 30, "@prenom").Value = tar.Prenom;
                xCmd.Parameters.Add("lieu_plant", SqlDbType.VarChar, 45, "@lieu_plant").Value = tar.Lieu_plant;
                xCmd.Parameters.Add("village", SqlDbType.VarChar, 45, "@village").Value = tar.Village;
                xCmd.Parameters.Add("localite", SqlDbType.VarChar, 45, "@localite").Value = tar.Localite;
                xCmd.Parameters.Add("groupement", SqlDbType.VarChar, 45, "@groupement").Value = tar.Groupement;
                xCmd.Parameters.Add("chefferie", SqlDbType.VarChar, 45, "@chefferie").Value = tar.Chefferie;
                xCmd.Parameters.Add("territoire", SqlDbType.VarChar, 45, "@territoire").Value = tar.Territoire;
                xCmd.Parameters.Add("wpttar", SqlDbType.Int, 10, "@wpttar").Value = tar.Wpttar;
                xCmd.Parameters.Add("latitude", SqlDbType.VarChar, 20, "@latitude").Value = tar.Latitude;
                xCmd.Parameters.Add("longitude", SqlDbType.VarChar, 20, "@longitude").Value = tar.Longitude;
                xCmd.Parameters.Add("altitude", SqlDbType.Int, 10, "@altitude").Value = tar.Altitude;
                xCmd.Parameters.Add("epetar", SqlDbType.Int, 10, "@epetar").Value = tar.Epetar;
                xCmd.Parameters.Add("nphoto", SqlDbType.Int, 10, "@nphoto").Value = tar.Nphoto;
                xCmd.Parameters.Add("azimut", SqlDbType.VarChar, 10, "@azimut").Value = tar.Azimut;
                xCmd.Parameters.Add("latitude_ph", SqlDbType.VarChar, 20, "@latitude_ph").Value = tar.Latitude_ph;
                xCmd.Parameters.Add("longitude_ph", SqlDbType.VarChar, 20, "@longitude_ph").Value = tar.Longitude;
                xCmd.Parameters.Add("id_agent", SqlDbType.VarChar, 6, "@id_agent").Value = tar.Id_agent;
                xCmd.Parameters.Add("superficie", SqlDbType.Float, 4, "@superficie").Value = tar.Superficie;
                xCmd.Parameters.Add("objectifs", SqlDbType.VarChar, 100, "@objectifs").Value = tar.Objectifs;
                xCmd.Parameters.Add("chefdelocalite", SqlDbType.Bit, 1, "@chefdelocalite").Value = tar.Chefdelocalite;
                xCmd.Parameters.Add("nomchefdelocalite", SqlDbType.VarChar, 100, "@nomchefdelocalite").Value = tar.Nomchefdelocalite;
                xCmd.Parameters.Add("fonction", SqlDbType.VarChar, 45, "@fonction").Value = tar.Fonction;
                xCmd.Parameters.Add("documentdepropriete", SqlDbType.Bit, 1, "@documentdepropriete").Value = tar.Documentdepropriete;
                xCmd.Parameters.Add("typedocument", SqlDbType.VarChar, 45, "@typedocument").Value = tar.Typedocument;
                xCmd.Parameters.Add("utilisationprecedente", SqlDbType.VarChar, 50, "@utilisationprecedente").Value = tar.Utilisationprecedente;
                xCmd.Parameters.Add("arbreexistant", SqlDbType.Bit, 1, "@arbreexistant").Value = tar.Arbreexistant;
                xCmd.Parameters.Add("nombrearbre", SqlDbType.Int, 10, "@nombrearbre").Value = tar.Nombrearbre;
                xCmd.Parameters.Add("situation", SqlDbType.VarChar, 30, "@situation").Value = tar.Situation;
                xCmd.Parameters.Add("pente", SqlDbType.VarChar, 30, "@pente").Value = tar.Pente;
                xCmd.Parameters.Add("sol", SqlDbType.VarChar, 30, "@sol").Value = tar.Sol;
                xCmd.Parameters.Add("superficiebloc1", SqlDbType.Float, 4, "@superficiebloc1").Value = tar.Superficiebloc1;
                xCmd.Parameters.Add("superficiebloc2", SqlDbType.Float, 4, "@superficiebloc2").Value = tar.Superficiebloc2;
                xCmd.Parameters.Add("superficiebloc3", SqlDbType.Float, 4, "@superficiebloc3").Value = tar.Superficiebloc3;
                xCmd.Parameters.Add("essencebloc1", SqlDbType.VarChar, 45, "@essencebloc1").Value = tar.Essencebloc1;
                xCmd.Parameters.Add("essencebloc2", SqlDbType.VarChar, 45, "@essencebloc2").Value = tar.Essencebloc2;
                xCmd.Parameters.Add("essencebloc3", SqlDbType.VarChar, 45, "@essencebloc3").Value = tar.Essencebloc3;
                xCmd.Parameters.Add("ecartement1", SqlDbType.VarChar, 7, "@ecartement1").Value = tar.Ecartement1;
                xCmd.Parameters.Add("ecartement2", SqlDbType.VarChar, 7, "@ecartement2").Value = tar.Ecartement2;
                xCmd.Parameters.Add("ecartement3", SqlDbType.VarChar, 7, "@ecartement3").Value = tar.Ecartement3;
                xCmd.Parameters.Add("idt", SqlDbType.Int, 10, "@idt").Value = tar.Idt;

                DialogResult drs = MessageBox.Show(this, "Voulez-vous reellement modifier cet TAR ?", "Mise a jour...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (drs == DialogResult.Yes)
                {
                    int f = xCmd.ExecuteNonQuery();
                    _EmptyControls();

                }
                if (drs == DialogResult.No)
                {
                    MessageBox.Show(this, "Mise a jour annulee", "Annulation");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(this, ex.Message, "Erreur");
            }

        }
        #endregion


        #region Numero_Automatique_TAR_et_PR
        private void _NumeroAutoTar()
        {
            int numero;

            try
            {
                if (xConn.State.ToString().Equals("Closed")) xConn.Open();
                xCmd = xConn.CreateCommand();
                xCmd.CommandText = "Select max(idt) as maxid from TAR where id_asso='" + txtIdAsso.Text.Trim() + "'";

                SqlDataReader xdr = null;
                xdr = xCmd.ExecuteReader();
                while (xdr.Read())
                {
                    if (xdr["maxid"].ToString() == null)
                    {
                        numero = 0;
                        int x = numero++;
                        txtid.Text = x.ToString();
                    }
                    if (xdr != null)
                    {
                        string t = xdr["maxid"].ToString();
                        if (t.Equals(""))
                        {
                            numero = 0;
                            int x = numero + 1;
                            //MessageBox.Show(this, x.ToString());
                            txtid.Text = x.ToString();
                            setGenerateidTAR();
                            setContratTAR();
                        }
                        if (!t.Equals(""))
                        {
                            int x = int.Parse(t);
                            txtid.Text = (x + 1).ToString();
                            setGenerateidTAR();
                            setContratTAR();
                        }
                        txtName.Focus();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(this, ex.Message, "Error");
            }
            xConn.Close();
        }


        private void _NumeroAutoPR()
        {
            int numBer;

            try
            {
                if (xConn.State.ToString().Equals("Closed")) xConn.Open();
                yCmd = xConn.CreateCommand();
                yCmd.CommandText = "Select max(idpr) as maxid from PR where id_asso='" + txtIdAsso2.Text.Trim() + "'";

                SqlDataReader xdr = null;
                xdr = yCmd.ExecuteReader();
                while (xdr.Read())
                {
                    if (xdr["maxid"].ToString() == null)
                    {
                        numBer = 0;
                        int x = numBer++;
                        txtIdpr2.Text = x.ToString();
                    }
                    if (xdr != null)
                    {
                        string t = xdr["maxid"].ToString();
                        if (t.Equals(""))
                        {
                            numBer = 0;
                            int x = numBer + 1;
                            //MessageBox.Show(this, x.ToString());
                            txtIdpr2.Text = x.ToString();
                            setNumeroPR();
                        }
                        if (!t.Equals(""))
                        {
                            int x = int.Parse(t);
                            txtIdpr2.Text = (x + 1).ToString();
                            setNumeroPR();
                        }
                        //txtidpr.Clear();
                        //txtidpr.Focus();
                        lstTar.Focus();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(this, ex.Message, "Error");
            }
            xConn.Close();
        }
        #endregion

        private void setContratTAR()
        {
            Tar n = new Tar();
            txtNumContr.Text = n.NumeroContratTAR(txtLSP.Text, cboSaison.Text, int.Parse(txtid.Text));
        }

        private void setGenerateidTAR()
        {
            Tar m = new Tar();
            txtIdTar.Text = m.NumeroIdTAR(txtLSP.Text, cboSaison.Text, int.Parse(txtid.Text));
        }

        private void setNumeroPR()
        {
            Pr n = new Pr();
            txtidpr.Text = n.NumeroDeLaPR(txtLSP2.Text.Trim(), cboSaison2.Text.Trim(), int.Parse(txtIdpr2.Text.Trim()));
        }

        private void EntryTabCtrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EntryTabCtrl.SelectedTab.Name.Equals("tbEntry1"))
            {
                this.Width = 1026;
                this.Height = 652;
                this.EntryTabCtrl.Width = 1017;
                this.EntryTabCtrl.Height = 625;
                this.CenterToParent();
            }
            if (EntryTabCtrl.SelectedTab.Name.Equals("tbEntry2"))
            {
                this.Width = 1257;
                this.Height = 652;
                this.EntryTabCtrl.Width = 1255;
                this.EntryTabCtrl.Height = 625;
                this.CenterToParent();
                _EmptyControls();
                __mainpr__();
            }
            if (EntryTabCtrl.SelectedTab.Name.Equals("tbEntry3"))
            {
                this.Width = 1026;
                this.Height = 652;
                this.EntryTabCtrl.Width = 1017;
                this.EntryTabCtrl.Height = 625;
                this.CenterToParent();
            }
        }

        private void txtclosef_Click(object sender, EventArgs e)
        {
            btnClose_Click(this, new System.EventArgs());
        }

        private void RemplirValeurComboPR()
        {
            //combo Melange
            cboMelange.Items.Clear();
            cboMelange.Items.Add("OUI");
            cboMelange.Items.Add("NON");
            
            //combo Planteur Present
            cboPlanteurPresent.Items.Clear();
            cboPlanteurPresent.Items.Add("OUI");
            cboPlanteurPresent.Items.Add("NON");
            //combo Type Ecartement
            cboTypeEcart.Items.Clear();
            cboTypeEcart.Items.Add("Regulier");
            cboTypeEcart.Items.Add("Irregulier");
            //combo Alignement
            cboAlign.Items.Clear();
            cboAlign.Items.Add("Ok");
            cboAlign.Items.Add("Insuffisant");
            //combo Piquets
            cboPiquet.Items.Clear();
            cboPiquet.Items.Add("Tous");
            cboPiquet.Items.Add("Insuffisant");
            //combo Eucalyptus
            cboEucaly.Items.Clear();
            cboEucaly.Items.Add("OUI");
            cboEucaly.Items.Add("NON");
            //combo Regarnissage
            cboRegarni.Items.Clear();
            cboRegarni.Items.Add("Suffisant");
            cboRegarni.Items.Add("Insuffisant");
            //combo Canopee
            cboCanopee.Items.Clear();
            cboCanopee.Items.Add("OUI");
            cboCanopee.Items.Add("NON");
            //combo Entretiern
            cboEntretien.Items.Clear();
            cboEntretien.Items.Add("Total");
            cboEntretien.Items.Add("Suffisant");
            cboEntretien.Items.Add("Insuffisant");
            cboEntretien.Items.Add("Urgent");
            //cbo Etat Plantation
            cboEtatPlant.Items.Clear();
            cboEtatPlant.Items.Add("Parfait");
            cboEtatPlant.Items.Add("Excellent");
            cboEtatPlant.Items.Add("Tres Bon");
            cboEtatPlant.Items.Add("Bon");
            cboEtatPlant.Items.Add("Mauvais");
            cboEtatPlant.Items.Add("Desastreux");
            //combo Culture vivrieres
            cboCulturesVi.Items.Clear();
            cboCulturesVi.Items.Add("OUI");
            cboCulturesVi.Items.Add("NON");
            //combo croissance arbres
            cboCroissArbre.Items.Clear();
            cboCroissArbre.Items.Add("Excellente");
            cboCroissArbre.Items.Add("Tres Forte");
            cboCroissArbre.Items.Add("Bonne");
            cboCroissArbre.Items.Add("Faible");
            cboCroissArbre.Items.Add("Tres Faible");
        }

        private void _LockTxtPr()
        {

            txtEssence1.Enabled = txtEssence2.Enabled = txtPied1.Enabled = txtPied2.Enabled = txtCauses.Enabled = txtPercentCanop.Enabled = txtDegats.Enabled = txtPercentPiquet.Enabled = txtPlantRegarnir.Enabled = false;
            chkCauses0.Enabled = chkCauses1.Enabled = chkCauses2.Enabled = chkCauses3.Enabled = chkCauses4.Enabled = false;
            chkCulture0.Enabled = chkCulture1.Enabled = chkCulture2.Enabled = chkCulture3.Enabled = chkCulture4.Enabled = chkCulture5.Enabled = chkCulture6.Enabled = false;
            txtCultures.Enabled = txtNPhotopr.Enabled = txtAzimutpr.Enabled = txtLatPhotoPr.Enabled = txtLongiPhotoPr.Enabled = false;
            chkDegat0.Enabled = chkDegat1.Enabled = chkDegat2.Enabled = chkDegat3.Enabled = chkDegat4.Enabled = chkDegat5.Enabled = chkDegat6.Enabled = chkDegat7.Enabled = chkDegat8.Enabled = chkDegat9.Enabled = chkDegat10.Enabled = chkDegat11.Enabled = chkDegat12.Enabled = chkDegat13.Enabled = false;
        }

        private void _ViderTxtBoxPr()
        {
            foreach (Control g in this.panel2.Controls)
            {
                if (g is TextBox)
                {
                    TextBox p = (TextBox)g;
                    p.Clear();
                }
            }

            txtPied1.Text = txtPied2.Text = txtNPhotopr.Text = txtSupReal.Text = txtSupNonReal.Text = "0";
            txtPente1.Text = txtPente2.Text = txtPente3.Text = txtPente4.Text = txtPercentCanop.Text = txtPercentPiquet.Text = txtPercentRegarni.Text = "0.0";
            rtxtCommentAsso.Clear();
            rtxtCommentWWF.Clear();
            rtxtCommentPlanteur.Clear();
            
            cboAgent2.SelectedIndex = -1;
            cboMelange.SelectedIndex = -1;
            cboEntretien.SelectedIndex = -1;
            cboEtatPlant.SelectedIndex = -1;
            cboEucaly.SelectedIndex = -1;
            cboCulturesVi.SelectedIndex = -1;
            cboEucaly.SelectedIndex = -1;
            cboPiquet.SelectedIndex = -1;
            cboPlanteurPresent.SelectedIndex = -1;
            cboRegarni.SelectedIndex = -1;
            cboTypeEcart.SelectedIndex = -1;
            cboCroissArbre.SelectedIndex = -1;
            cboCanopee.SelectedIndex = -1;

            txtidpr.Focus();
        }

        #region Point_entree_pour_PR
        private void __mainpr__()
        {
            RemplirValeurComboPR();
            //Place les valeurs par defaut
            _ViderTxtBoxPr();
            _LockTxtPr();

            foreach (Control z in this.panel2.Controls)
            {
                if (z is TextBox)
                {
                    TextBox zz = (TextBox)z;
                    zz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                }
            }
        }
        #endregion

        private void chkCopiePlanteur_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCopiePlanteur.Checked)
            {
                Pr pr = new Pr();
                strPlanterCopie = pr._Checkboxpr(chkCopiePlanteur);

            }
        }

        private void cboMelange_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboMelange.Text.Equals("OUI"))
            {
                txtEssence1.Enabled = txtEssence2.Enabled = txtPied1.Enabled = txtPied2.Enabled = true;
            }
            if (cboMelange.Text.Equals("NON"))
            {
                txtEssence1.Enabled = txtEssence2.Enabled = txtPied1.Enabled = txtPied2.Enabled = false;
            }
        }

        private void cboTypeEcart_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboTypeEcart.Text.Equals("Irregulier"))
            {
                txtCauses.Enabled = true;
                chkCauses0.Enabled = chkCauses1.Enabled = chkCauses2.Enabled = chkCauses3.Enabled = chkCauses4.Enabled = true;
            }
            else
            {
                txtCauses.Clear();
                txtCauses.Enabled = false;
                chkCauses0.Enabled = chkCauses1.Enabled = chkCauses2.Enabled = chkCauses3.Enabled = chkCauses4.Enabled = false;
            }
        }

        private void cboAlign_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboAlign.Text.Equals("Insuffisant") || cboTypeEcart.Text.Equals("Irregulier"))
            {
                txtCauses.Enabled = true;
                chkCauses0.Enabled = chkCauses1.Enabled = chkCauses2.Enabled = chkCauses3.Enabled = chkCauses4.Enabled = true;
            }
            else
            {
                txtCauses.Clear();
                txtCauses.Enabled = false;
                chkCauses0.Enabled = chkCauses1.Enabled = chkCauses2.Enabled = chkCauses3.Enabled = chkCauses4.Enabled = false;

            }
        }

        private void cboPiquet_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboPiquet.Text.Equals("Insuffisant"))
            {
                txtPercentPiquet.Enabled = true;
            }
            if (cboPiquet.Text.Equals("Suffisant"))
            {
                txtPercentPiquet.Clear();
                txtPercentPiquet.Enabled = false;
            }
        }

        private void cboCanopee_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboCanopee.Text.Equals("OUI"))
            {
                txtPercentCanop.Enabled = true;
            }
            if (cboCanopee.Text.Equals("NON"))
            {
                txtPercentCanop.Clear();
                txtPercentCanop.Text = "0.0";
                txtPercentCanop.Enabled = false;
            }
        }

        private void cboCulturesVi_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboCulturesVi.Text.Equals("OUI"))
            {
                chkCulture0.Enabled = chkCulture1.Enabled = chkCulture2.Enabled = chkCulture3.Enabled = chkCulture4.Enabled = chkCulture5.Enabled = chkCulture6.Enabled = true;
                txtCultures.Enabled = true;
            }
            if (cboCulturesVi.Text.Equals("NON"))
            {
                chkCulture0.Enabled = chkCulture1.Enabled = chkCulture2.Enabled = chkCulture3.Enabled = chkCulture4.Enabled = chkCulture5.Enabled = chkCulture6.Enabled = false;
                txtCultures.Clear();
                txtCultures.Enabled = false;
            }
        }

        private void txtPercentDegats_TextChanged(object sender, EventArgs e)
        {
            if (!txtPercentDegats.Text.Trim().Equals("0") || !txtPercentDegats.Text.Trim().Equals(""))
            {
                chkDegat0.Enabled = chkDegat1.Enabled = chkDegat2.Enabled = chkDegat3.Enabled = chkDegat4.Enabled = chkDegat5.Enabled = chkDegat6.Enabled = chkDegat7.Enabled = chkDegat8.Enabled = chkDegat9.Enabled = chkDegat10.Enabled = chkDegat11.Enabled = chkDegat12.Enabled = chkDegat13.Enabled = true;
                txtDegats.Enabled = true;

            }
            if (txtPercentDegats.Text.Trim().Equals("0") || txtPercentDegats.Text.Trim().Equals(""))
            {
                chkDegat0.Enabled = chkDegat1.Enabled = chkDegat2.Enabled = chkDegat3.Enabled = chkDegat4.Enabled = chkDegat5.Enabled = chkDegat6.Enabled = chkDegat7.Enabled = chkDegat8.Enabled = chkDegat9.Enabled = chkDegat10.Enabled = chkDegat11.Enabled = chkDegat12.Enabled = chkDegat13.Enabled = false;
                txtDegats.Clear();
                txtDegats.Enabled = false;
            }
        }

        private void chkPhotoGps_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPhotoGps.Checked)
            {
                txtNPhotopr.Enabled = txtAzimutpr.Enabled = txtLatPhotoPr.Enabled = txtLongiPhotoPr.Enabled = true;
            }
            if (!chkPhotoGps.Checked)
            {
                txtNPhotopr.Text = txtAzimutpr.Text = txtLatPhotoPr.Text = txtLongiPhotoPr.Text = "";
                txtNPhotopr.Enabled = txtAzimutpr.Enabled = txtLatPhotoPr.Enabled = txtLongiPhotoPr.Enabled = false;
                txtNPhotopr.Text = "0";
                txtAzimutpr.Text = "0";
            }

        }

        private void txtPercentDegats_Leave(object sender, EventArgs e)
        {
            
        }

        private void cboAgent2_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (xConn.State.ToString().Equals("Closed")) xConn.Open();
                yCmd = xConn.CreateCommand();
                yCmd.CommandText = "Select * from AGENTRECOLTE where nom_agent='" + cboAgent2.Text.Trim() + "'";

                SqlDataReader xdr = null;
                xdr = yCmd.ExecuteReader();

                while (xdr.Read())
                {
                    txtIdAgent2.Clear();
                    txtIdAgent2.Text = xdr["id_agent"].ToString();
                }
            }
            catch (SqlException x)
            {
                MessageBox.Show(this, x.Message, "Erreur");
            }
            xConn.Close();
        }

        private void txtPied1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPied2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Fill_Lst_des_TAR()
        {
            try
            {
                if (xConn.State.ToString().Equals("Closed")) xConn.Open();
                yCmd = xConn.CreateCommand();
                yCmd.CommandText = "select id_tar,id_asso,id_SaisonAsso from TAR where id_SaisonAsso='" + cboAsso2.Text + "'";

                SqlDataAdapter dxr = new SqlDataAdapter(yCmd);
                DataSet sxd = new DataSet();
                dxr.Fill(sxd, "Tar");

                lstTar.Sorted = false;
                lstTar.DataSource = sxd.Tables["Tar"];
                lstTar.DisplayMember = sxd.Tables["Tar"].Columns["id_tar"].ToString();
                lstTar.ValueMember = sxd.Tables["Tar"].Columns["id_tar"].ToString();
            }
            catch (SqlException e)
            {
                MessageBox.Show(this, e.Message, "Erreur");
            }
            xConn.Close();
        }

        private void cboAsso2_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (xConn.State.ToString().Equals("Closed")) xConn.Open();
                yCmd = xConn.CreateCommand();
                yCmd.CommandText = "Select * from SEASON_ASSO where id_SaisonAsso='" + cboAsso2.Text.Trim() + "'";
                SqlDataReader rd = null;
                rd = yCmd.ExecuteReader();
                while (rd.Read())
                {
                    txtIdAsso2.Focus();
                    txtIdAsso2.Text = rd["id_asso"].ToString();
                }
            }
            catch (SqlException x)
            {
                MessageBox.Show(this, x.Message, "Erreur");
            }
            xConn.Close();
            //Appel aux methodes supplementaires
            _SelectLspNameForPR(txtIdAsso2.Text.Trim());
            Fill_Lst_des_TAR();
        }

        private void btnAddPR_Click(object sender, EventArgs e)
        {
            try
            {
                Pr myPr = new Pr();
                myPr.idpr = int.Parse(txtIdpr2.Text.Trim());
                myPr.Id_pr = txtidpr.Text.Trim();
                myPr.Id_agent = txtIdAgent2.Text.Trim();
                myPr.Id_tar = txt_id_tar.Text.Trim();
                myPr.Id_season = cboSaison2.Text;
                myPr.Id_asso = txtIdAsso2.Text.Trim();
                myPr.Essenceprincipale = txtEssence.Text.Trim();
                myPr.Essence1 = txtEssence1.Text.Trim();
                myPr.Essence2 = txtEssence2.Text.Trim();
                myPr.Pieds1 = int.Parse(txtPied1.Text.Trim());
                myPr.Pieds2 = int.Parse(txtPied2.Text.Trim());
                myPr.Melanges = cboMelange.Text.Trim();
                myPr.Pente1 = float.Parse(txtPente1.Text.Trim());
                myPr.Pente2 = float.Parse(txtPente2.Text.Trim());
                myPr.Pente3 = float.Parse(txtPente3.Text.Trim());
                myPr.Pente4 = float.Parse(txtPente4.Text.Trim());
                myPr.SuperficieRealise = float.Parse(txtSupReal.Text.Trim());
                myPr.SuperficieNonPlante = float.Parse(txtSupNonReal.Text.Trim());
                myPr.Ecartementtype = cboTypeEcart.Text;
                myPr.Ecartement = txtSpacing.Text.Trim();
                myPr.Alignement = cboAlign.Text;
                myPr.Causes = txtCauses.Text.Trim();
                myPr.Azimut = txtAzimutpr.Text.Trim();
                myPr.Numerophoto = int.Parse(txtNPhotopr.Text.Trim());
                myPr.Latitudepr = txtLatPhotoPr.Text.Trim();
                myPr.Longitude = txtLongiPhotoPr.Text.Trim();
                myPr.Piquets = cboPiquet.Text;
                myPr.Pourcentagepiquet = float.Parse(txtPercentPiquet.Text.Trim());
                myPr.Planteurcopie = strPlanterCopie;
                myPr.Regarnissage = cboRegarni.Text;
                myPr.Pourcentageregarni = float.Parse(txtPercentRegarni.Text.Trim());
                myPr.Presenceculture = cboCulturesVi.Text;
                myPr.Typeculture = txtCultures.Text.Trim();
                myPr.Presenceplanteur = cboPlanteurPresent.Text;
                myPr.Canopees = cboCanopee.Text;
                myPr.Canopeespourcent = float.Parse(txtPercentCanop.Text.Trim());
                myPr.Entretien = cboEntretien.Text;
                myPr.Etatplantation = cboEtatPlant.Text;
                myPr.Eucalyptuscoursdeau = cboEucaly.Text;
                myPr.Haut1 = float.Parse(txtHaut0.Text.Trim());
                myPr.Haut2 = float.Parse(txtHaut1.Text.Trim());
                myPr.Haut3 = float.Parse(txtHaut2.Text.Trim());
                myPr.Haut4 = float.Parse(txtHaut3.Text.Trim());
                myPr.Degats = float.Parse(txtPercentDegats.Text.Trim());
                myPr.TypeDegats = txtDegats.Text.Trim();
                myPr.Croissancearbre = cboCroissArbre.Text;
                myPr.Commentairewwf = rtxtCommentWWF.Text;
                myPr.Commentaireplanteur = rtxtCommentPlanteur.Text;
                myPr.Commentaireasso = rtxtCommentAsso.Text;

                myPrValue = txtidpr.Text.Trim();

                    if (xConn.State.ToString().Equals("Closed")) xConn.Open();

                    yCmd = xConn.CreateCommand();
                    yCmd.CommandText = "insert into Pr(idpr,id_pr,id_agent,id_tar,id_SaisonAsso,id_asso,essenceprincipale,melanges,essence1,pieds1,essence2,pieds2,pente1,pente2,pente3,pente4,superficieRealise,superficieNonPlante,ecartementtype,ecartement,alignement,causes,piquets,pourcentagepiquet,eucalyptuscoursdeau,regarnissage,pourcentageregarni,haut1,haut2,haut3,haut4,canopees,canopeespourcent,presenceplanteur,entretien," +
                        "etatplantation,presenceculture,typeculture,degats,typedegats,croissancearbre,numerophoto,azimut,latitudepr,longitude,planteurcopie,commentairewwf,commentaireplanteur,commentaireasso) values (@idpr,@id_pr,@id_agent,@id_tar,@id_SaisonAsso,@id_asso,@essenceprincipale,@melanges,@essence1,@pieds1,@essence2,@pieds2,@pente1,@pente2,@pente3,@pente4,@superficieRealise,@superficieNonPlante,@ecartementtype,@ecartement,@alignement,@causes," +
                        "@piquets,@pourcentagepiquet,@eucalyptuscoursdeau,@regarnissage,@pourcentageregarni,@haut1,@haut2,@haut3,@haut4,@canopees,@canopeespourcent,@presenceplanteur,@entretien,@etatplantation,@presenceculture,@typeculture,@degats,@typedegats,@croissancearbre,@numerophoto,@azimut,@latitudepr,@longitude,@planteurcopie,@commentairewwf,@commentaireplanteur,@commentaireasso)";

                    yCmd.Parameters.Add("idpr", SqlDbType.Int, 10, "@idpr").Value = myPr.idpr;
                    yCmd.Parameters.Add("id_pr", SqlDbType.VarChar, 25, "@id_pr").Value = myPr.Id_pr;
                    yCmd.Parameters.Add("id_agent", SqlDbType.VarChar, 6, "@id_agent").Value = myPr.Id_agent;
                    yCmd.Parameters.Add("id_tar", SqlDbType.VarChar, 25, "@id_tar").Value = myPr.Id_tar;
                    yCmd.Parameters.Add("id_SaisonAsso", SqlDbType.VarChar, 32, "@id_SaisonAsso").Value = myPr.Id_season;
                    yCmd.Parameters.Add("id_asso", SqlDbType.VarChar, 25, "@id_asso").Value = myPr.Id_asso;
                    yCmd.Parameters.Add("essenceprincipale", SqlDbType.VarChar, 75, "@essenceprincipale").Value = myPr.Essenceprincipale;
                    yCmd.Parameters.Add("melanges", SqlDbType.Char, 3, "@melanges").Value = myPr.Melanges;
                    yCmd.Parameters.Add("essence1", SqlDbType.VarChar, 75, "@essence1").Value = myPr.Essence1;
                    yCmd.Parameters.Add("pieds1", SqlDbType.Float, 4, "@pieds1").Value = myPr.Pieds1;
                    yCmd.Parameters.Add("essence2", SqlDbType.VarChar, 75, "@essence2").Value = myPr.Essence2;
                    yCmd.Parameters.Add("pieds2", SqlDbType.Float, 4, "@pieds2").Value = myPr.Pieds2;
                    yCmd.Parameters.Add("pente1", SqlDbType.Float, 2, "@pente1").Value = myPr.Pente1;
                    yCmd.Parameters.Add("pente2", SqlDbType.Float, 2, "@pente2").Value = myPr.Pente2;
                    yCmd.Parameters.Add("pente3", SqlDbType.Float, 2, "@pente3").Value = myPr.Pente3;
                    yCmd.Parameters.Add("pente4", SqlDbType.Float, 2, "@pente4").Value = myPr.Pente4;
                    yCmd.Parameters.Add("superficieRealise", SqlDbType.Float, 4, "@superficieRealise").Value = myPr.SuperficieRealise;
                    yCmd.Parameters.Add("superficieNonPlante", SqlDbType.Float, 4, "@superficieNonPlante").Value = myPr.SuperficieNonPlante;
                    yCmd.Parameters.Add("ecartementtype", SqlDbType.VarChar, 10, "@ecartementtype").Value = myPr.Ecartementtype;
                    yCmd.Parameters.Add("ecartement", SqlDbType.VarChar, 7, "@ecartement").Value = myPr.Ecartement;
                    yCmd.Parameters.Add("alignement", SqlDbType.VarChar, 11, "@alignement").Value = myPr.Alignement;
                    yCmd.Parameters.Add("causes", SqlDbType.VarChar, 100, "@causes").Value = myPr.Causes;
                    yCmd.Parameters.Add("piquets", SqlDbType.VarChar, 11, "@piquets").Value = myPr.Piquets;
                    yCmd.Parameters.Add("pourcentagepiquet", SqlDbType.Float, 4, "@pourcentagepiquet").Value = myPr.Pourcentagepiquet;
                    yCmd.Parameters.Add("eucalyptuscoursdeau", SqlDbType.Char, 3, "@eucalyptuscoursdeau").Value = myPr.Eucalyptuscoursdeau;
                    yCmd.Parameters.Add("regarnissage", SqlDbType.VarChar, 11, "@regarnissage").Value = myPr.Regarnissage;
                    yCmd.Parameters.Add("pourcentageregarni", SqlDbType.Float, 4, "@pourcentageregarni").Value = myPr.Pourcentageregarni;
                    yCmd.Parameters.Add("haut1", SqlDbType.Float, 4, "@haut1").Value = myPr.Haut1;
                    yCmd.Parameters.Add("haut2", SqlDbType.Float, 4, "@haut2").Value = myPr.Haut2;
                    yCmd.Parameters.Add("haut3", SqlDbType.Float, 4, "@haut3").Value = myPr.Haut3;
                    yCmd.Parameters.Add("haut4", SqlDbType.Float, 4, "@haut4").Value = myPr.Haut4;
                    yCmd.Parameters.Add("canopees", SqlDbType.Char, 3, "@canopees").Value = myPr.Canopees;
                    yCmd.Parameters.Add("canopeespourcent", SqlDbType.Float, 4, "@canopeespourcent").Value = myPr.Canopeespourcent;
                    yCmd.Parameters.Add("presenceplanteur", SqlDbType.Char, 3, "@presenceplanteur").Value = myPr.Presenceplanteur;
                    yCmd.Parameters.Add("entretien", SqlDbType.VarChar, 12, "@entretien").Value = myPr.Entretien;
                    yCmd.Parameters.Add("etatplantation", SqlDbType.VarChar, 12, "@etatplantation").Value = myPr.Etatplantation;
                    yCmd.Parameters.Add("presenceculture", SqlDbType.Char, 3, "@presenceculture").Value = myPr.Presenceculture;
                    yCmd.Parameters.Add("typeculture", SqlDbType.VarChar, 125, "@typeculture").Value = myPr.Typeculture;
                    yCmd.Parameters.Add("degats", SqlDbType.Float, 4, "@degats").Value = myPr.Degats;
                    yCmd.Parameters.Add("typedegats", SqlDbType.VarChar, 150, "@typedegats").Value = myPr.TypeDegats;
                    yCmd.Parameters.Add("croissancearbre", SqlDbType.VarChar, 14, "@croissancearbre").Value = myPr.Croissancearbre;
                    yCmd.Parameters.Add("numerophoto", SqlDbType.Int, 10, "@numerophoto").Value = myPr.Numerophoto;
                    yCmd.Parameters.Add("azimut", SqlDbType.VarChar, 6, "@azimut").Value = myPr.Azimut;
                    yCmd.Parameters.Add("latitudepr", SqlDbType.VarChar, 20, "@latitudepr").Value = myPr.Latitudepr;
                    yCmd.Parameters.Add("longitude", SqlDbType.VarChar, 20, "@longitude").Value = myPr.Longitude;
                    yCmd.Parameters.Add("planteurcopie", SqlDbType.Bit, 1, "@planteurcopie").Value = myPr.Planteurcopie;
                    yCmd.Parameters.Add("commentairewwf", SqlDbType.VarChar, 200, "@commentairewwf").Value = myPr.Commentairewwf;
                    yCmd.Parameters.Add("commentaireplanteur", SqlDbType.VarChar, 200, "@commentaireplanteur").Value = myPr.Commentaireplanteur;
                    yCmd.Parameters.Add("commentaireasso", SqlDbType.VarChar, 200, "@commentaireasso").Value = myPr.Commentaireasso;


                    int i = yCmd.ExecuteNonQuery();
                    //faire appel a la methode pour clear les textbox
                  
            }
            catch (SqlException k)
            {
                MessageBox.Show(this, k.Message, "Erreur");
            }
            xConn.Close();
            dtgvPR.Refresh();
            _LockTxtPr();
            _ViderTxtBoxPr();
            _NumeroAutoPR();
            Conn_BindingSource_PR();
            _OpenFormGPScoordinate();
            
        }

        private void _OpenFormGPScoordinate()
        {
            DialogResult drz = MessageBox.Show(this, "Voulez-vous saisir les donnees GPS pour \n cette PR", "Ajout donnees Gps ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drz == DialogResult.Yes)
            {
                btnGPSdata_Click(this, new System.EventArgs());
            }
        }

        private void lstTar_Click(object sender, EventArgs e)
        {
            txt_id_tar.Text = lstTar.SelectedValue.ToString();
        }

        private void btnDelPr_Click(object sender, EventArgs e)
        {
            try
            {
                if (xConn.State.ToString().Equals("Closed")) xConn.Open();
                myValue = dtgvPR["id_pr", dtgvPR.CurrentRow.Index].Value.ToString();

                yCmd = xConn.CreateCommand();
                yCmd.CommandText = "delete from Pr where id_pr='" + myValue + "'";

                DialogResult drez = MessageBox.Show(this, "Voulez-vous reellement supprimer cette PR ?", "Suppression...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (drez == DialogResult.Yes)
                {
                    int f = yCmd.ExecuteNonQuery();
                    //faire appel a la methode pour clear les textbox

                    foreach (Control zi in this.panel2.Controls)
                    {
                        if (zi is TextBox)
                        {
                            TextBox ziz = (TextBox)zi;
                            ziz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        }
                    }

                    
                }
                if (drez == DialogResult.No)
                {
                    MessageBox.Show(this, "Suppression annulee !", "Annulation");
                }
            }
            catch (SqlException d)
            {
                MessageBox.Show(this, d.Message, "Erreur");
            }
            xConn.Close();
            dtgvPR.Refresh();
            _LockTxtPr();
            _ViderTxtBoxPr();
            _NumeroAutoPR();
            Conn_BindingSource_PR();
        }

        private void btnUpdatePr_Click(object sender, EventArgs e)
        {
            try
            {
                Pr pr = new Pr();
                pr.idpr = int.Parse(txtIdpr2.Text.Trim());
                pr.Id_pr = txtidpr.Text.Trim();
                pr.Id_agent = txtIdAgent2.Text.Trim();
                pr.Id_tar = txt_id_tar.Text.Trim();
                pr.Id_season = cboSaison2.Text;
                pr.Id_asso = txtIdAsso2.Text.Trim();
                pr.Essenceprincipale = txtEssence.Text.Trim();
                pr.Essence1 = txtEssence1.Text.Trim();
                pr.Essence2 = txtEssence2.Text.Trim();
                pr.Pieds1 = int.Parse(txtPied1.Text.Trim());
                pr.Pieds2 = int.Parse(txtPied2.Text.Trim());
                pr.Melanges = cboMelange.Text.Trim();
                pr.Pente1 = float.Parse(txtPente1.Text.Trim());
                pr.Pente2 = float.Parse(txtPente2.Text.Trim());
                pr.Pente3 = float.Parse(txtPente3.Text.Trim());
                pr.Pente4 = float.Parse(txtPente4.Text.Trim());
                pr.SuperficieRealise = float.Parse(txtSupReal.Text.Trim());
                pr.SuperficieNonPlante = float.Parse(txtSupNonReal.Text.Trim());
                pr.Ecartementtype = cboTypeEcart.Text;
                pr.Ecartement = txtSpacing.Text.Trim();
                pr.Alignement = cboAlign.Text;
                pr.Causes = txtCauses.Text.Trim();
                pr.Azimut = txtAzimutpr.Text.Trim();
                pr.Numerophoto = int.Parse(txtNPhotopr.Text.Trim());
                pr.Latitudepr = txtLatPhotoPr.Text.Trim();
                pr.Longitude = txtLongiPhotoPr.Text.Trim();
                pr.Piquets = cboPiquet.Text;
                pr.Pourcentagepiquet = float.Parse(txtPercentPiquet.Text.Trim());
                pr.Planteurcopie = strPlanterCopie;
                pr.Regarnissage = cboRegarni.Text;
                pr.Pourcentageregarni = float.Parse(txtPercentRegarni.Text.Trim());
                pr.Presenceculture = cboCulturesVi.Text;
                pr.Typeculture = txtCultures.Text.Trim();
                pr.Presenceplanteur = cboPlanteurPresent.Text;
                pr.Canopees = cboCanopee.Text;
                pr.Canopeespourcent = float.Parse(txtPercentCanop.Text.Trim());
                pr.Entretien = cboEntretien.Text;
                pr.Etatplantation = cboEtatPlant.Text;
                pr.Eucalyptuscoursdeau = cboEucaly.Text;
                pr.Haut1 = float.Parse(txtHaut0.Text.Trim());
                pr.Haut2 = float.Parse(txtHaut1.Text.Trim());
                pr.Haut3 = float.Parse(txtHaut2.Text.Trim());
                pr.Haut4 = float.Parse(txtHaut3.Text.Trim());
                pr.Degats = float.Parse(txtPercentDegats.Text.Trim());
                pr.TypeDegats = txtDegats.Text.Trim();
                pr.Croissancearbre = cboCroissArbre.Text;
                pr.Commentairewwf = rtxtCommentWWF.Text;
                pr.Commentaireplanteur = rtxtCommentPlanteur.Text;
                pr.Commentaireasso = rtxtCommentAsso.Text;

               
                    if (xConn.State.ToString().Equals("Closed")) xConn.Open();
                    myValue = dtgvPR[0, dtgvPR.CurrentRow.Index].Value.ToString();
                    yCmd = xConn.CreateCommand();
                    yCmd.CommandText = "update Pr set idpr=@idpr,id_pr=@id_pr,id_agent=@id_agent,id_tar=@id_tar,id_SaisonAsso=@id_SaisonAsso,id_asso=@id_asso,essenceprincipale=@essenceprincipale,melanges=@melanges,essence1=@essence1,pieds1=@pieds1,essence2=@essence2,pieds2@pieds2,pente1@pente1,pente2=@pente2,pente3=@pente3,pente4=@pente4,superficieRealise=@superficieRealise,superficieNonPlante=@superficieNonPlante,ecartementtype=@ecartementtype,ecartement=@ecartement,alignement=@alignement,causes=@causes," +
                        "piquets=@piquets,pourcentagepiquet=@pourcentagepiquet,eucalyptuscoursdeau=@eucalyptuscoursdeau,regarnissage=@regarnissage,pourcentageregarni=@pourcentageregarni,haut1=@haut1,haut2=@haut2,haut3=@haut3,haut4=@haut4,canopees=@canopees,canopeespourcent=@canopeespourcent,presenceplanteur=@presenceplanteur,entretien=@entretien,etatplantation=@etatplantation,presenceculture=@presenceculture,typeculture=@typeculture,degats=@degats,typedegats=@typedegats,croissancearbre=@croissancearbre,numerophoto=@numerophoto,azimut=@azimut,latitudepr=@latitudepr," +
                        "longitude=@longitude,planteurcopie=@planteurcopie,commentairewwf=@commentairewwf,commentaireplanteur=@commentaireplanteur,commentaireasso=@commentaireasso where id_pr='" + myValue + "'";

                    yCmd.Parameters.Add("idpr", SqlDbType.Int, 10, "@idpr").Value = pr.idpr;
                    yCmd.Parameters.Add("id_pr", SqlDbType.VarChar, 25, "@id_pr").Value = pr.Id_pr;
                    yCmd.Parameters.Add("id_agent", SqlDbType.VarChar, 6, "@id_agent").Value = pr.Id_agent;
                    yCmd.Parameters.Add("id_tar", SqlDbType.VarChar, 25, "@id_tar").Value = pr.Id_tar;
                    yCmd.Parameters.Add("id_SaisonAsso", SqlDbType.VarChar, 32, "@id_SaisonAsso").Value = pr.Id_season;
                    yCmd.Parameters.Add("id_asso", SqlDbType.VarChar, 25, "@id_asso").Value = pr.Id_asso;
                    yCmd.Parameters.Add("essenceprincipale", SqlDbType.VarChar, 75, "@essenceprincipale").Value = pr.Essenceprincipale;
                    yCmd.Parameters.Add("melanges", SqlDbType.Char, 3, "@melanges").Value = pr.Melanges;
                    yCmd.Parameters.Add("essence1", SqlDbType.VarChar, 75, "@essence1").Value = pr.Essence1;
                    yCmd.Parameters.Add("pieds1", SqlDbType.Float, 4, "@pieds1").Value = pr.Pieds1;
                    yCmd.Parameters.Add("essence2", SqlDbType.VarChar, 75, "@essence2").Value = pr.Essence2;
                    yCmd.Parameters.Add("pieds2", SqlDbType.Float, 4, "@pieds2").Value = pr.Pieds2;
                    yCmd.Parameters.Add("pente1", SqlDbType.Float, 2, "@pente1").Value = pr.Pente1;
                    yCmd.Parameters.Add("pente2", SqlDbType.Float, 2, "@pente2").Value = pr.Pente2;
                    yCmd.Parameters.Add("pente3", SqlDbType.Float, 2, "@pente3").Value = pr.Pente3;
                    yCmd.Parameters.Add("pente4", SqlDbType.Float, 2, "@pente4").Value = pr.Pente4;
                    yCmd.Parameters.Add("superficieRealise", SqlDbType.Float, 4, "@superficieRealise").Value = pr.SuperficieRealise;
                    yCmd.Parameters.Add("superficieNonPlante", SqlDbType.Float, 4, "@superficieNonPlante").Value = pr.SuperficieNonPlante;
                    yCmd.Parameters.Add("ecartementtype", SqlDbType.VarChar, 10, "@ecartementtype").Value = pr.Ecartementtype;
                    yCmd.Parameters.Add("ecartement", SqlDbType.VarChar, 7, "@ecartement").Value = pr.Ecartement;
                    yCmd.Parameters.Add("alignement", SqlDbType.VarChar, 11, "@alignement").Value = pr.Alignement;
                    yCmd.Parameters.Add("causes", SqlDbType.VarChar, 100, "@causes").Value = pr.Causes;
                    yCmd.Parameters.Add("piquets", SqlDbType.VarChar, 11, "@piquets").Value = pr.Piquets;
                    yCmd.Parameters.Add("pourcentagepiquet", SqlDbType.Float, 4, "@pourcentagepiquet").Value = pr.Pourcentagepiquet;
                    yCmd.Parameters.Add("eucalyptuscoursdeau", SqlDbType.Char, 3, "@eucalyptuscoursdeau").Value = pr.Eucalyptuscoursdeau;
                    yCmd.Parameters.Add("regarnissage", SqlDbType.VarChar, 11, "@regarnissage").Value = pr.Regarnissage;
                    yCmd.Parameters.Add("pourcentageregarni", SqlDbType.Float, 4, "@pourcentageregarni").Value = pr.Pourcentageregarni;
                    yCmd.Parameters.Add("haut1", SqlDbType.Float, 4, "@haut1").Value = pr.Haut1;
                    yCmd.Parameters.Add("haut2", SqlDbType.Float, 4, "@haut2").Value = pr.Haut2;
                    yCmd.Parameters.Add("haut3", SqlDbType.Float, 4, "@haut3").Value = pr.Haut3;
                    yCmd.Parameters.Add("haut4", SqlDbType.Float, 4, "@haut4").Value = pr.Haut4;
                    yCmd.Parameters.Add("canopees", SqlDbType.Char, 3, "@canopees").Value = pr.Canopees;
                    yCmd.Parameters.Add("canopeespourcent", SqlDbType.Float, 4, "@canopeespourcent").Value = pr.Canopeespourcent;
                    yCmd.Parameters.Add("presenceplanteur", SqlDbType.Char, 3, "@presenceplanteur").Value = pr.Presenceplanteur;
                    yCmd.Parameters.Add("entretien", SqlDbType.VarChar, 12, "@entretien").Value = pr.Entretien;
                    yCmd.Parameters.Add("etatplantation", SqlDbType.VarChar, 12, "@etatplantation").Value = pr.Etatplantation;
                    yCmd.Parameters.Add("presenceculture", SqlDbType.Char, 3, "@presenceculture").Value = pr.Presenceculture;
                    yCmd.Parameters.Add("typeculture", SqlDbType.VarChar, 125, "@typeculture").Value = pr.Typeculture;
                    yCmd.Parameters.Add("degats", SqlDbType.Float, 4, "@degats").Value = pr.Degats;
                    yCmd.Parameters.Add("typedegats", SqlDbType.VarChar, 150, "@typedegats").Value = pr.TypeDegats;
                    yCmd.Parameters.Add("croissancearbre", SqlDbType.VarChar, 14, "@croissancearbre").Value = pr.Croissancearbre;
                    yCmd.Parameters.Add("numerophoto", SqlDbType.Int, 10, "@numerophoto").Value = pr.Numerophoto;
                    yCmd.Parameters.Add("azimut", SqlDbType.VarChar, 6, "@azimut").Value = pr.Azimut;
                    yCmd.Parameters.Add("latitudepr", SqlDbType.VarChar, 20, "@latitudepr").Value = pr.Latitudepr;
                    yCmd.Parameters.Add("longitude", SqlDbType.VarChar, 20, "@longitude").Value = pr.Longitude;
                    yCmd.Parameters.Add("planteurcopie", SqlDbType.Bit, 1, "@planteurcopie").Value = pr.Planteurcopie;
                    yCmd.Parameters.Add("commentairewwf", SqlDbType.VarChar, 200, "@commentairewwf").Value = pr.Commentairewwf;
                    yCmd.Parameters.Add("commentaireplanteur", SqlDbType.VarChar, 200, "@commentaireplanteur").Value = pr.Commentaireplanteur;
                    yCmd.Parameters.Add("commentaireasso", SqlDbType.VarChar, 200, "@commentaireasso").Value = pr.Commentaireasso;


                    int i = yCmd.ExecuteNonQuery();
                    //faire appel a la methode pour clear les textbox

                }
                catch (SqlException r)
                {
                    MessageBox.Show(this, r.Message, "Erreur");
                }
                xConn.Close();
                dtgvPR.Refresh();
                _LockTxtPr();
                _ViderTxtBoxPr();
            }

        private void btnGPSdata_Click(object sender, EventArgs e)
        {
            gpsdataForm w = new gpsdataForm();
            w.MdiParent = xMainForm;
            w.setMdiMainForm(xMainForm);
            w.setEntryForm(this);
            w.Icon = this.Icon;
            w.Show();

        }

        #region EXPORT_VERS_EXCEL

        private void ExportTarDataToExcel()
        {
            Excel.Application xApp;
            Excel.Workbook xWorkbook;
            Excel.Worksheet xWorksheet;

            object misValue = System.Reflection.Missing.Value;

            xApp = new Excel.ApplicationClass();
            xWorkbook = xApp.Workbooks.Add(misValue);
            xWorksheet = (Excel.Worksheet)xWorkbook.Worksheets.get_Item(1);

            int j = 0; int i = 0;

      //Stocke les en-tetes des colonnes
            for (int k = 1; k < dtgvTAR.Columns.Count + 1; k++)
            {
                xWorksheet.Cells[1, k] = dtgvTAR.Columns[k - 1].HeaderText;
            }
    //Les contenus des cellules
            for (i = 0; i <= dtgvTAR.RowCount - 1; i++)
            {
                for (j = 0; j <= dtgvTAR.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dtgvTAR[j, i];
                    xWorksheet.Cells[i + 2, j + 1] = cell.Value;
                }
            }

            xWorkbook.SaveAs("C:\\tar_ecomakala.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

            xWorkbook.Close(true, misValue, misValue);
            xApp.Quit();

            releaseObject(xWorksheet);
            releaseObject(xWorkbook);
            releaseObject(xApp);

            MessageBox.Show("Le Fichier vient d'etre cree. \n Merci de le retrouver sur votre repertoire racine","Exportation");
        }

        private void ExportPRDataToExcel()
        {
            Excel.Application xApppr;
            Excel.Workbook xWorkbookpr;
            Excel.Worksheet xWorksheetpr;

            object misValue = System.Reflection.Missing.Value;

            xApppr = new Excel.ApplicationClass();
            xWorkbookpr = xApppr.Workbooks.Add(misValue);
            xWorksheetpr = (Excel.Worksheet)xWorkbookpr.Worksheets.get_Item(1);

            int j = 0; int i = 0;

            //Stocke les en-tetes des colonnes
            for (int k = 1; k < dtgvPR.Columns.Count + 1; k++)
            {
                xWorksheetpr.Cells[1, k] = dtgvPR.Columns[k - 1].HeaderText;
            }
            //Les contenus des cellules
            for (i = 0; i <= dtgvPR.RowCount - 1; i++)
            {
                for (j = 0; j <= dtgvPR.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dtgvPR[j, i];
                    xWorksheetpr.Cells[i + 2, j + 1] = cell.Value;
                }
            }

            xWorkbookpr.SaveAs("C:\\Pr_ecomakala.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

            xWorkbookpr.Close(true, misValue, misValue);
            xApppr.Quit();

            releaseObject(xWorksheetpr);
            releaseObject(xWorkbookpr);
            releaseObject(xApppr);

            MessageBox.Show("Le Fichier vient d'etre cree. \n Merci de le retrouver sur votre repertoire racine", "Exportation");

        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception occured while release object" + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        #endregion


        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportTarDataToExcel();
        }

        private void btnExpExcel_Click(object sender, EventArgs e)
        {
            ExportPRDataToExcel();
        }

        private void chkCauses0_Click(object sender, EventArgs e)
        {
            if (chkCauses0.Checked)
            {
                Pr ba = new Pr();
                txtCauses.Text = ba.ValueOnSelectedCheckbox(txtCauses, chkCauses0);
            }
        }

        private void EntryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            xMainForm.entry = null;
        }

      

       


        //****************************************************************************
    }
}

