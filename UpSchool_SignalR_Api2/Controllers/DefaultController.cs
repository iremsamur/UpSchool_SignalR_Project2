using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using UpSchool_SignalR_Api2.Hubs;
using UpSchool_SignalR_Api2.Models;

namespace UpSchool_SignalR_Api2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DefaultController : ControllerBase
    {
        private readonly ElectricService _service;

        public DefaultController(ElectricService service)
        {
            _service = service;
        }
        //elektrik listesini kaydedip getirecek

        [HttpPost]
        public async Task<IActionResult> SaveElectric(Electric electric)
        {
            await _service.SaveElectric(electric);
            IQueryable<Electric> electricList = _service.GetList();
            return Ok(_service.GetElectricChartList());
        }
        //veritabanına her şehir için değişen random elektrik  tüketim değerlerini atayacak
        [HttpGet]
        public IActionResult SendData()
        {
            //kurulacak yapı ile her saniyede bir kerz enumdan gelen değerlerle birlikte 100-1000 arasında
            //rastgele birim değerini veritabanına kaydedecek
            //elektrik fatura değerleri random'dan gelecek
            Random rnd = new Random();
            Enumerable.Range(1, 10).ToList().ForEach(x =>
            {
                foreach (ECity item in Enum.GetValues(typeof(ECity)))
                {
                    var newElectric = new Electric
                    {
                        //şimdi değer atamaları yapılacak
                        City = item,
                        Count = rnd.Next(100, 1000),
                        ElectricDate = DateTime.Now.AddDays(x)//x burada range'in değerlerini alıyor.
                        //1'den 10'a kadar
                    };
                    _service.SaveElectric(newElectric).Wait();//beklemesini sağlıyor
                    System.Threading.Thread.Sleep(1000);//1 saniye bekleterek, işlemlerin her biri 1 saniye arayla gerçekleşecek
                }
            });
            return Ok("Elektrik verileri veri tabanına kaydedildi.");


        }
    }
}
