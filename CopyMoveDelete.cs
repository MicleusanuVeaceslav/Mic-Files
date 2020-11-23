/*
 * Esercizio di Informatica: Creare un programma che permette di copiare, muovere e cancellare un file.
 * Alunno: Micleusanu Veaceslav 
 * Classe: 3°F
 * Data:12/05/2020
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_mover
{
    public partial class CopyMoveDelete : Form
    {

        //Dichiarazione delle variabili
        public string filePath; //file che va a prendere
        public string finalDestination; //percorso finale
        public string fileName;
        DialogResult dialog; //Posizione del file
        DialogResult dialog1; //Posizione finale del file 

        public CopyMoveDelete()
        {
            InitializeComponent();
        }

        //Copia il file
        private void copy_Click(object sender, EventArgs e)
        {
            dlg_save.FileName = fileName;
            DialogResult dialog1 = dlg_save.ShowDialog();
            finalDestination = dlg_save.FileName;
            if (( dlg_select.FileName != "" && dialog != DialogResult.Cancel ) && (dlg_select.FileName != "" && dialog1 != DialogResult.Cancel))
            {

                File.Copy(filePath, finalDestination);

                showPath.Text = " File succesfully copyed! ";
            }
        }

        //Sposta il file in un'altra cartella
        private void move_Click(object sender, EventArgs e)
        {
            dlg_save.FileName = fileName;
            DialogResult dialog1 = dlg_save.ShowDialog();

            finalDestination = dlg_save.FileName;

            if ((dlg_select.FileName != "" && dialog != DialogResult.Cancel) && (dlg_save.FileName != "" && dialog1 != DialogResult.Cancel))
            {
                File.Copy(filePath, finalDestination);

                File.Delete(filePath);

                showPath.Text = " File succesfully moved! ";
            }
        }

        //Selezione il file 
        private void select_Click(object sender, EventArgs e)
        {

            dialog = dlg_select.ShowDialog();
            filePath = dlg_select.FileName;
            showPath.Text = filePath;
            fileName = Path.GetFileName(filePath);
        }

        //Elimina se confermato 

        private void delete_Click(object sender, EventArgs e)
        {

            if (dlg_select.FileName != "" && dialog != DialogResult.Cancel)
            {               
                DialogResult question;
                question = MessageBox.Show("Do you really want to delete the selected file ?", "Confirm", MessageBoxButtons.YesNo);
                if (question == DialogResult.Yes)
                {
                    File.Delete(filePath);
                    showPath.Text = " File succesfully removed! ";
                }                
            }
        }
    }
}
