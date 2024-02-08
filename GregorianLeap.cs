using KCalendar.Core.Contract;

namespace KCalendar.Core
{
    internal class GregorianLeap : ICalendarLeap
    {
        public bool IsLeap(ICalendar date)
        {
            return ((date.Year % 4) == 0) && (!(((date.Year % 100) == 0) && ((date.Year % 400) != 0)));
        }
    }
}
