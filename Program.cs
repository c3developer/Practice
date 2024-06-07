// цех участок(идукционная печь) время(начало конец и выбор дня)
// напряжение (мин макс среднее) В таблице 3 столбца время hh.mm.ss ток 
using System.Data;

public class MarketReport
{
    public Workshop Workshop { get; set; }
    public HistoryItem[] HistoryItem { get; set; }
}
// Переменные для шапки
public class Workshop
{
    public String ShopName { get; set; }// цех
    public String Sector { get; set; }// участок
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
//Переменные для таблицы
public class HistoryItem
{
    public decimal Tension { get; set; }
    public DateTime DateTime { get; set; }
}
//Генератор данных
public class MakeReporter
{
    public MarketReport GetReport()
    {
        return new MarketReport
        {
           Workshop = new Workshop
           {
               ShopName = "ТПЦ-2", Sector = "Индукционная Печь", StartDate = new DateTime(2024, 6, 7), EndDate = new DateTime(DateTime)
           }
        }
    }
}
