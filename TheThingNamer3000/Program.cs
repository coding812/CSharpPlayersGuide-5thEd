Console.WriteLine("What kind of thing are we talking about?");

// Assigns the name of the thing to the variable a
string a = Console.ReadLine();

Console.WriteLine("How would you describe it? Big? Azure? Tattered?");

// Assigns the description of the thing to the variable b
string b = Console.ReadLine();

// adds "of Doom" to the description of the thing
string c = "of Doom";

// adds "3000" to the description of the thing
string d = "3000";

Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");