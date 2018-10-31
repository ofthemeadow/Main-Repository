using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalExerciseNum1.Models
{
    class Zodiac
    {
        static void zSign(int day, string month)
        {
            string signName = "";
            if (month == "December")
            {
                signName = (day < 22) ? "Sagittarius" : "Capricorn";
            }
            else if (month == "January")
            {
                signName = (day < 20) ? "Capricorn" : "Aquarius";
            }
            else if (month == "February")
            {
                signName = (day < 19) ? "Aquarius" : "Pisces";
            }
            else if (month == "March")
            {
                signName = (day < 21) ? "Pisces" : "Aries";
            }
            else if (month == "April")
            {
                signName = (day < 20) ? "Aries" : "Taurus";
            }
            else if (month == "May")
            {
                signName = (day < 21) ? "Taurus" : "Gemini";
            }
            else if (month == "June")
            {
                signName = (day < 21) ? "Gemini" : "Cancer";
            }
            else if (month == "July")
            {
                signName = (day < 23) ? "Cancer" : "Leo";
            }
            else if (month == "August")
            {
                signName = (day < 23) ? "Leo" : "Virgo";
            }
            else if (month == "September")
            {
                signName = (day < 23) ? "Virgo" : "Libra";
            }
            else if (month == "October")
            {
                signName = (day < 23) ? "Libra" : "Scorpio";
            }
            else if (month == "November")
            {
                signName = (day < 22) ? "Scorpio" : "Sagittarius";
            }
        }
    }

    public class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string Gender { get; set; }
        public string Zodiac { get; set; }
    }
}