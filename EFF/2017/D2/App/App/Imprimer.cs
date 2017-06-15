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
    public partial class Imprimer: Form
    {
        public Imprimer()
        {
            InitializeComponent( );
        }

        private void Imprimer_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'ff2017_v11DataSet.Utilisateur'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.UtilisateurTableAdapter.Fill(this.ff2017_v11DataSet.Utilisateur);
            this.reportViewer1.RefreshReport( );
        }
    }
}
