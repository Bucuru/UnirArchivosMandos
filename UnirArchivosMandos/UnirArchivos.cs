using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class RellenarArrays
    {
        public string[] sMouseCommands;
        public string[] sKeyboardCommands;
        public string[] sCommentsMouse;
        public string[] sCommentsKeyboard;
        public string sCommentsFecha;

        public RellenarArrays(string sFicheroMandos)
        {   
            int countCommentsMouse=0;
            int countCommentsKeyboard=0;
            int countKeyboard=0;
            int countMouse=0;
            string line;
            bool bMouseComment = true;
                        
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(@sFicheroMandos);

                while ((line = file.ReadLine()) != null)
                {
                    if (line.IndexOf("Fecha Generaci") != -1)
                    {
                        sCommentsFecha = line + " " + sFicheroMandos;
                    }
                    //Siempre viene primero los comentarios del mandos por ratón
                    else if (line.IndexOf("#") != -1)
                    {
                        //Después de esta condición se cambia a los comentarios de teclado.
                        if (line.IndexOf("TECLADO") != -1)
                        {
                            bMouseComment = false;
                            Array.Resize(ref sCommentsKeyboard, countCommentsKeyboard + 1);
                            sCommentsKeyboard[countCommentsKeyboard] = line;
                            countCommentsKeyboard++;
                        }
                        else if (bMouseComment)
                        {
                            Array.Resize(ref sCommentsMouse, countCommentsMouse + 1);
                            sCommentsMouse[countCommentsMouse] = line;
                            countCommentsMouse++;
                        }                        
                        else
                        {
                            Array.Resize(ref sCommentsKeyboard, countCommentsKeyboard+1);
                            sCommentsKeyboard[countCommentsKeyboard] = line;
                            countCommentsKeyboard++;
                        }
                    }
                    else if (line.IndexOf("!") != -1)
                    {
                        Array.Resize(ref sMouseCommands, countMouse+1);
                        sMouseCommands[countMouse] = line;
                        countMouse++;
                    }
                    else if (line.IndexOf("|") != -1)
                    {
                        Array.Resize(ref sKeyboardCommands, countKeyboard+1);
                        sKeyboardCommands [countKeyboard] = line;
                        countKeyboard++;
                    }                    
                }
            }
            catch
            {
                MessageBox.Show("Error leyendo archivo: " + sFicheroMandos);   
            }
        }

    }
}
