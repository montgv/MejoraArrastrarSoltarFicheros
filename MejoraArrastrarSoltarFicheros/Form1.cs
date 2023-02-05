using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MejoraArrastrarSoltarFicheros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Nos permite arrastrar los datos al listBox
            this.listBoxFicheros.AllowDrop = true;
        }
        //Se produce cuando se arrastra un objeto dentro del listBox
        private void listBoxFicheros_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
        //Se produce cuando se inicia una operacion de arratras y colocar
        private void listBoxFicheros_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] listaRutaArchivos;
                int i;

                //Asignamos las rutas de los archivos a un array
                object v = e.Data.GetData(DataFormats.FileDrop);
                listaRutaArchivos = (string[])v;

                //Lo recorremos y los vamos agregando al listBox uno por uno
                for (i = 0; i < listaRutaArchivos.Length; i++)
                {
                    if (listBoxFicheros.Items.Contains(listaRutaArchivos[i]))
                    {
                        MessageBox.Show("Esta ruta ya existe.");
                    } else
                    {
                        listBoxFicheros.Items.Add(listaRutaArchivos[i]);
                    }
                }
            }
        }
    }
}
