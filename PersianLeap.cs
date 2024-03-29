﻿using KCalendar.Core.Contract;

namespace KCalendar.Core
{
    internal class PersianOfficialLeap : ICalendarLeap
    {
        public bool IsLeap(ICalendar date)
        {
            return (
                (date.DateToJulian(new PersianDate(date.Year + 1, 1, 1))) - date.DateToJulian(new PersianDate(date.Year, 1, 1))
                ) > 365;
        }
    }
}
