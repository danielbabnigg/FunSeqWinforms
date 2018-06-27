using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunSeqWinforms
{
    public partial class NewEraPumpControl : Form
    {
        public NewEraPumpControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("yAy yoU cLicKed mE");
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hicheckbox.CheckedItems.Count != 0)
            {
                string s = "";
                for (int x = 0; x <= hicheckbox.CheckedItems.Count - 1; x++)
                {
                    s = s + "you checked: " + hicheckbox.CheckedItems[x].ToString() + "\n";
                }
                MessageBox.Show(s);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("The selected date is: " + dateTimePicker1.Text);
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            MessageBox.Show("you scrolled");
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("done");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you're on tab 1");
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("yay");
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("do you see me");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("good");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            MessageBox.Show("hinohi");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.webBrowser1.Navigate("http://www.microsoft.com");
        }
    }
}
