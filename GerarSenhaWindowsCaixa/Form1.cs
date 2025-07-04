using System.Text.RegularExpressions;

namespace GerarSenhaWindowsCaixa;

public partial class Form1 : Form
{
    [GeneratedRegex(@"[^a-zA-Z0-9\s]")]
    private static partial Regex AlphaNumericRegex();

    public Form1()
    {
        InitializeComponent();
        textBox1.Clear();
        button2.Enabled = false;
        button3.Visible = false;
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

                Clipboard.SetText(senha);

                MessageBox.Show("Sua senha foi copiada para a área de transferência: " +
                    senha, "Sua nova senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
        e.Handled = e.KeyChar == (char)Keys.Space;

        if (AlphaNumericRegex().IsMatch(e.KeyChar.ToString()))
        {
            e.Handled = true;
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        PasswordGeneratorService passwordGeneratorService = new();

        try
        {
            string password = passwordGeneratorService.NovaSenhaForte();

            Clipboard.SetText(password);

            MessageBox.Show("Sua senha foi copiada para a área de transferência: " + password, "Sua nova senha Forte", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBox1.Checked)
        {
            button1.Visible = false;
            button3.Visible = true;
            textBox1.Enabled = false;
        }
        else
        {
            button1.Visible = true;
            button3.Visible = false;
            textBox1.Enabled = true;
        }
    }
}