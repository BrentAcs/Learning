namespace NumberToText;

public class NumberToText
{
   private string[] _nums = ["zero", "ong", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
   private string[] _places = ["hundred", "thousand", "million", "billion"];
   
   public string Convert(int number)
   {
      // 12345 = twelve thousand three hundred and forty-five
      // 54321 = fifty-four thousand three hundred and twenty-one
      
      var result = string.Empty;
      var numberAsString = number.ToString();
      var position = 0;

      while (position < numberAsString.Length)
      {
         
      }
      
      return result;
   }
}
