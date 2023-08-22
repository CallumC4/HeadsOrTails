using System.ComponentModel;
using System.ComponentModel.Design;

int i = 0;
int win = 0;
int loss = 0;


while(i < 3)
{
    
    Console.WriteLine("Heads or Tails? (H/T)");
    string pick = Console.ReadLine();

    
    Random flip = new Random();
    int result = flip.Next(0,2);

    if (result == 0 && pick == "H")
    {
            Console.WriteLine("Heads! You Won");
            win = win + 1;
        i++;
    }

    if (result == 1 && pick == "T")
    {
            Console.WriteLine("Tails! You Won");
            win = win + 1;
        i++;
    }       

    if (result == 0 && pick != "H")
    {
            Console.WriteLine("Wrong, you lose");
            loss = loss + 1;
        i++;
    }
    
    if (result == 1 && pick != "T")
    {
            Console.WriteLine("Wrong, you lose");
            loss = loss + 1;
        i++;
    }

        
}

Console.WriteLine("you won - " + win);
Console.WriteLine("you lost - " + loss);