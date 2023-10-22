using cqrsdemo.API.Context;
using cqrsdemo.API.Models;
using MediatR;

namespace cqrsdemo.API.Features.ProductFeatures.Commands
{
    public class CreateProductCommand : IRequest<int>
    {
        public string? Name { get; set; }
        public string? Barcode { get; set; }
        public string? Description { get; set; }
        public decimal BuyingPrice { get; set; }
        public decimal Rate { get; set; }

        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
        {
            private readonly ApplicationContext _context;
            public CreateProductCommandHandler(ApplicationContext context)
            {
                _context = context;
            }
            public async Task<int> Handle(CreateProductCommand command, CancellationToken cancellationToken)
            {
                var product = new Product();
                product.Name = command.Name;
                product.Barcode = command.Barcode;
                product.Description = command.Description;
                product.BuyingPrice = command.BuyingPrice;
                product.Rate = command.Rate;
                _context.Products.Add(product);
                await _context.SaveChangesAsync();
                return product.Id;
            }
        }
    }
}
