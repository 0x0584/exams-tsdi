using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App
{
    public partial class EtatListPartici: Form
    {
        public EtatListPartici()
        {
            InitializeComponent( );
        }

        private void EtatListPartici_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport( );
        }
    }
}
