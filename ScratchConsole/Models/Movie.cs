using System;
using System.Collections.Generic;
using System.Text;

namespace ScratchConsole.Models
{
    public class Movie
    {
        public const int firstYear = 1888;

        // Java Encapsulation
        //private string title;

        //public string GetTitle() { return title; }
        //public void SetTitle(string title) { this.title = title; }

        // C# Encapsulation

        // Full Property

        //private int year;

        //public int Year
        //{
        //    get { return year; }
        //    set { year = value; }
        //}

        // Automatic Property

        public string Title { get; set; } = "[Name Not Found]";

        public int Year { get; 
            set
            {
                if(value >= firstYear)
                {
                    field = value;
                }
            }
        } = 1888;

        



    }
}
