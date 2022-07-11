/* Фибоначи

f(1) = 1
f(2) = 1
f(n) = f(n - 1) +  f(n - 2)
*/

double fibonacci(int num)
{
    if (num == 1 || num == 2) { return 1; }
    else return fibonacci(num - 1) + fibonacci(num - 2);
}

for (int i = 0; i < 5; i++) { Console.WriteLine($"f({i}) = {fibonacci(i)}");}
