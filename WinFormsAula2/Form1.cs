namespace WinFormsAula2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = NomeB.Text;
            cliente.Senha = SenhaB.Text;
            cliente.Email = EmailB.Text;
            cliente.Estado = Estado.Text;
            MessageBox.Show("Cadastro realizado com sucesso!");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NomeB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}