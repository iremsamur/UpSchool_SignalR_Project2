using Microsoft.AspNetCore.SignalR;
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

    }
}
