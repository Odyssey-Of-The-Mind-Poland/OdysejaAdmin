namespace OdysejaAdmin.Data
{
    public class Performance
    {
        public int id { get; set; }
        public string city { get; set; }
        public string team { get; set; }
        public int problem { get; set; }
        public int age { get; set; }
        public int stage { get; set; }
        public string performance { get; set; }
        public string spontan { get; set; }

        public Performance(int id, string city, string team, int problem, int age, int stage, string performance, string spontan)
        {
            this.id = id;
            this.city = city;
            this.team = team;
            this.problem = problem;
            this.age = age;
            this.stage = stage;
            this.performance = performance;
            this.spontan = spontan;
        }
    }
}