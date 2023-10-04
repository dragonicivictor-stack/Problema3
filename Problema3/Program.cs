namespace Problema3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti sirul de caractere: ");
            string text = Console.ReadLine();

            Console.WriteLine("Introduceti cuvantul cautat: ");
            string subtext = Console.ReadLine();

            int aparatii = 0;
            
            for (int i = 0; i <= text.Length - subtext.Length; i++)
            {
                if (text.Substring(i, subtext.Length).Equals(subtext, StringComparison.OrdinalIgnoreCase))
                {
                    aparatii++;
                }
            }

            Console.WriteLine("Cuvantul cautat apare de " + aparatii + " ori");

        }
    }
}