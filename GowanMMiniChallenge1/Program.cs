//Maddie Gowan
//10-17-22
//Mini Challenge #1 - Say Hello
//This is a redo of the former assignment

Console.Clear();

Console.WriteLine("Type end to stop, or play to continue");
string playAgain = Console.ReadLine().ToLower();

/*if(playAgain != "play" && "end"){
    Console.WriteLine("This is not a valid answer. Rude.");
}*/

if(playAgain == "end"){
    Console.WriteLine("Okay, goodbye");
}

while(playAgain == "play"){

Console.WriteLine("I'm awake!");

Console.WriteLine("Hello, what is your name?");

string myName = Console.ReadLine().ToLower();

if (myName == "maddie")
    {Console.WriteLine("Hi " + myName + ". Have a good day <3");
    Console.WriteLine("Would you like to play again? Type end or play");
    playAgain = Console.ReadLine().ToLower();}
else
   {Console.WriteLine("Oh, you're not who I expected. Hello " + myName ".");
   Console.WriteLine("Would you like to play again? Type end or play");
    playAgain = Console.ReadLine().ToLower();}

}