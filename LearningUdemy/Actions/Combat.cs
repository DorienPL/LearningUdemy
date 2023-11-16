using LearningUdemy.Gear;
using LearningUdemy.Enemies;
using LearningUdemy.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningUdemy.Actions
{
    public class Combat
    {     
        public static void Fight(Monster enemy, Weapon weapon, Player player)
        {
            int damageAmount;
            while (enemy.monsterHealth > 0)
            {
                damageAmount = weapon.weaponDamage - enemy.monsterArmour;
                enemy.monsterHealth -= damageAmount;
                player.playerHealthPoints -= enemy.monsterDamage;

                if (enemy.monsterHealth <= 0 & player.playerHealthPoints > 0)
                {
                    player.playerGoldPieces += enemy.monsterGoldPiece;
                    player.playerExp += enemy.monsterExp;
                    Console.WriteLine($"You earned {enemy.monsterGoldPiece} GP. You have in total {player.playerGoldPieces} GP.");
                    Console.WriteLine($"You earned {enemy.monsterExp} XP. You have {player.playerExp} in total \n");
                }
                else if (player.playerHealthPoints <= 0)
                {
                    Console.WriteLine("You died in fight");
                    break;
                }

            }
        }
        
        
    }
}
