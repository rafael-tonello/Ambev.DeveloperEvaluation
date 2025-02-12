namespace Ambev.DeveloperEvaluation.Application.Customer.Get
{
    public class GetCustomerResult
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public double Price { get; set; }
    }
}
