namespace Aula06_UC11_Teste02
{
    public partial class Form1 : Form
    {
        //Construtor  da classe Form1
        // Coment�rio 2

        //comentario do Alberto
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Testando");
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_exibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Nome do Usuario: {tb_nome.Text}");
        }
    }
}
