namespace PointOfSales.Application.Features.Client.Queries.GetProviderPaged
{
    public class ProviderPagedDto
    {
        public Guid Id { get; set; }
		public string Name { get; set; }
		public string Phone { get; set; }
		public string DocumentNumber { get; set; } 
		public string Email { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string Commentary { get; set; }
	}
}
