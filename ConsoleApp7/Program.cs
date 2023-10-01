using System.Text;

Console.OutputEncoding = Encoding.UTF8;
////int a,b;
////a=Convert.ToInt32(Console.ReadLine());
////b=Convert.ToInt32(Console.ReadLine());
//int[,] arr = new int[3, 3];
//int[,] arr2 = new int[3, 3];
//int[,] arr3 = new int[3, 3];

//RandomArray(arr);
//PrintArray(arr);

//RandomArray(arr2);
//PrintArray(arr2);

//for (int i = 0; i < arr.GetLength(0); i++) //Сложение массива arr и arr2 и вывод реезультата 
//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {

//        arr3[i, j] = arr[i, j] + arr2[i, j];
//        Console.Write(arr3[i, j] + " ");
//    }
//    Console.WriteLine();
//}


////int[,] arr = new int[3, 3];
////for(int i = 0; i < arr.GetLength(0); i++)
////{
////    for(int j = 0; j < arr.GetLength(1); j++)
////    {

////        Console.Write(arr[i,j]+" ");
////    }
////    Console.WriteLine( );
////}

//void RandomArray(int[,]arr)
//{
//    for (int i = 0; i < arr.GetLength(0); i++) //Массив arr заполняется рандомными числами
//    {
//        for (int j = 0; j < arr.GetLength(1); j++)
//        {
//            Random rnd = new Random();
//            arr[i, j] = rnd.Next(0, 9);
//        }
//    }
//}

//void PrintArray(int[,]arr)
//{
//    for (int i=0; i<arr.GetLength(0); i++)//Выводим значения массива arr в консоль
//    {
//        for(int j=0; j<arr.GetLength(1);j++)
//        {
//            Console.Write(arr[i, j] + " ");
//        }
//        Console.WriteLine( );
//    }
//    Console.WriteLine( );
//}


//int a=0;
//Func(a);
//Console.WriteLine(a);

//void Func(int a)
//{
//    a= 1;
//}



//int a, b, c;
//a = Convert.ToInt32(Console.ReadLine());
// Pow(a);




//void Pow (int a)
//{
//    if (a%2 == 0)
//    {
//        Console.WriteLine( "четное");
//    }
//    else
//    {
//        Console.WriteLine("не четное");
//    }

//}




int a,c,b;
a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine( Factorial(a));

b = 0;


int Factorial(int a)
{
    if(a==0)
    {
        return Factorial(a - 1);
        b = a * (a--);
        
        return b;
    }
    else
    {
        return Factorial(a-1);
    }

}



