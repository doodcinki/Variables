namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //What int is?

            /* 
        
            int x;
            int y;

            x = 7;
            y = x + 3;



            Console.WriteLine(y);
            Console.ReadLine();
            */

            //What string is?

            Console.WriteLine("What is your name?");
          
            Console.Write("Type your first name: ");
            string myFirstName = Console.ReadLine();


            // Longer version of code lower quality 

            //string myLastName;
            //Console.Write("Type your last name: ");
            //myLastName = Console.ReadLine();

            //Try to make code short - "code quality"

            Console.Write("Type your last name: ");
            string myLastName = Console.ReadLine();


            Console.WriteLine("Hello, " + myFirstName + " " + myLastName + " !");
            Console.ReadLine();

            //Cant repeat variables names when creating new one 

        }
    }
}