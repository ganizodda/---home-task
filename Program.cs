//Task1
// int fact(int a)
// {
//     if (a <= 1)
//     {
//         return 1;
//     }
//     return a*fact(a-1);
// }
// while (true)
// {
//     System.Console.Write("Factorial = ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine(fact(a));
// }




//Task2
// int Fibonacci(int n)
// {
//     if (n == 0)
//     {
//         return 0;
//     }
//     else if (n == 1)
//     {
//         return 1;
//     }
//     else
//     {
//         return Fibonacci(n-1)+Fibonacci(n-2);
//     }
// }
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Fibonacci(n));





// Task3
// int DoubleFactorial(int n)
// {
//     if (n <= 1)
//     {
//         return 1;
//     }
//     return n*DoubleFactorial(n-2);
// }

// while (true)
// {
//     Console.Write("Enter nunmber to find double factorial: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine(DoubleFactorial(a));
// }






//Task4
// void cnt( int n)
// {
//     if (n <= 0)
//     {
//         return;
//     }
//     System.Console.Write(n + " ");
//     cnt(n - 1);
// }
// int n = Convert.ToInt32(Console.ReadLine());
// cnt(n);


//Task5
// void count(int n)
// {
//     if (n <= 0)
//     {
//         return;
//     }
//     count(n - 1);  
//     System.Console.Write(n + " ");
// }

// int n = Convert.ToInt32(Console.ReadLine());
// count(n);




//Task6
// int sum(int n)
// {
//     if (n <= 0) 
//     return 0;
//     return n + sum(n - 1);
// }
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(sum(n));




//Task7
// void ver(int n)
// {
//     if(n == 0)
//     {
//         return;
//     }
//     ver( n / 10);
//     int a = n%10;
//     System.Console.Write(a + " ");
// }
// int n = Convert.ToInt32(Console.ReadLine());
// ver(n);




//Task8
// int ver (int a)
// {
//     if (a == 0)
//     {
//         return 0;
//     }
//     return 1 + ver(a/10);
// }
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(ver(a));
 
//Task9
// void even(int a, int b)
// {
//     if(a > b)
//     {
//         return;
//     }
//     if(a%2 == 0)
//     {
//         Console.Write(a + " ");
//     }
//     even(a + 1, b);
// }
// void odd (int a, int b)
// {
//     if(a > b)
//     {
//         return;
//     }
//     if(a%2 != 0)
//     {
//         Console.Write(a+" ");
//     }
//     odd(a+1, b);
// }
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("All even numbers from "+a+" to "+b+" are: ");
// even(a, b);
// Console.WriteLine();
// Console.WriteLine("All odd numbers from "+a+" to "+b+" are: ");
// odd(a, b);


//task10
// int ver (int a)
// {
//     if (a == 0)
//     {
//         return 0;
//     }
//     return 1 + ver(a/10);
// }
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Digits : " + ver(a));


// int sum(int a)
// {
//     if(a == 0)
//     {
//         return 0;
//     }
//     return (a % 10) + sum(a / 10);
    
// }
// System.Console.WriteLine("Sum of digits = " + sum(a));


// int even(int a)
// {
//     if(a == 0)
//     {
//         return 0;
//     }
//     int juft = a%10;
//     if(juft!=0 && juft % 2 == 0)
//     {
//         return 1 + even(a / 10);
//     }
//     return 0 + even(a / 10);
// }
// System.Console.WriteLine("Even = " + even(a));


// int odd(int a)
// {
//     if(a == 0)
//     {
//         return 0;
//     }
//     int toq = a%10;
//     if(toq!=0 && toq % 2 != 0)
//     {
//         return 1 + odd(a / 10);
//     }
//     return 0 + odd(a / 10);
// }
// System.Console.WriteLine("Odd = " + odd(a));


// int zeros(int a)
// {
//     if(a == 0)
//     {
//         return 0;
//     }
//     int zero = a%10;
//     if(zero == 0)
//     {
//         return 1 + zeros (a/10);

//     }
//     return  0 + zeros (a/10);

// }
// System.Console.WriteLine("Zero = " + zeros(a));


// int min(int a)
// {
//     if(a/10==0)
//     {
//         return a%10;
//     }    
//     int r = a%10;
//     int d = min(a/10);
//     return Math.Min(r , d);
// }
// System.Console.WriteLine("Min = " + min(a));


// int max(int a)
// {
//     if(a/10==0)
//     {
//         return a%10;
//     }    
//     int r = a%10;
//     int d = max(a/10);
//     return Math.Max(r , d);
// }
// System.Console.WriteLine("Max = " + max(a));


//Task 11;
// string  grade(int a)
// {
//     if (a >= 90) 
//     return "A";
//     else if (a >= 80) return "B";
//     else if (a >= 70) return "C";
//     else if (a >= 60) return "D";
//     else return "F";
// }

// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(grade(a));



//task 12;
// int a  = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int [a];
// for(int i = 0; i < a; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// for(int i = 0;i < a; i++)
// {
//     if (i % 2 == 0)
//     {
//         System.Console.Write(arr[i] + " ");
//     }
// }



//Task 13
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// for(int i = 0; i<n; i++)
// {
//     arr[i] = Convert.ToInt32(Console.ReadLine());
// }
// int cnt = 0;
// for(int i = 1; i<n; i++)
// {
//     if(arr[i] > arr[i - 1])
//     {
//         cnt++;
//     }
// }
//     Console.WriteLine(cnt);

