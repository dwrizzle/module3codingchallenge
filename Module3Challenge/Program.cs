using System;

namespace ZooAnimalsAssignment
{
    class Program
    {
        static void Main(string[] args)
        
        Console.Write("Enter the animal's hunger level (1-10): ");
            int hungerLevel = int.Parse(Console.ReadLine());

            if (hungerLevel >= 8)
            {
                 Console.WriteLine("Lion: Roar! I need a big meal! ");                    
            }
            else if (hungerLevel >= 5)
            {
               Console.WriteLine("Monkey: Ooh ooh! I'll take some bananas. ");
            }
            else
            {
                Console.WriteLine("Tortoise: Slow and steady-I'll have some lettuce. ");
            }

            Console.Write("Enter the day of the week as a number. With 1 for Sunday, 2 for Monday, etc.: ")
            int Dayoftheweek = int.Parse(Console.ReadLine());



            switch(Dayoftheweek)
            {
                case 1: 
                     Console.WriteLine("The big cat enclose is purr-aying for you to visit them! ");
                    break;
                case 2:
                    Console.WriteLine("Rent the arboretum for your special occassion! ");
                    break;
                case 3: 
                    Console.WriteLine("The monkeys are going bananas hoping to see your smile! ");
                    break;
                case 4:
                    Console.WriteLine("You know what day it is. Hump day! Visit our camel enclosure. ");
                    break;
                case 5: 
                    Console.WriteLine("Do you wanna taco bout it? 15% off Jeff's Tacos today! ");
                    break;
                case 6:
                    Console.WriteLine("Happy hour at the zoo is watching the seals do sweet tricks! ");
                    break;
                case 7:
                    Console.WriteLine("It's Saturday! Instead of being sat at home - come sit on the train and take a spin around the zoo! ");
                    break;
            
            }
        
    }
}
