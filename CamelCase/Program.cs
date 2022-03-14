
//S;M;plasticCup() => plastic cup

Console.WriteLine("Hello, World!");

var cline = Console.ReadLine();

var splitted = cline.Split(';');

if (splitted[0] == "S")
{
    if (splitted[1] == "M")
    {
        int uindex = UpperIndex(splitted[2]);


    }

}


int UpperIndex(string str)
{
    foreach (char c in str)
    {
        if (char.IsUpper(c))
        {

        }
    }
    return 0;
}