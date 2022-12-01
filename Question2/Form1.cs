using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 12001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }

            timer1.Enabled = true;
            statusBar.Maximum = 120;
            timer1.Interval = 1000;

            wikiBrowser.Navigate("https://en.m.wikipedia.org/wiki/Benjamin_Harrison");

            bhRadio.CheckedChanged += new EventHandler(this.BHRadio__CheckedChanged);
            fdrRadio.CheckedChanged += new EventHandler(this.FDRRadio__CheckedChanged);
            wjcRadio.CheckedChanged += new EventHandler(this.WJCRadio__CheckedChanged);
            jbRadio.CheckedChanged += new EventHandler(this.JBRadio__CheckedChanged);
            fpRadio.CheckedChanged += new EventHandler(this.FPRadio__CheckedChanged);
            gwbRadio.CheckedChanged += new EventHandler(this.GWBRadio__CheckedChanged);
            boRadio.CheckedChanged += new EventHandler(this.BORadio__CheckedChanged);
            jfkRadio.CheckedChanged += new EventHandler(this.JFKRadio__CheckedChanged);
            wmRadio.CheckedChanged += new EventHandler(this.WMRadio__CheckedChanged);
            rrRadio.CheckedChanged += new EventHandler(this.RRRadio__CheckedChanged);
            ddeRadio.CheckedChanged += new EventHandler(this.DDERadio__CheckedChanged);
            mvRadio.CheckedChanged += new EventHandler(this.MVRadio__CheckedChanged);
            gwRadio.CheckedChanged += new EventHandler(this.GWRadio__CheckedChanged);
            jaRadio.CheckedChanged += new EventHandler(this.JARadio__CheckedChanged);
            trRadio.CheckedChanged += new EventHandler(this.TRRadio__CheckedChanged);
            tjRadio.CheckedChanged += new EventHandler(this.TJRadio__CheckedChanged);

            allRadio.CheckedChanged += new EventHandler(this.AllRadio__CheckedChanged);
            demoRadio.CheckedChanged += new EventHandler(this.DemoRadio__CheckedChanged);
            repubRadio.CheckedChanged += new EventHandler(this.RepubRadio__CheckedChanged);
            demoRepubRadio.CheckedChanged += new EventHandler(this.DemoRepubRadio__CheckedChanged);
            fedRadio.CheckedChanged += new EventHandler(this.FedRadio__CheckedChanged);

            bhNumBox.KeyPress += new KeyPressEventHandler(this.BHNumBox__KeyPress);
            fdrNumBox.KeyPress += new KeyPressEventHandler(this.FDRNumBox__KeyPress);
            wjcNumBox.KeyPress += new KeyPressEventHandler(this.WJCNumBox__KeyPress);
            jbNumBox.KeyPress += new KeyPressEventHandler(this.JBNumBox__KeyPress);
            fpNumBox.KeyPress += new KeyPressEventHandler(this.FPNumBox__KeyPress);
            gwNumBox.KeyPress += new KeyPressEventHandler(this.GWNumBox__KeyPress);
            boNumBox.KeyPress += new KeyPressEventHandler(this.BONumBox__KeyPress);
            jfkNumBox.KeyPress += new KeyPressEventHandler(this.JFKNumBox__KeyPress);
            wmNumBox.KeyPress += new KeyPressEventHandler(this.WMNumBox__KeyPress);
            rrNumBox.KeyPress += new KeyPressEventHandler(this.RRNumBox__KeyPress);
            ddeNumBox.KeyPress += new KeyPressEventHandler(this.DDENumBox__KeyPress);
            mvNumBox.KeyPress += new KeyPressEventHandler(this.MVNumBox__KeyPress);
            gwbNumBox.KeyPress += new KeyPressEventHandler(this.GWBNumBox__KeyPress);
            jaNumBox.KeyPress += new KeyPressEventHandler(this.JANumBox__KeyPress);
            trNumBox.KeyPress += new KeyPressEventHandler(this.TRNumBox__KeyPress);
            tjNumBox.KeyPress += new KeyPressEventHandler(this.TJNumBox__KeyPress);

            bhNumBox.Validating += new CancelEventHandler(this.BHNumBox__Validating);
            fdrNumBox.Validating += new CancelEventHandler(this.FDRNumBox__Validating);
            wjcNumBox.Validating += new CancelEventHandler(this.WJCNumBox__Validating);
            jbNumBox.Validating += new CancelEventHandler(this.JBNumBox__Validating);
            fpNumBox.Validating += new CancelEventHandler(this.FPNumBox__Validating);
            gwNumBox.Validating += new CancelEventHandler(this.GWNumBox__Validating);
            boNumBox.Validating += new CancelEventHandler(this.BONumBox__Validating);
            jfkNumBox.Validating += new CancelEventHandler(this.JFKNumBox__Validating);
            wmNumBox.Validating += new CancelEventHandler(this.WMNumBox__Validating);
            rrNumBox.Validating += new CancelEventHandler(this.RRNumBox__Validating);
            ddeNumBox.Validating += new CancelEventHandler(this.DDENumBox__Validating);
            mvNumBox.Validating += new CancelEventHandler(this.MVNumBox__Validating);
            gwbNumBox.Validating += new CancelEventHandler(this.GWBNumBox__Validating);
            jaNumBox.Validating += new CancelEventHandler(this.JANumBox__Validating);
            trNumBox.Validating += new CancelEventHandler(this.TRNumBox__Validating);
            tjNumBox.Validating += new CancelEventHandler(this.TJNumBox__Validating);

            bhNumBox.MouseHover += new EventHandler(this.BHNumBox__MouseHover);
            fdrNumBox.MouseHover += new EventHandler(this.FDRNumBox__MouseHover);
            wjcNumBox.MouseHover += new EventHandler(this.WJCNumBox__MouseHover);
            jbNumBox.MouseHover += new EventHandler(this.JBNumBox__MouseHover);
            fpNumBox.MouseHover += new EventHandler(this.FPNumBox__MouseHover);
            gwbNumBox.MouseHover += new EventHandler(this.GWBNumBox__MouseHover);
            boNumBox.MouseHover += new EventHandler(this.BONumBox__MouseHover);
            jfkNumBox.MouseHover += new EventHandler(this.JFKNumBox__MouseHover);
            wmNumBox.MouseHover += new EventHandler(this.WMNumBox__MouseHover);
            rrNumBox.MouseHover += new EventHandler(this.RRNumBox__MouseHover);
            ddeNumBox.MouseHover += new EventHandler(this.DDENumBox__MouseHover);
            mvNumBox.MouseHover += new EventHandler(this.MVNumBox__MouseHover);
            gwNumBox.MouseHover += new EventHandler(this.GWNumBox__MouseHover);
            jaNumBox.MouseHover += new EventHandler(this.JANumBox__MouseHover);
            trNumBox.MouseHover += new EventHandler(this.TRNumBox__MouseHover);
            tjNumBox.MouseHover += new EventHandler(this.TJNumBox__MouseHover);

            exitButton.Click += new EventHandler(this.ExitButton__Click);
            imgBox.MouseEnter += new EventHandler(this.ImgBox__MouseEnter);
            imgBox.MouseLeave += new EventHandler(this.ImgBox__MouseLeave);
            wikiBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.WikiBrowser__DocumentCompleted);
            
        }
        bool bhCorrect = false;
        bool fdrCorrect = false;
        bool wjcCorrect = false;
        bool jbCorrect = false;
        bool fpCorrect = false;
        bool gwbCorrect = false;
        bool boCorrect = false;
        bool jfkCorrect = false;
        bool wmCorrect = false;
        bool rrCorrect = false;
        bool ddeCorrect = false;
        bool mvCorrect = false;
        bool gwCorrect = false;
        bool jaCorrect = false;
        bool trCorrect = false;
        bool tjCorrect = false;

        //president checked changded radio buttons
        private void BHRadio__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if(rb.Checked == true)
            {
                imgBox.Image = presidentsList.Images[1];
                wikiBrowser.Navigate("https://en.m.wikipedia.org/wiki/Benjamin_Harrison");
                urlBox.Text = "https://en.m.wikipedia.org/wiki/Benjamin_Harrison";
            }
            else { }

        }
        private void FDRRadio__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked == true)
            {
                imgBox.Image = presidentsList.Images[3];
                wikiBrowser.Navigate("https://en.m.wikipedia.org/wiki/Franklin_D_Roosevelt");
                urlBox.Text = "https://en.m.wikipedia.org/wiki/Franklin_D_Roosevelt";
            }
            else { }

        }
        private void WJCRadio__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked == true)
            {
                imgBox.Image = presidentsList.Images[14];
                wikiBrowser.Navigate("https://en.m.wikipedia.org/wiki/William_J_Clinton");
                urlBox.Text = "https://en.m.wikipedia.org/wiki/William_J_Clinton";
            }
            else { }

        }
        private void JBRadio__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked == true)
            {
                imgBox.Image = presidentsList.Images[7];
                wikiBrowser.Navigate("https://en.m.wikipedia.org/wiki/James_Buchanan");
                urlBox.Text = "https://en.m.wikipedia.org/wiki/James_Buchanan";
            }
            else { }

        }
        private void FPRadio__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked == true)
            {
                imgBox.Image = presidentsList.Images[5];
                wikiBrowser.Navigate("https://en.m.wikipedia.org/wiki/Franklin_Pierce");
                urlBox.Text = "https://en.m.wikipedia.org/wiki/Franklin_Pierce";
            }
            else { }

        }
        private void GWBRadio__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked == true)
            {
                imgBox.Image = presidentsList.Images[6];
                wikiBrowser.Navigate("https://en.m.wikipedia.org/wiki/George_W_Bush");
                urlBox.Text = "https://en.m.wikipedia.org/wiki/George_W_Bush";
            }
            else { }

        }
        private void BORadio__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked == true)
            {
                imgBox.Image = presidentsList.Images[0];
                wikiBrowser.Navigate("https://en.m.wikipedia.org/wiki/Barack_Obama");
                urlBox.Text = "https://en.m.wikipedia.org/wiki/Barack_Obama";
            }
            else { }

        }
        private void JFKRadio__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked == true)
            {
                imgBox.Image = presidentsList.Images[9];
                wikiBrowser.Navigate("https://en.m.wikipedia.org/wiki/John_F_Kennedy");
                urlBox.Text = "https://en.m.wikipedia.org/wiki/John_F_Kennedy";
            }
            else { }

        }
        private void WMRadio__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked == true)
            {
                imgBox.Image = presidentsList.Images[15];
                wikiBrowser.Navigate("https://en.m.wikipedia.org/wiki/William_McKinley");
                urlBox.Text = "https://en.m.wikipedia.org/wiki/William_McKinley";
            }
            else { }

        }
        private void RRRadio__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked == true)
            {
                imgBox.Image = presidentsList.Images[11];
                wikiBrowser.Navigate("https://en.m.wikipedia.org/wiki/Ronald_Reagan");
                urlBox.Text = "https://en.m.wikipedia.org/wiki/Ronald_Reagan";
            }
            else { }

        }
        private void DDERadio__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked == true)
            {
                imgBox.Image = presidentsList.Images[2];
                wikiBrowser.Navigate("https://en.m.wikipedia.org/wiki/Dwight_D_Eisenhower");
                urlBox.Text = "https://en.m.wikipedia.org/wiki/Dwight_D_Eisenhower";
            }
            else { }

        }
        private void MVRadio__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked == true)
            {
                imgBox.Image = presidentsList.Images[10];
                wikiBrowser.Navigate("https://en.m.wikipedia.org/wiki/Martin_VanBuren");
                urlBox.Text = "https://en.m.wikipedia.org/wiki/Martin_VanBuren";
            }
            else { }

        }
        private void GWRadio__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked == true)
            {
                imgBox.Image = presidentsList.Images[5];
                wikiBrowser.Navigate("https://en.m.wikipedia.org/wiki/George_Washington");
                urlBox.Text = "https://en.m.wikipedia.org/wiki/George_Washington";
            }
            else { }

        }
        private void JARadio__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked == true)
            {
                imgBox.Image = presidentsList.Images[8];
                wikiBrowser.Navigate("https://en.m.wikipedia.org/wiki/John_Adams");
                urlBox.Text = "https://en.m.wikipedia.org/wiki/John_Adams";
            }
            else { }

        }
        private void TRRadio__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked == true)
            {
                imgBox.Image = presidentsList.Images[12];
                wikiBrowser.Navigate("https://en.m.wikipedia.org/wiki/Theodore_Roosevelt");
                urlBox.Text = "https://en.m.wikipedia.org/wiki/Theodore_Roosevelt";
            }
            else { }

        }
        private void TJRadio__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked == true)
            {
                imgBox.Image = presidentsList.Images[13];
                wikiBrowser.Navigate("https://en.m.wikipedia.org/wiki/Thomas_Jefferson");
                urlBox.Text = "https://en.m.wikipedia.org/wiki/Thomas_Jefferson";
            }
            else { }

        }

        //filter checked changed radio buttons

        private void AllRadio__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked == true)
            {
                bhRadio.Checked = true;
                bhRadio.Visible = true;
                fdrRadio.Visible = true;
                wjcRadio.Visible = true;
                jbRadio.Visible = true;
                fpRadio.Visible = true;
                gwbRadio.Visible = true;
                boRadio.Visible = true;
                jfkRadio.Visible = true;
                wmRadio.Visible = true;
                rrRadio.Visible = true;
                ddeRadio.Visible = true;
                mvRadio.Visible = true;
                gwRadio.Visible = true;
                jaRadio.Visible = true;
                trRadio.Visible = true;
                tjRadio.Visible = true;
            }
        }
        private void DemoRadio__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked == true)
            {
                fdrRadio.Checked = true;
                bhRadio.Visible = false;
                fdrRadio.Visible = true;
                wjcRadio.Visible = true;
                jbRadio.Visible = true;
                fpRadio.Visible = true;
                gwbRadio.Visible = false;
                boRadio.Visible = true;
                jfkRadio.Visible = true;
                wmRadio.Visible = false;
                rrRadio.Visible = false;
                ddeRadio.Visible = false;
                mvRadio.Visible = true;
                gwRadio.Visible = false;
                jaRadio.Visible = false;
                trRadio.Visible = false;
                tjRadio.Visible = false;
            }
        }
        private void RepubRadio__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked == true)
            {
                bhRadio.Checked = true;
                bhRadio.Visible = true;
                fdrRadio.Visible = false;
                wjcRadio.Visible = false;
                jbRadio.Visible = false;
                fpRadio.Visible = false;
                gwbRadio.Visible = true;
                boRadio.Visible = false;
                jfkRadio.Visible = false;
                wmRadio.Visible = true;
                rrRadio.Visible = true;
                ddeRadio.Visible = true;
                mvRadio.Visible = false;
                gwRadio.Visible = false;
                jaRadio.Visible = false;
                trRadio.Visible = true;
                tjRadio.Visible = false;
            }
        }
        private void DemoRepubRadio__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked == true)
            {
                tjRadio.Checked = true;
                bhRadio.Visible = false;
                fdrRadio.Visible = false;
                wjcRadio.Visible = false;
                jbRadio.Visible = false;
                fpRadio.Visible = false;
                gwbRadio.Visible = false;
                boRadio.Visible = false;
                jfkRadio.Visible = false;
                wmRadio.Visible = false;
                rrRadio.Visible = false;
                ddeRadio.Visible = false;
                mvRadio.Visible = false;
                gwRadio.Visible = false;
                jaRadio.Visible = false;
                trRadio.Visible = false;
                tjRadio.Visible = true;
            }
        }
        private void FedRadio__CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked == true)
            {
                gwRadio.Checked = true;
                bhRadio.Visible = false;
                fdrRadio.Visible = false;
                wjcRadio.Visible = false;
                jbRadio.Visible = false;
                fpRadio.Visible = false;
                gwbRadio.Visible = false;
                boRadio.Visible = false;
                jfkRadio.Visible = false;
                wmRadio.Visible = false;
                rrRadio.Visible = false;
                ddeRadio.Visible = false;
                mvRadio.Visible = false;
                gwRadio.Visible = true;
                jaRadio.Visible = true;
                trRadio.Visible = false;
                tjRadio.Visible = false;
            }
        }

        //president keypress text boxes

        private void BHNumBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
            if(statusBar.Value < statusBar.Maximum)
            {

            }else if(statusBar.Value == statusBar.Maximum)
            {
                timer1.Tick += new EventHandler(this.TimerMove__Tick);
            }
            
        }
        private void FDRNumBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
            if (statusBar.Value < statusBar.Maximum)
            {

            }
            else if (statusBar.Value == statusBar.Maximum)
            {
                timer1.Tick += new EventHandler(this.TimerMove__Tick);
            }
        }
        private void WJCNumBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
            if (statusBar.Value < statusBar.Maximum)
            {

            }
            else if (statusBar.Value == statusBar.Maximum)
            {
                timer1.Tick += new EventHandler(this.TimerMove__Tick);
            }
        }
        private void JBNumBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
            if (statusBar.Value < statusBar.Maximum)
            {

            }
            else if (statusBar.Value == statusBar.Maximum)
            {
                timer1.Tick += new EventHandler(this.TimerMove__Tick);
            }
        }
        private void FPNumBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
            if (statusBar.Value < statusBar.Maximum)
            {

            }
            else if (statusBar.Value == statusBar.Maximum)
            {
                timer1.Tick += new EventHandler(this.TimerMove__Tick);
            }
        }
        private void GWBNumBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
            if (statusBar.Value < statusBar.Maximum)
            {

            }
            else if (statusBar.Value == statusBar.Maximum)
            {
                timer1.Tick += new EventHandler(this.TimerMove__Tick);
            }
        }
        private void BONumBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
            if (statusBar.Value < statusBar.Maximum)
            {

            }
            else if (statusBar.Value == statusBar.Maximum)
            {
                timer1.Tick += new EventHandler(this.TimerMove__Tick);
            }
        }
        private void JFKNumBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
            if (statusBar.Value < statusBar.Maximum)
            {

            }
            else if (statusBar.Value == statusBar.Maximum)
            {
                timer1.Tick += new EventHandler(this.TimerMove__Tick);
            }
        }
        private void WMNumBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
            if (statusBar.Value < statusBar.Maximum)
            {

            }
            else if (statusBar.Value == statusBar.Maximum)
            {
                timer1.Tick += new EventHandler(this.TimerMove__Tick);
            }
        }
        private void RRNumBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
            if (statusBar.Value < statusBar.Maximum)
            {

            }
            else if (statusBar.Value == statusBar.Maximum)
            {
                timer1.Tick += new EventHandler(this.TimerMove__Tick);
            }
        }
        private void DDENumBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
            if (statusBar.Value < statusBar.Maximum)
            {

            }
            else if (statusBar.Value == statusBar.Maximum)
            {
                timer1.Tick += new EventHandler(this.TimerMove__Tick);
            }
        }
        private void MVNumBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
            if (statusBar.Value < statusBar.Maximum)
            {

            }
            else if (statusBar.Value == statusBar.Maximum)
            {
                timer1.Tick += new EventHandler(this.TimerMove__Tick);
            }
        }
        private void GWNumBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
            if (statusBar.Value < statusBar.Maximum)
            {

            }
            else if (statusBar.Value == statusBar.Maximum)
            {
                timer1.Tick += new EventHandler(this.TimerMove__Tick);
            }
        }
        private void JANumBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
            if (statusBar.Value < statusBar.Maximum)
            {

            }
            else if (statusBar.Value == statusBar.Maximum)
            {
                timer1.Tick += new EventHandler(this.TimerMove__Tick);
            }
        }
        private void TRNumBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
            if (statusBar.Value < statusBar.Maximum)
            {

            }
            else if (statusBar.Value == statusBar.Maximum)
            {
                timer1.Tick += new EventHandler(this.TimerMove__Tick);
            }
        }
        private void TJNumBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
            if (statusBar.Value < statusBar.Maximum)
            {

            }
            else if (statusBar.Value == statusBar.Maximum)
            {
                timer1.Tick += new EventHandler(this.TimerMove__Tick);
            }
        }

        //president validate text boxes

        private void BHNumBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if(bhNumBox.Text == "23" || bhNumBox.Text == "023")
            {
                bhCorrect = true;
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
                
            }else if(bhNumBox.Text != "23" || bhNumBox.Text != "023")
            {
                this.errorProvider.SetError(tb, "Incorrect Number");
                e.Cancel = true;
                tb.Tag = false;
            }

            AllCorrect();
        }
        private void FDRNumBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (fdrNumBox.Text == "32" || fdrNumBox.Text == "032")
            {
                fdrCorrect = true;
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
                
            }
            else if (fdrNumBox.Text != "32" || fdrNumBox.Text != "032")
            {
                this.errorProvider.SetError(tb, "Incorrect Number");
                e.Cancel = true;
                tb.Tag = false;
            }

            AllCorrect();
        }
        private void WJCNumBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (wjcNumBox.Text == "42" || wjcNumBox.Text == "042")
            {
                wjcCorrect = true;
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
                
            }
            else if (wjcNumBox.Text != "42" || wjcNumBox.Text != "042")
            {
                this.errorProvider.SetError(tb, "Incorrect Number");
                e.Cancel = true;
                tb.Tag = false;
            }

            AllCorrect();
        }
        private void JBNumBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (jbNumBox.Text == "15" || jbNumBox.Text == "015")
            {
                jbCorrect = true;
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
               
            }
            else if (jbNumBox.Text != "15" || jbNumBox.Text != "015")
            {
                this.errorProvider.SetError(tb, "Incorrect Number");
                e.Cancel = true;
                tb.Tag = false;
            }

            AllCorrect();
        }
        private void FPNumBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (fpNumBox.Text == "14" || fpNumBox.Text == "014")
            {
                fpCorrect = true;
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
                
            }
            else if (fpNumBox.Text != "14" || fpNumBox.Text != "014")
            {
                this.errorProvider.SetError(tb, "Incorrect Number");
                e.Cancel = true;
                tb.Tag = false;
            }

            AllCorrect();
        }
        private void GWBNumBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (gwbNumBox.Text == "43" || gwbNumBox.Text == "043")
            {
                gwbCorrect = true;
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
                
            }
            else if (gwbNumBox.Text != "43" || gwbNumBox.Text != "043")
            {
                this.errorProvider.SetError(tb, "Incorrect Number");
                e.Cancel = true;
                tb.Tag = false;
            }

            AllCorrect();
        }
        private void BONumBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (boNumBox.Text == "44" || boNumBox.Text == "044")
            {
                boCorrect = true;
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
                
            }
            else if (boNumBox.Text != "44" || boNumBox.Text != "044")
            {
                this.errorProvider.SetError(tb, "Incorrect Number");
                e.Cancel = true;
                tb.Tag = false;
            }

            AllCorrect();
        }
        private void JFKNumBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (jfkNumBox.Text == "35" || jfkNumBox.Text == "035")
            {
                jfkCorrect = true;
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
               
            }
            else if (jfkNumBox.Text != "35" || jfkNumBox.Text != "035")
            {
                this.errorProvider.SetError(tb, "Incorrect Number");
                e.Cancel = true;
                tb.Tag = false;
            }

            AllCorrect();
        }
        private void WMNumBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (wmNumBox.Text == "25" || wmNumBox.Text == "025")
            {
                wmCorrect = true;
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
                
            }
            else if (wmNumBox.Text != "25" || wmNumBox.Text != "025")
            {
                this.errorProvider.SetError(tb, "Incorrect Number");
                e.Cancel = true;
                tb.Tag = false;
            }

            AllCorrect();
        }
        private void RRNumBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (rrNumBox.Text == "40" || rrNumBox.Text == "040")
            {
                rrCorrect = true;
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
                
            }
            else if (rrNumBox.Text != "40" || rrNumBox.Text != "040")
            {
                this.errorProvider.SetError(tb, "Incorrect Number");
                e.Cancel = true;
                tb.Tag = false;
            }

            AllCorrect();
        }
        private void DDENumBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (ddeNumBox.Text == "34" || ddeNumBox.Text == "034")
            {
                ddeCorrect = true;
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
                
            }
            else if (ddeNumBox.Text != "34" || ddeNumBox.Text != "034")
            {
                this.errorProvider.SetError(tb, "Incorrect Number");
                e.Cancel = true;
                tb.Tag = false;
            }

            AllCorrect();
        }
        private void MVNumBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (mvNumBox.Text == "8" || mvNumBox.Text == "08")
            {
                mvCorrect = true;
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
                
            }
            else if (mvNumBox.Text != "8" || mvNumBox.Text != "08")
            {
                this.errorProvider.SetError(tb, "Incorrect Number");
                e.Cancel = true;
                tb.Tag = false;
            }

            AllCorrect();
        }
        private void GWNumBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (gwNumBox.Text == "1" || gwNumBox.Text == "01")
            {
                gwCorrect = true;
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
                
            }
            else if (gwNumBox.Text != "1" || gwNumBox.Text != "01")
            {
                this.errorProvider.SetError(tb, "Incorrect Number");
                e.Cancel = true;
                tb.Tag = false;
            }

            AllCorrect();
        }
        private void JANumBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (jaNumBox.Text == "2" || jaNumBox.Text == "02")
            {
                jaCorrect = true;
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
                
            }
            else if (jaNumBox.Text != "2" || jaNumBox.Text != "02")
            {
                this.errorProvider.SetError(tb, "Incorrect Number");
                e.Cancel = true;
                tb.Tag = false;
            }

            AllCorrect();
        }
        private void TRNumBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (trNumBox.Text == "26" || trNumBox.Text == "026")
            {
                trCorrect = true;
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
                
            }
            else if (trNumBox.Text != "26" || trNumBox.Text != "026")
            {
                this.errorProvider.SetError(tb, "Incorrect Number");
                e.Cancel = true;
                tb.Tag = false;
            }

            AllCorrect();
        }
        private void TJNumBox__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tjNumBox.Text == "3" || tjNumBox.Text == "03")
            {
                tjCorrect = true;
                this.errorProvider.SetError(tb, null);
                e.Cancel = false;
                tb.Tag = true;
                
            }
            else if (tjNumBox.Text != "3" || tjNumBox.Text != "03")
            {
                this.errorProvider.SetError(tb, "Incorrect Number");
                e.Cancel = true;
                tb.Tag = false;
            }

            AllCorrect();
        }

        //president mouse hover text boxes

        private void BHNumBox__MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(bhNumBox, "Which # President?");
        }
        private void FDRNumBox__MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(fdrNumBox, "Which # President?");
        }
        private void WJCNumBox__MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(wjcNumBox, "Which # President?");
        }
        private void JBNumBox__MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(jbNumBox, "Which # President?");
        }
        private void FPNumBox__MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(fpNumBox, "Which # President?");
        }
        private void GWBNumBox__MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(gwbNumBox, "Which # President?");
        }
        private void BONumBox__MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(boNumBox, "Which # President?");
        }
        private void JFKNumBox__MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(jfkNumBox, "Which # President?");
        }
        private void WMNumBox__MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(wmNumBox, "Which # President?");
        }
        private void RRNumBox__MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(rrNumBox, "Which # President?");
        }
        private void DDENumBox__MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(ddeNumBox, "Which # President?");
        }
        private void MVNumBox__MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(mvNumBox, "Which # President?");
        }
        private void GWNumBox__MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(gwNumBox, "Which # President?");
        }
        private void JANumBox__MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(jaNumBox, "Which # President?");
        }
        private void TRNumBox__MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(trNumBox, "Which # President?");
        }
        private void TJNumBox__MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(tjNumBox, "Which # President?");
        }

        //other functionalities

        private void ExitButton__Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ImgBox__MouseEnter(object sender, EventArgs e)
        {
            imgBox.Width = 274;
            imgBox.Height = 294;
        }
        private void ImgBox__MouseLeave(object sender, EventArgs e)
        {
            imgBox.Width = 174;
            imgBox.Height = 194;
        }
        private void WikiBrowser__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webBrowser = (WebBrowser)sender;
            HtmlElementCollection htmlElementCollection;


            htmlElementCollection = webBrowser.Document.GetElementsByTagName("a");
            for(int i = 0; i < htmlElementCollection.Count; i++)
            {
                htmlElementCollection[i].SetAttribute("title", "Professor Schuh for President!");
            }
        }

        private void TimerMove__Tick(object sender, EventArgs e)
        {
            if (statusBar.Value != statusBar.Minimum)
            {

                statusBar.Value--;
            }
            else if(statusBar.Value == statusBar.Minimum)
            {
                timer1.Stop();
                statusBar.Value = statusBar.Maximum;
                bhNumBox.Text = "0";
                fdrNumBox.Text = "0";
                wjcNumBox.Text = "0";
                jbNumBox.Text = "0";
                fpNumBox.Text = "0";
                gwbNumBox.Text = "0";
                boNumBox.Text = "0";
                jfkNumBox.Text = "0";
                wmNumBox.Text = "0";
                rrNumBox.Text = "0";
                ddeNumBox.Text = "0";
                mvNumBox.Text = "0";
                gwNumBox.Text = "0";
                jaNumBox.Text = "0";
                trNumBox.Text = "0";
                tjNumBox.Text = "0";
            }
        }

        private void AllCorrect()
        {
            if(bhCorrect == true && fdrCorrect == true && wjcCorrect == true && jbCorrect == true && fpCorrect == true && gwbCorrect == true && boCorrect == true && jfkCorrect == true && wmCorrect == true && rrCorrect == true && ddeCorrect == true && mvCorrect == true && gwCorrect == true && jaCorrect == true && trCorrect == true && tjCorrect == true)  
            {
                timer1.Stop();
                wikiBrowser.Navigate("https://www.youtube.com/embed/18212B4yfLg?autoplay=1");
                exitButton.Enabled = true;
            }
            else { }
        }
    }
}
