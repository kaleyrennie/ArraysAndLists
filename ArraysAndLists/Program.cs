using System;
using System.Collections.Generic;


 class Program
 {
     static void Main()
    {

        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(10);
        //intList.Remove(10);

        //Console.WriteLine(intList[0]);
        //Console.ReadLine();


        //List<string> intList = new List<string>();
        //intList.Add("Hello");
        //intList.Add("Kaley");
        //intList.Remove("Kaley");

        //Console.WriteLine(intList[0]);
        //Console.ReadLine();


        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();
        
       
        string[] dinArray = new string[4];
        
        dinArray[0] = "spaghetti";
        dinArray[1] = "stuffer peppers";
        dinArray[2] = "stir fry";
        dinArray[3] = "portabella burger";
        Console.WriteLine("Chose a number between 0 and 3 to reveal what you should have for dinner. ");
        int din = Convert.ToInt32(Console.ReadLine());

        if (din > dinArray.Length)
            {
            Console.WriteLine("You selected a number outside of 0 to 3. I guess its Ramen tonight then...");
            }
        if (din == 0)
            {
            Console.WriteLine(dinArray[0]);
            }
        if (din == 1)
        {
            Console.WriteLine(dinArray[1]);
        }
        if (din == 2)
        {
            Console.WriteLine(dinArray[2]);
        }
        if (din == 3)
        {
            Console.WriteLine(dinArray[3]);
        }



        int[] ageArray = new int[4];
        ageArray[0] = 5;
        ageArray[1] = 8;
        ageArray[2] = 3;
        ageArray[3] = 1;
        Console.WriteLine("chose a number between 0 and 3 to reveal how many cookies you should eat. ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age > ageArray.Length)
        {
            Console.WriteLine("You did not chose between 0 and 3. No cookes for you...");
        }
        if (age == 0)
        {
            Console.WriteLine(ageArray[0]);
        }
        if (age == 1)
        {
            Console.WriteLine(ageArray[1]);
        }
        if (age == 2)
        {
            Console.WriteLine(ageArray[2]);
        }
        if (age == 3)
        {
            Console.WriteLine(ageArray[3]);
        }




        List<string> petList = new List<string>();
        petList.Add("You should get a cat! ");
        petList.Add("You should get a dog! ");
        petList.Add("You should get a bird! ");
        petList.Add("you should get a snake! ");
        Console.WriteLine("Enter a number from 0 to 3 to find out what kind of pet you should get. ");
        int pet = Convert.ToInt32(Console.ReadLine());
       
        if (pet >= 4 )
        {
            Console.WriteLine("You did not chose between 0 and 3. No cookes for you...");
        }
        if (pet == 0)
        {
            Console.WriteLine(petList[0]);
        }
        if (pet == 1)
        {
            Console.WriteLine(petList[1]);
        }
         if (pet == 2)
        {
            Console.WriteLine(petList[2]);
        }
        
        if (pet == 3)
        {
            Console.WriteLine(petList[3]);
        }
        Console.ReadLine();








    }
}
