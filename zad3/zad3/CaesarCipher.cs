namespace zad3;

public static class CaesarCipher
{
    public static string Encrypt(string text, int shift)
    {
        shift = shift % 26;
        if (shift < 0) shift += 26;

        char[] result = text.ToCharArray();
        for (int i = 0; i < result.Length; i++)
        {
            char c = result[i];
            if (char.IsLetter(c))
            {
                char baseChar = char.IsUpper(c) ? 'A' : 'a';
                c = (char)(((c - baseChar + shift) % 26) + baseChar);
            }
            result[i] = c;
        }
        return new string(result);
    }

    public static string Decrypt(string text, int shift)
    {
        return Encrypt(text, -shift);
    }
}