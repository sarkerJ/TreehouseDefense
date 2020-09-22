namespace TreehouseDefense
{
    class MapLocation : Point //subclass of point . MapLocation Inherits all of the non static members of the parent class
    {
        public MapLocation(int x, int y, Map map) : base(x, y) //method used to check if something is on the map
        {
            if (!map.OnMap(this))
            {
                throw new OutOfBoundsException(this + " is outside the boundaries of the map."); //this in this case would print the map location info . This is done through the .ToString which is automatically called. Since we did an override of that method in Point it will print X and Y instead
            }
        }
        
        public bool InRangeOf(MapLocation location, int range) //finds if a speific instance is in range of the instance which this instance of maplocation is part of
        {
            return DistanceTo(location) <= range;
        }
    }
}