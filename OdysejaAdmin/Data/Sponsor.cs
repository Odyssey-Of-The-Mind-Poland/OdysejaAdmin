namespace OdysejaAdmin.Data;

public class Sponsor
{
    public int id { get; }
    public string name { get; }

    public Sponsor(int id, string name)
    {
        this.id = id;
        this.name = name;
    }
}