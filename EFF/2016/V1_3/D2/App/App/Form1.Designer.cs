namespace App
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose( );
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnadd = new System.Windows.Forms.Button( );
            this.btnmod = new System.Windows.Forms.Button( );
            this.btnsupp = new System.Windows.Forms.Button( );
            this.tbname = new System.Windows.Forms.TextBox( );
            this.btnfirst = new System.Windows.Forms.Button( );
            this.btnnext = new System.Windows.Forms.Button( );
            this.btnprev = new System.Windows.Forms.Button( );
            this.btnlast = new System.Windows.Forms.Button( );
            this.tbemail = new System.Windows.Forms.TextBox( );
            this.tbpasswd = new System.Windows.Forms.TextBox( );
            this.label1 = new System.Windows.Forms.Label( );
            this.label2 = new System.Windows.Forms.Label( );
            this.label3 = new System.Windows.Forms.Label( );
            this.tbpren = new System.Windows.Forms.TextBox( );
            this.label4 = new System.Windows.Forms.Label( );
            this.dgv1 = new System.Windows.Forms.DataGridView( );
            this.lberremail = new System.Windows.Forms.Label( );
            this.lberrpasswd = new System.Windows.Forms.Label( );
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit( );
            this.SuspendLayout( );
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(12, 62);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Ajouter";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnmod
            // 
            this.btnmod.Location = new System.Drawing.Point(93, 62);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(75, 23);
            this.btnmod.TabIndex = 0;
            this.btnmod.Text = "Modifier";
            this.btnmod.UseVisualStyleBackColor = true;
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // btnsupp
            // 
            this.btnsupp.Location = new System.Drawing.Point(174, 62);
            this.btnsupp.Name = "btnsupp";
            this.btnsupp.Size = new System.Drawing.Size(75, 23);
            this.btnsupp.TabIndex = 0;
            this.btnsupp.Text = "Supp";
            this.btnsupp.UseVisualStyleBackColor = true;
            this.btnsupp.Click += new System.EventHandler(this.btnsupp_Click);
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(12, 27);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(100, 20);
            this.tbname.TabIndex = 1;
            this.tbname.Text = "foo";
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(272, 334);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(36, 23);
            this.btnfirst.TabIndex = 0;
            this.btnfirst.Text = "|<";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(356, 334);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(36, 23);
            this.btnnext.TabIndex = 0;
            this.btnnext.Text = ">";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnprev
            // 
            this.btnprev.Location = new System.Drawing.Point(314, 334);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(36, 23);
            this.btnprev.TabIndex = 0;
            this.btnprev.Text = "<";
            this.btnprev.UseVisualStyleBackColor = true;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(399, 334);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(36, 23);
            this.btnlast.TabIndex = 0;
            this.btnlast.Text = ">|";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(229, 27);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(100, 20);
            this.tbemail.TabIndex = 1;
            this.tbemail.Text = "foo@bar.com";
            // 
            // tbpasswd
            // 
            this.tbpasswd.Location = new System.Drawing.Point(335, 27);
            this.tbpasswd.Name = "tbpasswd";
            this.tbpasswd.PasswordChar = '#';
            this.tbpasswd.Size = new System.Drawing.Size(100, 20);
            this.tbpasswd.TabIndex = 1;
            this.tbpasswd.Text = "1233321";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // tbpren
            // 
            this.tbpren.Location = new System.Drawing.Point(123, 27);
            this.tbpren.Name = "tbpren";
            this.tbpren.Size = new System.Drawing.Size(100, 20);
            this.tbpren.TabIndex = 1;
            this.tbpren.Text = "bar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Pren";
            // 
            // dgv1
            // 
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 91);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(423, 237);
            this.dgv1.TabIndex = 3;
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
            // 
            // lberremail
            // 
            this.lberremail.AutoSize = true;
            this.lberremail.ForeColor = System.Drawing.Color.Maroon;
            this.lberremail.Location = new System.Drawing.Point(256, 50);
            this.lberremail.Name = "lberremail";
            this.lberremail.Size = new System.Drawing.Size(0, 13);
            this.lberremail.TabIndex = 2;
            // 
            // lberrpasswd
            // 
            this.lberrpasswd.AutoSize = true;
            this.lberrpasswd.ForeColor = System.Drawing.Color.Maroon;
            this.lberrpasswd.Location = new System.Drawing.Point(362, 50);
            this.lberrpasswd.Name = "lberrpasswd";
            this.lberrpasswd.Size = new System.Drawing.Size(0, 13);
            this.lberrpasswd.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 371);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.lberrpasswd);
            this.Controls.Add(this.lberremail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbpasswd);
            this.Controls.Add(this.tbpren);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnprev);
            this.Controls.Add(this.btnsupp);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.btnadd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit( );
            this.ResumeLayout(false);
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnmod;
        private System.Windows.Forms.Button btnsupp;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbpasswd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbpren;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label lberremail;
        private System.Windows.Forms.Label lberrpasswd;
    }
}

