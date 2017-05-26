namespace App
{
    partial class FormConsultation
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
            this.listview_categ = new System.Windows.Forms.ListView( );
            this.dgv_comp = new System.Windows.Forms.DataGridView( );
            ((System.ComponentModel.ISupportInitialize)(this.dgv_comp)).BeginInit( );
            this.SuspendLayout( );
            // 
            // listview_categ
            // 
            this.listview_categ.Location = new System.Drawing.Point(12, 12);
            this.listview_categ.MultiSelect = false;
            this.listview_categ.Name = "listview_categ";
            this.listview_categ.Size = new System.Drawing.Size(94, 176);
            this.listview_categ.TabIndex = 0;
            this.listview_categ.UseCompatibleStateImageBehavior = false;
            this.listview_categ.SelectedIndexChanged += new System.EventHandler(this.listview_categ_SelectedIndexChanged);
            // 
            // dgv_comp
            // 
            this.dgv_comp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_comp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_comp.Location = new System.Drawing.Point(112, 12);
            this.dgv_comp.Name = "dgv_comp";
            this.dgv_comp.Size = new System.Drawing.Size(297, 176);
            this.dgv_comp.TabIndex = 1;
            // 
            // FormConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 206);
            this.Controls.Add(this.dgv_comp);
            this.Controls.Add(this.listview_categ);
            this.Name = "FormConsultation";
            this.Text = "FormConsultation";
            this.Load += new System.EventHandler(this.FormConsultation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_comp)).EndInit( );
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listview_categ;
        private System.Windows.Forms.DataGridView dgv_comp;
    }
}