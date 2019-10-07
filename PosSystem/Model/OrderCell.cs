using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PosSystem
{
    public class OrderCell : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        Meal _meal;
        int _mealQuantity;
        public OrderCell(Meal meal)
        {
            this._meal = meal;
            this._mealQuantity = 1;
        }
        public Meal Meal
        {
            get
            {
                return this._meal;
            }
        }

        public string MealDelete
        {
            get
            {
                const string DELETE = "X";
                return DELETE;
            }
        }
        public string MealName
        {
            get
            {
                return this._meal.MealName;
            }
        }
        public string MealCategory
        {
            get
            {
                return this._meal.MealCategory;
            }
        }
        public int MealUnitPrice
        {
            get
            {
                return this._meal.MealPrice;
            }
        }

        public int MealSubtotal
        {
            get
            {
                return this._meal.MealPrice * this.MealQuantity;
            }
        }
        public string MealSubtotalLabel
        {
            get
            {
                const string DOLLAR = "NTD";
                return this.MealSubtotal + DOLLAR;
            }
        }
        public int MealQuantity
        {
            get
            {

                return this._mealQuantity;
            }
            set
            {
                NotifyPropertyChanged(nameof(OrderCell.MealSubtotal));
                NotifyPropertyChanged(nameof(OrderCell.MealSubtotalLabel));
                this._mealQuantity = value;
            }
        }

        //通知變更
        void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

}
