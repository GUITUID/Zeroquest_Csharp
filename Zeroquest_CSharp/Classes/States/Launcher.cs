using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Launcher
{
	/**
	 * Launch the intro (splashscreen) and menu
	 */
	public void start()
	{
		//Monster m = new Monster();
		//Player p = new Player();
		//p.setEName("Zadwarf");
		//p.setECurrentHp(10);
		//p.setETotalHp(10);
		//p.setEAtk(3);
		//p.setEDef(3);

		//pchoice(p,m);

		//battle(p,m);

		State.intro();
		Menu.menu();
	}

	/**
	 * Main method
	 * @param args
	 */
	public static void main(String args [])
	{
		Launcher launcher = new Launcher();
		launcher.start();
	}
}
