namespace ReversedWords;

public class Reverse
{
    public void Rvrs()
    {
        Console.Write("Enter the word to be reversed: ");
        string word = Console.ReadLine();

        string reversed = "";

        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversed += word[i];
        }

        Console.WriteLine(reversed);
    }
}