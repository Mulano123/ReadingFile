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

namespace ReadingFile
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
            listOfProgram();
            listOfGender();
        }

        public void listOfProgram()
        {
            string[] ListOfPrograms = new string[] {
                "BS in Information Technology",
                "BS in Computer Science",
                "BS in Information Systems",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
            };

            for (int i = 0; i < ListOfPrograms.Length; i++)
            {
                cmbProgram.Items.Add(ListOfPrograms[i].ToString());
            }
        }
        public void listOfGender()
        {
            string[] listOfGender = new string[] {
                "Male",
                "Female"
            };

            for (int i = 0; i < 2; i++)
            {
                cmbGender.Items.Add(listOfGender[i].ToString());
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string FileName = txtStudentNo.Text;
            string docPath = Path.Combine("C:\\Users\\joshua\\OneDrive\\Documents", FileName);

            using (StreamWriter stream = File.CreateText(docPath))
            {
                stream.WriteLine("Student No: " + txtStudentNo.Text);
                stream.WriteLine("FullName: " + txtLastName.Text + ", " + txtFirstName.Text + ", " + txtMiddleInitial.Text);
                stream.WriteLine("Program: " + cmbProgram.Text);
                stream.WriteLine("Gender: " + cmbGender.Text);
                stream.WriteLine("Age: " + txtAge.Text);
                stream.WriteLine("Birthday: " + datePickerBirthday.Value.ToString("yyyy-MM-dd"));
                stream.WriteLine("Contact No: " + txtContactNo.Text);

            }

            MessageBox.Show("Registered Successfully.");
            Close();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            FrmStudentRecord stud = new FrmStudentRecord();
            stud.ShowDialog();
            
        }
    }
}
