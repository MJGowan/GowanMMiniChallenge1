//Maddie Gowan
//10-17-22
//Mini Challenge 1 - Redo
//In this challenge we had to enter our name into the terminal, and have the
//computer provide a response, a "hello".

//Peer Reviewed by Amardeep Mann: The if/else statemnet was a great choice and
//good call on using ToLower() to check for mixed-case inputs. The play again
//feature works great via the while loop. I thought it was pretty funny that
//there is a specific right answer for this game, very nice touch. Maybe in a
//future revision you can interpolate the user's name in the "Not who I was
//expecting" text somehow. Great work!

//Response by Madeline Gowan: Thank you! I added the users name into the second
//response as you suggested. I never considered that, so I appreciate the feedback!!

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
   {Console.WriteLine("Oh, you're not who I expected. Hello " + myName + ".");
   Console.WriteLine("Would you like to play again? Type end or play");
    playAgain = Console.ReadLine().ToLower();}

}