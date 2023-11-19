namespace ReversedSentences;

public class Reverse
{
    public void Rvrs()
    {
        Console.Write("Enter the word to be reversed: ");
        string sentence = Console.ReadLine();

        string reversed = "";

        for (int i = sentence.Length - 1; i >= 0; i--)
        {
            reversed += sentence[i];
        }

        Console.WriteLine(reversed);
    }
}