public class ExampleClass
{
    public int MyProperty { get; set; } //Declare the property

    // Constructor to initialize the property
    public ExampleClass()
    {
        MyProperty = 10; //Initialize the property
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); // Now it's safe
    }

    //Example of initializing directly before use:
    public void AnotherMethod()
    {
        MyProperty = 20;
        Console.WriteLine(MyProperty);
    }
}