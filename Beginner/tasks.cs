//ALL TASKS TAKED FROM https://acmp.ru

//BEFORE YOU USE SCRIPTS CHOOSE ONLY ONE OF THEM AND COMMENT OUT THE OTHERS OR THERE WILL BE BUGS
//BEFORE YOU USE SCRIPTS CHOOSE ONLY ONE OF THEM AND COMMENT OUT THE OTHERS OR THERE WILL BE BUGS
//BEFORE YOU USE SCRIPTS CHOOSE ONLY ONE OF THEM AND COMMENT OUT THE OTHERS OR THERE WILL BE BUGS
//BEFORE YOU USE SCRIPTS CHOOSE ONLY ONE OF THEM AND COMMENT OUT THE OTHERS OR THERE WILL BE BUGS
//BEFORE YOU USE SCRIPTS CHOOSE ONLY ONE OF THEM AND COMMENT OUT THE OTHERS OR THERE WILL BE BUGS




//THIS TASKS ONLY FOR BEGINNERS!!!!
//1 task
int a = int.Parse(Console.ReadLine());
int b = 0;
if (a >= 1)
{
    for (int i = 1; i <= a; i++)
        b += i;
}
else { 
    for (int i = a; i <= 1; i++)
        b += i;
}
Console.WriteLine(b);



//2 task
int b = 10;
while (true)
{
    int a = int.Parse(Console.ReadLine());
    if (a > b)
        Console.WriteLine("Number is smaller");
    else if (a < b)
        Console.WriteLine("Number is bigger");
    else
    {
        Console.WriteLine("Congraits! You write a correct number");
        break;
    }
}



//3 task
Console.WriteLine((Console.ReadLine().Contains("0")) ? "no" : "yes"); 
var a = 2;
Console.WriteLine((a == 2) ? "=" : ((a < 2) ? "<" : ">"));



//4 task
string input = Console.ReadLine();
string result = ValidateMove(input);
Console.WriteLine(result);
static string ValidateMove(string move)
{
    if (move.Length != 5 || move[2] != '-')
        return "error";

    char fromColumn = move[0];
    char fromRow = move[1];
    char toColumn = move[3];
    char toRow = move[4];

    if (!IsWithinBoard(fromColumn, fromRow) || !IsWithinBoard(toColumn, toRow))
        return "error";

    int columnDiff = Math.Abs(fromColumn - toColumn);
    int rowDiff = Math.Abs(fromRow - toRow);

    if ((columnDiff == 2 && rowDiff == 1) || (columnDiff == 1 && rowDiff == 2))
        return "yes";
    else
        return "no";
}
static bool IsWithinBoard(char column, char row)
{
    return column >= 'A' && column <= 'H' && row >= '1' && row <= '8';
}



//5 task
int pos = int.Parse(Console.ReadLine());
string word = Console.ReadLine();
string result = word.Remove(pos - 1, 1);
Console.WriteLine(result);



//6 task
Console.Write("enter: ");
int num = int.Parse(Console.ReadLine());
string bs = Convert.ToString(num, 2);
int co = 0;
foreach (char c in bs)
{
    if (c == '1')
        co++;
}
Console.WriteLine($"{co}");



//7 task
int num = int.Parse(Console.ReadLine());
string bs = Convert.ToString(num, 2);
char[] ca = bs.ToCharArray();
Array.Reverse(ca);
string rbs = new string(ca);
int rslt = Convert.ToInt32(rbs, 2);
Console.WriteLine($"{rslt}");
