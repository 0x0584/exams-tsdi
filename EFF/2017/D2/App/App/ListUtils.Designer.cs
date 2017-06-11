namespace App
{
    partial class ListUtils
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
            this.dgv1 = new System.Windows.Forms.DataGridView( );
            this.dpicker = new System.Windows.Forms.DateTimePicker( );
            this.btnexport = new System.Windows.Forms.Button( );
            this.btnetat = new System.Windows.Forms.Button( );
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit( );
            this.SuspendLayout( );
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 104);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(240, 150);
            this.dgv1.TabIndex = 0;
            // 
            // dpicker
            // 
            this.dpicker.Location = new System.Drawing.Point(12, 12);
            this.dpicker.Name = "dpicker";
            this.dpicker.Size = new System.Drawing.Size(191, 20);
            this.dpicker.TabIndex = 1;
            this.dpicker.ValueChanged += new System.EventHandler(this.dpicker_ValueChanged);
            // 
            // btnexport
            // 
            this.btnexport.Location = new System.Drawing.Point(13, 75);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(75, 23);
            this.btnexport.TabIndex = 2;
            this.btnexport.Text = "Exporter";
            this.btnexport.UseVisualStyleBackColor = true;
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // btnetat
            // 
            this.btnetat.Location = new System.Drawing.Point(94, 75);
            this.btnetat.Name = "btnetat";
            this.btnetat.Size = new System.Drawing.Size(75, 23);
            this.btnetat.TabIndex = 2;
            this.btnetat.Text = "Imprimer";
            this.btnetat.UseVisualStyleBackColor = true;
            this.btnetat.Click += new System.EventHandler(this.btnetat_Click);
            // 
            // ListUtils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 266);
            this.Controls.Add(this.btnetat);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.dpicker);
            this.Controls.Add(this.dgv1);
            this.Name = "ListUtils";
            this.Text = "ListUtils";
            this.Load += new System.EventHandler(this.ListUtils_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit( );
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DateTimePicker dpicker;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Button btnetat;
    }
}