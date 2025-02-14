public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property before it's initialized
        Console.WriteLine(MyProperty); // Bug: Uninitialized property
    }
}