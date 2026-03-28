namespace GC;

public class NetworkResource : Resource, IDisposable
{
    public NetworkResource(string name, bool isopen) : base(name, isopen)
    {
    }

    public override void Open()
    {
        IsOpen = true;
        Console.WriteLine($"NetworkResource {Name} is opened");
    }

    public override void Close()
    {
        IsOpen = false;
        Console.WriteLine($"NetworkResource {Name} is closed.");
    }
    
    public void Dispose()
    {
        Close();
    }
}