void hasThirdNumber(int x) {
int div = 1;
while (x / div >= 10) 
{
    div *= 10;
}
Console.WriteLine(x);
if (div < 100) {
    Console.WriteLine("Too little number");
} else {
    // last number of x / (div/100)    123456
    int digit = (x / (div/100)) % 10;
    Console.WriteLine("Third is {0}", digit);
}

}

hasThirdNumber(12);
hasThirdNumber(123);
hasThirdNumber(1234);
hasThirdNumber(12345);
hasThirdNumber(987654);

   


