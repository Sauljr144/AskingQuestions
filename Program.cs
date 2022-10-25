string name1;
string time1;
string playAgain = "Y";

while(playAgain != "N")
{
    //-----Name-----//

    Console.WriteLine("Hello there, what is your name?");

    name1 = Console.ReadLine();

    //------Time-----//

    time1 = DateTime.Now.ToString("hh:mm tt");

    //-----Output-----//

    Console.WriteLine($"Welcome {name1}, it is currently {time1}.");

    Console.WriteLine("Do you want to play again? Y/N");
    playAgain = Console.ReadLine().ToUpper();
}

Console.WriteLine("Bye!");