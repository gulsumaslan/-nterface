﻿using İnterface.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace İnterface
{
    public class Need : ICredit

    {
        public int Id { get ; set; }
        public int CreditLimit { get; set; }
        public int Interest { get ; set ; }

        public int Avans { get; set; }

        public void Bonus()
        {
            Console.WriteLine(" consumer loan bonus");
        }





        public void Calculate()
        {
            Console.WriteLine( "CreditLimit:"+CreditLimit + " "  + "Interest:"+Interest + " " +"Avans:"+  Avans  + " consumer loan(İhtiyaç Kredisi)");
        }
    }
}
