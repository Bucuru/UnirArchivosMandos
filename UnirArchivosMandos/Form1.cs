using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private string[] sMouseCommandsArray;
        private string[] sKeyboardCommandsArray;
        private string[] sCommentsMouseArray;
        private string[] sCommentsKeyboardArray;
        private string[] sCommentsFechaArray;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            string[] sArchivos;

            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            open.Filter = "All files|*.sv";
            open.ShowDialog();

            sArchivos = open.FileNames;

            RellenarLista(sArchivos);
        }

        private void RellenarLista(string[]  sFicheros)
        {
            int i;

            for (i = 0; i < sFicheros.Length  ; i++)
            {
                lstArchivos.Items.Add(sFicheros[i]);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            lstArchivos.Clear(); 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int i;
            RellenarArrays[] oFicheroMandos = new RellenarArrays[lstArchivos.Items.Count];

            if (lstArchivos.Items.Count < 2)
            {
                MessageBox.Show("No se pueden combinar archivos de mandos. Debe existir más de un archivo en la lista");
            }
            else 
            {
                for (i = 0; i < lstArchivos.Items.Count; i++)
                {
                    oFicheroMandos[i] = new RellenarArrays(lstArchivos.Items[i].Text);                          
                }                
                
                JuntarArrayCommentsFecha(oFicheroMandos);
                JuntarArrayCommentsMouse(oFicheroMandos[0]);
                JuntarArrayCommentsKeyboard(oFicheroMandos[0]);
                JuntarArrayMouseCommands(oFicheroMandos);
                JuntarArrayKeyboardCommands (oFicheroMandos);

                CrearArchivo();

            }
        }

        private void JuntarArrayCommentsFecha(RellenarArrays[] oFicherosMandos) 
        {
            int i;
            
            for (i = 0; i < oFicherosMandos.Length ; i++)
            {
                Array.Resize(ref sCommentsFechaArray, i+1);
                sCommentsFechaArray[i] = oFicherosMandos[i].sCommentsFecha;
            }       
        }

        private void JuntarArrayCommentsMouse(RellenarArrays oFicherosMandos)
        {
            int i;
            
            //Estos comentarios solo se añaden de un archivo pues son siempre igual
            for (i = 0; i < oFicherosMandos.sCommentsMouse.Length; i++)
            {
                Array.Resize(ref sCommentsMouseArray, i+1);
                sCommentsMouseArray[i] = oFicherosMandos.sCommentsMouse[i];
            }
        }

        private void JuntarArrayCommentsKeyboard(RellenarArrays oFicherosMandos)
        {
            int i;

            //Estos comentarios solo se añaden de un archivo pues son siempre igual
            for (i = 0; i < oFicherosMandos.sCommentsKeyboard.Length; i++)
            {
                Array.Resize(ref sCommentsKeyboardArray, i+1);
                sCommentsKeyboardArray[i] = oFicherosMandos.sCommentsKeyboard[i];
            }
        }

        // Junta todos los buffers de mandos por ratón de los distintos archivos de mandos
        private void JuntarArrayMouseCommands(RellenarArrays[] oFicherosMandos)
        {
            int i;
            int j;
            int count=0;

            for (i = 0; i < oFicherosMandos.Length; i++)
            {
                for (j = 0; j < oFicherosMandos[i].sMouseCommands.Length ; j++)
                {
                    Array.Resize(ref sMouseCommandsArray, count+1);
                    sMouseCommandsArray[count] = oFicherosMandos[i].sMouseCommands[j];
                    count++;
                }
            }

            //Ordeno el array
            Array.Sort(sMouseCommandsArray,string.CompareOrdinal );            

        }

        // Junta todos los buffers de mandos por teclado de los distintos archivos de mandos
        private void JuntarArrayKeyboardCommands(RellenarArrays[] oFicherosMandos)
        {
            int i;
            int j;
            int count = 0;

            for (i = 0; i < oFicherosMandos.Length; i++)
            {
                for (j = 0; j < oFicherosMandos[i].sKeyboardCommands.Length; j++)
                {
                    Array.Resize(ref sKeyboardCommandsArray, count+1);
                    sKeyboardCommandsArray[count] = oFicherosMandos[i].sKeyboardCommands[j];
                    count++;
                }
            }

            //Ordeno el array
            Array.Sort(sKeyboardCommandsArray);
        }

        private void CrearArchivo()
        {
            string sArchivo;
            int i;

            SaveFileDialog save = new SaveFileDialog();
            save.ShowDialog();

            try
            {
                sArchivo = save.FileName;
                System.IO.StreamWriter file = new System.IO.StreamWriter(@sArchivo);
                
                //Escribo una cabecera
                file.WriteLine("# " + DateTime.Now + " -- Archivo generado de la unión de los siguientes archivos de mandos: "); 
                //Escribo las fechas
                for (i=0;i<sCommentsFechaArray.Length;i++)
                {
                    file.WriteLine(sCommentsFechaArray[i]); 
                }

                //Escribo los comentarios por ratón
                for (i = 0; i < sCommentsMouseArray.Length; i++)
                {
                    file.WriteLine(sCommentsMouseArray[i]); 
                }

                //Escribo los mandos por ratón
                for (i = 0; i < sMouseCommandsArray.Length; i++)
                {
                    file.WriteLine(sMouseCommandsArray[i]);
                }

                //Escribo los comentarios por teclado
                for (i = 0; i < sCommentsKeyboardArray .Length; i++)
                {
                    file.WriteLine(sCommentsKeyboardArray [i]);
                }

                //Escribo los mandos por teclado
                for (i = 0; i < sKeyboardCommandsArray.Length; i++)
                {
                    file.WriteLine(sKeyboardCommandsArray[i]);
                }

                file.Close();
                MessageBox.Show("Proceso Completado.");   

            }
            catch
            {
                MessageBox.Show("Error creando el archivo.");   
            }

        }

        
    }
}
