namespace TreehouseDefense
{
    abstract class  Invader : IInvader //because we have the word abstract, this line doesnt mean Invader Inherits from IInvader but states Invader Implements The IInvader interface because of this any instances that refer to Invader should not be changed to IInvader. BUT NOT THE SUBCLASSES they can still inherit from Invader!
    {
        private readonly Path _path;
        private int _pathStep = 0; //invader keeps info of their location here
      
        protected virtual int StepSize {get;} =1;  //protected accessor allows Only invander and its Subclasses to access this variable
        
        public MapLocation Location => _path.GetLocationAt(_pathStep);  //computed property
        
        // True if the invader has reached the end of the path
        public bool HasScored { get { return _pathStep >= _path.Length; } }// computed property
        
        public abstract int Health { get; protected set; } //public property //abstract in here basically says that subclasses MUST OVERRIDE it to use it
        
        public bool IsNeutralized => Health <= 0;
        
        public bool IsActive => !(IsNeutralized || HasScored);
        
        public Invader(Path path)
        {
            _path = path;
        }
        
        public void Move() => _pathStep += StepSize;
        
        public virtual void DecreaseHealth(int factor) //virtual tells C# that this is one possible implementation of the decreaseHealth method & that subclasses can make have their own implementation of this method
        {
            Health -= factor;
            System.Console.WriteLine("Shot at and hit an invader!");

        }
    }
}