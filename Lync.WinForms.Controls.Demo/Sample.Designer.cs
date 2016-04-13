namespace Lync.WinForms.Controls.Demo
{
    partial class Sample
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
            this.presenceIndicator = new Lync.WinForms.Controls.PresenceIndicator();
            this.SuspendLayout();
            // 
            // presenceIndicator1
            // 
            this.presenceIndicator.Location = new System.Drawing.Point(34, 12);
            this.presenceIndicator.Name = "presenceIndicator1";
            this.presenceIndicator.Size = new System.Drawing.Size(22, 23);
            this.presenceIndicator.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.presenceIndicator);
            this.Name = "Sample";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Lync.WinForms.Controls.PresenceIndicator presenceIndicator;
    }
}

