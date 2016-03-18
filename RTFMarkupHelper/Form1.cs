using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTFMarkupHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            string w_file = "RTFMarkupHelper.exe";
            string w_directory = System.IO.Directory.GetCurrentDirectory();

            DateTime c3 = System.IO.File.GetLastWriteTime(System.IO.Path.Combine(w_directory, w_file));            
            lblVersion.Text = "RTF Markup Helper | Build: " + c3.ToString("yyyyMMdd") + "." + c3.ToString("HHmmss");

            textSpecials.Text = "® © ™";
        }

        private void rtfBox_TextChanged(object sender, EventArgs e)
        {
            textBox.Text = rtfBox.Rtf.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblVersion_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Html);

            if (rtfBox.CanPaste(myFormat))
            {
                rtfBox.Paste(myFormat);         
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            rtfBox.Rtf = textBox.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("RTF Markup Helper is a simple C# app to make it easier to view, edit and convert RTF markup code.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // default/example RTF (direct from SLO project 20160317.01)
            rtfBox.Rtf = @"{\rtf1\ansi\ansicpg1252\deff0{\fonttbl{\f0\fswiss\fprq2\fcharset0 Franklin Gothic Book;}{\f1\froman\fprq2\fcharset0 Times New Roman;}{\f2\fnil Times New Roman;}}\viewkind4\uc1\pard\sl276\slmult1\lang1033\b\f0\fs22 D\'e9saccords\f1\par\b0\f0 Un d\'e9saccord est le terme utilis\'e9 lorsque le style de leadership que vous avez choisi pour vous-m\'eame ne r\'e9pond pas aux besoins de performance de la personne que vous influencez.\par\par\pard\sa200\sl276\slmult1 Plus le style de leadership est \'e9loign\'e9 du niveau de Performance Readiness\'ae (Maturit\'e9 (dans la performance)) du collaborateur qui est influenc\'e9, moins l\rquote interaction a de chances de r\'e9ussir. Ce ph\'e9nom\'e8ne peut \'e9galement \'eatre d\'e9fini comme le sur-dirigisme ou le sous-dirigisme.\par\pard\sl276\slmult1\b Sur-dirigisme\par\b0 Nous d\'e9finissons le sur-dirigisme comme l\rquote utilisation d\rquote un style de leadership actif o\'f9 le niveau de Performance Readiness\'ae (Maturit\'e9 (dans la performance)) de l\rquote individu qui est influenc\'e9 n\'e9cessite une implication moindre du leader.\f2\fs24\par}";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox.Text = rtfBox.Text = "";
        }
    }
}
