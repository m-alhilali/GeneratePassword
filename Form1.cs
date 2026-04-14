using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Color clr = new Color();
        void Reset()
        {
            
            CheckBox[] checkBoxes = { check123, checkMix, checkabs, checkABC, checkPunct };
            foreach (CheckBox check in checkBoxes)
            {
                check.Checked = false;
            }
            textPassword.Clear();
            btnCopy.Enabled = false;
            trackBar.Value = 0;
            lblLengthPassword.Text = "0";

        }
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd=new Random();

        void GeneratePassword()
        {
            if(!checkPunct.Checked&&!check123.Checked&&!checkABC.Checked&&!checkabs.Checked&&!checkMix.Checked)
            {
                MessageBox.Show("Check Any Type","Wrong",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            btnCopy.Enabled = true;
            textPassword.Text = string.Empty;
            if (trackBar.Value <= 0)
                return;
            List <char> list = new List<char>();
            if (!checkMix.Checked)
            {
                for (int i = 0; i < trackBar.Value; i++)
                {
                    if (checkPunct.Checked)
                        list.Add(((char)rnd.Next(33, 47)));
                    if (check123.Checked)
                        list.Add((char)rnd.Next(48, 57));
                    if (checkABC.Checked)
                        list.Add((char)rnd.Next(65, 90));
                    if (checkabs.Checked)
                        list.Add((char)rnd.Next(97, 122));
                }
                for (int i = 0; i < trackBar.Value; i++)
                {
                    textPassword.Text += list[rnd.Next(0, list.Count)];
                }
            }
            else
            {
                for (int i = 0; i < trackBar.Value; i++)
                {
                    textPassword.Text += (char)rnd.Next(33,122) ;
                }
            }
           
        }
        private void trackBar_Scroll(object sender, EventArgs e)
        {
            lblLengthPassword.Text=trackBar.Value.ToString();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GeneratePassword();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            textPassword.Copy();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            Reset();
        }

        private void ChangeButtonSize(object sender, EventArgs e)
        {
            Control btn = (Control)sender;
            btn.Size=new Size(btn.Width+4, btn.Height+4);
            clr = btn.ForeColor;
            btn.ForeColor=Color.Black;
        }

        private void ResetButtonSize(object sender, EventArgs e)
        {
            Control btn = (Control)sender;
            btn.Size = new Size(btn.Width - 4, btn.Height - 4);
            btn.ForeColor = clr;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }
    }
}
