namespace OdysejaAdmin.Data
{
 public class Info
 {
     public int id { get; set; }
     
     public string infoName { get; set; }
     
     public string infoText { get; set; }
     
     public int city { get; set; }

     public Info(int id, string infoName, string infoText, int city)
     {
         this.id = id;
         this.infoName = infoName;
         this.infoText = infoText;
         this.city = city;
     }
 }   
}