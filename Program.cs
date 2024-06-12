namespace Assignment6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            string? userInput = "";
            int option = 0;
            bool exitProgram = false;

            CallCenter callCenter = new();

            do
            {

                do
                {
                    Console.WriteLine("Please choose an option:");
                    Console.WriteLine("Add a Call, Enter 1");
                    Console.WriteLine("Answer a Call, Enter 2");
                    Console.WriteLine("See Calls in Queue, Enter 3");
                    Console.WriteLine("See Id of Calls in Queue, Enter 4");
                    Console.WriteLine("Exit Program, Enter 5");
                    userInput = Console.ReadLine();
                } while (userInput == "");

                option = Convert.ToInt32(userInput);

                switch (option)
                {
                    case 1:
                        callCenter.Call(callCenter.GetCallCount());
                        Console.WriteLine();
                        break;
                    case 2:
                        callCenter.Answer();
                        Console.WriteLine();
                        break;
                    case 3:
                        callCenter.DisplayCallCount();
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine();
                        callCenter.DisplayCallIds();
                        Console.WriteLine();
                        break;
                    case 5:
                        exitProgram = true;
                        break;
                }
            } while (exitProgram != true);
        }
    }
}
