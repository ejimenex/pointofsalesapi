namespace PointOfSales.Application.Exceptions
{
    public class NotFoundException : Exception
    {
        public List<string> ValidationErrors { get; set; }
        public NotFoundException(string name, object key) : base($"{name} ({key}) is not found")
        {

        }
    }
}
