namespace GerarSenhaWindowsCaixa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Clear();
            button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PasswordGeneratorService passwordGeneratorService = new();

            try
            {
                string nomePais = textBox1.Text.ToString();

                if (!string.IsNullOrEmpty(nomePais) && !string.IsNullOrWhiteSpace(nomePais))
                {
                    string senha = passwordGeneratorService.NovaSenha(nomePais);
                    MessageBox.Show(senha, "Sua nova senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (textBox1.Text.Length > 0)
                {
                    button2.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                button2.Enabled = true;
            }
        }
    }
}
