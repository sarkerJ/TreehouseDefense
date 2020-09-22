namespace TreehouseDefense
{
    class SniperTower : Tower
    {
          protected override int Range {get;} = 3;

          protected override double Accuracy{get;} = 1.0;

          public SniperTower(MapLocation location) :base(location)
          {}
      
    }
  
}