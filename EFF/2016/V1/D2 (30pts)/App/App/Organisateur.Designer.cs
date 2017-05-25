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
            this.combox_ids = new System.Windows.Forms.ComboBox( );
            this.btn_next = new System.Windows.Forms.Button( );
            this.btn_last = new System.Windows.Forms.Button( );
            this.btn_prev = new System.Windows.Forms.Button( );
            this.btn_first = new System.Windows.Forms.Button( );
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit( );
            this.SuspendLayout( );
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(12, 10);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Ajouter";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnmod
            // 
            this.btnmod.Location = new System.Drawing.Point(93, 10);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(75, 23);
            this.btnmod.TabIndex = 1;
            this.btnmod.Text = "Modifier";
            this.btnmod.UseVisualStyleBackColor = true;
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // btnsupp
            // 
            this.btnsupp.Location = new System.Drawing.Point(174, 10);
            this.btnsupp.Name = "btnsupp";
            this.btnsupp.Size = new System.Drawing.Size(75, 23);
            this.btnsupp.TabIndex = 2;
            this.btnsupp.Text = "Supprimer";
            this.btnsupp.UseVisualStyleBackColor = true;
            this.btnsupp.Click += new System.EventHandler(this.btnsupp_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(334, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tbnom
            // 
            this.tbnom.Location = new System.Drawing.Point(80, 195);
            this.tbnom.Name = "tbnom";
            this.tbnom.Size = new System.Drawing.Size(100, 20);
            this.tbnom.TabIndex = 4;
            this.tbnom.Text = "aa";
            // 
            // tbpren
            // 
            this.tbpren.Location = new System.Drawing.Point(80, 226);
            this.tbpren.Name = "tbpren";
            this.tbpren.Size = new System.Drawing.Size(100, 20);
            this.tbpren.TabIndex = 4;
            this.tbpren.Text = "AA";
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(262, 193);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(100, 20);
            this.tbemail.TabIndex = 4;
            this.tbemail.Text = "aa@AA.com";
            // 
            // tbpasswd
            // 
            this.tbpasswd.Location = new System.Drawing.Point(265, 227);
            this.tbpasswd.Name = "tbpasswd";
            this.tbpasswd.PasswordChar = '*';
            this.tbpasswd.Size = new System.Drawing.Size(100, 20);
            this.tbpasswd.TabIndex = 4;
            this.tbpasswd.Text = "aassaass";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "passwd";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(236, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(259, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 6;
            // 
            // combox_ids
            // 
            this.combox_ids.FormattingEnabled = true;
            this.combox_ids.Location = new System.Drawing.Point(275, 10);
            this.combox_ids.Name = "combox_ids";
            this.combox_ids.Size = new System.Drawing.Size(141, 21);
            this.combox_ids.TabIndex = 7;
            this.combox_ids.SelectedIndexChanged += new System.EventHandler(this.combox_ids_SelectedIndexChanged);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(386, 63);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(38, 23);
            this.btn_next.TabIndex = 8;
            this.btn_next.Text = ">>";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(386, 92);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(38, 23);
            this.btn_last.TabIndex = 8;
            this.btn_last.Text = ">|";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(2, 63);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(38, 23);
            this.btn_prev.TabIndex = 8;
            this.btn_prev.Text = "<<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(2, 92);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(38, 23);
            this.btn_first.TabIndex = 8;
            this.btn_first.Text = "|<";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // Organisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 271);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.combox_ids);
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
        private System.Windows.Forms.ComboBox combox_ids;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_first;
    }
}