public delegate void AddNumberDelegate(int x, int y);
public delegate string SayHelloDelegate(string name);

class Program
{
    public void Addition(int a, int b)
        => Console.WriteLine(a + b);
    

    public static string SayHello(string name)
        => "Hello" + name;

    public static void Main(string[] args)
    {
        Program program = new Program();
       
        AddNumberDelegate numberDelegate = new AddNumberDelegate(program.Addition);
        
        numberDelegate(20, 60);
        numberDelegate.Invoke(56, 78);

        SayHelloDelegate sayHelloDelegate = new SayHelloDelegate(SayHello);

        string str = sayHelloDelegate("ayyappa");
        string str1 = sayHelloDelegate.Invoke("Reddy");
        Console.WriteLine(str);
        Console.ReadLine();


    }
}