using CarBook.Application.Features.Mediator.Commands.ReservationCommands;
using CarBook.Application.Features.Mediator.Commands.TestimonialCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entites;
using MediatR;
using NuGet.Protocol.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.ReservationHandlers
{
    public class CreateReservationCommandHandler : IRequestHandler<CreateReservationCommand>
    {
        private readonly IRepository<Reservation> _repository;

        public CreateReservationCommandHandler(IRepository<Reservation> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateReservationCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Reservation
            {
              Age=request.Age,
              CarID=request.CarID,
              Description=request.Description,
              DriverLicenceYears=request.DriverLicenceYears,
              DropOffLocationID=request.DropOffLocationID,
              Name=request.Name,
              Email=request.Email,
              Phone=request.Phone,
              PickUpLocationID=request.PickUpLocationID,
              Surname=request.Surname,
            });
        }
    }
}
