// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
/*
Console.Write("Input number ");
int number = Convert.ToInt32(Console.ReadLine());
if(number >9999 && number < 100000){
    if (number/10000 == number % 10 && number / 1000 % 10 == (number%100) / 10){
        Console.WriteLine("Палиндром");
    }else{
        Console.WriteLine("Не палиндром");
    }
    }
else{
    Console.WriteLine("Это не пятизначное число");
}
*/
// Напишите программу, которая принимает на 
// вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double Power(double a, double b){
    return Math.Pow((a-b), 2);
}

double[] a = new double[3];
double[] b = new double[3];
for(int i = 0; i < 3; i++){
    Console.Write($"Input a{i+1} dot ");
    a[i] = Convert.ToDouble(Console.ReadLine());
}
for(int i = 0; i < 3; i++){
    Console.Write($"Input b{i+1} dot ");
    b[i] = Convert.ToDouble(Console.ReadLine());
}

double res = Math.Sqrt(Power(a[0],b[0])+Power(a[1],b[1])+Power(a[2],b[2]));
res = Math.Round(res, 3);
Console.WriteLine($"Расстояние между точками {res}");
*/
// Напишите программу, которая принимает на 
// вход число (N) и выдаёт таблицу кубов 
// чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
/*
int number = -1;
while (number < 1){
    Console.Write("Input number ");
    number = Convert.ToInt32(Console.ReadLine());
}
int current = 1;
while(current <= number){
    Console.Write(Math.Pow(current, 3) + " ");
    current++;
}
*/