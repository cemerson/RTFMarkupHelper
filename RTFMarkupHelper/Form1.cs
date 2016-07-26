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

		RichTextStripper rtfStrip;

		public Form1()
		{
			InitializeComponent();

			rtfStrip = new RichTextStripper();
						
			string w_file = "RTFMarkupHelper.exe";
			string w_directory = System.IO.Directory.GetCurrentDirectory();

			DateTime c3 = System.IO.File.GetLastWriteTime(System.IO.Path.Combine(w_directory, w_file));            
			lblVersion.Text = "RTF Markup Helper | Build: " + c3.ToString("yyyyMMdd") + "." + c3.ToString("HHmmss");

		}
		public static string TrimNewLines(string text)
		{
            //while (text.EndsWith(Environment.NewLine))
            //{
            //    text = text.Substring(0, text.Length - Environment.NewLine.Length);
            //}

            //while (text.Contains(Environment.NewLine))
            //{
            //    text = text.Substring(0, text.Length - Environment.NewLine.Length);
            //}
            // return text; // return text.Trim();
            // return text.ToString().Trim(Environment.NewLine.ToCharArray());
            // return text.Replace("\n\r", "");
            text = text.Replace(System.Environment.NewLine, "");
            text = text.Replace("} ", "}");
            return text;

        }

        private void rtfBox_TextChanged(object sender, EventArgs e)
		{
			string rtfString = rtfBox.Rtf.ToString();
			textBox.Text = TrimNewLines(rtfString); // DecodeEscapedCharacters(ConvertToRtf(rtfString));  //ConvertToRtf(rtfString); // rtfBox.Rtf.ToString();            
			//GetRtfUnicodeEscapedString(rtfBox.Rtf.ToString());
		   //  string myText = rtfBox.Rtf. File.ReadAllText(myFilePath, Encoding.Unicode);


		}

		public static string GetRtfUnicodeEscapedString(string s)
		{
			var sb = new StringBuilder();
			foreach (var c in s)
			{
				if (c <= 0x7f)
					sb.Append(c);
				else
					// sb.Append("\\u" + Convert.ToUInt32(c) + "?");
					sb.Append(Convert.ToChar(c));
			}
			return sb.ToString();
		}

		public static string ConvertToRtf(string rtfText)
		{
			int findUTF = -1;
			bool continueUTFSearch = true;
			string esacpeddString = "";

			do
			{
				findUTF = rtfText.IndexOf(@"\'", findUTF + 1);
				if (findUTF != -1)
				{
					string replacedString = rtfText.Substring(findUTF, 4);
					esacpeddString = replacedString.Substring(2);

					int esacpeddCharValue = Convert.ToInt16(esacpeddString, 16);
					char esacpeddChar = Convert.ToChar(esacpeddCharValue);

					esacpeddString = esacpeddChar.ToString();

					rtfText = rtfText.Replace(replacedString, esacpeddString);
					findUTF = -1;
				}
				else
				{
					continueUTFSearch = false;
				}
			} while (continueUTFSearch);

			return rtfText;

		}	

	
	
		public static string DecodeEscapedCharacters(string escapedCharString){
		
				// string s = "具有靜電產生裝置之影像輸入裝置"; // Unicode
				Encoding Windows1252 = Encoding.GetEncoding("Windows-1252");
				Encoding Utf8 = Encoding.UTF8;
				byte[] utf8Bytes = Utf8.GetBytes(escapedCharString); // Unicode -> UTF-8
				//string badDecode = Windows1252.GetString(utf8Bytes); // Mis-decode as Latin1
				Console.WriteLine("Escaped: " + escapedCharString);  // Shows your garbage string.
				string goodDecode = Utf8.GetString(utf8Bytes); // Correctly decode as UTF-8
				Console.WriteLine("Decoded: " + goodDecode);

				// Recovering from bad decode...
				byte[] originalBytes = Windows1252.GetBytes(escapedCharString);
				goodDecode = Utf8.GetString(originalBytes);
				Console.WriteLine("Confirm Decode: " + goodDecode);
		
			return goodDecode;
		
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
			textBox.Text = TrimNewLines(textBox.Text);
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
			// default/example RTF 
			rtfBox.Rtf = @"{\rtf1\ansi\ansicpg1252\deff0{\fonttbl{\f0\fswiss\fprq2\fcharset0 Franklin Gothic Book;}{\f1\froman\fprq2\fcharset0 Times New Roman;}}\viewkind4\uc1\pard\sl276\slmult1\lang1033\b\f0\fs22 Header 1\f1\par\b0\f0 This is a paragraph of text. This is a paragraph of text.This is a paragraph of text. This is a paragraph of text. This is a paragraph of text. This is a paragraph of text. This is a paragraph of text. This is a paragraph of text.\par\par\b Cabecera 2\par\b0 es un p\'e1rrafo de texto. Este es un p\'e1rrafo de text.This es un p\'e1rrafo de texto. Este es un p\'e1rrafo de texto. Este es un p\'e1rrafo de texto. Este es un p\'e1rrafo de texto. Este es un p\'e1rrafo de texto. Este es un p\'e1rrafo de texto.\par}";
		}

		private void button5_Click(object sender, EventArgs e)
		{
			textBox.Text = rtfBox.Text = "";
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button6_Click(object sender, EventArgs e)
		{
			
			if (rtfBox.SelectionCharOffset > 0)
			{
				rtfBox.SelectionCharOffset = 0;
				// rtfBox.SelectionFont = new Font(rtfBox.SelectionFont.FontFamily, rtfBox.SelectionFont.Size + 4);
			}
			else
			{
				rtfBox.SelectionCharOffset = 4;
				// rtfBox.SelectionFont = new Font(rtfBox.SelectionFont.FontFamily, rtfBox.SelectionFont.Size - 4);
			}
			
		}

		private void formatBold_Click(object sender, EventArgs e)
		{
			rtfBox.SelectionFont = new Font(rtfBox.Font,
				rtfBox.SelectionFont.Style ^ FontStyle.Bold);
		}

		private void formatItalic_Click(object sender, EventArgs e)
		{
			rtfBox.SelectionFont = new Font(rtfBox.Font,
				rtfBox.SelectionFont.Style ^ FontStyle.Italic);
		}

		private void formatUnderline_Click(object sender, EventArgs e)
		{
			rtfBox.SelectionFont = new Font(rtfBox.Font,
				rtfBox.SelectionFont.Style ^ FontStyle.Underline);
		}

		private void insertSymbolC_Click(object sender, EventArgs e)
		{
			insertCharacter("©");
		}

		private void insertCharacter(string insertString)
		{            
			var selectionIndex = rtfBox.SelectionStart;
			rtfBox.Text = rtfBox.Text.Insert(selectionIndex, insertString);
			rtfBox.SelectionStart = selectionIndex + insertString.Length;
		}

		private void insertSymbolTM_Click(object sender, EventArgs e)
		{
			insertCharacter("™");
		}

		private void insertSymbolR_Click(object sender, EventArgs e)
		{
			insertCharacter("®");
		}


		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			string fontSizeString = tbFontSize.Text;
			if (String.IsNullOrEmpty(fontSizeString)) return;
			int fontSize = Convert.ToInt16(tbFontSize.Text);
			if (fontSize <= 0) return;
			rtfBox.SelectionFont = new Font(rtfBox.SelectionFont.FontFamily, fontSize);
		}

		private void button6_Click_1(object sender, EventArgs e) {

			String rtfMarkupExcerpt = rtfStrip.StripRichTextFormat(rtfBox.Rtf); // rtfBox.Text.Substring(rtfBox.SelectionStart, rtfBox.SelectionLength);

			MessageBox.Show(
				"SelectedRTF:\n" + rtfBox.SelectedRtf + 
				"\nLength:\n" + rtfBox.SelectionLength +
				"\nStart:\n" + rtfBox.SelectionStart +
				"\nRTF:\n" + rtfMarkupExcerpt);
		}

		private void btTextDirection_Click(object sender, EventArgs e)
		{
			var isRTL = rtfBox.RightToLeft.ToString();
			if(isRTL.ToUpper() == "NO")
			{                
				rtfBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
				btTextDirection.Text = "Right-to-Left";
			}
			else
			{
				rtfBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
				btTextDirection.Text = "Left-to-Right";
			}

			rtfBox_TextChanged(null, null);
		}
	}
}
