namespace Ambev.DeveloperEvaluation.Application.Product.Get
{
    public class GetProductResult
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public double Price { get; set; }
    }
}
