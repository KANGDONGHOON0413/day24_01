using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day24_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            domainUpDown2.SelectedIndex = 0;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {                
                if (domainUpDown1.SelectedIndex == -1) throw new Exception("과일을 선택해 주세요.");
                if (numericUpDown1.Value == 0) throw new Exception("개수를 확인해 주세요.");
                textBox1.Text = "과일: " + domainUpDown1.Text;
                textBox1.Text += ", 개수: " + numericUpDown1.Value.ToString();
                textBox1.Text += ", 배송지: " + domainUpDown2.Text;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            domainUpDown2.Items.Add(domainUpDown2.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            //pictureBox1.Image = Image.FromFile("default.jpg");
            ImageChange("default");
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            ImageChange(domainUpDown1.Text);
        }

        public void ImageChange(string S)
        {
            pictureBox1.Image = Image.FromFile(S + ".jpg");
        }
    }
}
