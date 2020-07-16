using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Battle
{

	public static void entitiesBattle(Player player, Monster monster)
	{
		Console.WriteLine(monster.getEntityName() + " attack " + player.getEntityName());

		while (player.getEntityCurrentHealth() > 0 || monster.getEntityCurrentHealth() > 0)
		{
			int monsterAttack = monster.EntityAttack();
			int playerDefense = player.playerDefense(player);
			int playerGetHitXTimes = monsterAttack - playerDefense;

			if (playerGetHitXTimes > 0)
			{
				Console.WriteLine(monster.getEntityName() + " attack " + monsterAttack + " times.");
				Console.WriteLine(player.getEntityName() + " defend " + playerDefense + " times.");
				Console.WriteLine(player.getEntityName() + " is hit " + playerGetHitXTimes + " times.");
				player.entityLoseHealth(playerGetHitXTimes);

				if (player.getEntityCurrentHealth() <= 0)
				{
					Console.WriteLine(player.getEntityName() + " is dead.");
					Console.WriteLine("----------------------------");
					Console.WriteLine("GM says:"
							+ " You suck...");
					break;
				}
			}
			else
			{
				Console.WriteLine(player.getEntityName() + " parried the attack.");
			}

			Console.WriteLine("----------------------------");

			int playerAttack = player.EntityAttack();
			int monsterDefense = monster.monsterDefense(monster);
			int monsterGetHitXTimes = playerAttack - monsterDefense;

			if (monsterGetHitXTimes > 0)
			{
				Console.WriteLine(player.getEntityName() + " attack " + playerAttack + " times.");
				Console.WriteLine(monster.getEntityName() + " defend " + monsterDefense + " times.");
				Console.WriteLine(monster.getEntityName() + " is hit " + monsterGetHitXTimes + " times.");
				Console.WriteLine(player.getEntityName() + " says: ");
				player.playerHitSpeech();
				monster.entityLoseHealth(monsterGetHitXTimes);

				if (monster.getEntityCurrentHealth() <= 0)
				{
					Console.WriteLine("----------------------------");
					Console.WriteLine(monster.getEntityName() + " is dead.");
					Console.WriteLine(player.getEntityName() + " says: " + monster.getEntityName() + "s"); player.playerVictorySpeech();

					break;
				}
			}
			else
			{
				Console.WriteLine(monster.getEntityName() + " parried the attack.");
			}

			Console.WriteLine("----------------------------");

		}

	}
}