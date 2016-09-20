using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            textBox1.Text = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {

                textBox2.Text = File.ReadAllText(openFileDialog1.FileName);
                int row = 0;
                foreach (string line in textBox2.Lines)
                {
                    
                    Console.WriteLine(row);

                    if (line.StartsWith("Your name:"))
                    {
                        string line1 = line;
                        line1 = line1.Replace("Your name: ", "");
                        dataGridView1.Rows.Add(line1);
                    }
                    else { }

                    if (line.StartsWith("Your email: "))
                    {
                        string line1 = line;
                        line1 = line1.Replace("Your email: ", "");
                        dataGridView1.Rows[row].Cells[1].Value = line1;
                        
                    }
                    else { }

                    if (line.StartsWith("Your phone number: "))
                    {
                        string line1 = line;
                        line1 = line1.Replace("Your phone number: ", "");
                        dataGridView1.Rows[row].Cells[2].Value = line1;
                        
                    }
                    else { }

                    if (line.StartsWith("Preferred method of contact: "))
                    {
                        string line1 = line;
                        line1 = line1.Replace("Preferred method of contact: ", "");
                        dataGridView1.Rows[row].Cells[3].Value = line1;
                       
                    }
                    else { }

                    if (line.StartsWith("Reason for contacting us: "))
                    {
                        string line1 = line;
                        line1 = line1.Replace("Reason for contacting us: ", "");
                        dataGridView1.Rows[row].Cells[4].Value = line1;
                       
                    }
                    else { }
                    if (line.StartsWith("Message: "))
                    {
                        string line1 = line;
                        line1 = line1.Replace("Message: ", "");
                        dataGridView1.Rows[row].Cells[5].Value = line1;
                        row++;
                    }
                    else { }
                    

                }
                dataGridView1.AutoResizeColumns();

            }
            else
            {
                string message = "Please choose a msg file";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }


    }
}
