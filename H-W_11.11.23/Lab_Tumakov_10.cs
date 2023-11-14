using H_W_11._11._23;
using System;
interface ICipher
{
    string Encode(string text);
    string Decode(string text);
}
interface IFigure
{
    void MoveHorizontal(int x);
    void MoveVertical(int y);
    void ChangeColor(string color);
}
class Program
{

    static void Main(string[] args)
    {
        //EX 10.1 Interface ICipher
        Console.WriteLine("EX 10.1 Interface ICipher");
        ICipher acipher = new ACipher();
        string encoded = acipher.Encode("Hello World!");
        string decoded = acipher.Decode(encoded);
        ICipher bcipher = new BCipher();
        encoded = bcipher.Encode("Hello World!");
        decoded = bcipher.Decode(encoded);
        Console.WriteLine($"encoded - {encoded}");
        Console.WriteLine("----------------------");
        Console.WriteLine($"decoded - {decoded}");
        Console.WriteLine("");
        //H-W 10.1 Class Figure
        Console.WriteLine("H-W 10.1 Class Figure");
        Figure f = new Circle();
        f.MoveHorizontal(10);
        f.Show();
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }

}