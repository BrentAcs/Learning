// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var numberToText = new NumberToText.NumberToText();
int[] numbers = [12345, 54321];

foreach (var number in numbers)
{
   Console.WriteLine($"{number} is {numberToText.Convert(number)}");
}
