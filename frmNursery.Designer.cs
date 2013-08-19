namespace xEntry
{
    partial class frmNursery
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbIdentification = new System.Windows.Forms.TabPage();
            this.tbSuivie = new System.Windows.Forms.TabPage();
            this.tbVerification = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbIdentification);
            this.tabControl1.Controls.Add(this.tbSuivie);
            this.tabControl1.Controls.Add(this.tbVerification);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(811, 537);
            this.tabControl1.TabIndex = 0;
            // 
            // tbIdentification
            // 
            this.tbIdentification.Location = new System.Drawing.Point(4, 22);
            this.tbIdentification.Name = "tbIdentification";
            this.tbIdentification.Padding = new System.Windows.Forms.Padding(3);
            this.tbIdentification.Size = new System.Drawing.Size(803, 511);
            this.tbIdentification.TabIndex = 0;
            this.tbIdentification.Text = "Identification";
            this.tbIdentification.UseVisualStyleBackColor = true;
            this.tbIdentification.Click += new System.EventHandler(this.tbIdentification_Click);
            // 
            // tbSuivie
            // 
            this.tbSuivie.Location = new System.Drawing.Point(4, 22);
            this.tbSuivie.Name = "tbSuivie";
            this.tbSuivie.Padding = new System.Windows.Forms.Padding(3);
            this.tbSuivie.Size = new System.Drawing.Size(803, 511);
            this.tbSuivie.TabIndex = 1;
            this.tbSuivie.Text = "Suivie";
            this.tbSuivie.UseVisualStyleBackColor = true;
            // 
            // tbVerification
            // 
            this.tbVerification.Location = new System.Drawing.Point(4, 22);
            this.tbVerification.Name = "tbVerification";
            this.tbVerification.Size = new System.Drawing.Size(803, 511);
            this.tbVerification.TabIndex = 2;
            this.tbVerification.Text = "Verification";
            this.tbVerification.UseVisualStyleBackColor = true;
            // 
            // frmNursery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 537);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNursery";
            this.Text = "Formulaire de saisie des pepinieres :";
            this.Load += new System.EventHandler(this.frmNursery_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbIdentification;
        private System.Windows.Forms.TabPage tbSuivie;
        private System.Windows.Forms.TabPage tbVerification;
    }
}