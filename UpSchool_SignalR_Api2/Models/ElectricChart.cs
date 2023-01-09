using System.Collections.Generic;

namespace UpSchool_SignalR_Api2.Models
{
    public class ElectricChart
    {
        public ElectricChart()
        {
            Counts = new List<int>();//listenin hata vermemesi için list olan ögeyi constructor içinde yazarım
        }
        public string ElectricDate { get; set; }//tarih
        public List<int> Counts { get; set; }//o tarihte tüketilen elektirk miktarı

    }
}
