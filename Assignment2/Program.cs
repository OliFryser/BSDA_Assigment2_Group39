using System.Text.RegularExpressions;


foreach (var wizard in WizardCollection.Create())
{
    Console.WriteLine(wizard);

            var str = "Hi!. my name........... is,,,,,!!!?? Benjamin !!yes.maybe,true";

Regex pattern = new Regex(@"\P{L}+");
    string[] words = pattern.Split(str);

    foreach (var word in words)
    {
        Console.WriteLine(word);
    }

    Console.WriteLine(str.Split(@"\P{L}+").Length);

}
