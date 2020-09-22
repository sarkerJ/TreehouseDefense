namespace TreehouseDefense
{
    class BasicInvader : Invader
    {         
          public override int Health { get; protected set; } =2; //the public property is being overidden so you can use it. 

          public BasicInvader(Path path) : base(path){}
    }
}