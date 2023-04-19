namespace PointOfSales.Application.Contracts.Persistence
{
    public interface  IMyDataRepository:IAsyncRepository<MyData>
    {
         Task<string> GetOrderSecuence();
         Task<string> GetInvoiceSecuence();
         Task UpdateInvoiceSecuence();
         Task UpdateOrderSecuence();
         Task<MyData> GetOne();

    }
}
