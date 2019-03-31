using System;

namespace HelloWorld
{
    class Program
    {
        public static void Main (string[] args)
        {
            Message myMessage;
            myMessage = new Message("Hello World");
            myMessage.Print();
            Message[] Messages = new Message[4];
            string name;
            Messages[0] = new Message(" welcome back oh great educator!");
            Messages[1] = new Message(" what a lovely name");
            Messages[2] = new Message(" great name");
            Messages[3] = new Message(" that is a silly name");
            name = Console.ReadLine();
            switch (name)
            {
                case "YIXIN":
                    Messages[0].Print();
                    break;
                case "Ethan":
                    Messages[1].Print();
                    break;
                case "HU":
                    Messages[2].Print();
                    break;
                default:
                    Messages[3].Print();
                    break;
            }
            Console.ReadLine();
        }
    }
}
