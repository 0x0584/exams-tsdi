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
            this.dgv1 = new System.Windows.Forms.DataGridView( );
            this.btnsupp = new System.Windows.Forms.Button( );
            this.btnmod = new System.Windows.Forms.Button( );
            this.btnadd = new System.Windows.Forms.Button( );
            this.btnclose = new System.Windows.Forms.Button( );
            this.btnfirst = new System.Windows.Forms.Button( );
            this.btnprev = new System.Windows.Forms.Button( );
            this.btnlast = new System.Windows.Forms.Button( );
            this.btnnext = new System.Windows.Forms.Button( );
            this.tbpren = new System.Windows.Forms.TextBox( );
            this.tbname = new System.Windows.Forms.TextBox( );
            this.tbaddr = new System.Windows.Forms.TextBox( );
            this.tbtele = new System.Windows.Forms.TextBox( );
            this.label1 = new System.Windows.Forms.Label( );
            this.label2 = new System.Windows.Forms.Label( );
            this.label3 = new System.Windows.Forms.Label( );
            this.label4 = new System.Windows.Forms.Label( );
            this.chboxtype = new System.Windows.Forms.ComboBox( );
            this.label5 = new System.Windows.Forms.Label( );
            this.btnclear = new System.Windows.Forms.Button( );
            this.btnsave = new System.Windows.Forms.Button( );
            this.btnrefresh = new System.Windows.Forms.Button( );
            this.lblstate = new System.Windows.Forms.Label( );
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit( );
            this.SuspendLayout( );
            // 
            // dgv1
            // 
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 44);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(324, 185);
            this.dgv1.TabIndex = 0;
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // btnsupp
            // 
            this.btnsupp.Location = new System.Drawing.Point(261, 15);
            this.btnsupp.Name = "btnsupp";
            this.btnsupp.Size = new System.Drawing.Size(75, 23);
            this.btnsupp.TabIndex = 1;
            this.btnsupp.Text = "Supprimer";
            this.btnsupp.UseVisualStyleBackColor = true;
            this.btnsupp.Click += new System.EventHandler(this.btnsupp_Click);
            // 
            // btnmod
            // 
            this.btnmod.Location = new System.Drawing.Point(172, 15);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(75, 23);
            this.btnmod.TabIndex = 1;
            this.btnmod.Text = "Modifier";
            this.btnmod.UseVisualStyleBackColor = true;
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(10, 15);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "Ajouter";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(355, 19);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "Fermer";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(380, 54);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(32, 23);
            this.btnfirst.TabIndex = 1;
            this.btnfirst.Text = "|<";
            this.btnfirst.UseVisualStyleBackColor = true;
            this.btnfirst.Click += new System.EventHandler(this.firstf);
            // 
            // btnprev
            // 
            this.btnprev.Location = new System.Drawing.Point(380, 83);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(32, 23);
            this.btnprev.TabIndex = 1;
            this.btnprev.Text = "<";
            this.btnprev.UseVisualStyleBackColor = true;
            this.btnprev.Click += new System.EventHandler(this.prevf);
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(380, 141);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(32, 23);
            this.btnlast.TabIndex = 1;
            this.btnlast.Text = ">|";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.lastf);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(380, 112);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(32, 23);
            this.btnnext.TabIndex = 1;
            this.btnnext.Text = ">";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.nextf);
            // 
            // tbpren
            // 
            this.tbpren.Location = new System.Drawing.Point(48, 261);
            this.tbpren.Name = "tbpren";
            this.tbpren.Size = new System.Drawing.Size(100, 20);
            this.tbpren.TabIndex = 2;
            this.tbpren.Text = "gg";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(48, 235);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(100, 20);
            this.tbname.TabIndex = 2;
            this.tbname.Text = "ss";
            // 
            // tbaddr
            // 
            this.tbaddr.Location = new System.Drawing.Point(228, 261);
            this.tbaddr.Name = "tbaddr";
            this.tbaddr.Size = new System.Drawing.Size(100, 20);
            this.tbaddr.TabIndex = 2;
            // 
            // tbtele
            // 
            this.tbtele.Location = new System.Drawing.Point(228, 235);
            this.tbtele.Name = "tbtele";
            this.tbtele.Size = new System.Drawing.Size(100, 20);
            this.tbtele.TabIndex = 2;
            this.tbtele.Text = "dd";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(4, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(4, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(162, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telephone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Addresse";
            // 
            // chboxtype
            // 
            this.chboxtype.FormattingEnabled = true;
            this.chboxtype.Items.AddRange(new object[] {
            "permanant",
            "vacataire"});
            this.chboxtype.Location = new System.Drawing.Point(334, 261);
            this.chboxtype.Name = "chboxtype";
            this.chboxtype.Size = new System.Drawing.Size(77, 21);
            this.chboxtype.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(352, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Type";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(355, 170);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(91, 15);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Enregistrer";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(342, 54);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(32, 23);
            this.btnrefresh.TabIndex = 6;
            this.btnrefresh.Text = "R";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // lblstate
            // 
            this.lblstate.AutoSize = true;
            this.lblstate.ForeColor = System.Drawing.Color.DarkRed;
            this.lblstate.Location = new System.Drawing.Point(376, 206);
            this.lblstate.Name = "lblstate";
            this.lblstate.Size = new System.Drawing.Size(35, 13);
            this.lblstate.TabIndex = 7;
            this.lblstate.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 302);
            this.Controls.Add(this.lblstate);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnclear);
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
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnprev);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnfirst);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.btnsupp);
            this.Controls.Add(this.dgv1);
            this.Name = "Form1";
            this.Text = "Formateur";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit( );
            this.ResumeLayout(false);
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnsupp;
        private System.Windows.Forms.Button btnmod;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.TextBox tbpren;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbaddr;
        private System.Windows.Forms.TextBox tbtele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox chboxtype;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Label lblstate;
    }
}

