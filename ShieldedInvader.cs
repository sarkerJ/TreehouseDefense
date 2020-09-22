using System;
namespace TreehouseDefense
{
    class ShieldedInvader : Invader //inherited all of the non static members of Invader but only changed 1. Aka same functions and usage apart 1 method
    {
        public override int Health { get; protected set; } =2; //the public property is being overidden so you can use it. 
  
      
        public ShieldedInvader(Path path) : base(path)
        {}
        
        public override void DecreaseHealth(int factor) //since we are making a diff implementation of this method we swap "virtual" to ovveride" for the subclasses that have their own implementation of it
               
              {
                    if(Random.NextDouble() < .5)
                    {
                      base.DecreaseHealth(factor); //base just means use the parent method called DecreaseHealth method implementation
                    }
                    else
                    {
                      System.Console.WriteLine("Shot at a shielded invader but it sustained no damage");
                    }
                
              }
    
    }
}