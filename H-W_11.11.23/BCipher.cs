using System;
class BCipher : ICipher
{
    public string Encode(string text)
    {
        string result = "";
        foreach (char c in text)
        {
            if (Char.IsLetter(c))
            {
                int index = Char.IsUpper(c) ? 'Z' - c : 'z' - c;
                char shifted = (char)(Char.IsUpper(c) ? 'A' + index : 'a' + index);
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
        return Encode(text);
    }
}