using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pnj : CommonEntity
{

//player defense method
int pnjDef(Pnj pnj)

	{
		int a = 0;
		for (int i = 0; i != pnj.getEntityDefense(); i++)
		{
			Random randomDice = new Random();
			if (heroquestDiceType[randomDice.Next(6)] == "Shield")
			{
				a++;
			}
		}
		return a;
	}

}
