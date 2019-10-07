using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PosSystem
{
    public class Order : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        BindingList<OrderCell> _order;
        int _totalPrice = 0;
        public Order()
        {
            _order = new BindingList<OrderCell>();
        }

        //增加餐點
        public void AddMeal(Meal selectMeal)
        {
            this._totalPrice += selectMeal.MealPrice;
            this._order.Add(new OrderCell(selectMeal));
            NotifyPropertyChanged((nameof(Order.OrderList)));
            NotifyPropertyChanged(nameof(Order.TotalPrice));
        }

        //刪除餐點
        public void DeleteMeal(int index)
        {
            this._totalPrice -= this._order[index].MealSubtotal;
            this._order.RemoveAt(index);
            NotifyPropertyChanged((nameof(Order.OrderList)));
            NotifyPropertyChanged(nameof(Order.TotalPrice));
        }

        public int TotalPrice
        {
            get
            {
                return _order.Sum(i => i.MealSubtotal);
            }
            
        }

        public BindingList<OrderCell> OrderList
        {
            get
            {
                return this._order;
            }
        }

        //更改訂單數量
        public void ChangeOrderQuantity(int quantity, int rowIndex)
        {
            OrderCell cell = this._order[rowIndex];
            int difference = quantity - cell.MealQuantity;
            cell.MealQuantity = quantity;
            this._totalPrice += cell.Meal.MealPrice * difference;
            NotifyPropertyChanged((nameof(Order.OrderList)));
            NotifyPropertyChanged(nameof(Order.TotalPrice));
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
