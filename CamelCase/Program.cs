
/// <summary>
/// S;M;plasticCup() => plastic cup
/// C;V;mobile phone => mobilePhone
/// C;C;coffee machine => CoffeeMachine
/// S;C;LargeSoftwareBook => large software book
/// C;M;white sheet of paper => whiteSheetOfPaper()
/// S;V;pictureFrame => picture frame
/// </summary>



//var cline = Console.ReadLine();
var cline = "S;M;plasticCup()";

var splitted = cline.Split(';');

if (splitted[0] == "S")
{
    if (splitted[1] == "M")
    {
        int uindex = UpperIndex(splitted[2]);
        if (uindex != 999)
        {
            char[] charstrim = { '(', ')' };

            var str1 = splitted[2].Substring(0, uindex);
            var lower = char.ToLower(splitted[2][uindex]);

            var str2 = splitted[2].Substring(uindex + 1, splitted[2].Length - uindex - 1);
            str2 = str2.Trim(charstrim);
            var resultstr = string.Concat(str1, " ", lower.ToString(), str2);
            Console.WriteLine(resultstr);
        }

    }

}


int UpperIndex(string str)
{
    int retval = 999;

    for (int i = 0; i < str.Length; i++)
    {
        if (char.IsUpper(str[i]))
        {
            retval = i;
        }
    }
    return retval;
}