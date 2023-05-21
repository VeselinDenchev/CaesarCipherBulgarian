namespace CaesarCipherBulgarian
{
    using System.Text;

    public static class CaesarCipherBulgarianDecryptor
    {
        private const string BULGARIAN_ALPHABET_STRING = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЬЮЯ";

        private static readonly List<char> bulgarianAlphabetCharArray = BULGARIAN_ALPHABET_STRING.ToCharArray().ToList();

        public static void PrintAllCaesarCipherPossibilities(string cipheredText)
        {
            if (!String.IsNullOrWhiteSpace(cipheredText))
            {
                StringBuilder decipheredTextPossibilitiesStringBuilder = new StringBuilder();
                decipheredTextPossibilitiesStringBuilder.AppendLine("Възможни варианти за оригиналния текст:");

                for (int i = 1; i < bulgarianAlphabetCharArray.Count; i++)
                {
                    foreach (char character in cipheredText)
                    {
                        if (bulgarianAlphabetCharArray.Contains(character))
                        {
                            int currentCharIndex = bulgarianAlphabetCharArray.IndexOf(character);
                            decipheredTextPossibilitiesStringBuilder.Append(bulgarianAlphabetCharArray[(currentCharIndex + i) % bulgarianAlphabetCharArray.Count]);
                        }
                        else if (character == ' ')
                        {
                            decipheredTextPossibilitiesStringBuilder.Append(character);
                        }
                        else
                        {
                            Console.WriteLine("Текстът съдържа символ, който не е от българската азбука!");
                            break;
                        }
                    }

                    decipheredTextPossibilitiesStringBuilder.AppendLine();
                }

                string decipheredTextPossibilities = decipheredTextPossibilitiesStringBuilder.ToString();
                Console.WriteLine(decipheredTextPossibilities);
            }
            else
            {
                Console.WriteLine("Празен текст!");
            }
        }
    }
}
