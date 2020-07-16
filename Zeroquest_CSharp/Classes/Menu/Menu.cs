using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Menu
{

    public static void menu()
    {
		
		Console.WriteLine("--------------------------------------------------------------------------");
		Console.WriteLine("|                              MENU                                      |");
		Console.WriteLine("--------------------------------------------------------------------------");
		
		Console.WriteLine("\n1)New game \n2)Load Game \n3)Multiplayer \n4)Options \n5)Quit");
        //Scanner scanner = new Scanner(System.in);
        //string userInput = Console.ReadLine();
        int menuChoice = Convert.ToInt32(Console.ReadLine());
        //int menuChoice = scanner.nextInt();

        switch (menuChoice)
        {
            //If we chose a New Game we will create a new character
            case 1:
                NewGame.createCharacter();
                break;
            case 2:
    		Console.WriteLine("Not implemented yet\n");

                //Console.WriteLine("Please select a saved game:\n");
                break;
            case 3:
    		Console.WriteLine("No options for this game yet\n");

                break;
            case 4:
    		Console.WriteLine("Coming as soon as possible\n");
                break;
            case 5:
                State.quit();
                System.Windows.Forms.Application.Exit();
                //System.exit(0);
                break;
        }

        //scanner.close();
    }
}
