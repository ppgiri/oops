using System;
using System.Collections.Generic;
using System.Text;

namespace MobileConsoleApp
{
    //abstract class 
    abstract class MobileAbstract
    {
        //abstact method
        public abstract void Pword();

    }

    class Oneplus : MobileAbstract
    {
        //overriding abstract method
        public override void Pword()
        {
            Console.WriteLine("unknown");
        }
    }


}
