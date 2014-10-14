using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editeur_Objets
{
    public partial class frmGroundEditor : Form
    {
        public frmGroundEditor()
        {
            InitializeComponent();
        }

        private void frmGroundEditor_Load(object sender, EventArgs e)
        {
            if (Form1.fileDB.arrGround[Var.currentData] != null)
            {
                // TODO : Charger l'item existant
            }
        }
    }
}
