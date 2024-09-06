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
