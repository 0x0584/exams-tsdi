namespace App
{
    partial class Organisateur
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
            if (disposing && (components != null)) {
                components.Dispose( );
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
            this.btnadd = new System.Windows.Forms.Button( );
            this.btnmod = new System.Windows.Forms.Button( );
            this.btnsupp = new System.Windows.Forms.Button( );
            this.dataGridView1 = new System.Windows.Forms.DataGridView( );
            this.tbnom = new System.Windows.Forms.TextBox( );
            this.tbpren = new System.Windows.Forms.TextBox( );
            this.tbemail = new System.Windows.Forms.TextBox( );
            this.tbpasswd = new System.Windows.Forms.TextBox( );
            this.label2 = new System.Windows.Forms.Label( );
            this.label3 = new System.Windows.Forms.Label( );
            this.label4 = new System.Windows.Forms.Label( );
            this.label5 = new System.Windows.Forms.Label( );
            this.label1 = new System.Windows.Forms.Label( );
            this.label6 = new System.Windows.Forms.Label( );
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit( );
            this.SuspendLayout( );
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(12, 170);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Ajouter";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnmod
            // 
            this.btnmod.Location = new System.Drawing.Point(12, 199);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(75, 23);
            this.btnmod.TabIndex = 1;
            this.btnmod.Text = "Modifier";
            this.btnmod.UseVisualStyleBackColor = true;
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // btnsupp
            // 
            this.btnsupp.Location = new System.Drawing.Point(12, 228);
            this.btnsupp.Name = "btnsupp";
            this.btnsupp.Size = new System.Drawing.Size(75, 23);
            this.btnsupp.TabIndex = 2;
            this.btnsupp.Text = "Supprimer";
            this.btnsupp.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(404, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // tbnom
            // 
            this.tbnom.Location = new System.Drawing.Point(152, 173);
            this.tbnom.Name = "tbnom";
            this.tbnom.Size = new System.Drawing.Size(100, 20);
            this.tbnom.TabIndex = 4;
            this.tbnom.Text = "aa";
            // 
            // tbpren
            // 
            this.tbpren.Location = new System.Drawing.Point(152, 202);
            this.tbpren.Name = "tbpren";
            this.tbpren.Size = new System.Drawing.Size(100, 20);
            this.tbpren.TabIndex = 4;
            this.tbpren.Text = "AA";
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(316, 172);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(100, 20);
            this.tbemail.TabIndex = 4;
            this.tbemail.Text = "aa@AA.com";
            // 
            // tbpasswd
            // 
            this.tbpasswd.Location = new System.Drawing.Point(316, 211);
            this.tbpasswd.Name = "tbpasswd";
            this.tbpasswd.PasswordChar = '*';
            this.tbpasswd.Size = new System.Drawing.Size(100, 20);
            this.tbpasswd.TabIndex = 4;
            this.tbpasswd.Text = "aassaass";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "passwd";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(313, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(313, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 6;
            // 
            // Organisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 266);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbpasswd);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tbpren);
            this.Controls.Add(this.tbnom);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsupp);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.btnadd);
            this.Name = "Organisateur";
            this.Text = "Organisateur";
            this.Load += new System.EventHandler(this.Organisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit( );
            this.ResumeLayout(false);
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnmod;
        private System.Windows.Forms.Button btnsupp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbnom;
        private System.Windows.Forms.TextBox tbpren;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbpasswd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}