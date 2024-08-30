using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertMate
{
    public class VolumeConvertor
    {
        // Conversion factors relative to the base unit (Liter)
        private const decimal LiterToMilliliter = 1000M;
        private const decimal LiterToGallon = 0.264172M;
        private const decimal LiterToQuart = 1.056688M;

        // Convert from Liter
        public static decimal LiterToMilliliters(decimal liters) => liters * LiterToMilliliter;
        public static decimal LiterToGallons(decimal liters) => liters * LiterToGallon;
        public static decimal LiterToQuarts(decimal liters) => liters * LiterToQuart;

        // Convert from Milliliter
        public static decimal MilliliterToLiters(decimal milliliters) => milliliters / LiterToMilliliter;
        public static decimal MilliliterToGallons(decimal milliliters) => MilliliterToLiters(milliliters) * LiterToGallon;
        public static decimal MilliliterToQuarts(decimal milliliters) => MilliliterToLiters(milliliters) * LiterToQuart;

        // Convert from Gallon
        public static decimal GallonToLiters(decimal gallons) => gallons / LiterToGallon;
        public static decimal GallonToMilliliters(decimal gallons) => GallonToLiters(gallons) * LiterToMilliliter;
        public static decimal GallonToQuarts(decimal gallons) => gallons * 4;

        // Convert from Quart
        public static decimal QuartToLiters(decimal quarts) => quarts / LiterToQuart;
        public static decimal QuartToMilliliters(decimal quarts) => QuartToLiters(quarts) * LiterToMilliliter;
        public static decimal QuartToGallons(decimal quarts) => quarts / 4;
    }
}
