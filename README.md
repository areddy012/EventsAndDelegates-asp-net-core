 A delegate is a type-safe function pointer that holds the reference of a method and invokes it for execution. To call a method using a delegate, we follow three steps:

1) Define a delegate:
                [<Modifiers>] delegate void | type <Name>([<Parameter list>]);

            The return type of the delegate and the method it references should match.
            Parameters of the delegate and the referenced method should have matching types.

         Example:
        
            public delegate void AddNumberDelegate(int x, int y);
            public void Addition(int a, int b);

            public delegate string SayHelloDelegate(string name);
            public static string SayHello(string name);
2) Instantiate the delegate:
            AddNumberDelegate numberDelegate = new AddNumberDelegate(program.Addition);
            SayHelloDelegate sayHelloDelegate = new SayHelloDelegate(SayHello);
   
4) Now call the delegate by passing required parameter values, so that internally the method which is bound with the delegate gets executed.

     AddNumberDelegate numberDelegate = new AddNumberDelegate(program.Addition);
        //First way
        numberDelegate(20, 60);

        //Second way
        numberDelegate.Invoke(56, 78);

    SayHelloDelegate sayHelloDelegate = new SayHelloDelegate(SayHello);

        //First way
        string str = sayHelloDelegate("ayyappa");
        //Second way
        string str1 = sayHelloDelegate.Invoke("Reddy");
        Console.WriteLine(str);
        Console.ReadLine();


   
