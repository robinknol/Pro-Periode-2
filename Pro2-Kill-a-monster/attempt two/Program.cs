using System;

namespace Pro2_Kill_a_monster
{
    class Program
    {
        static void Main(string[] args)
        {
            Player myPlayer = new Player();
            Monster myMonster = new Monster();
            Random randomNum = new Random();

            while (myMonster.hitPoints >= 1)
            {
                

                // random number generators
                int monsterAction = randomNum.Next(1,2);
                int playerRun = 20;

                Console.Clear();
                
                Console.WriteLine(myMonster.name + " has " + myMonster.hitPoints + " hit points left");
                Console.WriteLine(myPlayer.name + " has " + myPlayer.hitPoints + " hitpoints left");

                string playerAction = Console.ReadLine();

                // Player action
                if (playerAction == "attack")
                {
                    playerAttack();
                }

                else if (playerAction == "run")
                {
                    playerHeal();
                }

                else if (playerAction == "quit")
                {
                    return;
                }
                // end of player action

                // monster action
                // Console.WriteLine(monsterAction);
                if (monsterAction == 1)
                {
                    MonsterAttack();
                }

                else if (monsterAction == 2)
                {
                    monsterHeal();
                }
                Console.ReadLine();
            }

            void playerAttack()
            {
                int hitPlayer = randomNum.Next(1, 20);

                if (hitPlayer == 1)
                {
                    Console.WriteLine(myPlayer.name + " trip's");
                    // Console.WriteLine(hitPlayer);
                    myPlayer.hitPoints -= 5;
                }
                else if (hitPlayer <= 5)
                {
                    Console.WriteLine(myPlayer.name + " missed");
                    // Console.WriteLine(hitPlayer);
                }
                else if (hitPlayer >= 6)
                {
                    Console.WriteLine(myPlayer.name + " hit's");
                    // Console.WriteLine(hitPlayer);
                    myMonster.hitPoints -= 10;
                }
                else if (hitPlayer == 20)
                {
                    Console.WriteLine(myPlayer.name + "crits");
                    // Console.WriteLine(hitPlayer);
                    myMonster.hitPoints -= 25;
                }
            }

            void playerHeal()
            {
                
                int playerRun = randomNum.Next(1, 20);

                if (playerRun <= 5)
                {
                    Console.WriteLine("You can't run away");
                    // Console.WriteLine(playerRun);
                }
                else if (playerRun >= 6)
                {
                    Console.WriteLine("You got away but " + myMonster.name + " will find you and will kill you");
                    // Console.WriteLine(playerRun);
                    myPlayer.hitPoints += 15;
                }
                else if (playerRun == 20)
                {
                    Console.WriteLine("you got away and the" + myMonster.name + " will not be able to find you");
                    // Console.WriteLine(playerRun);
                    myPlayer.hitPoints = 100;
                }
            }

            void MonsterAttack()
            {
                int hitMonster = randomNum.Next(1, 20);

                if (hitMonster == 1)
                {
                    Console.WriteLine(myMonster.name + " trip's");
                    // Console.WriteLine(hitMonster);
                    myMonster.hitPoints -= 5;
                }
                else if (hitMonster <= 3)
                {
                    Console.WriteLine(myMonster.name + " missed");
                    // Console.WriteLine(hitMonster);
                }
                else if (hitMonster >= 6)
                {
                    Console.WriteLine(myMonster.name + " hit's");
                    // Console.WriteLine(hitMonster);
                    myPlayer.hitPoints -= 10;
                }
                else if (hitMonster >= 19)
                {
                    Console.WriteLine(myMonster.name + "crits");
                    // Console.WriteLine(hitMonster);
                    myPlayer.hitPoints -= 25;
                }
            }

            void monsterHeal()
            {
                int monsterRun = randomNum.Next(1, 20);

                if (monsterRun <= 9)
                {
                    Console.WriteLine("It seems like " + myMonster.name + " is trying to run away but he can't");
                    // Console.WriteLine(monsterRun);
                }
                else if (monsterRun >= 10)
                {
                    Console.WriteLine("How did you lose " + myMonster.name + " he got away");
                    // Console.WriteLine(monsterRun);
                    myMonster.hitPoints += 25;
                }
            }
        }
    }
}
