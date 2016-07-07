using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        int count=0;
        Random rnd;
        char[] spec_chars = new char[] { '%', '*', ')', '?', '#', '$', '^', '&', '~' };

        public MainForm()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program include few little program, \nwitch will be used.", "About Program");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadNotepad();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            count++;
            lblCount.Text = count.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            count--;
            lblCount.Text = count.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            count = 0;
            lblCount.Text = Convert.ToString(count);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btngo_Click(object sender, EventArgs e)
        {
            int n;
            n = rnd.Next(Convert.ToInt32(nudfrom.Value), Convert.ToInt32(nudto.Value));
            lblrandom.Text = n.ToString();
            if (cbRandom.Checked)
            {
                int i = 0;
                while (tbRandom.Text.IndexOf(n.ToString()) != -1)
                {
                    n = rnd.Next(Convert.ToInt32(nudfrom.Value), Convert.ToInt32(nudto.Value));
                    i++;
                    if (i > 1000) break;
                }
                if (i <= 1000) tbRandom.AppendText(n + "\n");
            }
           else tbRandom.AppendText(n + "\n");
        }

        private void tbRandom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRandomClear_Click(object sender, EventArgs e)
        {
            tbRandom.Clear();
        }

        private void btnRandomCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbRandom.Text);
        }

        private void cbRandom_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tsmiInsertDate_Click(object sender, EventArgs e)
        {
           rtbNotepad.AppendText ("\n" + DateTime.Now.ToShortDateString() + "\n");
        }

        private void tsmiInsertTime_Click(object sender, EventArgs e)
        {
            rtbNotepad.AppendText("\n" + DateTime.Now.ToShortTimeString() + "\n");
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            try
            {
                rtbNotepad.SaveFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Save Error");
            }
        }

        void LoadNotepad()
        {
            try
            {
                rtbNotepad.LoadFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Loading Error");
            }
        }

private void tsmiLoad_Click(object sender, EventArgs e)
        {
            LoadNotepad();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void btnCreatePass_Click(object sender, EventArgs e)
        {
            if (clbPassTypeCheck.CheckedItems.Count == 0) return;
            string password = "";
            for (int i=0; i<nudPassLenght.Value;i++)
            {
                int n = rnd.Next(0, clbPassTypeCheck.CheckedItems.Count);
                string s = clbPassTypeCheck.CheckedItems[n].ToString();
                switch (s)
                {
                    case "Numbers": password += rnd.Next(10).ToString();
                        break;
                    case "Upper case": password += Convert.ToChar(rnd.Next(65,88));
                        break;
                    case "Lower case": password += Convert.ToChar(rnd.Next(97, 122));
                        break;
                    default:
                        password += spec_chars[rnd.Next(spec_chars.Length)];
                        break;
                }
                tbPass.Text = password;
            }
        }
    }
}
