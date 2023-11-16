using System.ComponentModel.DataAnnotations;
using System;
using LearningUdemy.Gear;
using LearningUdemy.Character;
using LearningUdemy.Enemies;
using LearningUdemy.Actions;
using LearningUdemy.Leveling;

var Prophecy = new Armour
{
    armourType = "Helmet",
    armourDamageReduction = 10,
    armourPrice = 200
};
var Doomslayer = new Weapon
{
    weaponType = "Hammer",
    weaponDamage = 20,
    weaponPrice = 150,
};
var Patryk = new Player
{
    playerName = "Dorien",
    playerHealthPoints = 100,
    playerRace = "Human",
    playerGoldPieces = 420,
    playerExp = 0
};
var OrcChief = new Monster
{
    monsterType = "Orc",
    monsterHealth = 50,
    monsterArmour = 20,
    monsterDamage = 20,
    monsterGoldPiece = 25,
    monsterExp = 20
};
var Goblin = new Monster
{
    monsterType = "Goblin",
    monsterHealth = 20,
    monsterArmour = 5,
    monsterDamage = 10,
    monsterGoldPiece = 10,
    monsterExp = 100
};
var DragonLord = new Monster
{
    monsterType = "Dragon",
    monsterHealth = 1000,
    monsterArmour = 100,
    monsterDamage = 150,
    monsterGoldPiece = 2000,
    monsterExp = 1500
};
Combat.Fight(Goblin, Doomslayer, Patryk);
Combat.Fight(DragonLord, Doomslayer, Patryk);

Level.EarnLevel(Patryk);