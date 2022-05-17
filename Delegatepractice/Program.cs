// See https://aka.ms/new-console-template for more information
using Delegatepractice;
using Delegate = Delegatepractice.Delegate;

//Console.WriteLine("Hello, World!");
//Console.WriteLine("Delegatepractice"); 
//Delegate obj = new ();
//AddDelegate ad = new(obj.Add);
//GreetingsDelegate gd = new(Delegate.Greetings);
//ad(100, 50);
//string GreetingsMessage = gd("Rupali");
//Console.WriteLine(GreetingsMessage);
//Console.ReadKey();
MulticastDel p = new MulticastDel();
MathDelegate del1 = new MathDelegate(MulticastDel.Add);
MathDelegate del2 = new MathDelegate(MulticastDel.Sub);
MathDelegate del3 = p.Mul;
MathDelegate del4 = new MathDelegate(p.Div); ;
MathDelegate del5 = del1 + del2 + del3 + del4;
del5.Invoke(20, 5);
Console.WriteLine();
del5 -= del2;
del5(22, 7);




