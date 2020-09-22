namespace TreehouseDefense
{
    class FastInvader : Invader
    {
          protected override int StepSize {get; } =2;  //protected accessor allows Only invander and its Subclasses to access this variable
        
          public override int Health { get; protected set; } =2; //the public property is being overidden so you can use it. 

          public FastInvader(Path path) : base(path){}
    }
}