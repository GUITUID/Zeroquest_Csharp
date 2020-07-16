﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PlayerState
{



	public static void flee(Player player)
	{
		player.setEntityState("flee.");
	}

	public static void eat(Player player, Object object)
	{
		player.setEntityState("eat" + object.getObjectName());
	}

	public static void drink(Player player, Object object)
	{
		if (player.getEntityAlcoholResistance() < player.getEntityAlcoholLevel())
		{
			getDrunk(player);
		}
		else
		{
			player.setEntityState("drink" + object.getObjectName());
			player.setEntityAlcoholLevel(player.getEntityAlcoholLevel() + object.OAlcStat());
		}
	}

	public static void getDrunk(Player player)
	{
		player.setEntityState("is totally drunk.");
	}

	public static void dead(Player player)
	{
		player.setEntityState("is dead.");
	}

	public static void look(Player player, Object object, Place place)
	{
		if (object != null)
		{
			player.setEntityState("look at" + object.getObjectName());
		}
		else if (place != null)
		{
			player.setEntityState("look at" + place.getPlaceName());
		}
	}

	public static void sleep(Player player, Place place)
	{
		player.setEntityState("is asleep");
	}

	public static void deepsleep(Player player, Place place)
	{
		player.setEntityState("is deeply asleep");
	}

	public static void poisoned(Player player)
	{
		player.setEntityState("is poisoned");
	}

	public static void sick(Player player)
	{
		player.setEntityState("is sick");
	}

	/**
	 * 
	 * @param playerState
	 */
	static void playerState(int playerState)
	{
		for (int i = 0; i != 6; i++)
		{
			//Console.WriteLine(pactions[i]);
		}
	}

	//Player actions method
	//static int nActions()
	//{
	//return pactions.length;
	//}


	//Player actions method
	static void playerActions()
	{
		//for(int i=0; i!=nActions(); i++){
		//Console.WriteLine(pactions[i]);
		//}
	}

	public void playerChoseToFight(Player player, Monster monster)
	{
		Console.WriteLine(player.getEntityName() + " face a " + monster.getEntityName());

		playerActions();
		Console.WriteLine("----------------------------");
	}

}
