// See https://aka.ms/new-console-template for more information
//rakendus küsib kasutajal sisestada tema vanuse
//kui kasutaja vanus on väikesem kui 13 siis konsoolis kuvatakse:
//"you are too young to use instagram
//muul juhul
//konsoolis kuvatakse "welcome to instagram

Console.WriteLine("Enter your age:");

int userAge = Int32.Parse(Console.ReadLine());

if(userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}


else //if (user age < 13)
{
    Console.WriteLine("you are too young to use Instagram.");
}

