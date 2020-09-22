using System;

namespace TreehouseDefense
{
    class Game
    {
        public static void Main() //first method that is run in the game
        {
            Map map = new Map(8, 5);
            
            try
            {
                Path path = new Path(
                    new [] {
                        new MapLocation(0, 2, map),
                        new MapLocation(1, 2, map),
                        new MapLocation(2, 2, map),
                        new MapLocation(3, 2, map),
                        new MapLocation(4, 2, map),
                        new MapLocation(5, 2, map),
                        new MapLocation(6, 2, map),
                        new MapLocation(7, 2, map)
                    }
                );
//                MapLocation location = new MapLocation(0,2,map);
//                
//                if(path.IsOnPath(location))
//                   {
//                      Console.WriteLine(location + "Location is on the path");
//                      return;
//                   }
//              
                IInvader[] invaders =  //Had to change Invader[] = To IInvader[] because ResurrectingInvader is not a type Invader But a IInvader type
                {
//                    new ShieldedInvader(path),
//                    new FastInvader(path),
//                    new StrongInvader(path),
//                    new BasicInvader(path),
                    new ResurrectingInvader(path)

                };
                
                Tower[] towers = {
                    new LongRangeTower(new MapLocation(1, 3, map)),
//                    new SniperTower(new MapLocation(3, 3, map)),
//                    new PowerfullTower(new MapLocation(5, 3, map)),
                    new Tower(new MapLocation(7, 3, map)),
                };
                
                Level leve1 = new Level(invaders)
                {
                    Towers = towers
                };
                
                bool playerWon = leve1.Play();
                
                Console.WriteLine("Player " + (playerWon? "won" : "lost"));
            }
            catch(OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(TreehouseDefenseException)
            {
                Console.WriteLine("Unhandled TreehouseDefenseException");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unhandled Exception: " + ex);
            }
        }
    }
}