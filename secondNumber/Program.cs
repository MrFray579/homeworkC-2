void randomNumbersCompare (int start, int finish)
{
    int A = new Random().Next(start, finish);
    Console.WriteLine(A);
    int B = (A / 10) % 10;
    Console.WriteLine(B);
    
}

randomNumbersCompare (100, 999);
