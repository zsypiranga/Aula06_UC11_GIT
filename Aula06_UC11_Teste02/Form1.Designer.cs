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
            label1 = new Label();
            tb_nome = new TextBox();
            bt_exibir = new Button();
            ((System.ComponentModel.ISupportInitialize)sair).BeginInit();
            SuspendLayout();
            // 
            // sair
            // 
            sair.BackgroundImageLayout = ImageLayout.None;
            sair.Image = (Image)resources.GetObject("sair.Image");
            sair.Location = new Point(418, 0);
            sair.Name = "sair";
            sair.Size = new Size(52, 50);
            sair.TabIndex = 0;
            sair.TabStop = false;
            sair.Click += sair_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 1;
            label1.Text = "Nome do usuário";
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(12, 53);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(247, 23);
            tb_nome.TabIndex = 2;
            // 
            // bt_exibir
            // 
            bt_exibir.Location = new Point(135, 82);
            bt_exibir.Name = "bt_exibir";
            bt_exibir.Size = new Size(124, 23);
            bt_exibir.TabIndex = 3;
            bt_exibir.Text = "Exibir Nome";
            bt_exibir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(468, 359);
            Controls.Add(bt_exibir);
            Controls.Add(tb_nome);
            Controls.Add(label1);
            Controls.Add(sair);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)sair).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox sair;
        private Label label1;
        private TextBox tb_nome;
        private Button bt_exibir;
    }
}
