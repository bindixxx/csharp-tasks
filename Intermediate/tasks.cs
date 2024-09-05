//ALL TASKS TAKED FROM https://acmp.ru

//BEFORE YOU USE SCRIPTS CHOOSE ONLY ONE OF THEM AND COMMENT OUT THE OTHERS OR THERE WILL BE BUGS
//BEFORE YOU USE SCRIPTS CHOOSE ONLY ONE OF THEM AND COMMENT OUT THE OTHERS OR THERE WILL BE BUGS
//BEFORE YOU USE SCRIPTS CHOOSE ONLY ONE OF THEM AND COMMENT OUT THE OTHERS OR THERE WILL BE BUGS
//BEFORE YOU USE SCRIPTS CHOOSE ONLY ONE OF THEM AND COMMENT OUT THE OTHERS OR THERE WILL BE BUGS
//BEFORE YOU USE SCRIPTS CHOOSE ONLY ONE OF THEM AND COMMENT OUT THE OTHERS OR THERE WILL BE BUGS




//THIS TASKS ONLY FOR INTERMEDIATE!!!!
//1 task
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int x = a;
int y = b;
int c = 0;
int d = 0;
if (x == 0)
    c = y;
else
{
    while (y != 0)
    {
        if (x > y)
            x -= y;
        else
            y -= x;
    }
    c = x;
}
d = a * b / c;
Console.WriteLine(d);



//2 task
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());
for (int x = -100; x <= 100; x++)
{
    int result = a * x * x * x + b * x * x + c * x + d;
    if (result == 0)
        Console.Write($"{x}");
}



//3 task
string a = Console.ReadLine();
int result = 0;
for (int i = 0; i <= a.Length - 5; i++)
{
    if (a[i] == '>' && a[i + 1] == '>' && a[i + 2] == '-' && a[i + 3] == '-' && a[i + 4] == '>')
        result++;
    if (a[i] == '<' && a[i + 1] == '-' && a[i + 2] == '-' && a[i + 3] == '<' && a[i + 4] == '<')
        result++;
}
Console.WriteLine(result);



//4 task
var a = int.Parse(Console.ReadLine());
var b = int.Parse(Console.ReadLine());

List<int> original = new List<int>();
List<int> blue = new List<int>();
List<int> green = new List<int>();
List<int> red = new List<int>();
List<int> black = new List<int>();
for (int i = 1; i <= a; i++)
    for (int j = 1; j <= b; j++)
        original.Add(i * j);

for (int i = 0; i < original.Count; i++)
{
    if (original[i] % 5 != 0) blue.Add(original[i]);
}
Console.WriteLine(original.Count - blue.Count);

original = blue;
for (int i = 0; i < original.Count; i++)
{
    if (original[i] % 3 != 0) green.Add(original[i]);
}
Console.WriteLine(original.Count - green.Count);

original = green;

for (int i = 0; i < original.Count; i++)
{
    if (original[i] % 2 != 0) red.Add(original[i]);
}
Console.WriteLine(original.Count - red.Count);

original = red;

for (int i = 0; i < original.Count; i++)
{
    if (original[i] % 1 != 0) black.Add(original[i]);
}
Console.WriteLine(original.Count - black.Count);

original = black;



//5 task
List<int> command1 = new List<int>();
List<int> command2 = new List<int>();
int sumcommand1 = 0;
int sumcommand2 = 0;
for (int i = 0; i < 4; i++)
{
    string a = Console.ReadLine();
    command1.Add(int.Parse(a.Split(' ')[0]));
    command2.Add(int.Parse(a.Split(' ')[1]));
}
foreach (var item in command1)
    sumcommand1 += item;
foreach (var item in command2)
    sumcommand2 += item;
if (sumcommand1 > sumcommand2)
    Console.WriteLine("Command 1 won");
else if (sumcommand1 < sumcommand2)
    Console.WriteLine("Command 2 won");
else
    Console.WriteLine("draw");



//6 task
List<int> command1 = new List<int>();
List<int> command2 = new List<int>();
int sumcommand1 = 0;
int sumcommand2 = 0;
for (int i = 0; i < 4; i++)
{
    string a = Console.ReadLine();
    command1.Add(int.Parse(a.Split(' ')[0]));
    command2.Add(int.Parse(a.Split(' ')[1]));
}
foreach (var item in command1)
    sumcommand1 += item;
foreach (var item in command2)
    sumcommand2 += item;
if (sumcommand1 > sumcommand2)
    Console.WriteLine("Command 1 won");
else if (sumcommand1 < sumcommand2)
    Console.WriteLine("Command 2 won");
else
    Console.WriteLine("draw");


List<int> a = new List<int>();
for (int i = 0; i < 6; i++)
    a.Add(int.Parse(Console.ReadLine()));
for (int i = 0; i < a.Count - 1; i++)
{
    bool sorted = true;
    for (int j = 0; j < a.Count - 1 - i; j++)
    {
        if (a[j] > a[j + 1])
        {
            int temp = a[j];
            a[j] = a[j + 1];
            a[j + 1] = temp;
            sorted = false;
        }
    }
    if (sorted)
        break;
}
foreach (var item in a)
    Console.WriteLine(item);



//7 task
var b = Console.ReadLine().Split(' ');
var c = new List<int>();
foreach (var item in b)
    c.Add(int.Parse(item));
int left = 0;
int right = c.Count - 1;
while (left <= right)
{
    int middle = (left + right) / 2;
    if (c[middle] == 7)
    {
        Console.WriteLine($"Число 7 находится в ячейке {middle}");
        break;
    }
    else if (c[middle] < 7)
        left = middle + 1;
    else
        right = middle - 1;
}
