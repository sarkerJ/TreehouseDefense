namespace TreehouseDefense
{
    class PowerfullTower : Tower
    {
          protected override int Power{get;} = 2;

          public PowerfullTower(MapLocation location) :base(location)
          {}
      
    }
  
}