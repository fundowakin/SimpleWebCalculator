namespace DAL.Models
{
    public class Expression
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public Result Result { get; set; }
    }
}