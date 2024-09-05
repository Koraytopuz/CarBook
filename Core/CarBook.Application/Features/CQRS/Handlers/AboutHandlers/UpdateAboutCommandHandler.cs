using CarBook.Application.Features.CQRS.Commands.AboutCommands;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class UpdateAboutCommandHandler
    {
        private readonly IRepository<About> _reporsitory;

        public UpdateAboutCommandHandler(IRepository<About> reporsitory)
        {
            _reporsitory = reporsitory;
        }
        public async Task Handle(UpdateAboutCommand command)
        {
            var values=await _reporsitory.GetByIdAsync(command.AboutID);
            values.Description = command.Description;
            values.Title = command.Title;
            values.ImageUrl = command.ImageUrl;
            await _reporsitory.UpdateAsync(values);
        }
    }
}
