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
    public partial class frmEssence : Form
    {

        private SqlConnection sconn;
        private SqlCommand command;
        private SqlDataAdapter dataadapter;
        private SqlDataReader datareader;
        private DataSet dataset;
        private string requete;
        BindingSource _bindingNav = new BindingSource();

        #region Feuille_Main_Instance

        mdiMainForm _mymainform = new mdiMainForm();
        public mdiMainForm setMdiMainForm()
        {
            return _mymainform;
        }
        public void setMdiMainForm(mdiMainForm mainf)
        {
            _mymainform = mainf;
        }

        #endregion

        public frmEssence()
        {
            InitializeComponent();
        }

        private void frmEssence_Load(object sender, EventArgs e)
        {
            sconn = new SqlConnection(_mymainform.strconn);
            dtgessence.AutoGenerateColumns = false;
            createColumsDataGrid();
            remplirSource();
            btAddEss.Enabled = true;
            btAddEss.Text = "Ajouter";
            btUpdate.Enabled = false;
            txtIdEssence.Focus();

        }

        private void createColumsDataGrid()
        {
            DataGridViewTextBoxColumn idEssence = new DataGridViewTextBoxColumn();
            idEssence.Name = "idEssence";
            idEssence.HeaderText = "Id essence";
            idEssence.DataPropertyName = "id_essence";
            idEssence.Width = 100;

            DataGridViewTextBoxColumn libEssence = new DataGridViewTextBoxColumn();
            libEssence.Name = "libEssence";
            libEssence.HeaderText = "Libelle essence";
            libEssence.DataPropertyName = "libessence";
            libEssence.Width = 200;

            dtgessence.Columns.Add(idEssence);
            dtgessence.Columns.Add(libEssence);

        }

        private void remplirSource()
        {
            try
            {
                if (sconn.State.ToString().Equals("Closed")) sconn.Open();
                requete = "select id_essence,libessence from ESSENCE";
                command = new SqlCommand(requete, sconn);
                dataadapter = new SqlDataAdapter(command);
                dataset = new DataSet();
                dataadapter.Fill(dataset, "table_essence");

                _bindingNav.DataSource = dataset.Tables["table_essence"];
                dtgessence.DataSource = _bindingNav;
                bindingNavigator1.BindingSource = _bindingNav;

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
                return;
            }

            dataset.Dispose();
            dataadapter.Dispose();
            command.Dispose();
            sconn.Close();

        }

        private void viderTextBox()
        {
            this.txtIdEssence.Clear();
            this.txtLibEssence.Clear();
            this.txtIdEssence.Focus();
        }

        private void btAddEss_Click(object sender, EventArgs e)
        {
            if (btAddEss.Text.Trim().Equals("Ajouter"))
            {
                try
                {
                    if (sconn.State.ToString().Equals("Closed")) sconn.Open();
                    requete = "insert into ESSENCE(id_essence,libessence) values(@id_essence,@libessence)";
                    command = new SqlCommand(requete, sconn);

                    Essence arbre = new Essence();
                    arbre.Id_essence = txtIdEssence.Text.Trim();
                    arbre.Libessence = txtLibEssence.Text.Trim();

                    command.Parameters.Add("@id_essence", SqlDbType.VarChar, 10, "id_essence").Value = arbre.Id_essence;
                    command.Parameters.Add("@libessence", SqlDbType.VarChar, 75, "libessence").Value = arbre.Libessence;

                    int i = command.ExecuteNonQuery();
                    viderTextBox();


                }
                catch (SqlException ex)
                {
                    MessageBox.Show(this, ex.Message);
                    return;
                }
            }
            else if (btAddEss.Text.Trim().Equals("Nouveau"))
            {
                viderTextBox();
                btUpdate.Enabled = false;
                btAddEss.Text = "Ajouter";
            }
            command.Dispose();
            sconn.Close();
            remplirSource();
        }

        private void dtgessence_Click(object sender, EventArgs e)
        {
            if (dtgessence.RowCount > 0)
            {
                txtIdEssence.Text = dtgessence["idEssence", dtgessence.CurrentRow.Index].Value.ToString();
                if (sconn.State.ToString().Equals("Closed")) sconn.Open();
                requete = "select id_essence,libessence from ESSENCE where id_essence=@idessence";
                command = new SqlCommand(requete, sconn);
                command.Parameters.Add("@idessence", SqlDbType.VarChar, 10, "id_essence").Value = txtIdEssence.Text.Trim();
                datareader = command.ExecuteReader();

                if (datareader.Read())
                {
                    txtLibEssence.Text = datareader["libessence"].ToString();
                }
            }
            btUpdate.Enabled = true;
            btAddEss.Text = "Nouveau";
            command.Dispose();
            sconn.Close();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (sconn.State.ToString().Equals("Closed")) sconn.Open();
                requete = "delete from ESSENCE where id_essence=@idessence";
                command = new SqlCommand(requete, sconn);

                command.Parameters.Add("@idessence", SqlDbType.VarChar, 10, "id_essence").Value = txtIdEssence.Text.Trim(); ;

                DialogResult r = MessageBox.Show(this, "Etes-vous reellement sur de vouloir effacer/n l'essence en cours ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    int i = command.ExecuteNonQuery();
                    viderTextBox();
                }
                else
                {
                    return;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(this, ex.Message);
                return;
            }
            command.Dispose();
            sconn.Close();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (sconn.State.ToString().Equals("Closed")) sconn.Open();
                requete = "update ESSENCE set libessence=@libessence where id_essence=@id_essence";
                command = new SqlCommand(requete, sconn);

                command.Parameters.Add("@id_essence", SqlDbType.VarChar, 10, "id_essence").Value = txtIdEssence.Text.Trim(); ;
                command.Parameters.Add("@libessence", SqlDbType.VarChar, 75, "libessence").Value = txtLibEssence.Text.Trim(); ;

                int i = command.ExecuteNonQuery();
                viderTextBox();
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(this, ex.Message);
                return;
            }
            command.Dispose();
            sconn.Close();
            remplirSource();
            btAddEss.Text = "Ajouter";
        }

        private void frmEssence_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mymainform.fess = null;
        }



        //*********************************************************************        
    }
}