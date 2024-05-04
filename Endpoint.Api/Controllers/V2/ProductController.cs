using AutoMapper;
using Endpoint.Api.ViewModels.Products;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Endpoint.Api.Controllers.V2
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("v{version:apiVersion}/[controller]")]
    public class ProductController : Api.Controllers.V1.ProductController
    {
        public ProductController(IMediator mediator, IMapper mapper) : base(mediator, mapper)
        {
        }
        [HttpGet("{id}")]
        public override async Task<ActionResult<ProductViewModel>> GetProductById(long id)
        {
            return new ProductViewModel();
        }
    }
}