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
using System.Xml.Linq;

namespace LabExer
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();


            cbBoxProgram.Items.AddRange(new string[]
             {
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS Computer Engineering"
             });

            cbBoxGender.Items.AddRange(new string[]
            {
                "Male",
                "Female",
                "Prefer not to say"
             });
        }



        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                string studentNo = txtBoxStudentNo.Text.Trim();
                string lastName = txtBoxLastName.Text.Trim();
                string firstName = txtBoxFirstName.Text.Trim();
                string middleInitial = txtBoxMiddleInitial.Text.Trim();
                string age = txtBoxAge.Text.Trim();
                string birthday = dtBirthday.Text.Trim();
                string program = cbBoxProgram.Text.Trim();
                string gender = cbBoxGender.Text.Trim();
                string contact = txtBoxContactNo.Text.Trim();

                if (string.IsNullOrWhiteSpace(studentNo) || string.IsNullOrWhiteSpace(lastName) ||
                    string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(age) ||
                    string.IsNullOrWhiteSpace(program) || string.IsNullOrWhiteSpace(gender) ||
                    string.IsNullOrWhiteSpace(contact))
                {
                    MessageBox.Show("Please complete all fields before registering.", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string folderPath = @"C:\MyRegistrationFiles";
                Directory.CreateDirectory(folderPath);

                string filePath = Path.Combine(folderPath, studentNo + ".txt");

                string info =
                    "STUDENT REGISTRATION DETAILS" + Environment.NewLine +
                    "-------------------------------------" + Environment.NewLine +
                    "Student No: " + studentNo + Environment.NewLine +
                    "Last Name: " + lastName + Environment.NewLine +
                    "First Name: " + firstName + Environment.NewLine +
                    "Middle Initial: " + middleInitial + Environment.NewLine +
                    "Age: " + age + Environment.NewLine +
                    "Birthday: " + birthday + Environment.NewLine +
                    "Program: " + program + Environment.NewLine +
                    "Gender: " + gender + Environment.NewLine +
                    "Contact No: " + contact + Environment.NewLine +
                    "-------------------------------------" + Environment.NewLine +
                    "Registered on: " + DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt");


                File.WriteAllText(filePath, info);

                MessageBox.Show("Registration saved successfully!\nFile created at: " + filePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                System.Diagnostics.Process.Start("notepad.exe", filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
