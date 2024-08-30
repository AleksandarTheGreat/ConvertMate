using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertMate
{
    public class TimeConvertor
    {
        private const decimal SecondsPerMinute = 60M;
        private const decimal MinutesPerHour = 60M;
        private const decimal HoursPerDay = 24M;
        private const decimal DaysPerWeek = 7M;
        private const decimal WeeksPerMonth = 4.345M; // Approximate average
        private const decimal MonthsPerYear = 12M;

        // Convert Seconds to other units
        public static decimal SecondsToMinutes(decimal seconds) => seconds / SecondsPerMinute;
        public static decimal SecondsToHours(decimal seconds) => SecondsToMinutes(seconds) / MinutesPerHour;
        public static decimal SecondsToDays(decimal seconds) => SecondsToHours(seconds) / HoursPerDay;
        public static decimal SecondsToWeeks(decimal seconds) => SecondsToDays(seconds) / DaysPerWeek;
        public static decimal SecondsToMonths(decimal seconds) => SecondsToWeeks(seconds) / WeeksPerMonth;
        public static decimal SecondsToYears(decimal seconds) => SecondsToMonths(seconds) / MonthsPerYear;

        // Convert Minutes to other units
        public static decimal MinutesToSeconds(decimal minutes) => minutes * SecondsPerMinute;
        public static decimal MinutesToHours(decimal minutes) => minutes / MinutesPerHour;
        public static decimal MinutesToDays(decimal minutes) => MinutesToHours(minutes) / HoursPerDay;
        public static decimal MinutesToWeeks(decimal minutes) => MinutesToDays(minutes) / DaysPerWeek;
        public static decimal MinutesToMonths(decimal minutes) => MinutesToWeeks(minutes) / WeeksPerMonth;
        public static decimal MinutesToYears(decimal minutes) => MinutesToMonths(minutes) / MonthsPerYear;

        // Convert Hours to other units
        public static decimal HoursToSeconds(decimal hours) => HoursToMinutes(hours) * SecondsPerMinute;
        public static decimal HoursToMinutes(decimal hours) => hours * MinutesPerHour;
        public static decimal HoursToDays(decimal hours) => hours / HoursPerDay;
        public static decimal HoursToWeeks(decimal hours) => HoursToDays(hours) / DaysPerWeek;
        public static decimal HoursToMonths(decimal hours) => HoursToWeeks(hours) / WeeksPerMonth;
        public static decimal HoursToYears(decimal hours) => HoursToMonths(hours) / MonthsPerYear;

        // Convert Days to other units
        public static decimal DaysToSeconds(decimal days) => DaysToHours(days) * SecondsPerMinute;
        public static decimal DaysToMinutes(decimal days) => DaysToHours(days) * MinutesPerHour;
        public static decimal DaysToHours(decimal days) => days * HoursPerDay;
        public static decimal DaysToWeeks(decimal days) => days / DaysPerWeek;
        public static decimal DaysToMonths(decimal days) => DaysToWeeks(days) / WeeksPerMonth;
        public static decimal DaysToYears(decimal days) => DaysToMonths(days) / MonthsPerYear;

        // Convert Weeks to other units
        public static decimal WeeksToSeconds(decimal weeks) => WeeksToDays(weeks) * DaysPerWeek * SecondsPerMinute;
        public static decimal WeeksToMinutes(decimal weeks) => WeeksToDays(weeks) * DaysPerWeek * MinutesPerHour;
        public static decimal WeeksToHours(decimal weeks) => WeeksToDays(weeks) * DaysPerWeek * HoursPerDay;
        public static decimal WeeksToDays(decimal weeks) => weeks * DaysPerWeek;
        public static decimal WeeksToMonths(decimal weeks) => weeks / WeeksPerMonth;
        public static decimal WeeksToYears(decimal weeks) => WeeksToMonths(weeks) / MonthsPerYear;

        // Convert Months to other units
        public static decimal MonthsToSeconds(decimal months) => MonthsToWeeks(months) * WeeksPerMonth * DaysPerWeek * HoursPerDay * MinutesPerHour * SecondsPerMinute;
        public static decimal MonthsToMinutes(decimal months) => MonthsToWeeks(months) * WeeksPerMonth * DaysPerWeek * HoursPerDay * MinutesPerHour;
        public static decimal MonthsToHours(decimal months) => MonthsToWeeks(months) * WeeksPerMonth * DaysPerWeek * HoursPerDay;
        public static decimal MonthsToDays(decimal months) => MonthsToWeeks(months) * WeeksPerMonth * DaysPerWeek;
        public static decimal MonthsToWeeks(decimal months) => months * WeeksPerMonth;
        public static decimal MonthsToYears(decimal months) => months / MonthsPerYear;

        // Convert Years to other units
        public static decimal YearsToSeconds(decimal years) => YearsToMonths(years) * MonthsPerYear * WeeksPerMonth * DaysPerWeek * HoursPerDay * MinutesPerHour * SecondsPerMinute;
        public static decimal YearsToMinutes(decimal years) => YearsToMonths(years) * MonthsPerYear * WeeksPerMonth * DaysPerWeek * HoursPerDay * MinutesPerHour;
        public static decimal YearsToHours(decimal years) => YearsToMonths(years) * MonthsPerYear * WeeksPerMonth * DaysPerWeek * HoursPerDay;
        public static decimal YearsToDays(decimal years) => YearsToMonths(years) * MonthsPerYear * WeeksPerMonth * DaysPerWeek;
        public static decimal YearsToWeeks(decimal years) => YearsToMonths(years) * MonthsPerYear * WeeksPerMonth;
        public static decimal YearsToMonths(decimal years) => years * MonthsPerYear;
    }
}
