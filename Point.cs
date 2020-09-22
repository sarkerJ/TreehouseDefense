using System;

namespace TreehouseDefense
{
    class Point                //point represents a coordinate on the map
    {
        public readonly int X;
        public readonly int Y;
        
        public Point(int x, int y) //initializes x and y
        {
            X = x;
            Y = y;
        }
      
        public override string ToString()
        {
        
            return X + "," + Y;
        }
      
        public override bool Equals(object obj)
        {
            if(!(obj is Point))
            {
                return false;                
            }
          Point that = obj as Point;
          return this.X == that.X && this.Y == that.Y;
        }
        public override int GetHashCode()
        {
            return X.GetHashCode() * 31 + Y.GetHashCode(); //just used a prime number to make a new hash code
        }
      
        public int DistanceTo(int x, int y) //tells us the distance between the point object given in the parameter against the point object this specific point class is part of
        {
            return (int)Math.Sqrt(Math.Pow(X-x, 2) + Math.Pow(Y-y, 2));
        }
        
        public int DistanceTo(Point point) //same as above but accepts an instance of point instead of just x and y
        {
            return DistanceTo(point.X, point.Y);
        }
    }
}