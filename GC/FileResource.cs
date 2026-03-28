namespace GC;

public class FileResource : Resource, IDisposable
{
    public FileResource(string name, bool isopen) : base(name, isopen)
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
        Close();
    }
}