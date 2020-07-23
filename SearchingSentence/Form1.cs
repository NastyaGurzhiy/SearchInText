using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using System.Windows.Forms;

namespace SearchingSentence
{
    public partial class Form1 : Form
    {
        string fileName;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            if(oFDFile.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    txBFileName.Text = oFDFile.FileName;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void btnFindWord_Click(object sender, EventArgs e)
        {
            string word = txBSearchingWord.Text;
            try
            {
                StreamReader reader = new StreamReader(txBFileName.Text);
                string text = reader.ReadToEnd();
                Regex regex = new Regex($@"(\w|\s|[,()\\/""-])*{txBSearchingWord.Text}\s(\w|\s|[,()\\/""-])*\.");
                MatchCollection matchCollection =  regex.Matches(text);
                foreach (var item in matchCollection)
                {
                    txBFoundString.AppendText(item.ToString()+"\n");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }
    }
}
