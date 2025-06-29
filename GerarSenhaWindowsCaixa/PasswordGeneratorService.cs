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

    public string NovaSenhaForte()
    {
        Random random = new();

        char[] characters =
        [
            // Lowercase letters
            'a','b','c','d','e','f','g','h','i','j',
            'k','l','m','n','o','p','q','r','s','t',
            'u','v','w','x','y','z',
        
            // Uppercase letters
            'A','B','C','D','E','F','G','H','I','J',
            'K','L','M','N','O','P','Q','R','S','T',
            'U','V','W','X','Y','Z',
        
            // Digits
            '0','1','2','3','4','5','6','7','8','9',
        
            // Special characters
            '`','~','!','@','#','$','%','¨','&','*','(',')','-','=','_','+'
        ];

        byte passwordLenght = 10;
        StringBuilder stringBuilder = new(passwordLenght);

        for (int i = 0; i < passwordLenght; i++)
        {
            char randomChar = characters[random.Next(characters.Length)]; 
            stringBuilder.Append(randomChar);
        }

        return stringBuilder.ToString();
    }
}