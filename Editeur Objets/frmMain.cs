using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace Editeur_Objets
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }

        // Initialise les sols existants
        private void InitializeGrounds()
        {
            lstGrounds.Items.Clear();
            for (byte i=0; i<100; i++)
            {
                if (File.Exists("Sols/Sol" + i + ".dat"))
                {
                    Var.fileDB.LoadGround(i);
                    lstGrounds.Items.Add(Var.fileDB.arrGround[i].name);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeGrounds();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (byte i = 0; i < 100; i++)
            {
                if (Var.fileDB.arrGround[i] == null)
                {
                    Var.currentData = i;
                    break;
                }
            }
            Form launcher = new frmGroundEditor();
            launcher.Show();
        }

        private void tmrRefresh_Tick(object sender, EventArgs e)
        {
            if (Var.changed)
            {
                InitializeGrounds();
                Var.changed = false;
            }
        }

        private void lstGrounds_DoubleClick(object sender, EventArgs e)
        {
            Var.currentData = (byte)(lstGrounds.SelectedIndex);
            Form launcher = new frmGroundEditor();
            launcher.Show();
        }
    }
}
