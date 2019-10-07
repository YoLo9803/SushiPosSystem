using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PosSystem
{
    public class Category
    {
        int _lowerLimit;
        int _upperLimit;
        BindingList<Meal> _mealList;
        string _mealCategory;
        public Category(BindingList<Meal> mealList,string mealCategory,int lowerLimit, int upperLimit)
        {
            const string NULL = "mealList is null";
            if (mealList == null)
                throw new ArgumentException(NULL);
            this._mealCategory = mealCategory;
            this._lowerLimit = lowerLimit;
            this._upperLimit = upperLimit;
            this._mealList = mealList;
        }

        public string MealCategory
        {
            get
            {
                return this._mealCategory;
            }
            set
            {
                this._mealCategory = value;
            }
        }

        public BindingList<Meal> MealBindingList
        {
            get
            {
                return this._mealList;
            }
        }

        public int LowerLimit
        {
            get
            {
                return this._lowerLimit;
            }
        }

        public int UpperLimit
        {
            get
            {
                return this._upperLimit;
            }
        }
        public int MealsAmount
        {
            get
            {
                return this._upperLimit - this._lowerLimit + 1;
            }
        }

        //增加上限
        public void SetUpperLimit(int number)
        {
            this._upperLimit += number;
        }

        //增加下限
        public void SetLowerLimit(int number)
        {
            this._lowerLimit += number;
        }

        //插入餐點
        public void InsertMeal(Meal meal)
        {
            this._mealList.Insert(this._upperLimit, meal);
        }

        //更改餐點種類名稱
        public void ChangeCategoryName(string categoryName)
        {
            this.MealCategory = categoryName;
            for (int count = this._lowerLimit; count <= this._upperLimit; count++)
            {
                this._mealList[count].MealCategory = categoryName;
            }
        }
    }
}
