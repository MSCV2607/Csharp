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

namespace Archivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear y configurar el FolderBrowserDialog
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Selecciona una carpeta";
                folderBrowserDialog.ShowNewFolderButton = true;

                // Mostrar el diálogo y comprobar si se selecciona una carpeta
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderBrowserDialog.SelectedPath;

                    // Limpiar el ListBox antes de agregar nuevos ítems
                    listBoxArchivos.Items.Clear();

                    // Obtener y mostrar los archivos en la carpeta seleccionada
                    string[] files = Directory.GetFiles(selectedPath);
                    foreach (string file in files)
                    {
                        listBoxArchivos.Items.Add(Path.GetFileName(file));
                    }
                }
            }
        }
    }
}
