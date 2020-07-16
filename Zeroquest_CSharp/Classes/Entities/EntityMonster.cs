using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EntityMonster : EntityCommon
{
	/**
	 * Monster list:<br/>
	 * - monster name <br/>
	 * - monster level <br/>
	 * - monster attack <br/>
	 * - monster defense <br/>
	 * - monster health <br/>
	 * - amount of experience gained when defeated <br/>
	 */
	protected static String[,] monstersList =
		{
				{
					"Gobelin", "Skeleton", "Orc", "Ogre", "Troll", "Chaos warrior", "Lich", "Demon", "Zombie", "Werewolf", "Golem", "Cavern troll", "Orc chief"
				} ,
				{ //Level
					"1","1","2","3","4","5","4","6","10","1","6","10","6"
				},
				{ //Attack
					"1","2","2","3","4","3","5","6","2","5","6","6","4"
				},
				{ //Defense
					"2","1","2","2","3","3","2","5","1","3","6","3","3"
				},
				{ //Health points
					"1","1","1","3","6","2","3","6","1","4","4","6","3"
				},
				{ //Experience points acquired when defeated
					"5","5","10","15","20","25","20","30","50","25","30","50","30"
				},
		};

/**
 * Monster constructor
 */
public EntityMonster()
{
		Random randomMonster = new Random();
		int SpawnedMonster = randomMonster.Next(12);
	setEntityName(monstersList[0, SpawnedMonster]);
	//parseInt pour prendre les valeurs du tableau comme des nombres entiers
	setEntityAttack(int.Parse(monstersList[2, SpawnedMonster]));
	setEntityDefense(int.Parse(monstersList[3, SpawnedMonster]));
	setEntityTotalHealth(int.Parse(monstersList[4, SpawnedMonster]));
	setEntityCurrentHealth(int.Parse(monstersList[4, SpawnedMonster]));
}

/**
 * Method that return the monster defense score<br/>
 * @param monster
 * @return monsterDefense
 */
public int monsterDefense(EntityMonster monster)
{
	int monsterDefense = 0;
	for (int i = 0; i != monster.getEntityDefense(); i++)
	{
		Random randomDice = new Random();
		if (heroquestDiceType[randomDice.Next(6)] == "Ennemy Shield")
		{
			monsterDefense++;
		}
	}
	return monsterDefense;
}
}
