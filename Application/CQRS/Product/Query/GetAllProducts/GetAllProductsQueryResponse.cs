using Core.InputModels;
using Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.Product.Query.GetAllProducts
{
    public class GetAllProductsQueryResponse 
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public long UnitPrice { get; set; }
        public ProductUnits ProductUnit { get; set; }
        public string? Description { get; set; }
        public Guid CategoryId { get; set; }
    }
}
