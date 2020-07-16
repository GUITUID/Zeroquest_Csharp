﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LoadGame
{
	/**
	 * Load a character from an existing file
	 */
	public static void loadCharacter()
	{


		Scanner scanner = new Scanner(System.in);
		//TODO load list of characters files
		/*
		 *  chose a map and then play
		 */

		// We search for existing files in the characters directory
		File folder = new File("C:/Users/Zadwarf.ZADWARF-PC/git/Zeroquest/datas/characters/");
		Console.WriteLine("\n--------------------------------------------------------------------------");
		Console.WriteLine("|                      CHOOSE A GAME TO LOAD                             |");
		Console.WriteLine("--------------------------------------------------------------------------\n");
		File[] listOfFiles = folder.listFiles();
		for (int i = 0; i < listOfFiles.length; i++)
		{
			if (listOfFiles[i].isFile())
			{
				Console.WriteLine(i + 1 + ") " + listOfFiles[i].getName());
			}

		}

		String savedGameChoice = scanner.next();

		EntityPlayer player = new EntityPlayer();

		// We get the character name to get the save file
		String fileToRead = listOfFiles[Integer.parseInt(savedGameChoice) - 1].getName();

		try
		{
			// Creating a JsonReader for the selected character file
			JsonReader reader = new JsonReader(new FileReader("C:/Users/Zadwarf.ZADWARF-PC/git/Zeroquest/datas/characters/" + fileToRead));

			reader.beginObject();

			while (reader.hasNext())
			{

				String name = reader.nextName();

				// Name
				if (name.equals("playerDataToSaveName"))
				{
					player.setEntityName(reader.nextString());
					// Race
				}
				else if (name.equals("playerDataToSaveRace"))
				{
					player.setEntityRace(Integer.parseInt(reader.nextString()));
					// Class
				}
				else if (name.equals("playerDataToSaveClass"))
				{
					player.setEntityClass(Integer.parseInt(reader.nextString()));
					// Level
				}
				else if (name.equals("playerDataToSaveLevel"))
				{
					player.setEntityLevel(Integer.parseInt(reader.nextString()));
					// Current XP
				}
				else if (name.equals("playerDataToSaveCurrentXp"))
				{
					player.setEntityCurrentXp(Integer.parseInt(reader.nextString()));
					// Total XP
				}
				else if (name.equals("playerDataToSaveTotalXp"))
				{
					player.setEntityTotalXp(Integer.parseInt(reader.nextString()));
					// Current City
				}
				else if (name.equals("playerDataToSaveCity"))
				{
					player.setEntityCity(Integer.parseInt(reader.nextString()));
					// Current X position
				}
				else if (name.equals("playerDataToSaveXPosition"))
				{
					player.setEntityXPosition(Integer.parseInt(reader.nextString()));
					// Current Y position
				}
				else if (name.equals("playerDataToSaveYPosition"))
				{
					player.setEntityYPosition(Integer.parseInt(reader.nextString()));
					// Attack score
				}
				else if (name.equals("playerDataToSaveAttack"))
				{
					player.setEntityAttack(Integer.parseInt(reader.nextString()));
					// Defense score
				}
				else if (name.equals("playerDataToSaveDefense"))
				{
					player.setEntityDefense(Integer.parseInt(reader.nextString()));
					// Current Alcohol level
				}
				else if (name.equals("playerDataToSaveAlcoholLevel"))
				{
					player.setEntityAlcoholLevel(Integer.parseInt(reader.nextString()));
					// Total Alcohol resistance
				}
				else if (name.equals("playerDataToSaveAlcoholResistance"))
				{
					player.setEntityAlcoholResistance(Integer.parseInt(reader.nextString()));
					// Current HP
				}
				else if (name.equals("playerDataToSaveCurrentHealth"))
				{
					player.setEntityCurrentHealth(Integer.parseInt(reader.nextString()));
					// Total HP
				}
				else if (name.equals("playerDataToSaveTotalHealth"))
				{
					player.setEntityTotalHealth(Integer.parseInt(reader.nextString()));
					// Gold
				}
				else if (name.equals("playerDataToSaveGold"))
				{
					player.setEntityGold(Integer.parseInt(reader.nextString()));
					// Starting City
				}
				else if (name.equals("playerDataToSaveStartingCity"))
				{
					player.setEntityStartingCity(Integer.parseInt(reader.nextString()));

				}
				else
				{
					//avoid some unhandled events
					reader.skipValue();
				}
			}

			reader.endObject();
			reader.close();

		}
		catch (FileNotFoundException e)
		{
			e.printStackTrace();
		}
		catch (IOException e)
		{
			e.printStackTrace();
		}

		Console.WriteLine("\n--------------------------------------------------------------------------");
		Console.WriteLine("|                 YOUR CHARACTER WAS SUCCESSFULY LOADED                  |");
		Console.WriteLine("--------------------------------------------------------------------------\n");
		Console.WriteLine("Here are your character information:\n"
						+ "\n\t[Pseudo: " + player.getEntityName() + "]"
						//+ "\nRace:" + p.getERace()//p.getERaceName(getERace())
						+ "\n\t[Race: " + player.getEntityRaceName(player.getEntityRace()) + "]"
						//+ "\nClass:" + p.getEClass()//p.getEClassName(getEClass())
						+ "\n\t[Class: " + player.getEntityClassName(player.getEntityClass()) + "]"
						+ "\n\n\tStats:"
						+ "\n\t[Level: " + player.getEntityLevel() + "]"
						+ "\n\t[Xp: " + player.getEntityCurrentXp() + "/" + player.getEntityTotalXp() + "]"
						+ "\n\t[Attack:" + player.getEntityAttack() + "]"
						+ "\n\t[Defense:" + player.getEntityDefense() + "]"
						+ "\n\t[Health:" + player.getEntityCurrentHealth() + "/" + player.getEntityTotalHealth() + "]"
						+ "\n\t[Gold:" + player.getEntityGold() + "]\n");



		//TODO load list of maps

		//TODO 
		//Calling action
		Actions.pShowActionsCity();

		int actionChoice = scanner.nextInt();

		Actions.pActionsCity(actionChoice, player);
		player.getEntityState();
		player.entityPlayerDatasToSave(player);


		//Actions.eActions(actionChoice, player, null);
		scanner.close();
	}
}
