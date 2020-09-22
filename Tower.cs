using System;

namespace TreehouseDefense
{
    class Tower
    {
        protected virtual int Range {get;} = 1;
        protected virtual int Power{get;} = 1;
        protected virtual double Accuracy {get;} = .75;
        
        
        private readonly MapLocation _location;
        
        public Tower(MapLocation location)
        {
            _location = location;
        }
        
        private bool IsSuccessfulShot()
        {
            return Random.NextDouble() < Accuracy;
        }
        
        public void FireOnInvaders(IInvader[] invaders) //loops through the invaders and shoot at them
        {
            foreach(IInvader invader in invaders)
            {
                if(invader.IsActive && _location.InRangeOf(invader.Location, Range)) //checks if the invader is active and in range of the tower
                {
                    if(IsSuccessfulShot())  //if the accuracy is under .75 then it shoots successfully , otherwise it misses the target and retries for the next one
                    {
                        invader.DecreaseHealth(Power);
                        if(invader.IsNeutralized)
                        {
                            Console.WriteLine("Neutralized an invader at " + invader.Location + " !");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Shot at and missed an invader");
                    }
                    break;
                }
            }
        }
    }
}