namespace xEntry
{
    partial class gpsdataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gpsdataForm));
            this.bsngps = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtwpt = new System.Windows.Forms.TextBox();
            this.txtlat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtalt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtepe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtggpsdata = new System.Windows.Forms.DataGridView();
            this.btnAddGpsData = new System.Windows.Forms.ToolStripButton();
            this.btnDelGpsData = new System.Windows.Forms.ToolStripButton();
            this.btnUpdGpsData = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.txtg_Id_Pr = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnquitgps = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.bsngps)).BeginInit();
            this.bsngps.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtggpsdata)).BeginInit();
            this.SuspendLayout();
            // 
            // bsngps
            // 
            this.bsngps.AddNewItem = null;
            this.bsngps.CountItem = this.bindingNavigatorCountItem;
            this.bsngps.DeleteItem = null;
            this.bsngps.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnAddGpsData,
            this.btnDelGpsData,
            this.btnUpdGpsData,
            this.toolStripSeparator1,
            this.txtg_Id_Pr,
            this.toolStripSeparator2,
            this.btnquitgps});
            this.bsngps.Location = new System.Drawing.Point(0, 0);
            this.bsngps.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bsngps.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bsngps.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bsngps.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bsngps.Name = "bsngps";
            this.bsngps.PositionItem = this.bindingNavigatorPositionItem;
            this.bsngps.Size = new System.Drawing.Size(539, 25);
            this.bsngps.TabIndex = 0;
            this.bsngps.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 20);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(34, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtepe);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtalt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtlong);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtlat);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtwpt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 58);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "N Wpt :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtwpt
            // 
            this.txtwpt.Location = new System.Drawing.Point(7, 28);
            this.txtwpt.Name = "txtwpt";
            this.txtwpt.Size = new System.Drawing.Size(57, 20);
            this.txtwpt.TabIndex = 1;
            // 
            // txtlat
            // 
            this.txtlat.Location = new System.Drawing.Point(70, 28);
            this.txtlat.Name = "txtlat";
            this.txtlat.Size = new System.Drawing.Size(133, 20);
            this.txtlat.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(70, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Latitude :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtlong
            // 
            this.txtlong.Location = new System.Drawing.Point(209, 28);
            this.txtlong.Name = "txtlong";
            this.txtlong.Size = new System.Drawing.Size(133, 20);
            this.txtlong.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(209, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Longitude :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtalt
            // 
            this.txtalt.Location = new System.Drawing.Point(348, 28);
            this.txtalt.Name = "txtalt";
            this.txtalt.Size = new System.Drawing.Size(105, 20);
            this.txtalt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(348, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Altitude :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtepe
            // 
            this.txtepe.Location = new System.Drawing.Point(459, 28);
            this.txtepe.Name = "txtepe";
            this.txtepe.Size = new System.Drawing.Size(73, 20);
            this.txtepe.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(459, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "EPE :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtggpsdata);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 138);
            this.panel2.TabIndex = 2;
            // 
            // dtggpsdata
            // 
            this.dtggpsdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtggpsdata.Location = new System.Drawing.Point(3, 6);
            this.dtggpsdata.Name = "dtggpsdata";
            this.dtggpsdata.Size = new System.Drawing.Size(533, 129);
            this.dtggpsdata.TabIndex = 0;
            this.dtggpsdata.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtggpsdata_CellDoubleClick);
            this.dtggpsdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtggpsdata_CellContentClick);
            // 
            // btnAddGpsData
            // 
            this.btnAddGpsData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddGpsData.Image = ((System.Drawing.Image)(resources.GetObject("btnAddGpsData.Image")));
            this.btnAddGpsData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddGpsData.Name = "btnAddGpsData";
            this.btnAddGpsData.Size = new System.Drawing.Size(23, 22);
            this.btnAddGpsData.Text = "add gps data";
            this.btnAddGpsData.Click += new System.EventHandler(this.btnAddGpsData_Click);
            // 
            // btnDelGpsData
            // 
            this.btnDelGpsData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelGpsData.Image = ((System.Drawing.Image)(resources.GetObject("btnDelGpsData.Image")));
            this.btnDelGpsData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelGpsData.Name = "btnDelGpsData";
            this.btnDelGpsData.Size = new System.Drawing.Size(23, 22);
            this.btnDelGpsData.Text = "delete gps data";
            this.btnDelGpsData.Click += new System.EventHandler(this.btnDelGpsData_Click);
            // 
            // btnUpdGpsData
            // 
            this.btnUpdGpsData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUpdGpsData.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdGpsData.Image")));
            this.btnUpdGpsData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdGpsData.Name = "btnUpdGpsData";
            this.btnUpdGpsData.Size = new System.Drawing.Size(23, 22);
            this.btnUpdGpsData.Text = "update gps data";
            this.btnUpdGpsData.Click += new System.EventHandler(this.btnUpdGpsData_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // txtg_Id_Pr
            // 
            this.txtg_Id_Pr.Name = "txtg_Id_Pr";
            this.txtg_Id_Pr.Size = new System.Drawing.Size(100, 25);
            this.txtg_Id_Pr.ToolTipText = "ID PR";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnquitgps
            // 
            this.btnquitgps.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnquitgps.Image = ((System.Drawing.Image)(resources.GetObject("btnquitgps.Image")));
            this.btnquitgps.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnquitgps.Name = "btnquitgps";
            this.btnquitgps.Size = new System.Drawing.Size(23, 22);
            this.btnquitgps.Text = "close form";
            this.btnquitgps.Click += new System.EventHandler(this.btnquitgps_Click);
            // 
            // gpsdataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 222);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bsngps);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "gpsdataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coordonnees GPS  :";
            this.Load += new System.EventHandler(this.gpsdataForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsngps)).EndInit();
            this.bsngps.ResumeLayout(false);
            this.bsngps.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtggpsdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bsngps;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtwpt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtepe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtalt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtlong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtggpsdata;
        private System.Windows.Forms.ToolStripButton btnAddGpsData;
        private System.Windows.Forms.ToolStripButton btnDelGpsData;
        private System.Windows.Forms.ToolStripButton btnUpdGpsData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox txtg_Id_Pr;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnquitgps;
    }
}