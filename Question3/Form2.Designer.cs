namespace Question3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.funnyBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // funnyBrowser
            // 
            this.funnyBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.funnyBrowser.Location = new System.Drawing.Point(0, 0);
            this.funnyBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.funnyBrowser.Name = "funnyBrowser";
            this.funnyBrowser.Size = new System.Drawing.Size(800, 450);
            this.funnyBrowser.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.funnyBrowser);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser funnyBrowser;
    }
}