// See https://aka.ms/new-console-template for more information
using CodeChanllengeIron.Business;

Console.WriteLine("Enter your input: ");
string input = Console.ReadLine() ?? throw new Exception("input cannot be null");
Console.WriteLine($"The output text: {KeypadTranslator.OldPhonePad(input)}");
