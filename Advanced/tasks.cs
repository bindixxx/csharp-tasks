//ALL TASKS TAKED FROM https://acmp.ru

//BEFORE YOU USE SCRIPTS CHOOSE ONLY ONE OF THEM AND COMMENT OUT THE OTHERS OR THERE WILL BE BUGS
//BEFORE YOU USE SCRIPTS CHOOSE ONLY ONE OF THEM AND COMMENT OUT THE OTHERS OR THERE WILL BE BUGS
//BEFORE YOU USE SCRIPTS CHOOSE ONLY ONE OF THEM AND COMMENT OUT THE OTHERS OR THERE WILL BE BUGS
//BEFORE YOU USE SCRIPTS CHOOSE ONLY ONE OF THEM AND COMMENT OUT THE OTHERS OR THERE WILL BE BUGS
//BEFORE YOU USE SCRIPTS CHOOSE ONLY ONE OF THEM AND COMMENT OUT THE OTHERS OR THERE WILL BE BUGS




//THIS TASKS ONLY FOR ADVANCED!!!!
//1 task
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



//2 task
Console.WriteLine("Enter number ");
string input = Console.ReadLine();
ulong sumEven = 0;
ulong sumOdd = 0;
for (int i = 0; i < input.Length; i++)
{
    int a = input[i] - '0';
    if ((i % 2) == 0)
    {
        sumOdd += (ulong)a;
    }
    else
    {
        sumEven += (ulong)a;
    }
}
ulong b = sumEven - sumOdd;
if (b % 11 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}



//3 task
List<string> rules = new List<string>();
for (int i = 0; i < 6; i++)
{
    rules.Add(Console.ReadLine());
}
A();
int A()
{
    foreach (var item in rules[0])
    {
        if (item == 'a')
        {
            var result = A();
            if (result != 1)
            {
                return result;
            }
        }
        if (item == 'b')
        {
            var result = B();
            if (result != 1)
            {
                return result;
            }
        }
        if (item == 'c')
        {
            var result = C();
            if (result != 1)
            {
                return result;
            }
        }
        if (item == 'd')
        {
            var result = D();
            if (result != 1)
            {
                return result;
            }
        }
        if (item == 'e')
        {
            var result = E();
            if (result != 1)
            {
                return result;
            }
        }
        if (item == 'f')
        {
            var result = F();
            if (result != 1)
            {
                return result;
            }
        }
    }
    return 1;
}
int B()
{
    foreach (var item in rules[1])
    {
        if (item == 'a')
        {
            var result = A();
            if (result != 1)
            {
                return result;
            }
        }
        if (item == 'b')
        {
            var result = B();
            if (result != 1)
            {
                return result;
            }
        }
        if (item == 'c')
        {
            var result = C();
            if (result != 1)
            {
                return result;
            }
        }
        if (item == 'd')
        {
            var result = D();
            if (result != 1)
            {
                return result;
            }
        }
        if (item == 'e')
        {
            var result = E();
            if (result != 1)
            {
                return result;
            }
        }
        if (item == 'f')
        {
            var result = F();
            if (result != 1)
            {
                return result;
            }
        }
    }
    return 1;
}
int C()
{
    foreach (var item in rules[2])
    {
        if (item == 'a')
        {
            var result = A();
            if (result != 1)
            {
                return result;
            }
        }
        if (item == 'b')
        {
            var result = B();
            if (result != 1)
            {
                return result;
            }
        }
        if (item == 'c')
        {
            var result = C();
            if (result != 1)
            {
                return result;
            }
        }
        if (item == 'd')
        {
            var result = D();
            if (result != 1)
            {
                return result;
            }
        }
        if (item == 'e')
        {
            var result = E();
            if (result != 1)
            {
                return result;
            }
        }
        if (item == 'f')
        {
            var result = F();
            if (result != 1)
            {
                return result;
            }
        }
    }
    return 1;
}
int D()
{
    foreach (var item in rules[3])
    {
        if (item == 'a')
        {
            var result = A();
            if (result != 1)
            {
                return result;
            }
        }
        if (item == 'b')
        {
            var result = B();
            if (result != 1)
            {
                return result;
            }
        }
        if (item == 'c')
        {
            var result = C();
            if (result != 1)
            {
                return result;
            }
        }
        if (item == 'd')
        {
            var result = D();
            if (result != 1)
            {
                return result;
            }
        }
        if (item == 'e')
        {
            var result = E();
            if (result != 1)
            {
                return result;
            }
        }
        if (item == 'f')
        {
            var result = F();
            if (result != 1)
            {
                return result;
            }
        }
    }
    return 1;
}
int E()
{
    foreach (var item in rules[4])
    {
        if (item == 'a')
        {
            var result = A();
            if (result != 1)
            {
                return result;
            }
        }
        if (item == 'b')
        {
            var result = B();
            if (result != 1)
            {
                return result;
            }
        }
        if (item == 'c')
        {
            var result = C();
            if (result != 1)
            {
                return result;
            }
        }
        if (item == 'd')
        {
            var result = D();
            if (result != 1)
            {
                return result;
            }
        }
        if (item == 'e')
        {
            var result = E();
            if (result != 1)
            {
                return result;
            }
        }
        if (item == 'f')
        {
            var result = F();
            if (result != 1)
            {
                return result;
            }
        }
    }
    return 1;
}
int F()
{
    foreach (var item in rules[5])
    {
        if (item == 'a')
        {
            var result = A();
            if (result != 1)
            {
                return result;
            }
        }
        if (item == 'b')
        {
            var result = B();
            if (result != 1)
            {
                return result;
            }
        }
        if (item == 'c')
        {
            var result = C();
            if (result != 1)
            {
                return result;
            }
        }
        if (item == 'd')
        {
            var result = D();
            if (result != 1)
            {
                return result;
            }
        }
        if (item == 'e')
        {
            var result = E();
            if (result != 1)
            {
                return result;
            }
        }
        if (item == 'f')
        {
            var result = F();
            if (result != 1)
            {
                return result;
            }
        }
    }
    return 1;
}



