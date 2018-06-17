namespace C_Sharp_Objects
{
    class C_Sharp_ObjectsException : System.Exception
    {
        public C_Sharp_ObjectsException()
        {
        }
        
        public C_Sharp_ObjectsException(string message) : base(message)
        {
        }
        
    }
    
    class OutOfBoundsException : C_Sharp_ObjectsException
    {
        public OutOfBoundsException()
        {
        }
        
        public OutOfBoundsException(string message) : base(message)
        {
        }
    }
}