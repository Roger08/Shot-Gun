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
    public partial class frmGroundEditor : Form
    {
        public frmGroundEditor()
        {
            InitializeComponent();
        }

        // Initialisation des textures
        private void initTextures()
        {
            scrlPic.Maximum = Directory.GetFiles("Images/Sols").Length - 1;
        }

        // Mise à jour de la texture
        private void updateTexture(byte index)
        {
            picPic.ImageLocation = ("Images/Sols/" + index.ToString() + ".png");
        }

        // Chargement du sol
        private void frmGroundEditor_Load(object sender, EventArgs e)
        {
            initTextures();
            if (Var.fileDB.arrGround[Var.currentData] != null)
            {
                // On édite un sol existant
                txtName.Text = Var.fileDB.arrGround[Var.currentData].name;
                scrlPic.Value = Var.fileDB.arrGround[Var.currentData].pic;
                chkBlocking.Checked = Var.fileDB.arrGround[Var.currentData].blocking;
                updateTexture((byte)(scrlPic.Value));
            }
            else
            {
                // On est en train de créer un nouveau sol
                updateTexture(0);
            }
        }

        // Sauvegarde du sol
        private void button1_Click(object sender, EventArgs e)
        {
            Ground tmp = new Ground();
            tmp.name = txtName.Text;
            tmp.pic = (byte)(scrlPic.Value);
            tmp.blocking = chkBlocking.Checked;
            Var.fileDB.arrGround[Var.currentData] = tmp;
            Var.fileDB.SaveGround(Var.currentData);

            // Fermeture de la fenêtre
            Var.changed = true;
            this.Close();
        }

        private void scrlPic_ValueChanged(object sender, EventArgs e)
        {
            updateTexture((byte)(scrlPic.Value));
        }
    }
}
