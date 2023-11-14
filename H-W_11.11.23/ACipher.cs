using System;
class ACipher : ICipher
{
    public string Encode(string text)
    {
        string result = "";
        foreach (char c in text)
        {
            if (Char.IsLetter(c))
            {
                int shifted = (char)(c + 1);
                if (shifted > 'z') shifted -= 26;
                result += shifted;
            }
            else
            {
                result += c;
            }
        }
        return result;
    }
    public string Decode(string text)
    {
        string result = "";
        foreach (char c in text)
        {
            if (Char.IsLetter(c))
            {
                int shifted = (char)(c - 1);
                if (shifted < 'a') shifted += 26;
                result += shifted;
            }
            else
            {
                result += c;
            }
        }
        return result;
    }
}