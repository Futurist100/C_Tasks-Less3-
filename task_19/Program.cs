// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да



Console.WriteLine("Введите число ");

string n = Console.ReadLine();

double result = Int64.Parse(n);

char[] ch = n.ToCharArray();

int max = Convert.ToInt32((n.Length));

int m = max - 1;

int i = 0;

int control = 0;

while (i <= (max/2))
   {  
    control = control + (ch[i] - ch[m]);

     m = m - 1;

         i++;
         
    if (control != 0)
     {
        i = m;
     }
     else {}
  } 
   
if (i != m)
  {
    Console.WriteLine($"Число {result} является палидромом ");
  }
else 
{ 
    Console.WriteLine($"Число {result} не является палидромом ");
} 
