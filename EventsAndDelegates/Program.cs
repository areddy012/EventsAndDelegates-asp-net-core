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

        // non-static methods call using create instantiation of class 
        Program program = new Program();
        //program.Addition(1, 2);

        AddNumberDelegate numberDelegate = new AddNumberDelegate(program.Addition);
        //First way
        numberDelegate(20, 60);

        //Second way
        numberDelegate.Invoke(56, 78);

        //Always static methods call using class
        //string str = Program.SayHello("Ayyappa"); 

        //Console.WriteLine(str);
        //Console.ReadLine();

        SayHelloDelegate sayHelloDelegate = new SayHelloDelegate(SayHello);

        //First way
        string str = sayHelloDelegate("ayyappa");
        //Second way
        string str1 = sayHelloDelegate.Invoke("Reddy");
        Console.WriteLine(str);
        Console.ReadLine();


    }
}