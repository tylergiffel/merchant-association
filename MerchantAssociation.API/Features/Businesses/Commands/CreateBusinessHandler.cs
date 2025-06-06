using MediatR;
using Microsoft.EntityFrameworkCore;
using MerchantAssociation.API.Data;
using MerchantAssociation.API.Models;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MerchantAssociation.API.Features.Businesses.Commands
{
    public class CreateBusinessHandler : IRequestHandler<CreateBusiness, int>
    {
        private readonly ApplicationDbContext _context;

        public CreateBusinessHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateBusiness request, CancellationToken cancellationToken)
        {
            var business = new Business(
                request.Name,
                request.Description,
                request.Address,
                request.PhoneNumber,
                request.Email
            );

            _context.Businesses.Add(business);
            await _context.SaveChangesAsync(cancellationToken);

            return business.Id;
        }
    }
}