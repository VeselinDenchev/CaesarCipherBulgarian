using System.Text;

using CaesarCipherBulgarian;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Console.WriteLine("Въведeтe текст с български букви, шифриран чрез шифър на Цезар, който да бъде дешифриран: ");
string input = Console.ReadLine()?.ToUpper() ?? string.Empty;

Console.WriteLine();

CaesarCipherBulgarianDecryptor.PrintAllCaesarCipherPossibilities(input);