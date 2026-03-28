namespace GC;

public abstract class Resource
{
    public string Name;
    public bool IsOpen;

    public Resource(string name, bool isopen)
    {
        Name = name;
        IsOpen = isopen;
    }

    public abstract void Open();
    public abstract void Close();
    
}