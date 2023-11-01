using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance.Models
{
    public class Quote
    {
        public static double AgeFactor(int Age)
        {
            if (Age <= 18)
            {
                double ageQuote = 100;
                return ageQuote;
            }
            else if (Age > 18 && Age < 26)
            {
                double ageQuote = 50;
                return ageQuote;
            }
            else
            {
                double ageQuote = 25;
                return ageQuote;
            }
        }

        public static double YearFactor(int Year)
        {
            if (Year < 2000 || Year >= 2016)
            {
                double yearQuote = 25;
                return yearQuote;
            }
            else
            {
                return 0;
            }
        }

        public static double MakeModelFactor(string make, string model)
        {
            if (make == "Porsche" && model == "911 Carrera")
            {
                double makeModelQuote = 50;
                return makeModelQuote;
            }
            else if (make == "Porsche")
            {
                double makeModelQuote = 25;
                return makeModelQuote;
            }
            else
            {
                double makeModelQuote = 0;
                return makeModelQuote;
            }
        }
        
        public static double DUIFactor(bool DUI)
        {
            if (DUI == true)
            {
                return 1.25;
            }
            else
            {
                return 1;
            }
        }
        public static double CoverageFactor(bool CoverageType)
        {
            if (CoverageType == true)
            {
                return 1.5;
            }
            else
            {
                return 1;
            }
        }
    }
}