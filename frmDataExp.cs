using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace xEntry
{
    public partial class frmDataExp : Form
    {

        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataadapter;
        SqlDataReader datareader;
        DataSet dataset;
        string requete;
        BindingSource _bingingData = new BindingSource();
        BindingSource _bindingDetails = new BindingSource();
        ImageList il = new ImageList();
        int id_data_exploi=0;

        #region Feuille_demarrage

        mdiMainForm _mainForm =new mdiMainForm();
        public mdiMainForm getMdiMainForm()
        {
            return _mainForm;
        }
        public void setMdiMainForm(mdiMainForm myForm)
        {
            _mainForm=myForm;
        }

        #endregion

        public frmDataExp()
        {
            InitializeComponent();
        }

        private void frmDataExp_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(_mainForm.strconn);
            il.Images.Add(new Icon("dataInBd.ico"));

            populateListView();

            dtgDetailsExp.AutoGenerateColumns = false;
            generateColumnsForDatagridView();

            populateDataExploitationBindingSource();
           // populateDetailsExploitationBindingSource();

            fillComboSaison();
            fillComboAgent();
            fillComboEssence();
            fillQualityCombo();
            
            ViderTextBoxDataExploitation();
            

            cboEssence.SelectedIndex = -1;
            txtCirconference.Text = "0.0";
            txtHauteur.Text = "0.0";
            cboQuality1.SelectedIndex = -1;
            cboQuality2.SelectedIndex = -1;
            cboQuality3.SelectedIndex = -1;
            txtRemarques.Clear();
            

            //dtpickerDate.Value = (DateTime.Today.ToShortDateString()).ToString();
        }

        private void populateListView()
        {
            
            lstvId.Columns.Clear();
            lstvId.Items.Clear();
            lstvId.FullRowSelect = true;
            lstvId.ForeColor = System.Drawing.SystemColors.HotTrack;
            lstvId.View = System.Windows.Forms.View.SmallIcon;
            lstvId.SmallImageList = imageList1;
            

            if (connection.State.ToString().Equals("Closed")) connection.Open();
            requete = "select id_dataexp from DATAEXPLOITATION";
            command = new SqlCommand(requete, connection);
            datareader = null;
            datareader = command.ExecuteReader();

            for (int i = 0; i < datareader.FieldCount; i++)
            {
                ColumnHeader ch = new ColumnHeader();
                ch.Text = datareader.GetName(i);
                lstvId.Columns.Add(ch);
            }

            while (datareader.Read())
            {
                int xIdDataxp = datareader.GetOrdinal("id_dataexp");
                ListViewItem itm = new ListViewItem();
                //ListViewItem itm=new ListViewItem(datareader["id_dataexp"].toString());
                itm.Text = datareader.GetValue(0).ToString();
                itm.ImageIndex = 0;

                  //  listItem.SubItems.Add(dr["ProductID"].ToString());
                  //  listItem.SubItems.Add(dr["Description"].ToString());

                  //  listAuthors.Items.Add(listItem);
      
                  //// Add column headers for Details view.
                  //listAuthors.Columns.Add("Product", 100, HorizontalAlignment.Left);
                  //listAuthors.Columns.Add("ID", 100, HorizontalAlignment.Left);
                  //listAuthors.Columns.Add("Description", 100, HorizontalAlignment.Left);

                lstvId.Items.Add(itm);

            }

            datareader.Dispose();
            command.Dispose();
            connection.Close();
        }

        private void frmDataExp_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainForm.fde = null;
        }

        #region Gestion_ComboBox

        private void fillComboAssociation()
        {
            //Combo pour les associations
            cboAsso.Items.Clear();

            try
            {
                if (connection.State.ToString().Equals("Closed")) connection.Open();
                requete = "select id_asso, name_asso from ASSO";
                command = new SqlCommand(requete, connection);
                dataadapter = new SqlDataAdapter(command);
                dataset = new DataSet();
                dataadapter.Fill(dataset, "les_associations");

                cboAsso.DataSource=dataset.Tables["les_associations"];
                cboAsso.DisplayMember = "name_asso";
                cboAsso.ValueMember = "id_asso";

            }
            catch (SqlException x0)
            {
                MessageBox.Show(this, x0.Message);
                return;
            }
            dataset.Dispose();
            dataadapter.Dispose();
            command.Dispose();
            connection.Close();
            cboAsso.SelectedIndex = -1;
        }

        private void fillComboSaison()
        {
            cboSaison.Items.Clear();

            try
            {
                if (connection.State.ToString().Equals("Closed")) connection.Open();
                requete = "select id_season,name_season from SEASON";
                command = new SqlCommand(requete, connection);
                dataadapter = new SqlDataAdapter(command);
                dataset = new DataSet();
                dataadapter.Fill(dataset, "les_saisons");

                cboSaison.DataSource = dataset.Tables["les_saisons"];
                cboSaison.DisplayMember = "name_season";
                cboSaison.ValueMember = "id_season";

            }
            catch (SqlException x0)
            {
                MessageBox.Show(this, x0.Message);
                return;
            }
            dataset.Dispose();
            dataadapter.Dispose();
            command.Dispose();
            connection.Close();
            cboSaison.SelectedIndex = -1;
        }

        private void fillComboAgent()
        {
            cboAgent.Items.Clear();

            try
            {
                if (connection.State.ToString().Equals("Closed")) connection.Open();
                requete = "select id_agent,nom_agent from AGENTRECOLTE";
                command = new SqlCommand(requete, connection);
                dataadapter = new SqlDataAdapter(command);
                dataset = new DataSet();
                dataadapter.Fill(dataset, "les_agents");

                cboAgent.DataSource = dataset.Tables["les_agents"];
                cboAgent.DisplayMember = "nom_agent";
                cboAgent.ValueMember = "id_agent";

            }
            catch (SqlException x0)
            {
                MessageBox.Show(this, x0.Message);
                return;
            }
            dataset.Dispose();
            dataadapter.Dispose();
            command.Dispose();
            connection.Close();
            cboAgent.SelectedIndex = -1;
        }

        private void fillComboEssence()
        {
            cboEssence.Items.Clear();

            try
            {
                if (connection.State.ToString().Equals("Closed")) connection.Open();
                requete = "select id_essence,libessence from ESSENCE";
                command = new SqlCommand(requete, connection);
                dataadapter = new SqlDataAdapter(command);
                dataset = new DataSet();
                dataadapter.Fill(dataset, "les_essences");

                cboEssence.DataSource = dataset.Tables["les_essences"];
                cboEssence.DisplayMember = "libessence";
                cboEssence.ValueMember = "id_essence";

            }
            catch (SqlException x0)
            {
                MessageBox.Show(this, x0.Message);
                return;
            }
            dataset.Dispose();
            dataadapter.Dispose();
            command.Dispose();
            connection.Close();
            cboEssence.SelectedIndex = -1;
        }

        private void fillQualityCombo()
        {
            //cboQuality1.Items.Clear();
            //cboQuality2.Items.Clear();
            //cboQuality3.Items.Clear();
            
            //cboQuality1.Items.Add("1");
            //cboQuality1.Items.Add("2");
            //cboQuality1.Items.Add("3");
            //cboQuality2.Items.Add("1");
            //cboQuality2.Items.Add("2");
            //cboQuality2.Items.Add("3");
            //cboQuality3.Items.Add("1");
            //cboQuality3.Items.Add("2");
            //cboQuality3.Items.Add("3");

            cboQuality1.SelectedIndex = -1;
            cboQuality2.SelectedIndex = -1;
            cboQuality3.SelectedIndex = -1;
        }

        private void fillComboAssoPerSeason()
        {
            //13 (0)3 #323
            try
            {
                if (connection.State.ToString().Equals("Closed")) connection.Open();
                requete = "select c.id_asso,d.id_asso,d.id_season,c.name_asso from ASSO as c,SEASON_ASSO as d where c.id_asso=d.id_asso and d.id_season=@id_season";
                command = new SqlCommand(requete, connection);
                command.Parameters.Add("@id_season", SqlDbType.VarChar, 6, "id_season").Value = cboSaison.SelectedValue.ToString();
                dataadapter = new SqlDataAdapter(command);
                dataset = new DataSet();
                dataadapter.Fill(dataset, "table_saisonasso");

                cboAsso.DataSource=dataset.Tables["table_saisonasso"];
                cboAsso.DisplayMember = "name_asso";
                cboAsso.ValueMember = "id_asso";
            }
            catch (SqlException er)
            {
                MessageBox.Show(this, er.Message);
                return;
            }

            dataset.Dispose();
            dataadapter.Dispose();
            command.Dispose();
            connection.Close();
            cboAsso.SelectedIndex = -1;
        }

        #endregion

        private void populateDataExploitationBindingSource()
        {
            try
            {
                if (connection.State.ToString().Equals("Closed")) connection.Open();
                requete = "select id_dataexp,id_asso,id_season,age_plant,id_agent,datefield,superficie," +
                          "lignenumero,longueurligne,relieffield,pentefield,solfield from DATAEXPLOITATION";
                command = new SqlCommand(requete, connection);
                dataadapter = new SqlDataAdapter(command);
                dataset = new DataSet();
                dataadapter.Fill(dataset, "all_dataexploitation");

                _bingingData.DataSource = dataset.Tables["all_dataexploitation"];
                bindingNavigator1.BindingSource = _bingingData;
 
                //id_data_exploi = int.Parse(txtiddataexp.Text.Trim());


            }
            catch (Exception r)
            {
                MessageBox.Show(this, r.Message);
                return;
            }

            dataset.Dispose();
            dataadapter.Dispose();
            command.Dispose();
            connection.Close();
            changeDetailsValueFromTextChanged();
        }

        private void textBox_dataBinding()
        {
            //Zone pour DataBindings des controls pour le dataExploitation
            txtiddataexp.DataBindings.Add("Text", _bingingData, "id_dataexp", true);
            cboAsso.DataBindings.Add("Text", _bingingData, "id_asso", true);
            cboSaison.DataBindings.Add("Text", _bingingData, "id_season", true);
            txtAgePlant.DataBindings.Add("Text", _bingingData, "age_plant", true);
            cboAgent.DataBindings.Add("Text", _bingingData, "id_agent", true);
            dtpickerDate.DataBindings.Add("Text", _bingingData, "datefield", true);
            txtSuperficie.DataBindings.Add("Text", _bingingData, "superficie", true);
            txtNumeroLigne.DataBindings.Add("Text", _bingingData, "lignenumero", true);
            txtLongueur.DataBindings.Add("Text", _bingingData, "longueurligne", true);
            cboRelief.DataBindings.Add("Text", _bingingData, "relieffield", true);
            cboPente.DataBindings.Add("Text", _bingingData, "pentefield", true);
            cboSol.DataBindings.Add("Text", _bingingData, "solfield", true);

        }

        private void populateDetailsExploitationBindingSource()
        {

            try
            {
              //  if (!txtiddataexp.Text.Trim().Equals(""))
            if(!id_data_exploi.ToString().Equals(""))
                {
                    if (connection.State.ToString().Equals("Closed")) connection.Open();
                    requete = "select id_detailsexp,id_dataexp,id_essence,circonference,hauteur,qualite1,qualite2,qualite3," +
                        "remarques from DETAILEXPLOITATION where id_dataexp=@iddataexp";
                    command = new SqlCommand(requete, connection);
                    command.Parameters.Add("@iddataexp", SqlDbType.Int, 4, "id_dataexp").Value = id_data_exploi;//int.Parse(txtiddataexp.Text.Trim());
                    dataadapter = new SqlDataAdapter(command);
                    dataset = new DataSet();
                    dataadapter.Fill(dataset, "all_detailsexploitation");

                    _bindingDetails.DataSource = dataset.Tables["all_detailsexploitation"];
                    bindingNavigator2.BindingSource = _bindingDetails;
                    dtgDetailsExp.DataSource = _bindingDetails;
               ////Zone des controls pour binding des donnees de Details
               //     cboEssence.DataBindings.Add("Text", _bindingDetails, "id_essence", true);
               //     txtCirconference.DataBindings.Add("text", _bindingDetails, "circonference", true);
               //     txtHauteur.DataBindings.Add("Text", _bindingDetails, "hauteur", true);
               //     cboQuality1.DataBindings.Add("Text", _bindingDetails, "qualite1", true);
               //     cboQuality2.DataBindings.Add("text", _bindingDetails, "qualite2", true);
               //     cboQuality3.DataBindings.Add("Text", _bindingDetails, "qualite3", true);
               //     txtRemarques.DataBindings.Add("Text", _bindingDetails, "remarques", true);

                }
            }
            catch (Exception tr)
            {
                MessageBox.Show(this, tr.Message);
                return;
            }
            dataset.Dispose();
            dataadapter.Dispose();
            command.Dispose();
            connection.Close();

        }

        private void generateColumnsForDatagridView()
        {
            DataGridViewTextBoxColumn iddetailexp = new DataGridViewTextBoxColumn();
            iddetailexp.Name = "iddetails";
            iddetailexp.DataPropertyName = "id_detailsexp";
            iddetailexp.Width = 100;
            iddetailexp.HeaderText = "Id Details";
            
            DataGridViewTextBoxColumn iddataexp = new DataGridViewTextBoxColumn();
            iddetailexp.Name = "iddataexp";
            iddetailexp.DataPropertyName = "id_dataexp";
            iddetailexp.Width = 100;
            iddetailexp.HeaderText = "Id Donnees";

            DataGridViewTextBoxColumn essenc = new DataGridViewTextBoxColumn();
            essenc.Name = "essence";
            essenc.DataPropertyName = "id_essence";
            essenc.Width = 100;
            essenc.HeaderText = "Essence";

            DataGridViewTextBoxColumn circo = new DataGridViewTextBoxColumn();
            circo.Name = "circonference";
            circo.DataPropertyName = "circonference";
            circo.Width = 100;
            circo.HeaderText = "Circonference";

            DataGridViewTextBoxColumn hauteur = new DataGridViewTextBoxColumn();
            hauteur.Name = "hauteur";
            hauteur.DataPropertyName = "hauteur";
            hauteur.Width = 100;
            hauteur.HeaderText = "Hauteur";

            DataGridViewTextBoxColumn qlty1 = new DataGridViewTextBoxColumn();
            qlty1.Name = "quality1";
            qlty1.DataPropertyName = "qualite1";
            qlty1.Width = 75;
            qlty1.HeaderText = "Qualite 1";

            DataGridViewTextBoxColumn qlty2 = new DataGridViewTextBoxColumn();
            qlty2.Name = "quality2";
            qlty2.DataPropertyName = "qualite2";
            qlty2.Width = 75;
            qlty2.HeaderText = "Qualite 2";

            DataGridViewTextBoxColumn qlty3 = new DataGridViewTextBoxColumn();
            qlty3.Name = "quality3";
            qlty3.DataPropertyName = "qualite3";
            qlty3.Width = 75;
            qlty3.HeaderText = "Qualite 3";

            DataGridViewTextBoxColumn rmrq = new DataGridViewTextBoxColumn();
            rmrq.Name = "Remarques";
            rmrq.DataPropertyName = "remarques";
            rmrq.Width = 100;
            rmrq.HeaderText = "Remarques";

            dtgDetailsExp.Columns.Add(iddetailexp);
            dtgDetailsExp.Columns.Add(iddataexp);
            dtgDetailsExp.Columns.Add(essenc);
            dtgDetailsExp.Columns.Add(circo);
            dtgDetailsExp.Columns.Add(hauteur);
            dtgDetailsExp.Columns.Add(qlty1);
            dtgDetailsExp.Columns.Add(qlty2);
            dtgDetailsExp.Columns.Add(qlty3);
            dtgDetailsExp.Columns.Add(rmrq);
        }

        private void lstvId_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //if (lstvId.Sorting == System.Windows.Forms.SortOrder.Descending)
            //    lstvId.Sorting = SortOrder.Ascending;
            //else
            //    lstvId.Sorting = SortOrder.Descending;
            //lstvId.Sort();

        }
        private void viderTextBoxDetailsExploitation()
        {
            cboEssence.SelectedIndex = -1;
            txtCirconference.Text = "0.0";
            txtHauteur.Text = "0.0";
            cboQuality1.SelectedIndex = -1;
            cboQuality2.SelectedIndex = -1;
            cboQuality3.SelectedIndex = -1;
            txtRemarques.Clear();
            btAjoutDetails.Text = "Nouveau";
            cboEssence.Focus();
        }

        private void ViderTextBoxDataExploitation()
        {
            cboAsso.SelectedIndex = -1;
            cboSaison.SelectedIndex = -1;
            cboAgent.SelectedIndex = -1;
            txtAgePlant.Clear();
            txtCirconference.Clear();
            txtHauteur.Clear();
            txtiddataexp.Clear();
            txtNumeroLigne.Clear();
            cboRelief.SelectedIndex = -1;
            cboPente.SelectedIndex = -1;
            cboSol.SelectedIndex = -1;

            txtAgePlant.Text = "0.0";
            txtSuperficie.Text = "0.0";
            txtLongueur.Text = "0";
            txtNumeroLigne.Text = "0";

            cboSaison.Focus();
        }

        private void cboSaison_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!cboSaison.Text.Trim().Equals(""))
            {
                fillComboAssoPerSeason();
            }
        }

        private void btAjout_Click(object sender, EventArgs e)
        {

            try
            {
            Dataexploitation dexp = new Dataexploitation();
            dexp.Id_asso = cboAsso.SelectedValue.ToString();
            dexp.Id_season = cboSaison.SelectedValue.ToString();
            dexp.Age_plant = double.Parse(txtAgePlant.Text.ToString().Trim());
            //dexp.Age_plant = float.Parse(txtAgePlant.Text.Trim());
            dexp.Id_agent = cboAgent.SelectedValue.ToString();
            dexp.Datefield = DateTime.Parse(dtpickerDate.Value.ToString());
            dexp.Superficie = double.Parse(txtSuperficie.Text.ToString().Trim());
            dexp.Lignenumero = int.Parse(txtNumeroLigne.Text.ToString().Trim());
            dexp.Longueurligne = double.Parse(txtLongueur.Text.ToString().Trim());
            dexp.Relieffield = cboRelief.SelectedItem.ToString();
            dexp.Pentefield = cboPente.SelectedItem.ToString();
            dexp.Solfield = cboSol.SelectedText;

            if (connection.State.ToString().Equals("Closed")) connection.Open();
            requete = "insert into DATAEXPLOITATION(id_asso,id_season,age_plant,id_agent,datefield,superficie,lignenumero,longueurligne,relieffield,pentefield,solfield) values" +
                                                  "(@id_asso,@id_season,@age_plant,@id_agent,@datefield,@superficie,@lignenumero,@longueurligne,@relieffield,@pentefield,@solfield)";
            //requete = "insert into DATAEXPLOITATION(id_asso,id_season,id_agent,datefield,superficie,lignenumero,longueurligne,relieffield,pentefield,solfield) values" +
            //                      "(@id_asso,@id_season,@id_agent,@datefield,@superficie,@lignenumero,@longueurligne,@relieffield,@pentefield,@solfield)";

            command = new SqlCommand(requete, connection);

            command.Parameters.Add("@id_asso", SqlDbType.VarChar, 25, "id_asso").Value = dexp.Id_asso;
            command.Parameters.Add("@id_season", SqlDbType.VarChar, 6, "id_season").Value = dexp.Id_season;
            command.Parameters.Add("@age_plant", SqlDbType.Float, 4, "age_plant").Value = dexp.Age_plant;
            command.Parameters.Add("@id_agent", SqlDbType.VarChar, 6, "id_agent").Value = dexp.Id_agent;
            command.Parameters.Add("@datefield", SqlDbType.DateTime, 4, "datefield").Value = dexp.Datefield;
            command.Parameters.Add("@superficie", SqlDbType.Float, 4, "superficie").Value = dexp.Superficie;
            command.Parameters.Add("@lignenumero", SqlDbType.Int, 25, "lignenumero").Value = dexp.Lignenumero;
            command.Parameters.Add("@longueurligne", SqlDbType.Float, 4, "longueurligne").Value = dexp.Longueurligne;
            command.Parameters.Add("@relieffield", SqlDbType.VarChar, 20, "relieffield").Value = dexp.Relieffield;
            command.Parameters.Add("@pentefield", SqlDbType.VarChar, 20, "pentefield").Value = dexp.Pentefield;
            command.Parameters.Add("@solfield", SqlDbType.VarChar, 20, "solfield").Value = dexp.Solfield;

            int i = command.ExecuteNonQuery();
            ViderTextBoxDataExploitation();
            }
            catch (Exception er_)
            {
                MessageBox.Show(this, er_.Message);
                return;
            }

            command.Dispose();
            connection.Close();

            populateListView();

            populateDataExploitationBindingSource();
            populateDetailsExploitationBindingSource();
        }

        private void lstvId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvId.SelectedItems.Count > 0)
            {
                
                txtiddataexp.Clear();
                txtiddataexp.Text = lstvId.SelectedItems[0].Text;
                id_data_exploi=int.Parse(txtiddataexp.Text.Trim());
                //populateDetailsExploitationBindingSource();
               // MessageBox.Show(this, "vous avez select " + txtiddataexp.Text.Trim());
            }
        }

        private void txtiddataexp_TextChanged(object sender, EventArgs e)
        {
            changeDetailsValueFromTextChanged();
        }

        private void changeDetailsValueFromTextChanged()
        {
            if (!txtiddataexp.Text.Trim().Equals(""))
            {
                try
                {
                    id_data_exploi = int.Parse(txtiddataexp.Text.Trim());

                    populateDetailsExploitationBindingSource();
                }
                catch (Exception ex) { MessageBox.Show(this, ex.Message); return; }
            }
        }

        private void btAjoutDetails_Click(object sender, EventArgs e)
        {

            if (!txtiddataexp.Text.Trim().Equals("") || !btAjoutDetails.Text.Trim().Equals("Nouveau"))
            {

                try
                {
                    Detailexploitation detexp = new Detailexploitation();
                    detexp.Id_essence = cboEssence.SelectedValue.ToString();
                    detexp.Circonference = double.Parse(txtCirconference.Text.Trim());
                    detexp.Hauteur = double.Parse(txtHauteur.Text.Trim());
                    detexp.Id_dataexp = int.Parse(txtiddataexp.Text.Trim());
                    detexp.Qualite1 = int.Parse(cboQuality1.SelectedItem.ToString());
                    detexp.Qualite2 = int.Parse(cboQuality2.SelectedItem.ToString());
                    detexp.Qualite3 = int.Parse(cboQuality3.SelectedItem.ToString());
                    detexp.Remarques = txtRemarques.Text.Trim();

                    if (connection.State.ToString().Equals("Closed")) connection.Open();
                    requete = "insert into DETAILEXPLOITATION(id_dataexp,id_essence,circonference,hauteur,qualite1,qualite2,qualite3,remarques)" +
                              "values " +
                              "(@id_dataexp,@id_essence,@circonference,@hauteur,@qualite1,@qualite2,@qualite3,@remarques)";
                    command = new SqlCommand(requete, connection);
                    command.Parameters.Add("@id_dataexp", SqlDbType.Int, 4, "id_dataexp").Value = detexp.Id_dataexp;
                    command.Parameters.Add("@id_essence", SqlDbType.VarChar, 10, "id_essence").Value = detexp.Id_essence;
                    command.Parameters.Add("@circonference", SqlDbType.Float, 4, "circonference").Value = detexp.Circonference;
                    command.Parameters.Add("@hauteur", SqlDbType.Float, 4, "hauteur").Value = detexp.Hauteur;
                    command.Parameters.Add("@qualite1", SqlDbType.Int, 4, "qualite1").Value = detexp.Qualite1;
                    command.Parameters.Add("@qualite2", SqlDbType.Int, 4, "qualite2").Value = detexp.Qualite2;
                    command.Parameters.Add("@qualite3", SqlDbType.Int, 4, "qualite3").Value = detexp.Qualite3;
                    command.Parameters.Add("@remarques", SqlDbType.VarChar, 25, "remarques").Value = detexp.Remarques;

                    int y = command.ExecuteNonQuery();

                    viderTextBoxDetailsExploitation();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message);
                    return;
                }

            }
            else if (btAjoutDetails.Text.Trim().Equals("Nouveau"))
            {
                viderTextBoxDetailsExploitation();
                //cboEssence.SelectedIndex = -1;
                //txtCirconference.Text = "0.0";
                //txtHauteur.Text = "0.0";
                //cboQuality1.SelectedIndex = -1;
                //cboQuality2.SelectedIndex = -1;
                //cboQuality3.SelectedIndex = -1;
                //txtRemarques.Clear();
                //cboEssence.Focus();
                btAjoutDetails.Text = "Ajouter details";
            }

            command.Dispose();
            connection.Close();
            dtgDetailsExp.Refresh();
           // populateDetailsExploitationBindingSource();
        }

        private void btFermer_Click(object sender, EventArgs e)
        {
            this.Close();
           // _mainForm.fde = null;
        }

        private void dtgDetailsExp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtiddataexp_Leave(object sender, EventArgs e)
        {

        }

       
       

//*****************************************************************************************
    }
}
