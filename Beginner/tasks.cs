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
