using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace BulkyBookWeb.Models;

public class Category{

    public DateTime CreatedDataTime { get; set; } = DateTime.Now;

    [Key]
    public int Id { get; set; }
    [Required]
    [DisplayName("Ticker")]
    public string Name { get; set; }
    public string Sector { get; set; } 
    public string Index { get; set; }
    public int Float { get; set; }
    public int DailyVolume { get; set; }
    public double PrevClose { get; set; }
    public double Open { get; set; }
    public double HighOfDay { get; set; }
    public double LowOfDay { get; set; }
    public double Close { get; set; }
    public double FromOpen10High{ get; set; }
    public double FromOpen30High { get; set; }
    public double MorningLow { get; set; }
    public double First2HrsHigh { get; set; }
    public long MarketCap { get; set; }
    [DisplayName("Work or not")]
    public int DisplayOrder { get; set; }
    public double Day2Open { get; set; }
    public double Day2Close { get; set; }
    [DisplayName("Dollar Volume")]
    public double Day2Volume { get; set; }
    public double PrecDay2Open { get; set; }
    public double PrecHighOfDay { get; set; }
    public double PrecLowOfDay { get; set; }
    public double PrecCloseFromOpen { get; set; }
    public double PrecFromOpen30High { get; set; }
    public double PrecCompleteRange { get; set; }








   
}
