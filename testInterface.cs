namespace ConsoleApp{
 public interface Parent{
     int sum (int a,int b);
 }

    public class sonA : Parent
    {
        public int sum(int a, int b)
        {
            return a + b;
        }
    }


    public class SonB : Parent
    {
        public int sum(int a, int b)
        {
            return a * b ;
        }
    }

    
}