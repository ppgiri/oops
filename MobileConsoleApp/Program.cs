using System;

namespace MobileConsoleApp
{
    // (encapsulation , inheritence , polymorphism(overloading,overriding) )
    //parent class Mobile
   class Mobile
    {
        //method 1
        public virtual void Call() 
        { 
            Console.WriteLine("Calling is main feature"); 
        }
        //method 2
        public void Message()
        { 
            Console.WriteLine("messaging is main feature"); 
        }
        //overloading method 
        public void Phonenor(int num)
        {
            Console.WriteLine(num);
        }
    }
    //child class (Apple) which inherits parent class 
    class Apple : Mobile
    {

        //method1 of child class
        public void Security()
        { 
            Console.WriteLine("security");
        }
        //method2 of child class
        public void Camera()
        { 
            Console.WriteLine("camera"); 
        }
        //overloading method 
        public void Phonenor(int countrycode,int number)
        {
            int ccode = countrycode;
            int numb = number;
            int phnor = int.Parse(ccode.ToString() + numb.ToString());
            Console.WriteLine(phnor);

        }
        //overriding
        public override void Call()
        {
            Console.WriteLine("calling");
        }
        
    }

    class Complete
    {
        public static void Main(string[] args)
        {

            Apple appleobj = new Apple();
            Mobile mobileobj = new Mobile();
            Oneplus oneplus = new Oneplus();
            appleobj.Call();
            appleobj.Message();
            appleobj.Security();
            appleobj.Camera();
            appleobj.Phonenor(91, 56787);
            mobileobj.Phonenor(98765);
            oneplus.Pword();

            Console.ReadLine();
        }
    }
    
}
