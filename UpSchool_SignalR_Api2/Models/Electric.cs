using System;

namespace UpSchool_SignalR_Api2.Models
{
    //Enum değerleri karşılıkları ile tutar.  Genelde const sabit değerli yapılarda kullanılır.
    public enum ECity
    {

        istanbul=1,
        ankara=2,
        izmir=3,
        konya=4,
        trabzon=5

    }
    public class Electric
    {
        public int ElectricID { get; set; }
        public ECity City { get; set; }
        public int Count { get; set; }
        public DateTime ElectricDate { get; set; }
    }
}
