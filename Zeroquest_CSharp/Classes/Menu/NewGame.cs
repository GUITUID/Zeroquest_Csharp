﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NewGame
{
	/**
	 * Create a new character
	 */
	public static void createCharacter()
	{
		Scanner scanner = new Scanner(System.in);

		Console.WriteLine("--------------------------------------------------------------------------");
		Console.WriteLine("|                     ~~ CHARACTER CREATION ~~                           |");
		Console.WriteLine("--------------------------------------------------------------------------");
		Console.WriteLine("--------------------------------------------------------------------------");
		Console.WriteLine("|                      CHOSE YOUR NICKNAME                               |");
		Console.WriteLine("--------------------------------------------------------------------------");
		Console.WriteLine("Please write your nickname:");
		//TODO test response
		String pseudoChoice = scanner.next();
		//TODO check input from user
		//Console.WriteLine(RaceChoice);
		Console.WriteLine("--------------------------------------------------------------------------");
		Console.WriteLine("|                            PICK A RACE                                 |");
		Console.WriteLine("--------------------------------------------------------------------------");
		Console.WriteLine("Please pick a race:\n"
				+ "\n\t1)Human\n"
				+ "\tJack of all trade, master of none\n"
				+ "\n\t2)Dwarf\n"
				+ "\tTreasure finder, heavy drinker\n"
				+ "\n\t3)Elf\n"
				+ "\tBoulder..., vegetables eater...\n"
				+ "\n\t10)Random"
				+ "[Info: New races will be implemented later]");
		//New races will be implemented later
		int raceChoice = scanner.nextInt();
		//TODO check input from user
		Console.WriteLine("--------------------------------------------------------------------------");
		Console.WriteLine("|                           PICK A CLASS                                 |");
		Console.WriteLine("--------------------------------------------------------------------------");
		Console.WriteLine("Please pick a class:\n"
				+ "\n\t[Info: New classes will be implemented later]"
				+ "\n\t1)Warrior\n"
				+ "\tHP:10\tAtk:3\tDef:3\n"
				+ "\tAn equilibrated class, good for starting\n"
				+ "\n\t2)Paladin\n"
				+ "\tHP:12\tAtk:2\tDef:5\n"
				+ "\tA tanking class, good for taking damages\n"
				+ "\n\t3)Barbarian\n"
				+ "\tHP:12\tAtk:5\tDef:2\n"
				+ "\tA dps class, good for making damages\n"
				//New classes will be implemented later
				//+ "\n4)Thief\n"
				//+ "HP:6|Atk:4|Def:2\n"
				//+ "A dps class with extra damages if he hit ennemies from behind \n"
				//+ "\n5)Archer\n"
				//+ "HP:6|Atk:4|Def:2\n"
				//+ "A dps class with ability to shoot from distance\n"
				//+ "\n6)Mage\n"
				//+ "HP:4|Atk:4|Def:2\n"
				//+ "A dps class with powerful magic\n"
				//+ "\n7)Priest\n"
				//+ "HP:8|Atk:2|Def:3\n"
				//+ "A healing class, good for assist\n"
				//+ "\n8)[ELITE CLASS: Monk]\n"
				//+ "HP:6|Atk:5|Def:1\n"
				//+ "A dps class fighting only with hands\n"
				//+ "\n9)[ELITE CLASS: Ninja]\n"
				//+ "HP:6|Atk:4|Def:2\n"
				//+ "A dps class with powerful special habilities\n"
				+ "\n\t10)Random");

		int classChoice = scanner.nextInt();
		//TODO check input from user

		Player player = new Player();
		player.setEntityName(pseudoChoice);
		player.setEntityRace(raceChoice - 1);
		player.setEntityClass(classChoice - 1);
		player.setEntityCurrentHealth(player.getEntityClass());
		player.setEntityTotalHealth(player.getEntityClass());
		player.setEntityAttack(player.getEntityClass());
		player.setEntityDefense(player.getEntityClass());
		player.setEntityLevel(1);
		player.setEntityCurrentXp(0);
		player.setEntityTotalXp(100);
		int randomGold = new Random().nextInt(10);
		player.setEntityGold(randomGold);

		//Create a new json file for saving character status
		Json playerDatas = new Json();
		playerDatas.setOutputType(OutputType.json);

		//saving newly created character in a json format
		try
		{
			Saving.saveFile(pseudoChoice, playerDatas.prettyPrint(player), "character");
		}
		catch (IOException e1)
		{
			// TODO Auto-generated catch block
			Console.WriteLine("Error: error when creating character file");
			e1.printStackTrace();
		}

		//TODO write on a json file and next push to Rethinkdb database

		Console.WriteLine("--------------------------------------------------------------------------");
		Console.WriteLine("|        CONGRATULATION YOUR CHARACTER WAS SUCCESSFULY CREATED           |");
		Console.WriteLine("--------------------------------------------------------------------------");
		Console.WriteLine("Here are your character information:\n"
				+ "\n\t[Pseudo: " + player.getEntityName() + "]"
				//+ "\nRace:" + p.getERace()//p.getERaceName(getERace())
				+ "\n\t[Race: " + player.getEntityRaceName(player) + "]"
				//+ "\nClass:" + p.getEClass()//p.getEClassName(getEClass())
				+ "\n\t[Class: " + player.getEntityClassName(player) + "]"
				+ "\n\n\tStats:"
				+ "\n\t[Level: " + player.getEntityLevel() + "]"
				+ "\n\t[Xp: " + player.getEntityCurrentXp() + "/" + player.getEntityTotalXp() + "]"
				+ "\n\t[Attack:" + player.getEntityAttackValue() + "]"
				+ "\n\t[Defense:" + player.getEntityDefense() + "]"
				+ "\n\t[Health:" + player.getEntityCurrentHealth() + "/" + player.getEntityTotalHealth() + "]"
				+ "\n\t[Gold:" + player.getEntityGold() + "]");
		
		//TODO implements the rest of newgame
		Console.WriteLine("\nWelcome to Kaldhazan" + player.getEntityName());
		Console.WriteLine("What's your plans ?");
		//you start in a city, what's your plans ?
		//
		// find a quest
		// go to tavern
		// 

		scanner.close();

	}
}
