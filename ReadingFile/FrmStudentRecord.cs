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
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }     

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegistration register = new FrmRegistration();
            register.Show();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = @"C:\Users\joshua\OneDrive\Documents";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            string path = openFileDialog1.FileName;
            if (File.Exists(path))
            {
                using (StreamReader streamReader = File.OpenText(path))
                {
                    string _getText = "";
                    while ((_getText = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(_getText);
                        lvShowText.Items.Add(_getText);
                    }
                }
            }
            else
            {
                MessageBox.Show("The file that you open does not exist!");
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Succesfully Uploaded!");
            lvShowText.Clear();
                
        }

    }
}
