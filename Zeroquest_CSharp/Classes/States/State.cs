using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class State
{

	public static void intro()
	{
		/*Console.WriteLine("--------------------------------------------------------------------------\n"
		+ "||||||| |||||  ||||||    ||||     ||||     ||   || ||||||  ||||| ||||||||\n"
		+ "     || ||     ||   || ||    || ||    ||   ||   || ||     ||        ||\n"
		+ "  |||   ||||   |||||   ||    || ||    ||   ||   || ||||     ||      ||\n"
		+ "||      ||     ||  ||  ||    || ||   |||   ||   || ||         ||    ||\n"
		+ "||||||| |||||  ||   ||   ||||     ||||||    |||||  |||||| |||||     ||\n"
		+ "--------------------------------------------------------------------------"
		+ ""
		+ "An O'nun'kawa production
		+ ""
		
		
		);*/


	}

	/**
	 * Starts the game
	 */
	public static void titleScreen()
	{
		intro();
		Menu.menu();
	}

	/**
	 * Pause the game
	 */
	public static void pause()
	{

	}

	/**
	 * Close the game, saving all datas before exit
	 */
	public static void quit()
	{
		//TODO save all files before exit
		System.exit(0);
	}
}
