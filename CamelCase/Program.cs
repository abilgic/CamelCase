
/// <summary>
/// S;M;plasticCup() => plastic cup
/// C;V;mobile phone => mobilePhone
/// C;C;coffee machine => CoffeeMachine
/// S;C;LargeSoftwareBook => large software book
/// C;M;white sheet of paper => whiteSheetOfPaper()
/// S;V;pictureFrame => picture frame
/// </summary>

//var cline = Console.ReadLine();
//var cline = "S;M;plasticCup()";
//var cline = "S;C;LargeSoftwareBook";
var cline = "S;V;pictureFrame";
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
    else if (splitted[1] == "C")
    {
        var uIndexList = UpperIndexes(splitted[2]);
        char[] lower = new char[uIndexList.Count];
        string[] substr1 = new string[uIndexList.Count];
        var resultstrc = "";
        for (int i = 0; i < uIndexList.Count; i++)
        {
            if (i + 2 < uIndexList.Count)
            {
                lower[i] = char.ToLower(splitted[2][uIndexList[i]]);
                lower[i + 1] = char.ToLower(splitted[2][uIndexList[i + 1]]);
                lower[i + 2] = char.ToLower(splitted[2][uIndexList[i + 2]]);

                splitted[2] = splitted[2].Replace(splitted[2][uIndexList[i]], lower[i]).Replace(splitted[2][uIndexList[i + 1]], lower[i + 1]).Replace(splitted[2][uIndexList[i + 2]], lower[i + 2]);

                substr1[i] = splitted[2].Substring(uIndexList[i], uIndexList[i + 1] - uIndexList[i]);
                substr1[i + 1] = splitted[2].Substring(uIndexList[i + 1], uIndexList[i + 2] - uIndexList[i + 1]);
                substr1[i + 2] = splitted[2].Substring(uIndexList[i + 2], splitted[2].Length - uIndexList[i + 2]);

                resultstrc = string.Concat(substr1[i], " ", substr1[i + 1], " ", substr1[i + 2]);

            }
        }
        Console.WriteLine(resultstrc);
    }
    else if (splitted[1] == "V")
    {
        var uIndexList = UpperIndexes(splitted[2]);
        char[] lower = new char[uIndexList.Count];
        //string[] substrv1 = new string[uIndexList.Count];
        var resultstrv = "";

        for (int i = 0; i < uIndexList.Count; i++)
        {
            if (i < uIndexList.Count)
            {
                lower[i] = char.ToLower(splitted[2][uIndexList[i]]);
                splitted[2] = splitted[2].Replace(splitted[2][uIndexList[i]], lower[i]);
                var substrv1 = splitted[2].Substring(0, uIndexList[i]);
                var substrv2 = splitted[2].Substring(uIndexList[i], splitted[2].Length - uIndexList[i]);
                resultstrv = string.Concat(substrv1, " ", substrv2);
            }
        }
        Console.WriteLine(resultstrv);
    }
}

List<int> UpperIndexes(string str)
{
    List<int> UpperIndexList = new List<int>();

    for (int i = 0; i < str.Length; i++)
    {
        if (char.IsUpper(str[i]))
        {
            UpperIndexList.Add(i);
        }
    }
    return UpperIndexList;
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