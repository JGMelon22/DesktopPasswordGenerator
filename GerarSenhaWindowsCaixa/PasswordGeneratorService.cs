using System.Text;

namespace GerarSenhaWindowsCaixa;

public class PasswordGeneratorService
{
    public string NovaSenha(string nomeDoPais)
    {
        IDictionary<char, char> vogaisParaNumeros = new Dictionary<char, char>()
        {
            { 'A', '4' },
            { 'E', '3' },
            { 'I', '1' },
            { 'O', '0' },
            { 'U', '9' }
        };

        StringBuilder stringBuilder = new();

        foreach (char c in nomeDoPais)
        {
            if (vogaisParaNumeros.ContainsKey(c))
                stringBuilder.Append(vogaisParaNumeros[c]);
            else
                stringBuilder.Append(c);
        }

        return stringBuilder.ToString();
    }
}