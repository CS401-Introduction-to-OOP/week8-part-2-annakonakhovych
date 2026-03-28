namespace GC;

public class FileResource : Resource, IDisposable
{
    public FileResource(string name) : base(name)
    {
    }

    public override void Open()
    {
        IsOpen = true;
        Console.WriteLine($"File {Name} is opened");
    }

    public override void Close()
    {
        IsOpen = false;
        Console.WriteLine($"File {Name} is closed.");
    }
    
    public void Dispose()
    {
        Console.WriteLine($"Cleaning up {Name}");
        Close();
    }
}