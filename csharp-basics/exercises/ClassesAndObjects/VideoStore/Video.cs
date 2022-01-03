using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace VideoStore
{
    class Video
    {
        private string _title;
        private bool _isCheckedOut;
        private List<double> _ratings = new List<double>();

        public Video(string title)
        {
            _title = title;
            _isCheckedOut = false;
            _ratings = new List<double>();
        }

        public bool IsCheckedOut
        {
            get => _isCheckedOut;
            set => _isCheckedOut = value;
        }

        public List<double> Ratings
        {
            get => _ratings;
            set => _ratings = value;
        }

        public void BeingCheckedOut()
        {
            _isCheckedOut = true;
        }

        public void BeingReturned()
        {
            _isCheckedOut = false;
        }

        public void ReceivingRating(double rating)
        {
            Ratings.Add(rating);
        }

        public double AverageRating()
        {
            return Math.Round((Ratings.Sum() / Ratings.Count), 1);
        }

        public bool Available()
        {
            return !IsCheckedOut;
        }

        public string Title
        { get { return _title; } }

        public override string ToString()
        {
            return $"{Title} {AverageRating()} {Available()}";
        }
    }
}
