﻿// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.


void Nums(int n, int m) {
    if (n < m) {Nums(n, m-1);}
    Console.Write(m + " ");
}

Nums(2, 15);