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
            this.textBox1 = new System.Windows.Forms.TextBox( );
            this.btnsearch = new System.Windows.Forms.Button( );
            this.dgv1 = new System.Windows.Forms.DataGridView( );
            this.lbl_respo = new System.Windows.Forms.Label( );
            this.lbl_nb_chapitres = new System.Windows.Forms.Label( );
            this.lbl_ensei = new System.Windows.Forms.Label( );
            this.btnetat = new System.Windows.Forms.Button( );
            this.btnuvinfo = new System.Windows.Forms.Button( );
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit( );
            this.SuspendLayout( );
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 0;
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
            // dgv1
            // 
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 43);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(459, 236);
            this.dgv1.TabIndex = 2;
            // 
            // lbl_respo
            // 
            this.lbl_respo.AutoSize = true;
            this.lbl_respo.Location = new System.Drawing.Point(350, 303);
            this.lbl_respo.Name = "lbl_respo";
            this.lbl_respo.Size = new System.Drawing.Size(35, 13);
            this.lbl_respo.TabIndex = 5;
            this.lbl_respo.Text = "label1";
            // 
            // lbl_nb_chapitres
            // 
            this.lbl_nb_chapitres.AutoSize = true;
            this.lbl_nb_chapitres.Location = new System.Drawing.Point(436, 291);
            this.lbl_nb_chapitres.Name = "lbl_nb_chapitres";
            this.lbl_nb_chapitres.Size = new System.Drawing.Size(35, 13);
            this.lbl_nb_chapitres.TabIndex = 6;
            this.lbl_nb_chapitres.Text = "label1";
            // 
            // lbl_ensei
            // 
            this.lbl_ensei.AutoSize = true;
            this.lbl_ensei.Location = new System.Drawing.Point(350, 290);
            this.lbl_ensei.Name = "lbl_ensei";
            this.lbl_ensei.Size = new System.Drawing.Size(35, 13);
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
            // SearchFormateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 328);
            this.Controls.Add(this.lbl_respo);
            this.Controls.Add(this.lbl_nb_chapitres);
            this.Controls.Add(this.lbl_ensei);
            this.Controls.Add(this.btnetat);
            this.Controls.Add(this.btnuvinfo);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.textBox1);
            this.Name = "SearchFormateur";
            this.Text = "SearchFormateur";
            this.Load += new System.EventHandler(this.SearchFormateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit( );
            this.ResumeLayout(false);
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label lbl_respo;
        private System.Windows.Forms.Label lbl_nb_chapitres;
        private System.Windows.Forms.Label lbl_ensei;
        private System.Windows.Forms.Button btnetat;
        private System.Windows.Forms.Button btnuvinfo;
    }
}