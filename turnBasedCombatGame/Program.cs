using System;

namespace turnBasedCombatGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerHp = 30;
            int enemyHp = 20;

            int playerAttack = 5;
            int enemyAttack = 7;

            int playerHeal = 5;
            int enemyHeal = 5;

            Random random = new Random();

            while (playerHp > 0 && enemyHp > 0)
            {
                //Player turn
                Console.WriteLine("\n-- Player Turn! --");
                Console.WriteLine("Player Hp - " + playerHp + "    Enemy Hp - " + enemyHp);
                Console.WriteLine("Press 'a' to attack and 'h' to heal. ");

                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    enemyHp -= playerAttack;
                    Console.WriteLine("Player attack enemy and deals " + playerAttack + " damage.");
                    Console.WriteLine();
                }

                else if (choice == "h") 
                {
                    playerHp += playerHeal;
                    Console.WriteLine("Player restores " + playerHeal + " health points."); 
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine("That is not a valid choice! You lost your turn.");
                }

                //Enemy Turn

                if (enemyHp > 0)
                {
                    Console.WriteLine("\n-- Enemy Turn -- "); 
                    Console.WriteLine("Player Hp - " + playerHp + "    Enemy Hp - " + enemyHp);
                    int enemyChoice = random.Next(0 , 2);

                    if(enemyChoice == 0) 
                    { 
                        playerHp -= enemyAttack;
                        Console.WriteLine("Enemy attack and deals " + enemyAttack + " damage.");
                        Console.WriteLine();
                    }

                    else 
                    {
                        enemyHp += enemyHeal;
                        Console.WriteLine("Enemy restores " + enemyHeal + " health points");
                    }
                }
            }
            
            if(playerHp > 0)
            {
                Console.WriteLine("Congrats! You've won the game.");
            }

            else
            {
                Console.WriteLine("You lost the game!");
            }
        }
    }
}
