using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Thread t = new Thread(new ThreadStart(Colors));

            t.Start();
            fakeButton.Click += new EventHandler(this.FakeButton__Click);
            realButton.Click += new EventHandler(this.RealButton__Click);
            fakeButton.MouseHover += new EventHandler(this.FakeButton__MouseHover);
            fNameBox.KeyPress += new KeyPressEventHandler(this.Stop__KeyPress);
            ssnBox.KeyPress += new KeyPressEventHandler(this.Stop__KeyPress);
            phoneBox.Validating += new CancelEventHandler(this.SetNum__Validating);
            mNameBox.KeyPress += new KeyPressEventHandler(this.RandTxt__KeyPress);
            lNameBox.KeyPress += new KeyPressEventHandler(this.RandTxt__KeyPress);
            emailBox.KeyPress += new KeyPressEventHandler(this.Stop__KeyPress);
            emailBox.KeyPress += new KeyPressEventHandler(this.EnableBoxesRow2__KeyPress);
            phoneBox.KeyPress += new KeyPressEventHandler(this.EnableBoxesRow2__KeyPress);
            homeBox.KeyPress += new KeyPressEventHandler(this.EnableBoxesRow3__KeyPress);
        }

        private void FakeButton__Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void FakeButton__MouseHover(object sender, EventArgs e)
        {
            var rand = new Random();
            int num1 = rand.Next(817);
            int num2 = rand.Next(490);

            if (fakeButton.Enabled == true)
            {
                fakeButton.Location= new Point(num1, num2);
            }
        }

        private void Stop__KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if(tb.TextLength == 5)
            {
                tb.Enabled= false;
            }

            ValidateAll();
        }

        private void RandTxt__KeyPress(object sender, KeyPressEventArgs e)
        {
            char word;
            Random rand = new Random();
            TextBox tb = (TextBox)sender;

            int num1 = rand.Next(27);

            word = Convert.ToChar(num1 + 65);

            e.KeyChar = word;

            if(tb.Text.Length > 3)
            {
                licenseBox.Enabled= false;
            }
            else if(tb.Text.Length < 3)
            {
                licenseBox.Enabled= true;
            }

            ValidateAll();
        }

        private void SetNum__Validating(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if(tb.Text != "8675309")
            {
                tb.Text = "8675309";
            }
            else { }
            ValidateAll();
        }

        public void Colors()
        {
            for (int i = 0; i < 120; i++)
            {
                var rand = new Random();
                int numR = rand.Next(256);
                int numG = rand.Next(256);
                int numB = rand.Next(256);
                BackColor = Color.FromArgb(numR, numG, numB);
                Thread.Sleep(30000);
            }
        }

        private void EnableBoxesRow2__KeyPress(object sender, KeyPressEventArgs e)
        {
            genderBox2.Visible = true;
            eyeBox2.Visible = true;
            hairBox2.Visible = true;
            genLabel.Text = "Sex";
            ValidateAll();
        }

        private void EnableBoxesRow3__KeyPress(object sender, KeyPressEventArgs e)
        {
            genderBox3.Visible = true;
            genLabel.Text = "Sex";
            emailBox.Location = new Point(426, 280);
            ssnBox.Location = new Point(105, 160);

            ValidateAll();
        }

        private void ValidateAll()
        {
            this.fakeButton.Enabled =
                (bool)this.fNameBox.Tag &&
                (bool)this.mNameBox.Tag &&
                (bool)this.lNameBox.Tag &&
                (bool)this.emailBox.Tag &&
                (bool)this.phoneBox.Tag &&
                (bool)this.homeBox.Tag &&
                (bool)this.ssnBox.Tag &&
                (bool)this.genderBox3.Tag &&
                (bool)this.eyeBox2.Tag &&
                (bool)this.hairBox2.Tag;

            this.realButton.Visible =
                (bool)this.fNameBox.Tag &&
                (bool)this.mNameBox.Tag &&
                (bool)this.lNameBox.Tag &&
                (bool)this.emailBox.Tag &&
                (bool)this.phoneBox.Tag &&
                (bool)this.homeBox.Tag &&
                (bool)this.ssnBox.Tag &&
                (bool)this.genderBox3.Tag &&
                (bool)this.eyeBox2.Tag &&
                (bool)this.hairBox2.Tag;
        }

        private void RealButton__Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
            Close();
        }

    }
}
