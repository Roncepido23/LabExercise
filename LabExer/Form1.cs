using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabExer
{
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            FrmFileName frm = new FrmFileName();
            frm.ShowDialog();

            
            string getInput = txtInput.Text;

            
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text Files (*.txt)|*.txt";
            saveDialog.FileName = FrmFileName.SetFileName;
            saveDialog.Title = "Save Text File";

         
            DialogResult dialogResult = saveDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string path = saveDialog.FileName;

              
                using (StreamWriter outputFile = new StreamWriter(path))
                {
                    outputFile.WriteLine(getInput);
                }

                
                MessageBox.Show("File successfully saved!\nLocation: " + path, "Success");
            }

        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmRegistration regForm = new FrmRegistration();
            regForm.ShowDialog();

            this.Show();
        }
    }
}
