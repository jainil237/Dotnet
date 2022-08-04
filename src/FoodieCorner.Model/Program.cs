namespace abc
{
    public class dosa {
        public int i = 9;
        public int func(int j)
        {
            return j * 10;
        }
        public void print( int j)
        {
            Console.WriteLine(func(j));
        
        }
    
    }  
    public class masala : dosa
    {
       public int k = 20;
         
    }
    class program
    {
        public static void Main(string[] args)
        {

            dosa obj= new masala();
            obj.print(obj.i);   
        }
    }
}