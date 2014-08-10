using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mixy
{
    public partial class Form1 : Form
    {
        private string currentFile = "root";
        Opciones op = new Opciones();

        public Form1()
        {
            InitializeComponent();

            op.Show();
            op.Visible = false;
        }

        private string getVariableValue(string text)
        {
            return text.Remove(0, text.IndexOf(Options.VALUE_ASSIGN) + 2);
        }

        private string[] openFile()
        {
            OpenFileDialog file = new OpenFileDialog();
            DialogResult dr = file.ShowDialog();
           

            if (dr == DialogResult.OK)
            {
                try
                {
                    string[] lineas = System.IO.File.ReadAllLines(@file.FileName);
                    currentFile = file.FileName;
                    return lineas;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error abriendo el archivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return null;
        }

        private void saveFile()
        {
            string texto = "";

            foreach (TreeNode padre in treeView.Nodes)
            {
                texto += Environment.NewLine;
                texto += Environment.NewLine;
                texto += Environment.NewLine;


                /* Comentario */
                if (padre.ToolTipText.Length > 0)
                {
                    texto += padre.ToolTipText;
                    texto += Environment.NewLine;
                }

                /* Categoria */                
                texto += padre.Text;
                texto += Environment.NewLine;

                foreach (TreeNode hijo in padre.Nodes)
                {
                    /* Comentario */
                    if (hijo.ToolTipText.Length > 0)
                    {
                        texto += hijo.ToolTipText;
                        texto += Environment.NewLine;
                    }

                    /* Variable */
                    texto += hijo.Name + Options.VALUE_ASSIGN + getVariableValue(hijo.Text);
                    texto += Environment.NewLine;
                }
            }

            System.IO.File.WriteAllText(@currentFile, texto);
        }

        private List<TreeNode> getNodes(string[] lineas)
        {
            List<TreeNode> padres = new List<TreeNode>();
            TreeNode padre = new TreeNode("EstoNoMeSirve");

            try
            {
                /* Cada comentario se ira almacenando (en caso de ser multiples lineas)
                   Para añadirselo al treenode como toolstrip
                 */
                string comentario = "";

                foreach (string linea in lineas)
                {
                    /* Si contiene los caracteres de Clase, entonces creamos un nuevo padre */
                    if (linea.Contains(Options.CATEGORY[0]) && linea.Contains(Options.CATEGORY[1]))
                    {
                        /* Añadimos el que tenemos ahora (en caso de tener uno */
                        if (padre.Text != "EstoNoMeSirve")
                        {
                            padres.Add(padre);
                        }

                        /* Quitamos los corchetes */
                        /*string nombre = linea.Replace(Options.CATEGORY[0], ' ');
                        nombre = nombre.Replace(Options.CATEGORY[1], ' ');*/

                        padre = new TreeNode(linea);

                        /* Comentario */
                        padre.ToolTipText = comentario;

                        comentario = "";
                    }
                    /* Sino, Veo si es comentario */
                    else if (linea.Contains(Options.COMMENT))
                    {
                        comentario += linea;
                    }
                    /* Sino, puede ser una linea en blanco */
                    else if (linea.Length <= 1)
                    {
                        /* Linea en blanco */
                    }
                    /* Sino, es una variable */
                    else
                    {
                        string nombreVar = linea.Remove(linea.IndexOf(Options.VALUE_ASSIGN));
                        string valor = linea.Remove(0, linea.IndexOf(Options.VALUE_ASSIGN) + 1);
                                                
                        padre.Nodes.Add(nombreVar, valor);

                        /* Añadimos el comentario (si es que tiene) */
                        padre.Nodes[nombreVar].ToolTipText = comentario;

                        /* Limpiamos el comentario */
                        comentario = "";
                    }

                }

                /* Añadimos el ultimo */
                padres.Add(padre);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al leer el archivo. Asegurese que los caracteres especiales estan bien.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return padres;
        }
        
        private void timerAct_Tick(object sender, EventArgs e)
        {
            timerAct.Stop();

            for (int i = 0; i < treeView.Nodes.Count; i++)
                for (int k = 0; k < treeView.Nodes[i].Nodes.Count; k++)
                    if (!treeView.Nodes[i].Nodes[k].Text.Contains(Options.VALUE_ASSIGN))
                    {
                        //MessageBox.Show(treeView.Nodes[i].Nodes.Count.ToString());
                        treeView.Nodes[i].Nodes[k].Text = treeView.Nodes[i].Nodes[k].Name + " " + Options.VALUE_ASSIGN + " " + treeView.Nodes[i].Nodes[k].Text;
                    }

            timerAct.Start();            
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<TreeNode> todos = getNodes(openFile());

            if (todos != null)
            {
                /* Vaciamos el treeview actual */
                treeView.Nodes.Clear();

                /* Copiamos los nuevos nodos */
                foreach (TreeNode tn in todos)
                    treeView.Nodes.Add(tn);
            }
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            op.Visible = true;
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void quéEsMixyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mixy es un programa que facilita la edicion de archivos de configuracion de juegos. Por defecto, estos archivos son .ini",
                            "Mixy",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}
