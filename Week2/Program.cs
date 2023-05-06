Console.WriteLine("Enter your last name");
string lastName = Console.ReadLine();


Console.WriteLine("Enter your gender (m/f/n):");
char userGender = Char.Parse(Console.ReadLine());

string greeting;
if (userGender == 'f')
{
    greeting = "Ms.";
}
else if (userGender == 'm')
{
    greeting = "Mr.";
}
else
{
    greeting = "";
}
Console.WriteLine($"Hello, {greeting} {lastName}");

Console.WriteLine("Enter your year of birth:");

int userYB = Int32.Parse(Console.ReadLine());
int currentyear = DateTime.Now.Year;
int userAge = currentyear - userYB;


///int userAge = Int32.Parse(Console.ReadLine());*/

if (userAge >= 13)
{
    Console.WriteLine("You are old enough to have an account");
}
else
{
    Console.WriteLine("You are too young to have an account");
}


