//Elizar Garcia
//10-20-22
//Mini challenge #5 "Madlib"
//In this console project we will create a madlib


Console.Clear();

bool playAgain = true;
string playAgainAnswer;

Console.WriteLine("Hello, let's create a story together using the words you provide me.");
while(playAgain == true){
Console.WriteLine("Let's start with and adjective.");

string adjectiveOne = Console.ReadLine();

Console.WriteLine("Name a vehicle you would want to own someday.");
string vehicleOne = Console.ReadLine();

Console.WriteLine("What is your favorite color?");
string colorOne = Console.ReadLine();

Console.WriteLine("Noun");
string nounOne = Console.ReadLine();

Console.WriteLine("Verb");
string verbOne = Console.ReadLine();

Console.WriteLine("City");
string city = Console.ReadLine();

Console.WriteLine("adjective");
string adjectiveTwo = Console.ReadLine();

Console.WriteLine("Favorite time of year");
string timeYear = Console.ReadLine();

Console.WriteLine("favorite song");
string favSong = Console.ReadLine();

Console.WriteLine("Name a place");
string place = Console.ReadLine();

Console.WriteLine("Now lets enter what you gave me..."); 

Console.WriteLine($" In my {adjectiveOne} new {vehicleOne} with a {colorOne} finish, with my favorite {nounOne} on my mimd, I {verbOne} through the empty steets of {city}. ");
Console.WriteLine($"With the {adjectiveTwo} weather of {timeYear} I listen to {favSong} as I finally reach {place}. ");



Console.WriteLine("Would you like to play again??  Yes or No?");

playAgainAnswer = Console.ReadLine().ToUpper();

if (playAgainAnswer == "YES"){
    playAgain = true;
}else{
    Console.WriteLine("BOOOOO!!!");
    playAgain = false;
}
}
