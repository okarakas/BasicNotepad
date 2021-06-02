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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile1 = new OpenFileDialog();
            openFile1.DefaultExt = "*.rtf";
            openFile1.Filter = "RTF Files|*.rtf";
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               openFile1.FileName.Length > 0)
            {
                richTextBox1.LoadFile(openFile1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();

            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "RTF Files|*.rtf";

            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo == true)
            {
                richTextBox1.Undo();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanRedo == true)
            {
                if (richTextBox1.RedoActionName != "Delete")
                    richTextBox1.Redo();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Regular")
            {
                richTextBox1.SelectionFont = new Font(comboBox1.Text, Convert.ToInt32(comboBox2.Text), FontStyle.Regular);
            }
            else if (comboBox3.Text == "Bold")
            {
                richTextBox1.SelectionFont = new Font(comboBox1.Text, Convert.ToInt32(comboBox2.Text), FontStyle.Bold);
            }
            else if (comboBox3.Text == "Underline")
            {
                richTextBox1.SelectionFont = new Font(comboBox1.Text, Convert.ToInt32(comboBox2.Text), FontStyle.Underline);
            }
            else if (comboBox3.Text == "Italic")
            {
                richTextBox1.SelectionFont = new Font(comboBox1.Text, Convert.ToInt32(comboBox2.Text), FontStyle.Italic);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Regular")
            {
                richTextBox1.SelectionFont = new Font(comboBox1.Text, Convert.ToInt32(comboBox2.Text), FontStyle.Regular);
            }
            else if (comboBox3.Text == "Bold")
            {
                richTextBox1.SelectionFont = new Font(comboBox1.Text, Convert.ToInt32(comboBox2.Text), FontStyle.Bold);
            }
            else if (comboBox3.Text == "Underline")
            {
                richTextBox1.SelectionFont = new Font(comboBox1.Text, Convert.ToInt32(comboBox2.Text), FontStyle.Underline);
            }
            else if (comboBox3.Text == "Italic")
            {
                richTextBox1.SelectionFont = new Font(comboBox1.Text, Convert.ToInt32(comboBox2.Text), FontStyle.Italic);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Regular")
            {
                richTextBox1.SelectionFont = new Font(comboBox1.Text, Convert.ToInt32(comboBox2.Text), FontStyle.Regular);
            }
            else if (comboBox3.Text == "Bold")
            {
                richTextBox1.SelectionFont = new Font(comboBox1.Text, Convert.ToInt32(comboBox2.Text), FontStyle.Bold);
            }
            else if (comboBox3.Text == "Underline")
            {
                richTextBox1.SelectionFont = new Font(comboBox1.Text, Convert.ToInt32(comboBox2.Text), FontStyle.Underline);
            }
            else if (comboBox3.Text == "Italic")
            {
                richTextBox1.SelectionFont = new Font(comboBox1.Text, Convert.ToInt32(comboBox2.Text), FontStyle.Italic);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            colorDialog1.Color = richTextBox1.SelectionColor;
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
      colorDialog1.Color != richTextBox1.SelectionColor)
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
                button5.ForeColor = colorDialog1.Color;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            colorDialog1.Color = richTextBox1.SelectionBackColor;
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
      colorDialog1.Color != richTextBox1.SelectionBackColor)
            {
                richTextBox1.SelectionBackColor = colorDialog1.Color;
                button6.BackColor = colorDialog1.Color;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionCharOffset = -3;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionCharOffset = +3;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form form2 = new Find();
            form2.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Are you sure you want to close?", "Closing...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialog == DialogResult.OK)
            {
                Environment.Exit(0);
            }
            else if (dialog == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
