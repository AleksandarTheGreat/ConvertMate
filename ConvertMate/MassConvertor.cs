using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertMate
{
    public class MassConvertor
    {
        // Conversion factors to convert from the base unit (Gram)
        private const decimal GramToKilogram = 0.001M;
        private const decimal GramToPound = 0.00220462M;
        private const decimal GramToOunce = 0.035274M;
        private const decimal GramToTon = 1e-6M;

        // Convert from Gram
        public static decimal GramToKilograms(decimal grams) => grams * GramToKilogram;
        public static decimal GramToPounds(decimal grams) => grams * GramToPound;
        public static decimal GramToOunces(decimal grams) => grams * GramToOunce;
        public static decimal GramToTons(decimal grams) => grams * GramToTon;

        // Convert from Kilogram
        public static decimal KilogramToGrams(decimal kilograms) => kilograms / GramToKilogram;
        public static decimal KilogramToPounds(decimal kilograms) => GramToPounds(kilograms * 1000);
        public static decimal KilogramToOunces(decimal kilograms) => GramToOunces(kilograms * 1000);
        public static decimal KilogramToTons(decimal kilograms) => GramToTons(kilograms * 1000);

        // Convert from Pound
        public static decimal PoundToGrams(decimal pounds) => pounds / GramToPound;
        public static decimal PoundToKilograms(decimal pounds) => PoundToGrams(pounds) * GramToKilogram;
        public static decimal PoundToOunces(decimal pounds) => pounds * 16;
        public static decimal PoundToTons(decimal pounds) => pounds * 2.20462e-3M;

        // Convert from Ounce
        public static decimal OunceToGrams(decimal ounces) => ounces / GramToOunce;
        public static decimal OunceToKilograms(decimal ounces) => OunceToGrams(ounces) * GramToKilogram;
        public static decimal OunceToPounds(decimal ounces) => ounces / 16;
        public static decimal OunceToTons(decimal ounces) => OunceToGrams(ounces) * GramToTon;

        // Convert from Ton
        public static decimal TonToGrams(decimal tons) => tons / GramToTon;
        public static decimal TonToKilograms(decimal tons) => TonToGrams(tons) * GramToKilogram;
        public static decimal TonToPounds(decimal tons) => TonToGrams(tons) * GramToPound;
        public static decimal TonToOunces(decimal tons) => TonToGrams(tons) * GramToOunce;
    }
}
