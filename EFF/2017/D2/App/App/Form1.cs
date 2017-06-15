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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent( );
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            GestionTarifParking g = new GestionTarifParking( );
            g.ShowDialog( );
            if (!(g.IsDisposed)) {
                g.Dispose( );
                g.Close( );
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ListUtils  g = new ListUtils( );
            g.ShowDialog( );
            if (!(g.IsDisposed)) {
                g.Dispose( );
                g.Close( );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListParking g = new ListParking( );
            g.ShowDialog( );
            if (!(g.IsDisposed)) {
                g.Dispose( );
                g.Close( );
            }
        }
    }
}
