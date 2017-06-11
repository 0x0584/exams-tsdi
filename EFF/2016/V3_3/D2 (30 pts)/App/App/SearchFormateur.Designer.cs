namespace App
{
    partial class SearchFormateur
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
            this.tbsearch = new System.Windows.Forms.TextBox( );
            this.btnsearch = new System.Windows.Forms.Button( );
            this.lbl_respo = new System.Windows.Forms.Label( );
            this.lbl_nb_chapitres = new System.Windows.Forms.Label( );
            this.lbl_ensei = new System.Windows.Forms.Label( );
            this.btnetat = new System.Windows.Forms.Button( );
            this.btnuvinfo = new System.Windows.Forms.Button( );
            this.chboxtype = new System.Windows.Forms.ComboBox( );
            this.label4 = new System.Windows.Forms.Label( );
            this.label5 = new System.Windows.Forms.Label( );
            this.label3 = new System.Windows.Forms.Label( );
            this.label2 = new System.Windows.Forms.Label( );
            this.label1 = new System.Windows.Forms.Label( );
            this.tbtele = new System.Windows.Forms.TextBox( );
            this.tbname = new System.Windows.Forms.TextBox( );
            this.tbaddr = new System.Windows.Forms.TextBox( );
            this.tbpren = new System.Windows.Forms.TextBox( );
            this.btnmod = new System.Windows.Forms.Button( );
            this.dgv1 = new System.Windows.Forms.DataGridView( );
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit( );
            this.SuspendLayout( );
            // 
            // tbsearch
            // 
            this.tbsearch.Location = new System.Drawing.Point(93, 14);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(117, 20);
            this.tbsearch.TabIndex = 0;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(12, 14);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // lbl_respo
            // 
            this.lbl_respo.AutoSize = true;
            this.lbl_respo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_respo.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_respo.Location = new System.Drawing.Point(14, 139);
            this.lbl_respo.Name = "lbl_respo";
            this.lbl_respo.Size = new System.Drawing.Size(46, 17);
            this.lbl_respo.TabIndex = 5;
            this.lbl_respo.Text = "label1";
            // 
            // lbl_nb_chapitres
            // 
            this.lbl_nb_chapitres.AutoSize = true;
            this.lbl_nb_chapitres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nb_chapitres.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_nb_chapitres.Location = new System.Drawing.Point(14, 155);
            this.lbl_nb_chapitres.Name = "lbl_nb_chapitres";
            this.lbl_nb_chapitres.Size = new System.Drawing.Size(46, 17);
            this.lbl_nb_chapitres.TabIndex = 6;
            this.lbl_nb_chapitres.Text = "label1";
            // 
            // lbl_ensei
            // 
            this.lbl_ensei.AutoSize = true;
            this.lbl_ensei.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ensei.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_ensei.Location = new System.Drawing.Point(14, 122);
            this.lbl_ensei.Name = "lbl_ensei";
            this.lbl_ensei.Size = new System.Drawing.Size(46, 17);
            this.lbl_ensei.TabIndex = 7;
            this.lbl_ensei.Text = "label1";
            // 
            // btnetat
            // 
            this.btnetat.Location = new System.Drawing.Point(216, 14);
            this.btnetat.Name = "btnetat";
            this.btnetat.Size = new System.Drawing.Size(132, 23);
            this.btnetat.TabIndex = 3;
            this.btnetat.Text = "Etat List des chapitres";
            this.btnetat.UseVisualStyleBackColor = true;
            this.btnetat.Click += new System.EventHandler(this.btnetat_Click);
            // 
            // btnuvinfo
            // 
            this.btnuvinfo.Location = new System.Drawing.Point(354, 14);
            this.btnuvinfo.Name = "btnuvinfo";
            this.btnuvinfo.Size = new System.Drawing.Size(117, 23);
            this.btnuvinfo.TabIndex = 4;
            this.btnuvinfo.Text = "UV Ensei/Respo";
            this.btnuvinfo.UseVisualStyleBackColor = true;
            this.btnuvinfo.Click += new System.EventHandler(this.btnuvinfo_Click);
            // 
            // chboxtype
            // 
            this.chboxtype.FormattingEnabled = true;
            this.chboxtype.Items.AddRange(new object[] {
            "permanant",
            "vacataire"});
            this.chboxtype.Location = new System.Drawing.Point(354, 79);
            this.chboxtype.Name = "chboxtype";
            this.chboxtype.Size = new System.Drawing.Size(99, 21);
            this.chboxtype.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Addresse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(384, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(170, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Telephone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nom";
            // 
            // tbtele
            // 
            this.tbtele.Location = new System.Drawing.Point(236, 53);
            this.tbtele.Name = "tbtele";
            this.tbtele.Size = new System.Drawing.Size(100, 20);
            this.tbtele.TabIndex = 9;
            this.tbtele.Text = "dd";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(56, 53);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(100, 20);
            this.tbname.TabIndex = 8;
            this.tbname.Text = "ss";
            // 
            // tbaddr
            // 
            this.tbaddr.Location = new System.Drawing.Point(236, 79);
            this.tbaddr.Name = "tbaddr";
            this.tbaddr.Size = new System.Drawing.Size(100, 20);
            this.tbaddr.TabIndex = 11;
            // 
            // tbpren
            // 
            this.tbpren.Location = new System.Drawing.Point(56, 79);
            this.tbpren.Name = "tbpren";
            this.tbpren.Size = new System.Drawing.Size(100, 20);
            this.tbpren.TabIndex = 10;
            this.tbpren.Text = "gg";
            // 
            // btnmod
            // 
            this.btnmod.Location = new System.Drawing.Point(396, 138);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(75, 23);
            this.btnmod.TabIndex = 18;
            this.btnmod.Text = "Modify";
            this.btnmod.UseVisualStyleBackColor = true;
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // dgv1
            // 
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 193);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(459, 187);
            this.dgv1.TabIndex = 19;
            // 
            // SearchFormateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 392);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.chboxtype);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbtele);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.tbaddr);
            this.Controls.Add(this.tbpren);
            this.Controls.Add(this.lbl_respo);
            this.Controls.Add(this.lbl_nb_chapitres);
            this.Controls.Add(this.lbl_ensei);
            this.Controls.Add(this.btnetat);
            this.Controls.Add(this.btnuvinfo);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.tbsearch);
            this.Name = "SearchFormateur";
            this.Text = "SearchFormateur";
            this.Load += new System.EventHandler(this.SearchFormateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit( );
            this.ResumeLayout(false);
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label lbl_respo;
        private System.Windows.Forms.Label lbl_nb_chapitres;
        private System.Windows.Forms.Label lbl_ensei;
        private System.Windows.Forms.Button btnetat;
        private System.Windows.Forms.Button btnuvinfo;
        private System.Windows.Forms.ComboBox chboxtype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbtele;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbaddr;
        private System.Windows.Forms.TextBox tbpren;
        private System.Windows.Forms.Button btnmod;
        private System.Windows.Forms.DataGridView dgv1;
    }
}