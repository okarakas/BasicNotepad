using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_NotePad
{
    public partial class Find : Form
    {
        Form1 f1 = (Form1)Application.OpenForms["Form1"];
        public Find()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = textBox1.Text;
            if (word == string.Empty)
                return;
            f1.richTextBox1.SelectAll();
            f1.richTextBox1.SelectionBackColor = Color.White;

            if (checkBox1.Checked == true)
            {
                int s_start = f1.richTextBox1.SelectionStart, startIndex = 0, index;

                while ((index = f1.richTextBox1.Text.IndexOf(word, startIndex)) != -1)
                {
                    f1.richTextBox1.Select(index, word.Length);
                    f1.richTextBox1.SelectionBackColor = Color.LightBlue;

                    startIndex = index + word.Length;
                }

                f1.richTextBox1.SelectionStart = s_start;
                f1.richTextBox1.SelectionLength = 0;
                f1.richTextBox1.SelectionColor = Color.Black;
            }
            else
            {
                int s_start = f1.richTextBox1.SelectionStart, startIndex = 0, index;

                while ((index = f1.richTextBox1.Text.IndexOf(word, startIndex, StringComparison.CurrentCultureIgnoreCase)) != -1)
                {
                    f1.richTextBox1.Select(index, word.Length);
                    f1.richTextBox1.SelectionBackColor = Color.LightBlue;

                    startIndex = index + word.Length;
                }

                f1.richTextBox1.SelectionStart = s_start;
                f1.richTextBox1.SelectionLength = 0;
                f1.richTextBox1.SelectionColor = Color.Black;
            }
        }

        private void Find_FormClosing(object sender, FormClosingEventArgs e)
        {
            f1.richTextBox1.SelectAll();
            f1.richTextBox1.SelectionBackColor = Color.White;
        }
    }
}
