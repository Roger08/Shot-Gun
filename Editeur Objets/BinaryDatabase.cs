using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Editeur_Objets
{
    public class BinaryDatabase
    {
        public Ground[] arrGround = new Ground[100];

        public void LoadGround(byte index)
        {
            try
            {
                BinaryFormatter deserializer = new BinaryFormatter();
                Stream reader = default(Stream);

                reader = File.OpenRead("Sols/Sol" + index + ".dat");
                arrGround[index] = (Ground)deserializer.Deserialize(reader);
                reader.Close();
                reader.Dispose();
            }
            catch
            { MessageBox.Show("Une erreur est survenue lors du chargement du sol #" + index); }
        }

        public void SaveGround(byte index)
        {
            BinaryFormatter serializer = new BinaryFormatter();
            Stream writer = default(Stream);
            writer = File.Create("Sols/Sol" + index + ".dat");
            serializer.Serialize(writer, arrGround[index]);
            writer.Close();
        }
    }
}