//4 task
string em = Console.ReadLine();
char[] dm = new char[em.Length];

for (int i = 0; i < em.Length; i++)
{
    int a = (em[i] <= '9') ? em[i] - '0' : (em[i] >= 'A') ? em[i] - 'A' + 10 : 0;
    int di = (a - (i + 1) + 27) % 27;
    dm[i] = (di == 0) ? ' ' : (char)(di + 'a' - 1);
}
Console.WriteLine(dm);



//5 task
static int[] ConvertPosition(string position)
{
    int col = char.ToLower(position[0]) - 'a';
    int row = 8 - (position[1] - '0');
    return new int[] { row, col };
}
static void MarkQueen(bool[,] board, int row, int col, bool[,] o)
{
    int n = board.GetLength(0);
    for (int i = 0; i < n; i++)
    {
        if (!o[row, i]) board[row, i] = true;
        if (!o[i, col]) board[i, col] = true;

        if (row + i < n && col + i < n && !o[row + i, col + i]) board[row + i, col + i] = true;
        if (row - i >= 0 && col - i >= 0 && !o[row - i, col - i]) board[row - i, col - i] = true;
        if (row + i < n && col - i >= 0 && !o[row + i, col - i]) board[row + i, col - i] = true;
        if (row - i >= 0 && col + i < n && !o[row - i, col + i]) board[row - i, col + i] = true;
    }
}
static void MarkRook(bool[,] board, int row, int col, bool[,] o)
{
    int n = board.GetLength(0);
    for (int i = 0; i < n; i++)
    {
        if (!o[row, i]) board[row, i] = true;
        if (!o[i, col]) board[i, col] = true;
    }
}
static void MarkKnight(bool[,] board, int row, int col, bool[,] o)
{
    int[] dRow = { -2, -1, 1, 2, 2, 1, -1, -2 };
    int[] dCol = { 1, 2, 2, 1, -1, -2, -2, -1 };
    for (int i = 0; i < 8; i++)
    {
        int newRow = row + dRow[i];
        int newCol = col + dCol[i];
        if (newRow >= 0 && newRow < 8 && newCol >= 0 && newCol < 8 && !o[newRow, newCol])
            board[newRow, newCol] = true;
    }
}
int n = 8;
bool[,] board = new bool[n, n];
bool[,] o = new bool[n, n];
string[] positions = Console.ReadLine().Split(' ');
for (int i = 0; i < positions.Length; i++)
{
    int[] pos = ConvertPosition(positions[i]);
    o[pos[0], pos[1]] = true;

    if (i == 0)
    {
        MarkQueen(board, pos[0], pos[1], o);
    }
    else if (i == 1)
    {
        MarkRook(board, pos[0], pos[1], o);
    }
    else if (i == 2)
    {
        MarkKnight(board, pos[0], pos[1], o);
    }
}
int attack = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (board[i, j] && !o[i, j])
            attack++;
    }
}
Console.WriteLine(attack);



