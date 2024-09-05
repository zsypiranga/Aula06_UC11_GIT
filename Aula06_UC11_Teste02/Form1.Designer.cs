namespace Aula06_UC11_Teste02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            sair = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)sair).BeginInit();
            SuspendLayout();
            // 
            // sair
            // 
            sair.BackgroundImageLayout = ImageLayout.None;
            sair.Image = (Image)resources.GetObject("sair.Image");
            sair.Location = new Point(453, 12);
            sair.Name = "sair";
            sair.Size = new Size(52, 50);
            sair.TabIndex = 0;
            sair.TabStop = false;
            sair.Click += sair_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(517, 327);
            Controls.Add(sair);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)sair).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox sair;
    }
}
