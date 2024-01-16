using DocumentFormat.OpenXml.InkML;
using TraversalProject.CQRS.Commands.DestinationCommands;
using EntityLayer.Concrete;
using DataAccessLayer.Concrete;


namespace TraversalProject.CQRS.Handlers.DestinationHandlers
{
    public class CreateDestinationCommandHandler
    {
        private readonly DataAccessLayer.Concrete.Context _context;
        public CreateDestinationCommandHandler(DataAccessLayer.Concrete.Context context)
        {
            _context = context;
        }
        public void Handle(CreateDestinationCommand command)
        {
            _context.Destinations.Add(new Destination
            {
                City = command.City,
                Price = command.Price,
                DayNight = command.DayNight,
                Capacity = command.Capacity,
                Status = true
            });
            _context.SaveChanges();
        }
    }
}
