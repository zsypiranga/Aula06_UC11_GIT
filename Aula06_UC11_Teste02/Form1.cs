namespace Aula06_UC11_Teste02
{
    public partial class Form1 : Form
    {
        //Construtor  da classe Form1
        // Comentário 2
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Testando");
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
