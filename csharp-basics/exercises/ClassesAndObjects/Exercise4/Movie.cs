using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Movie
    {
        //fields
        private string _title;
        private string _studio;
        private string _rating;

        //ctor
        public Movie(string title, string studio, string rating)
        {
            _title = title;
            _studio = studio;
            _rating = rating;
        }

        public Movie(string title, string studio)
        {
            _title = title;
            _studio = studio;
            _rating = "PG";
        }

        //properties
        public string Title
        {
            get { return _title; }
            set { _title = value; }

        }
        public string Studio
        {
            get { return _studio; }
            set { _studio = value; }
        }
        public string Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }

        //methods
        public string DisplayInfo()
        {
            return $"{Title}, {Studio}, {Rating}";
        }
    }
}
