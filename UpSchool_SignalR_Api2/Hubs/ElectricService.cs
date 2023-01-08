using Microsoft.AspNetCore.SignalR;
using System.Linq;
using System.Threading.Tasks;
using UpSchool_SignalR_Api2.Models;

namespace UpSchool_SignalR_Api2.Hubs
{
    public class ElectricService
    {
        private readonly Context _context;
        private readonly IHubContext<ElectricHub> _hubContext;

        public ElectricService(Context context, IHubContext<ElectricHub> hubContext)
        {
            _context = context;
            _hubContext = hubContext;
        }
        public IQueryable<Electric> GetList()
        {
            return _context.Electrics.AsQueryable();
        }
        public async Task SaveElectric(Electric electric)
        {
            await _context.Electrics.AddAsync(electric);
            await _context.SaveChangesAsync();
            await _hubContext.Clients.All.SendAsync("ReceiveElectricList","data");//hub ile yine abone olmak gerekiyor. Bu yüzden ReceiveElectricList string değeri veriyoruz

        }

    }
}
