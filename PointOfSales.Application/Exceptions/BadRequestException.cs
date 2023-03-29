namespace PointOfSales.Application.Exceptions
{
    public class BadRequestException:Exception
    {
        public BadRequestException(string error)
        {
            throw new Exception(error);
        }
    }
}
