using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using LearningUdemy.Gear;
using LearningUdemy.Monsters;

namespace LearningUdemy.Player
{
    public class Player
    {
        public string playerName;
        public string playerRace;
        public int playerHealthPoints;
        public int playerGoldPieces;

        public static void DealDamage<TMonster, TWeapon,TPlayer>(TMonster enemy, TWeapon weapon,TPlayer player)
            where TMonster : Monster
            where TWeapon : Weapon
            where TPlayer : Player
        {
            int damageAmount = enemy.monsterHealth - weapon.weaponDamage;
            Console.WriteLine(damageAmount);
        }
        public static void EarnMoney<TMonster, TPlayer>(TMonster enemy, TPlayer player)
            where TMonster : Monster
            where TPlayer : Player
        {
            if (enemy.monsterHealth <= 0)
            {
                player.playerGoldPieces += enemy.monsterGoldPiece;
                Console.WriteLine("You earned: " + enemy.monsterGoldPiece + "\n" + "You have in total: " + player.playerGoldPieces);
            }
            else
            {
                Console.WriteLine("You earned nothing :)");
            }
        }
    }
}
