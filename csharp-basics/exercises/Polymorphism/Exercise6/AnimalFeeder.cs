using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class AnimalFeeder : UserInput
    {
        public Food FeedAnimal()
        {
            AppMessages.InputFoodType();
            var type = Read();
            AppMessages.InputFoodAmount();
            int amount;
            var isAmountValid = int.TryParse(Read(), out amount);
            while (!isAmountValid)
            {
                AppMessages.FoodError();
                isAmountValid = int.TryParse(Read(), out amount);
            }
            while (true)
            {
                if (type.ToLower() == "vegetable")
                    return new Vegetable(amount);
                if (type.ToLower() == "meat")
                    return new Meat(amount);

                AppMessages.FoodError();
                AppMessages.InputFoodType();
                type = Read();
            }
        }
    }
}
