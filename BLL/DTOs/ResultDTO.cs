namespace BLL.DTOs
{
    public class ResultDTO
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public int ExpressionId { get; set; }
        
        public ExpressionDTO Expression { get; set; }
    }
}