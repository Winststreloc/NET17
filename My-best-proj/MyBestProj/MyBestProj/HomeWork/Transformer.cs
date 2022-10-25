
namespace MyBestProj.HomeWork
{
    public class Transformer
    {
        public string Name { get;  set; }
        public int Id { get; set; }
        public Gun Gun { get; set; }
        
        public Transformer(string name, int id, Gun gun)
        {
            Name = name;
            Id = id;
            Gun = gun;
        }
    }
}
