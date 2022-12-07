using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsBasicProblems
{
    public class Animals
    {
        public void standing()
        {
            Console.WriteLine("All Animals Are standing for Looking to each them faces");
        }
    }
    public class MaleDog: Animals
    {
        string color="White";
        string dogNames="RRRR";
        int noOfDogs=6;
        public void Dogstanding()
        {
            Console.WriteLine("Rajamouli is  DOGS manager . \n He simply watcing dogs details for marriage  :- ");
            Console.WriteLine("MaleDog name "+dogNames+" them Color "+color+" and there are "+ noOfDogs +" waiting for marriage.");
        }
    }
    public class FemaleDog:Animals
    {
        string color1;
        string dogName1;
        int noOfDogs1;
        public FemaleDog(string color1, string dogName1, int noOfDogs1)
        {
            this.color1 = color1;
            this.dogName1 = dogName1;
            this.noOfDogs1 = noOfDogs1;         
        }
        public void Waiting()
        {
            Console.WriteLine("Also Rajmouli looking Femaledogs Detalis :-");
            Console.WriteLine("Female dogs names "+ dogName1 + " them Color "+color1+" and there are "+ noOfDogs1 +" simply sitting in the Hall.\n Remaing one Maledog is SINGLE ");
        }
    }



}
