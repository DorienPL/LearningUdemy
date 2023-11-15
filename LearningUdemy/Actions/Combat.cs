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
            int damageAmount = weapon.weaponDamage - enemy.monsterArmour;
            enemy.monsterHealth -= weapon.weaponDamage;
            Console.WriteLine("You dealt " + damageAmount + " damage");

            if (enemy.monsterHealth <= 0)
            {
                player.playerGoldPieces += enemy.monsterGoldPiece;
                Console.WriteLine("You earned " + enemy.monsterGoldPiece + " GP"+ "\n" + "You have in total " + player.playerGoldPieces + " GP");
            }
            else
            {
                Console.WriteLine("You earned nothing :)");
            }
        }
    }
}
