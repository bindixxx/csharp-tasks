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



//8 task
Console.WriteLine("Enter the number of time points: ");
int n = int.Parse(Console.ReadLine());
List<(int Hours, int Minutes, int Seconds)> times = new List<(int Hours, int Minutes, int Seconds)>();
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Enter time point {i + 1} ");
    string[] parts = Console.ReadLine().Split();
    int hours = int.Parse(parts[0]);
    int minutes = int.Parse(parts[1]);
    int seconds = int.Parse(parts[2]);
    times.Add((hours, minutes, seconds));
}
for (int i = 1; i < times.Count; i++)
{
    var key = times[i];
    int j = i - 1;
    while (j >= 0 && (times[j].Hours > key.Hours || (times[j].Hours == key.Hours && times[j].Minutes > key.Minutes) || (times[j].Hours == key.Hours && times[j].Minutes == key.Minutes && times[j].Seconds > key.Seconds)))
    {
        times[j + 1] = times[j];
        j--;
    }
    times[j + 1] = key;
}
Console.WriteLine("Sorted time points: ");
foreach (var time in times)
    Console.WriteLine($"{time.Hours} {time.Minutes} {time.Seconds}");



//9 task
string inputTime = Console.ReadLine();
int hours = int.Parse(inputTime.Substring(0, 2));
int minutes = int.Parse(inputTime.Substring(3, 2));
while (true)
{
    minutes++;
    if (minutes == 60)
    {
        minutes = 0;
        hours++;
        if (hours == 24)
        {
            hours = 0;
        }
    }
    if (hours / 10 == minutes % 10 && hours % 10 == minutes / 10)
    {
        Console.WriteLine($"{hours:D2}:{minutes:D2}");
        break;
    }
}



//10 task
Console.WriteLine("a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("b");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("c");
int c = int.Parse(Console.ReadLine());

double d = b * b - 4 * a * c;
if (a == 0)
{
    double x = -c / (double)b;
    Console.WriteLine($"x = {x}");
}
else
{
    double discriminant = b * b - 4 * a * c;

    if (discriminant > 0)
    {
        double sqrtDiscriminant = Math.Sqrt(discriminant);
        double x1 = (-b + sqrtDiscriminant) / (2.0 * a);
        double x2 = (-b - sqrtDiscriminant) / (2.0 * a);
        Console.WriteLine($"x1 = {x1} x2 = {x2}");
    }
    else if (discriminant == 0)
    {
        double x = -b / (2.0 * a);
        Console.WriteLine($"x = {x}");
    }
    else
    {
        Console.WriteLine("уравнение не имеет действительных корней");
    }
}



//11 task
Console.WriteLine("Enter numbers ");
int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int max = int.MinValue;
int min = int.MaxValue;
for (int i = 0; i < numbers.Length; i++)
{
    if ((i + 1) % 2 == 0)
    {
        if (numbers[i] > max)
            max = numbers[i];
    }
    else
    {
        if (numbers[i] < min)
            min = numbers[i];
    }
}
int result = max + min;
Console.WriteLine(result);



//12 task
static bool IsPalindrome(string s)
{
    int n = s.Length;
    for (int i = 0; i < n / 2; i++)
    {
        if (s[i] != s[n - i - 1])
        {
            return false;
        }
    }
    return true;
}
static bool IsAllCharactersSame(string s)
{
    for (int i = 1; i < s.Length; i++)
    {
        if (s[i] != s[0])
        {
            return false;
        }
    }
    return true;
}
string s = Console.ReadLine();
if (s.Length == 1 || IsAllCharactersSame(s))
{
    Console.WriteLine("NO SOLUTION");
    return;
}
while (IsPalindrome(s))
{
    s = s.Substring(0, s.Length - 1);
}
Console.WriteLine(s);



//13 task
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

int[] numbers = new int[10];
for (int i = 0; i <= n; i++)
{
    for (int j = 0; j <= m; j++)
    {
        int a = i * j;
        while (a > 0)
        {
            int b = a % 10;
            numbers[b]++;
            a /= 10;
        }

    }
}
for (int i = 0; i <= 9; i++)
{
    Console.WriteLine($"{i}: {numbers[i]}");
}
