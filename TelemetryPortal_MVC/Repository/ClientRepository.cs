using Microsoft.EntityFrameworkCore;
using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;
using TelemetryPortal_MVC.Repository;

namespace TelemetryPortal_MVC.Repository
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        /*private readonly TechtrendsContext _context = new TechtrendsContext(); 
        public IEnumerable<Client> GetAll()
        {
            return  _context.Clients.ToList(); 

        }*/
        public ClientRepository(TechtrendsContext context) : base(context)
        {

        }
        public Client GetAllClients()
        {
            return _context.Clients.OrderByDescending(client => client.DateOnboarded).FirstOrDefault();
        }

    }
    
  
}
