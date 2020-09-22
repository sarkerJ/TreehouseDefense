namespace TreehouseDefense
{
    class LongRangeTower : Tower
    {
          protected override int Range {get;} = 4;

          public LongRangeTower(MapLocation location) :base(location)
          {}
      
    }
  
}