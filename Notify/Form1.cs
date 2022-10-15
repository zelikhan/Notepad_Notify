using System;
using System.Runtime.InteropServices;          //Library
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notify
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "Notify the up-version of Notepad";
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            System.IO.StreamReader OpenFile = new
System.IO.StreamReader(openFileDialog1.FileName);
            textBox1.Text = OpenFile.ReadToEnd();
            OpenFile.Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = " Please wrote your thoughts ";
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = " Notify the up-version of Notepad ";
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = " Close Notify ";
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void shareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = System.DateTime.Now.ToString();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument prntDoc = new System.Drawing.Printing.PrintDocument();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog1=new FontDialog();
            if (fontDialog1.ShowDialog() == DialogResult.OK)

            {

                textBox1.Font = fontDialog1.Font;

            }
        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                
                    textBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.ShowDialog();
            System.IO.StreamWriter SaveFile = new
            System.IO.StreamWriter(saveFileDialog1.FileName);
            SaveFile.WriteLine(textBox1.Text);
            SaveFile.Close();
        }
    }
}
