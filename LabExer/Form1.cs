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
            saveDialog.Title = "Save Text File";
            saveDialog.Filter = "Text Files (*.txt)|*.txt";
            saveDialog.FileName = FrmFileName.SetFileName;

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter outputFile = new StreamWriter(saveDialog.FileName))
                {
                    outputFile.WriteLine(getInput);
                }
                MessageBox.Show("File successfully saved!\nLocation: " + saveDialog.FileName, "Success");
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
