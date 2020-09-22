namespace TreehouseDefense
{
    class StrongInvader : Invader
    {
          public override int Health { get;  protected set; } = 4; //public property

          public StrongInvader(Path path) : base(path)
          {
                
          }
    }
}