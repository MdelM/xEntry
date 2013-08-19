using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace xEntry
{
    public partial class mdiMainForm : Form
    {
        //private int childFormNumber = 0;
        public string strconn = "", lblstatusconn = "";
        public string usern = "", lblformstatus = "";
        public  frmxConn xconnf = null;
        public EntryForm entry = null;
        public frmNursery nursery = null;
        public frmDataExp fde = null;
        public frmEssence fess = null;
        
        public mdiMainForm()
        {
            InitializeComponent();
        }


        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void mdiMainForm_Load(object sender, EventArgs e)
        {
            LockMenu(false);
            stbinfoform.Text = "";
            stbinfoform.ToolTipText = "Forms informations status";
            lblformstatus = stbinfoform.Text;
            //mnuCatego.Enabled = false;
        }

        public void LockMenu(Boolean val)
        {
            mnuDEntry.Enabled = val;
            mnuNursery.Enabled = val;
            mnuEntryNursery.Enabled = val;
            mnuEntry.Enabled = val;
            toolsMenu.Enabled = val;
            mnuEssence.Enabled = val;
            mnuEsenc.Enabled = val;
            mnuDataexpl.Enabled = val;
            dataExpMenu.Enabled = val;
            viewMenu.Enabled = val;
            if (val != false)
            {
                this.statLabel.Text = usern + " est maintenant connecté ...";
            }
            else
            {
                this.statLabel.Text = "Deconnecté de la base des données ...";
            }
        }

        public void EnableMenuMainForm()
        {

            this.statLabel.Text = "L'application est maintenant connectée ...";

        }

        private void quittoolStripButton_Click(object sender, EventArgs e)
        {
            //this.Close();
            //Application.Exit();
            ExitToolsStripMenuItem_Click(this, new System.EventArgs());
        }

        private void jeconnectMenuItem_Click(object sender, EventArgs e)
        {
            //jmconnect jmc = new jmconnect();
            //jmc.MdiParent = this;
            //jmc.mymainform = this;
            //jmc.Show();
            connToolStripButton_Click(this, new System.EventArgs());
        }

        private void connToolStripButton_Click(object sender, EventArgs e)
        {
            //jmconnect jmc = new jmconnect();
            //jmc.MdiParent = this;
            //jmc.mymainform = this;
            //jmc.Show();

            if (xconnf == null)
            {
                xconnf = new frmxConn();
                xconnf.MdiParent = this;
                xconnf.mymainform = this;
                xconnf.Show();
            }
        }

        private void mdiMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void mnuDEntry_Click(object sender, EventArgs e)
        {
            if (entry == null)
            {
                entry = new EntryForm();
                entry.MdiParent = this;
                entry.setMdiMainForm(this);
                entry.Icon = this.Icon;
                entry.Show();
            }
        }

        private void mnuEntry_Click(object sender, EventArgs e)
        {
           // mnuDEntry_Click(this, new System.EventArgs());
            mnuDEntry_Click(sender, e);
        }

        private void mnuEntryNursery_Click(object sender, EventArgs e)
        {
            if (nursery == null)
            {
                nursery = new frmNursery();
                nursery.MdiParent = this;
                nursery.setMdiMainform(this);
                nursery.Icon = this.Icon;
                nursery.Show();
            }
        }

        private void btnNursery_Click(object sender, EventArgs e)
        {
            mnuEntryNursery_Click(this, new System.EventArgs());
        }

        private void dataExpMenu_Click(object sender, EventArgs e)
        {

            if (fde == null)
            {
                fde = new frmDataExp();
                fde.MdiParent = this;
                fde.setMdiMainForm(this);
                fde.Show();
            }
        }

        private void mnuDataexpl_Click(object sender, EventArgs e)
        {
            dataExpMenu_Click(sender, e);
        }

        private void mnuEssence_Click(object sender, EventArgs e)
        {
            if (fess == null)
            {
                fess = new frmEssence();
                fess.MdiParent = this;
                fess.setMdiMainForm(this);
                fess.Show();
            }
        }

        private void mnuEsenc_Click(object sender, EventArgs e)
        {
            mnuEssence_Click(sender, e);
        }

    }
}
