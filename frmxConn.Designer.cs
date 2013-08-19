namespace xEntry
{
    partial class frmxConn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxConn));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnxConn = new System.Windows.Forms.Button();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.txtnomuser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnomBD = new System.Windows.Forms.TextBox();
            this.txtnomserveur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtpwd);
            this.groupBox1.Controls.Add(this.txtnomuser);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtnomBD);
            this.groupBox1.Controls.Add(this.txtnomserveur);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(426, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veuillez entrez les informations de connexion :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnxConn);
            this.groupBox2.Location = new System.Drawing.Point(182, 166);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(226, 64);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(121, 16);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 41);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "&Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnxConn
            // 
            this.btnxConn.Image = ((System.Drawing.Image)(resources.GetObject("btnxConn.Image")));
            this.btnxConn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxConn.Location = new System.Drawing.Point(9, 16);
            this.btnxConn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnxConn.Name = "btnxConn";
            this.btnxConn.Size = new System.Drawing.Size(105, 41);
            this.btnxConn.TabIndex = 0;
            this.btnxConn.Text = "Co&nnecter";
            this.btnxConn.UseVisualStyleBackColor = true;
            this.btnxConn.Click += new System.EventHandler(this.btnxConn_Click);
            // 
            // txtpwd
            // 
            this.txtpwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpwd.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpwd.Location = new System.Drawing.Point(156, 128);
            this.txtpwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.PasswordChar = '*';
            this.txtpwd.Size = new System.Drawing.Size(252, 23);
            this.txtpwd.TabIndex = 25;
            this.txtpwd.TextChanged += new System.EventHandler(this.txtpwd_TextChanged);
            this.txtpwd.Enter += new System.EventHandler(this.txtnomserveur_Enter);
            this.txtpwd.Leave += new System.EventHandler(this.txtnomserveur_Leave);
            // 
            // txtnomuser
            // 
            this.txtnomuser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnomuser.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomuser.Location = new System.Drawing.Point(156, 94);
            this.txtnomuser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnomuser.Name = "txtnomuser";
            this.txtnomuser.Size = new System.Drawing.Size(252, 23);
            this.txtnomuser.TabIndex = 24;
            this.txtnomuser.Enter += new System.EventHandler(this.txtnomserveur_Enter);
            this.txtnomuser.Leave += new System.EventHandler(this.txtnomserveur_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mot de passe :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nom de l\'utilisateur :";
            // 
            // txtnomBD
            // 
            this.txtnomBD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnomBD.Enabled = false;
            this.txtnomBD.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomBD.Location = new System.Drawing.Point(156, 60);
            this.txtnomBD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnomBD.Name = "txtnomBD";
            this.txtnomBD.Size = new System.Drawing.Size(252, 23);
            this.txtnomBD.TabIndex = 21;
            this.txtnomBD.Text = "xEntryDbz";
            // 
            // txtnomserveur
            // 
            this.txtnomserveur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnomserveur.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomserveur.Location = new System.Drawing.Point(156, 26);
            this.txtnomserveur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnomserveur.Name = "txtnomserveur";
            this.txtnomserveur.Size = new System.Drawing.Size(252, 23);
            this.txtnomserveur.TabIndex = 20;
            this.txtnomserveur.Text = "Database\\SQLSERVWWFCARPOE";
            this.txtnomserveur.Enter += new System.EventHandler(this.txtnomserveur_Enter);
            this.txtnomserveur.Leave += new System.EventHandler(this.txtnomserveur_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Base des données :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nom du serveur SQL :";
            // 
            // frmxConn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(446, 264);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmxConn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmxConn";
            this.Load += new System.EventHandler(this.frmxConn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.TextBox txtnomuser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnomBD;
        private System.Windows.Forms.TextBox txtnomserveur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnxConn;
    }
}