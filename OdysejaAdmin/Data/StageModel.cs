namespace OdysejaAdmin.Data
{
    public class StageModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public int city { get; set; }
        public int number { get; set; }

        public StageModel(int id, string name, int city, int number)
        {
            this.id = id;
            this.name = name;
            this.city = city;
            this.number = number;
        }
    }
}