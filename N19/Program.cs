Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
int num0= number/10000;
int num1= (number/1000)%10;
int num3=(number%100)/10;
int num4=number%10;

    if(num0 == num4 && num1 == num3)
    {
        Console.WriteLine("Это число - палиндром");
    } 
    else
    {
        Console.WriteLine("Это число -  не палиндром");
    }

