public sealed class Logger 
{
   // using thread safe singleton pattern 
    private static Logger instance = null;
    private static readonly object plock=new object();
    
    private Logger()
    {
        
    }

    public static Logger GetInstances()
    {
        lock(plock)
        {
          if(instance==null)
          {
      		instance=new Logger();
          }
        
        }
       return instance;
    }
}