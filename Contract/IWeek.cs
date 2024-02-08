namespace KCalendar.Core.Contract
{
    public interface IWeek
    {
        string Name { get; }
        string  ShortName { get; }
        int DayIndex { get; }
        bool IsRestDay { get; }
    }
}
