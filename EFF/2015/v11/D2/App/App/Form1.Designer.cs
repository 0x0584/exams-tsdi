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
            this.btnsave = new System.Windows.Forms.Button( );
            this.btndel = new System.Windows.Forms.Button( );
            this.btnexit = new System.Windows.Forms.Button( );
            this.btnfirst = new System.Windows.Forms.Button( );
            this.btnlast = new System.Windows.Forms.Button( );
            this.btnnext = new System.Windows.Forms.Button( );
            this.btnprev = new System.Windows.Forms.Button( );
            this.dgv1 = new System.Windows.Forms.DataGridView( );
            this.tbnom = new System.Windows.Forms.TextBox( );
            this.label1 = new System.Windows.Forms.Label( );
            this.tbpop = new System.Windows.Forms.TextBox( );
            this.label2 = new System.Windows.Forms.Label( );
            this.tbtotal = new System.Windows.Forms.TextBox( );
            this.label3 = new System.Windows.Forms.Label( );
            this.comboville = new System.Windows.Forms.ComboBox( );
            this.label4 = new System.Windows.Forms.Label( );
            this.label5 = new System.Windows.Forms.Label( );
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit( );
            this.SuspendLayout( );
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(12, 12);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Ajouter";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(93, 12);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "Enregistrer";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(174, 12);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(75, 23);
            this.btndel.TabIndex = 0;
            this.btndel.Text = "Supprimer";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(332, 12);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 0;
            this.btnexit.Text = "Fermer";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnfirst
            // 
            this.btnfirst.Location = new System.Drawing.Point(250, 339);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(34, 23);
            this.btnfirst.TabIndex = 0;
            this.btnfirst.Text = "|<";
            this.btnfirst.UseVisualStyleBackColor = true;
            // 
            // btnlast
            // 
            this.btnlast.Location = new System.Drawing.Point(372, 339);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(34, 23);
            this.btnlast.TabIndex = 0;
            this.btnlast.Text = ">|";
            this.btnlast.UseVisualStyleBackColor = true;
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(332, 339);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(34, 23);
            this.btnnext.TabIndex = 0;
            this.btnnext.Text = ">";
            this.btnnext.UseVisualStyleBackColor = true;
            // 
            // btnprev
            // 
            this.btnprev.Location = new System.Drawing.Point(290, 339);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(34, 23);
            this.btnprev.TabIndex = 0;
            this.btnprev.Text = "<";
            this.btnprev.UseVisualStyleBackColor = true;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 96);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(394, 237);
            this.dgv1.TabIndex = 1;
            this.dgv1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellClick);
            // 
            // tbnom
            // 
            this.tbnom.Location = new System.Drawing.Point(13, 69);
            this.tbnom.Name = "tbnom";
            this.tbnom.Size = new System.Drawing.Size(100, 20);
            this.tbnom.TabIndex = 2;
            this.tbnom.Text = "foo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom Quartier";
            // 
            // tbpop
            // 
            this.tbpop.Location = new System.Drawing.Point(119, 69);
            this.tbpop.Name = "tbpop";
            this.tbpop.Size = new System.Drawing.Size(100, 20);
            this.tbpop.TabIndex = 2;
            this.tbpop.Text = "1542";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pop Quartier";
            // 
            // tbtotal
            // 
            this.tbtotal.Location = new System.Drawing.Point(225, 69);
            this.tbtotal.Name = "tbtotal";
            this.tbtotal.Size = new System.Drawing.Size(100, 20);
            this.tbtotal.TabIndex = 2;
            this.tbtotal.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Quartier";
            // 
            // comboville
            // 
            this.comboville.FormattingEnabled = true;
            this.comboville.Location = new System.Drawing.Point(333, 69);
            this.comboville.Name = "comboville";
            this.comboville.Size = new System.Drawing.Size(121, 21);
            this.comboville.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ville";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 374);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboville);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbtotal);
            this.Controls.Add(this.tbpop);
            this.Controls.Add(this.tbnom);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btnprev);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btndel);
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
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnfirst;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.TextBox tbnom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbpop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboville;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

