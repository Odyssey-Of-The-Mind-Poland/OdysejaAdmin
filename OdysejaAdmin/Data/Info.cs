namespace OdysejaAdmin.Data
{
 public class Info
 {
     public int id { get; set; }
     
     public string infoName { get; set; }
     
     public string infoText { get; set; }
     
     public int city { get; set; }
     
     public int category { get; set; }
     
     public int sortNumber { get; set; }
     public string categoryName { get; set; }

     public Info(int id, string infoName, string infoText, int city, int category, int sortNumber, string categoryName)
     {
         this.id = id;
         this.infoName = infoName;
         this.infoText = infoText;
         this.city = city;
         this.category = category;
         this.sortNumber = sortNumber;
         this.categoryName = categoryName;
     }
 }   
}