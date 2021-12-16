using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace VideoStore
{
    class VideoStore
    {
        private List<Video> _filmInventory = new List<Video>();
        public VideoStore()
        {
            _filmInventory = new List<Video>();
        }

        public List<Video> FilmList
        {
            get { return _filmInventory; }
            set { _filmInventory = value; }
        }

        public void AddVideo(string title)
        {
            FilmList.Add(new Video(title));
        }
        
        public void Checkout(string title)
        {
            FilmList[FilmListIndex(title)].BeingCheckedOut();
        }

        public void ReturnVideo(string title)
        {
            FilmList[FilmListIndex(title)].BeingReturned();
        }

        public void TakeUsersRating(double rating, string title)
        {
            FilmList[FilmListIndex(title)].ReceivingRating(rating);
        }

        public int FilmListIndex(string title)
        {

            int index = 0;
            foreach (Video film in FilmList)
            {
                if (film.Title == title)
                    index = FilmList.IndexOf(film);
            }
            return index;

        }

            public void ListInventory()
        {
            foreach (Video film in FilmList)
            {
                Console.WriteLine($"{film.Title} average rating: {film.AverageRating()}, Available: {film.Available()}");
            }
        }
    }
}
