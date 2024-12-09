using CarBook.Application.Features.Mediator.Commands.CarFeatureCommands;
using CarBook.Application.Interfaces.CarFeatureInterfaces;
using MediatR;
using NuGet.Protocol.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.CarFeatureHandlers
{
    public class UpdateCarFeaturesAvailableChangeToFalseCommandHandler : IRequestHandler<UpdateCarFeaturesAvailableChangeToFalseCommand>
    {
        private readonly ICarFeatureRepository _repository;

        public UpdateCarFeaturesAvailableChangeToFalseCommandHandler(ICarFeatureRepository repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateCarFeaturesAvailableChangeToFalseCommand request, CancellationToken cancellationToken)
        {
            _repository.ChangeCarFeatureAvailableToFalse(request.Id);
            //return Task.CompletedTask;
        }
    }
}
