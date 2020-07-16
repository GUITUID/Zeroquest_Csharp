using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cards
{

	String cardName;
	int cardCost;

	Boolean cardUnlocked;
	Boolean cardIsInHand;

	void setcardCost(int cardCost)
	{
		this.cardCost = cardCost;
	}

	public int getcardCost()
	{
		return cardCost;
	}

	void setcardUnlocked(Boolean cardUnlocked)
	{
		this.cardUnlocked = cardUnlocked;
	}

	public Boolean getcardUnlocked()
	{
		return cardUnlocked;
	}

	void setcardIsInHand(Boolean cardIsInHand)
	{
		this.cardIsInHand = cardIsInHand;
	}

	public Boolean getcardIsInHand()
	{
		return cardIsInHand;
	}
}
