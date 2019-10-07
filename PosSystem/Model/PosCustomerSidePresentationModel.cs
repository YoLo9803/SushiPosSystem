using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.IO;

namespace PosSystem
{
    public class PosCustomerSidePresentationModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        Model _model;
        const string PAGE = "Page:";
        const string SEMICOLON = "/";
        public const int COLUMNS = 3;
        public const int ROWS = 3;
        int _page = 1;
        public PosCustomerSidePresentationModel(Model model)
        {
            const string NULL = "model is null";
            if (model == null)
                throw new ArgumentException(NULL);
            this._model = model;
            _page = 1;
            this._model.PresentOrder.OrderList.ListChanged += OrderListListChanged;
        }

        //order改變時更新totalPrice
        private void OrderListListChanged(object sender, ListChangedEventArgs e)
        {
            NotifyPropertyChanged(nameof(this.LabelTotalPrice));
        }

        public int PageIndex
        {
            get
            {
                return (_page - 1) * COLUMNS * ROWS;
            }
        }

        //增加餐點
        public void AddMeal(Meal meal)
        {
            _model.PresentOrder.AddMeal(meal);
            NotifyPropertyChanged(nameof(this.LabelTotalPrice));
        }

        //刪除餐點
        public void DeleteMeal(int index)
        {
            _model.PresentOrder.DeleteMeal(index);
            NotifyPropertyChanged(nameof(this.LabelTotalPrice));
        }

        //是否超出餐點List範圍
        public bool IsListOutOfRange(int index)
        {
            if (_model.Meals == null || _model.Meals.LowerLimit + this.PageIndex + index > _model.Meals.UpperLimit)
                return false;
            else
                return true;
        }
        
        //偵測到TabControl變更頁面
        public void ChangeTabControlIndex(int pageNumber)
        {
            const int TWO = 2;
            if (pageNumber != -1)
                _model.TabPage = pageNumber + 1;
            else
                _model.TabPage = pageNumber + TWO;
            this._page = 1;
            NotifyPropertyChanged(nameof(this.LastPage));
            NotifyPropertyChanged(nameof(this.LabelPage));
        }

        //上下一頁
        public int PageTurning
        {
            set
            {
                this._page += value;
                NotifyPropertyChanged(nameof(this.NextPageEnabled));
                NotifyPropertyChanged(nameof(this.PreviousPageEnabled));
            }
        }
        //是否為最後一頁
        public bool NextPageEnabled
        {
            get
            {
                if (this._page == this.LastPage || this.LastPage == 1)
                    return false;
                else
                    return true;
            }
        }

        public bool PreviousPageEnabled
        { 
            get
            {
                if (this._page == 1 || this.LastPage == 1)
                    return false;
                else
                    return true;
            }
        }

        public string MealDescriptionText
        {
            get
            {
                if (_model.SelectMeal == null)
                    return null;
                else
                    return _model.SelectMeal.MealDescription;
            }
        }

        //最大頁數
        public int LastPage
        {
            get
            {
                if (_model.Meals == null)
                    return 1;
                int MEALS = _model.Meals.MealsAmount;
                if (MEALS < COLUMNS * ROWS)
                    return 1;
                else if (MEALS % (COLUMNS * ROWS) == 0)
                    return MEALS / (COLUMNS * ROWS);
                else
                    return MEALS / (COLUMNS * ROWS) + 1;
            }
        }

        //_labelPage字樣
        public string LabelPage
        {
            get
            {
                const string PAGE_FORMAT = "Page: {0} / {1}";
                return string.Format(PAGE_FORMAT, _page.ToString(), this.LastPage.ToString());
            }
        }

        public string LabelTotalPrice
        {
            get
            {
                const string TOTAL_PRICE_FORMAT = "Total:{0}元";
                return string.Format(TOTAL_PRICE_FORMAT, _model.PresentOrder.TotalPrice);
            }
        }

        public Model model
        {
            get
            {
                return this._model;
            }
        }

        //QTY改變時
        public void ChangeQuantity(int quantity, int rowIndex)
        {
            this._model.PresentOrder.ChangeOrderQuantity(quantity, rowIndex);
            NotifyPropertyChanged(nameof(this.LabelTotalPrice));
        }

        //通知更變
        public
        void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
