public class GuidService : IGuidService
{
    private readonly string _guid;

    public GuidService()
    {
        _guid = Guid.NewGuid().ToString();
        Console.WriteLine($"GuidService created: {_guid}");
    }

    public string GetGuid() => _guid;
}
