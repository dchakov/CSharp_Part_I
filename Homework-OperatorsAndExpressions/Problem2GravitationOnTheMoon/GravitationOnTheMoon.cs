﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Problem 2. Gravitation on the Moon• 
//The gravitational field of the Moon is approximately  17%  of that on the Earth.
//• Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
//Examples:
//weight
//weight on the Moon
//86 14.62 
//74.6 12.682 
//53.7 9.129 


namespace Problem2GravitationOnTheMoon
{
    class GravitationOnTheMoon
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter weight of a man:");
            double weightOfAman = double.Parse(Console.ReadLine());
            double weghtOnTheMoon = weightOfAman * 0.17;
            Console.WriteLine("Weight of a man on the moon is:"+weghtOnTheMoon);
        }
    }
}
