using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    internal class VideoStoreTest
    {
        public static void Run()
        {
            VideoStore testStore = new VideoStore();
            testStore.AddVideo("The Matrix");
            testStore.AddVideo("Godfather II");
            testStore.AddVideo("Star Wars Episode IV: A New Hope");

            testStore.TakeUsersRating(10, "The Matrix");
            testStore.TakeUsersRating(8, "The Matrix");
            testStore.TakeUsersRating(6, "The Matrix");

            testStore.TakeUsersRating(8, "Godfather II");
            testStore.TakeUsersRating(9, "Godfather II");
            testStore.TakeUsersRating(2, "Godfather II");

            testStore.TakeUsersRating(4, "Star Wars Episode IV: A New Hope");
            testStore.TakeUsersRating(8, "Star Wars Episode IV: A New Hope");
            testStore.TakeUsersRating(9, "Star Wars Episode IV: A New Hope");

            testStore.Checkout("The Matrix");
            testStore.ReturnVideo("The Matrix");
            testStore.Checkout("Godfather II");

            testStore.ListInventory();
        }
    }
}
