



int Big (int number)
{

     int ed = number % 10;
     int dec = number / 10;

     int max;
     if (ed > dec) max = ed;
     
     else max = dec;

     return max; 

}
    
    int randNumber = new Random().Next(10,100);
    int BigN = Big (randNumber);

    Console.WriteLine($"Bign of {randNumber} is {BigN}" );