namespace App
{
    partial class Consultation
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
            this.cbox1 = new System.Windows.Forms.ComboBox( );
            this.dgv1 = new System.Windows.Forms.DataGridView( );
            this.label1 = new System.Windows.Forms.Label( );
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit( );
            this.SuspendLayout( );
            // 
            // cbox1
            // 
            this.cbox1.FormattingEnabled = true;
            this.cbox1.Location = new System.Drawing.Point(66, 7);
            this.cbox1.Name = "cbox1";
            this.cbox1.Size = new System.Drawing.Size(121, 21);
            this.cbox1.TabIndex = 0;
            this.cbox1.SelectedIndexChanged += new System.EventHandler(this.cbox1_SelectedIndexChanged);
            // 
            // dgv1
            // 
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(12, 34);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(267, 192);
            this.dgv1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Famille";
            // 
            // Consultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 241);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.cbox1);
            this.Name = "Consultation";
            this.Text = "Consultation";
            this.Load += new System.EventHandler(this.Consultation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit( );
            this.ResumeLayout(false);
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label label1;
    }
}