using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ClubForm : Form
    {
        public ClubForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void addActivityLabel_Click(object sender, EventArgs e)
        {

        }

        private void BxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {

            string result = " ";

            foreach (string activity in BxEvents.SelectedItems) {
                result += activity + " ";
            }
               

            textBoxResult.Text = result;

        }

        private void addActivity_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            
            BxEvents.Items.Add(addActivity.Text);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            BxEvents.Items.Remove(addActivity.Text);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Gender_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void resultLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
