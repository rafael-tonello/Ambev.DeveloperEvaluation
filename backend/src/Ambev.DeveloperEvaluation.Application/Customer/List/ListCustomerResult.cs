namespace Ambev.DeveloperEvaluation.Application.Customer.List
{
    public class ListCustomerResult
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
        public double Email { get; set; }
    }
}
