using System;

class Program

{

    static void Main()

    {
        //Challange 1
        /*
         
        Console.WriteLine(" Start Regestration ");
        Console.WriteLine(" Enter the user name: ");
        String userName= Console.ReadLine();
        Console.WriteLine(" Enter the Password ");
        String password = Console.ReadLine();
        if (userName == null || password == null)
        {
            Console.WriteLine("Need usename and password to Register ");
        }
        else
        {
            Console.WriteLine("-----------Register Sucess----------");
        }


        Console.WriteLine(" Login ");
        Console.WriteLine(" Enter User name ");
        String checkUser = Console.ReadLine();
        Console.WriteLine("Enter Password");
        String checkPassword = Console.ReadLine();

        if (checkUser == null || checkPassword == null)
        {
            Console.WriteLine("Enter user name and password please");
        }
        else if (userName == checkUser && password == checkPassword) {
            Console.WriteLine("login Success ");
        }
        else
        {
            Console.WriteLine(" user name or password is incorrect");
        }
        */








        //------------------------------------------------
        /*
         //challange 2

         Console.WriteLine(" Enter the player name ");
         String player = Console.ReadLine();
         Console.WriteLine(" Enter the score ");
         int score= int.Parse(Console.ReadLine());
         checkHighScore(player, score);
        */
        //-------------------------





        //challange 3 
        Console.WriteLine("Enter the first number:");
        double num1 = double.Parse(Console.ReadLine());

        // Get operator
        Console.WriteLine("Enter an operator (+, -, *, /):");
        char operation = char.Parse(Console.ReadLine());

        // Get second number
        Console.WriteLine("Enter the second number:");
        double num2 = double.Parse(Console.ReadLine());
        switch (operation) {
            case '+':
                Console.WriteLine("result is " + (num1 + num2));
                break;
            case '-':
                Console.WriteLine("result is " + (num1 - num2));
                break;
            case '*':
                Console.WriteLine("result is " + (num1 * num2));
                break;
            case '/':
                if (num2==0)
                {
                    Console.WriteLine("uou can't divide by zero");
                }
                else
                {
                    Console.WriteLine("result is " + (num1 / num2));
                    break;
                }
                break;
            default:
                Console.WriteLine("Invalid operator! Please use +, -, *, or /.");
                break;



        }


    }
    /*
    static String highScorePlayer = "messi";
    static int highScore = 100;
    static void checkHighScore(String player,int score)
    {
        if (score> highScore)
        {
            Console.WriteLine(" New Score is : " + score);
            Console.WriteLine(" New high score holder is :  "+ player);
        }
        else
        {
            Console.WriteLine(" The old high score is "+ highScore+" and is still held by "+highScorePlayer);
        }
    }
    */
}