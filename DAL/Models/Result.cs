namespace DAL.Models
{
    public class Result
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public int ExpressionId { get; set; }
        
        public Expression Expression { get; set; }
    }
}