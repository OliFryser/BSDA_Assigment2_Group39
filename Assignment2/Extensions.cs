using System.Text.RegularExpressions;

namespace Assignment2;


public static class Extensions
{

public static bool IsSecure(this string str) => Regex.IsMatch(str, "(?i)^(s-http://).*");
  

public static int WordCount(this string str) => Regex.Split(str, @"\P{L}+").Length;





}
