namespace TreehouseDefense //the interface used to create the abstract method. 
{
  
    interface IMappable
    {
           MapLocation Location {get;}  //computed property

    }
  
    interface IMovable
    {
          void Move();

    }
  
  
    interface IInvader :IMovable, IMappable
    {
        
        // True if the invader has reached the end of the path
         bool HasScored { get ;}
        
         int Health { get; } //public property //abstract in here basically says that subclasses MUST OVERRIDE it to use it
        
         bool IsNeutralized {get;}
        
         bool IsActive{get;}

         void DecreaseHealth(int factor);
    }

}