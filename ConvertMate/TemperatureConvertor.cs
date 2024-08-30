using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertMate
{
    public class TemperatureConvertor
    {
        public static decimal CelsiusToFahrenheit(decimal celsius) => (celsius * 9 / 5) + 32;
        public static decimal CelsiusToKelvin(decimal celsius) => celsius + 273.15M;
        public static decimal CelsiusToRankine(decimal celsius) => (celsius + 273.15M) * 9 / 5;
        public static decimal FahrenheitToCelsius(decimal fahrenheit) => (fahrenheit - 32) * 5 / 9;
        public static decimal FahrenheitToKelvin(decimal fahrenheit) => (fahrenheit - 32) * 5 / 9 + 273.15M;
        public static decimal FahrenheitToRankine(decimal fahrenheit) => fahrenheit + 459.67M;
        public static decimal KelvinToCelsius(decimal kelvin) => kelvin - 273.15M;
        public static decimal KelvinToFahrenheit(decimal kelvin) => (kelvin - 273.15M) * 9 / 5 + 32;
        public static decimal KelvinToRankine(decimal kelvin) => kelvin * 9 / 5;
        public static decimal RankineToCelsius(decimal rankine) => (rankine - 491.67M) * 5 / 9;
        public static decimal RankineToFahrenheit(decimal rankine) => rankine - 459.67M;
        public static decimal RankineToKelvin(decimal rankine) => rankine * 5 / 9;
    }
}
