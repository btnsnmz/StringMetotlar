using System;

namespace StringMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken ="Dersimiz CSharp Hoşgeldiniiiz";
            string degisken2 ="Nbr";

            //Length
            Console.WriteLine(degisken.Length);

            //ToUpper ,ToLower

            Console.WriteLine(degisken.ToLower());
            Console.WriteLine(degisken.ToUpper());

            //Concat
            Console.WriteLine(string.Concat(degisken,"Merhaba"));

            //Comapre ,CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2 ));
            Console.WriteLine(string.Compare(degisken,degisken2,true));
            
            //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniiiz"));
            Console.WriteLine(degisken.StartsWith("Hoşgeldinizzz"));


            //IndexOF
            Console.WriteLine(degisken.IndexOf("CS"));

            //Insert
             Console.WriteLine(degisken.Insert(0,"Naber"));
             Console.WriteLine(degisken.LastIndexOf("i"));

             //padeleft ve padright
             Console.WriteLine(degisken+degisken2.PadLeft(30)); 
            //Remove
            Console.WriteLine(degisken.Remove(10));

            //replace
            Console.WriteLine(degisken.Replace("CSharp","C^# "));
            
            //split

            Console.WriteLine(degisken.Split(' ')[1]);
             
            


        }
    }
}
