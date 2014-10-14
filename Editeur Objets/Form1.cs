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
    public partial class Form1 : Form
    {
        public static BinaryDatabase fileDB = new BinaryDatabase();

        public Form1()
        {
            InitializeComponent();
        }

        // Initialise les sols existants
        private void InitializeGrounds()
        { 
            for (byte i=0; i<100; i++)
            {
                if (File.Exists("Sols/Sol" + i + ".dat"))
                {
                    fileDB.LoadGround(i);
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
                if (fileDB.arrGround[i] == null)
                {
                    Var.currentData = i;
                    break;
                }
            }
            Form launcher = new frmGroundEditor();
            launcher.Show();
        }
    }
}