//6 task
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int x3 = int.Parse(Console.ReadLine());
int y3 = int.Parse(Console.ReadLine());
int min_x = 0;
int max_x = 0;
int min_y = 0;
int max_y = 0;

//max
if (x1 >= x2 && x1 >= x3)
    max_x = x1;
else if (x2 >= x1 && x2 >= x3)
    max_x = x2;
else if (x3 >= x2 && x3 >= x1)
    max_x = x3;
if (y1 >= y2 && y1 >= y3)
    max_y = y1;
else if (y2 >= y1 && y2 >= y3)
    max_y = y2;
else if (y3 >= y2 && y3 >= y1)
    max_y = y3;

//min
if (x1 <= x2 && x1 <= x3)
    min_x = x1;
else if (x2 <= x1 && x2 <= x3)
    min_x = x2;
else if (x3 <= x2 && x3 <= x1)
    min_x = x3;
if (y1 <= y2 && y1 <= y3)
    min_y = y1;
else if (y2 <= y1 && y2 <= y3)
    min_y = y2;
else if (y3 <= y2 && y3 <= y1)
    min_y = y3;

int x4 = 0;
int y4 = 0;
if ((min_x == x1 && min_y == y1) || (min_x == x2 && min_y == y2) || (min_x == x3 && min_y == y3))
{
    if ((max_x == x1 && min_y == y1) || (max_x == x2 && min_y == y2) || (max_x == x3 && min_y == y3))
    {
        if ((min_x == x1 && max_y == y1) || (min_x == x2 && max_y == y2) || (min_x == x3 && max_y == y3))
        {
            if ((max_x == x1 && max_y == y1) || (max_x == x2 && max_y == y2) || (max_x == x3 && max_y == y3))
            {
                //won't get there
            }
            else
            {
                x4 = max_x;
                y4 = max_y;
            }
        }
        else
        {
            x4 = min_x;
            y4 = max_y;
        }
    }
    else
    {
        x4 = max_x;
        y4 = min_y;
    }
}
else
{
    x4 = min_x;
    y4 = min_y;
}

Console.WriteLine($"x: {x4} and y: {y4}");


string A(string c, int b)
{
    string d = "";
    for (int i = 0; i < b; i++)
    {
        d += c;
    }
    return d;
}
Console.WriteLine(A("abc", 4));

int Factorial(int n)
{
    if (n <= 1)
        return 1;
    else
        return n * Factorial(n - 1);
}
int number = 5;
int f = Factorial(number);
Console.WriteLine(f);



//7 task
using System.Numerics;

string a = Console.ReadLine();
string b = Console.ReadLine();

BigInteger A = BigInteger.Parse(a);
BigInteger B = BigInteger.Parse(b);
BigInteger result = A / B;

Console.WriteLine(result);



//8 task
//WRITE YOUR USERNAME IN PATH
//TO USE THIS ANSWER YOU NEED TO CREATE A FOLDER IN DESKTOP OR CHANGE PATH IN STRING AND FILES IN THIS FOLDER, ALSO YOU CAN TO CREATE FOLDER IN YOUR FORDER AND IT WILL BE WORKS  
static int FileSearch(string direction)
{
    int counter = 0;
    string[] allfiles = Directory.GetFiles(direction);
    foreach (string filename in allfiles)
    {
        Console.WriteLine(filename);
        counter++;
    }
    string[] directories = Directory.GetDirectories(direction);
    Console.WriteLine(counter += directories.Length);
    foreach (string directory in directories)
        counter += FileSearch(directory);
    return counter;
}
//THERE YOU CAN TO WRITE YOUR PATH TO YOUR FOLDER
string path = "C:\\Users\\YOURUSERNAME\\Desktop\\folder";
int FileCount = FileSearch(path);
Console.WriteLine(FileCount);
