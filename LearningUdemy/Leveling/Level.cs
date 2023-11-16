using System;
using LearningUdemy.Character;
namespace LearningUdemy.Leveling
{
	public class Level
	{
       public static void EarnLevel(Player player)
		{
			switch (player.playerExp)
			{
                case < 100:
					Console.WriteLine($"{player.playerName} is level 1");
					break;
				case < 200:
					Console.WriteLine($"{player.playerName} is level 2");
					player.playerHealthPoints += 10;
					break;
				case < 300:
					Console.WriteLine($"{player.playerName} is level 3");
					player.playerHealthPoints += 10;
					break;
                case < 400:
                    Console.WriteLine($"{player.playerName} is level 4");
                    player.playerHealthPoints += 10;
                    break;
                case < 500:
                    Console.WriteLine($"{player.playerName} is level 5");
                    player.playerHealthPoints += 10;
                    break;
            }
		}
		
	};
}

