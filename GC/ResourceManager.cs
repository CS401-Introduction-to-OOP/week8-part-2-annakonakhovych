namespace GC;

public class ResourceManager<T> where T : Resource
{
    private List<T> _resource = new List<T>();

    public void Add(T resource)
    {
        _resource.Add(resource);
    }

    public void OpenAll()
    {
        foreach (var resource in _resource)
        {
            resource.Open();
        }
    }
    
    public void CloseAll()
    {
        foreach (var resource in _resource)
        {
            resource.Close();
        }
    }
    
    
}