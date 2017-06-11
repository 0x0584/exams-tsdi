namespace App
{
    partial class GestionTarifParking
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
            this.btndel = new System.Windows.Forms.Button( );
            this.comboPark = new System.Windows.Forms.ComboBox( );
            this.comboType = new System.Windows.Forms.ComboBox( );
            this.tbprix = new System.Windows.Forms.TextBox( );
            this.label1 = new System.Windows.Forms.Label( );
            this.label2 = new System.Windows.Forms.Label( );
            this.label3 = new System.Windows.Forms.Label( );
            this.dgv1 = new System.Windows.Forms.DataGridView( );
            this.btnfirst = new System.Windows.Forms.Button( );
            this.btnprev = new System.Windows.Forms.Button( );
            this.btnnext = new System.Windows.Forms.Button( );
            this.btnlast = new System.Windows.Forms.Button( );
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit( );
            this.SuspendLayout( );
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(18, 57);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Ajouter";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnmod
            // 
            this.btnmod.Location = new System.Drawing.Point(99, 57);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(75, 23);
            this.btnmod.TabIndex = 0;
            this.btnmod.Text = "Modifier";
            this.btnmod.UseVisualStyleBackColor = true;
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(180, 57);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 23);
            this.btndel.TabIndex = 0;
            this.btndel.Text = "Supprimmer";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // comboPark
            // 
            this.comboPark.FormattingEnabled = true;
            this.comboPark.Location = new System.Drawing.Point(50, 22);
            this.comboPark.Name = "comboPark";
            this.comboPark.Size = new System.Drawing.Size(69, 21);
            this.comboPark.TabIndex = 1;
            // 
            // comboType
            // 
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(179, 22);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(69, 21);
            this.comboType.TabIndex = 1;
            // 
            // tbprix
            // 
            this.tbprix.Location = new System.Drawing.Point(296, 22);
            this.tbprix.Name = "tbprix";
            this.tbprix.Size = new System.Drawing.Size(64, 20);
            this.tbprix.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "idPark";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "idType";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prix";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(10, 86);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(367, 150);
            this.dgv1.TabIndex = 4;
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(43, 242);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(75, 23);
            this.btnfirst.TabIndex = 0;
            this.btnfirst.Text = "|<";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.btnfirst_Click);
            // 
            // btnprev
            // 
            this.btnprev.Location = new System.Drawing.Point(124, 242);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(75, 23);
            this.btnprev.TabIndex = 0;
            this.btnprev.Text = "<";
            this.btnprev.UseVisualStyleBackColor = true;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(205, 242);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(75, 23);
            this.btnnext.TabIndex = 0;
            this.btnnext.Text = ">";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(285, 242);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(75, 23);
            this.btnlast.TabIndex = 0;
            this.btnlast.Text = ">|";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // GestionTarifParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 304);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbprix);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.comboPark);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnprev);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.btnadd);
            this.Name = "GestionTarifParking";
            this.Text = "GestionTarifParking";
            this.Load += new System.EventHandler(this.GestionTarifParking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit( );
            this.ResumeLayout(false);
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnmod;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.ComboBox comboPark;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.TextBox tbprix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnlast;
    }
}