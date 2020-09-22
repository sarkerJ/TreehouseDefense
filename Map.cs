namespace TreehouseDefense
{
    class Map
    {
        public readonly int Width;
        public readonly int Height;
        
        public Map(int width, int height) //creates the map
        {
            Width = width;
            Height = height;
        }
        
        public bool OnMap(Point point) //checks whether or not something is on the map or not
        {
            return point.X >= 0 && point.X < Width && 
                   point.Y >= 0 && point.Y < Height;
        }
    }
}