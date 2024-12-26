public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public ExampleClass()
    {
        MyProperty = 0; // Initialize to a default value
    }

    public void MyMethod()
    {
        int value = MyProperty * 2; // No longer a potential NullReferenceException
    }
}