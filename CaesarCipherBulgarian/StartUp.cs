using System.Text;

using CaesarCipherBulgarian;

Console.InputEncoding = UTF8Encoding.Unicode;
Console.OutputEncoding = UTF8Encoding.Unicode;

Console.WriteLine("Въведeтe текст с български букви, шифриран чрез шифър на Цезар, който да бъде дешифриран: ");
string input = Console.ReadLine().ToUpper();

Console.WriteLine();

CaesarCipherBulgarianDecryptor.PrintAllCaesarCipherPossibilities(input);