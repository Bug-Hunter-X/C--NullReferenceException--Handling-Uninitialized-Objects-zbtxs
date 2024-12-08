public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize to default value

    public void MyMethod()
    {
        // Check for null before accessing
        Console.WriteLine(MyProperty.ToString());
    }

    //Or use null-conditional operator (?.) for concise code. 
    public void MyMethod2()
    {
        Console.WriteLine(MyProperty?.ToString()); 
    }
}