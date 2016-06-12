namespace Task02
{
    using System;

    public class Task02
    {
        public static void Main()
        {
            var path = Console.ReadLine().ToCharArray();
            var input = Console.ReadLine().Split();
            var kittyMoves = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                kittyMoves[i] = int.Parse(input[i]);
            }

            var kittyPos = 0;
            var foodCount = 0;
            var soulsCount = 0;
            var deadlocksCount = 0;
            var deadlocked = false;
            var jumpsCount = 0;
            var pathLength = path.Length;

            for (int i = 0; i < kittyMoves.Length + 1; i++)
            {
                var currentValue = path[kittyPos];
                if (currentValue == '@')
                {
                    soulsCount++;
                    path[kittyPos] = 'V';
                }
                else if (currentValue == '*')
                {
                    foodCount++;
                    path[kittyPos] = 'V';
                }
                else if (currentValue == 'x')
                {
                    deadlocksCount++;

                    if ((kittyPos & 1) == 0)
                    {
                        soulsCount--;
                        if (soulsCount < 0)
                        {
                            deadlocked = true;
                            break;
                        }

                        path[kittyPos] = '@';
                    }
                    else
                    {
                        foodCount--;
                        if (foodCount < 0)
                        {
                            deadlocked = true;
                            break;
                        }

                        path[kittyPos] = '*';
                    }
                }

                if (i == kittyMoves.Length)
                {
                    break;
                }

                var currentMove = kittyMoves[i];

                while (currentMove < 0)
                {
                    if (kittyPos == 0)
                    {
                        kittyPos = pathLength;
                    }

                    kittyPos--;
                    currentMove++;
                }

                while (currentMove > 0)
                {
                    if (kittyPos == pathLength - 1)
                    {
                        kittyPos = -1;
                    }

                    kittyPos++;
                    currentMove--;
                }

                //// 0 1 2 3 4 5   = 6
                //kittyPos += currentMove;
                //if (kittyPos < 0)
                //{
                //    kittyPos += pathLength;
                //}
                //else if (kittyPos >= pathLength)
                //{
                //    kittyPos -= pathLength;
                //}

                jumpsCount++;
            }

            if (deadlocked)
            {
                Console.WriteLine("You are deadlocked, you greedy kitty!\nJumps before deadlock: {0}", jumpsCount);
            }
            else
            {
                Console.WriteLine("Coder souls collected: {0}\nFood collected: {1}\nDeadlocks: {2}", soulsCount, foodCount, deadlocksCount);
            }
        }
    }
}