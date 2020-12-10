namespace OdysejaAdmin.Data
{
    public class IdNameModel
    {
        public int id { get; set; }
        public string name { get; set; }

        public IdNameModel(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}