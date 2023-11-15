using System.ComponentModel.DataAnnotations;
using System;
using LearningUdemy.Gear;
using LearningUdemy.Character;
using LearningUdemy.Enemies;
using LearningUdemy.Actions;

var Doomslayer = new Weapon
{
    weaponType = "Hammer",
    weaponDamage = 60,
    weaponPrice = 150,
    weaponRange = 2
};
var Prophecy = new Armour
{
    armourType = "Helmet",
    armourDamageReduction = 10,
    armourPrice = 200
};
var Patryk = new Player
{
    playerName = "Dorien",
    playerHealthPoints = 100,
    playerRace = "Human",
    playerGoldPieces = 420
};
var OrcChief = new Monster
{
    monsterType = "Orc",
    monsterHealth = 50,
    monsterArmour = 10,
    monsterDamage = 20,
    monsterGoldPiece = 25
};
Combat.Fight(OrcChief, Doomslayer, Patryk);


