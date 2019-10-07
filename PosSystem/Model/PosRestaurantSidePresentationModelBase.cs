using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PosSystem
{
    //存放後端會使用到的Setter & Getter
    public class PosRestaurantSidePresentationModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        Meal _selectMeal;
        Category _selectMealList;
        string _selectMealName;
        string _selectMealPrice;
        string _selectMealCategory;
        string _selectMealDescription;
        string _selectMealRelativePath;
        string _categoryName;
        int _categoryAmount;

        public Meal SelectMeal
        {
            get
            {
                return this._selectMeal;
            }
            set
            {
                this._selectMeal = value;
                NotifyPropertyChanged(nameof(this.ButtonDeleteMealEnabled));
            }
        }

        public int CategoryAmount
        {
            get
            {
                return this._categoryAmount;
            }
            set
            {
                this._categoryAmount = value;
            }
        }

        public Category SelectMealList
        {
            get
            {
                return this._selectMealList;
            }
            set
            {
                this._selectMealList = value;
                NotifyPropertyChanged(nameof(this.ButtonDeleteCategoryEnabled));
                NotifyPropertyChanged(nameof(this.TextBoxCategoryNameEnabled));
            }
        }

        public bool SaveButtonEnabled
        {
            get
            {
                if (this._selectMealName == "" || this._selectMealPrice == "" || this._selectMealCategory == "" || this._selectMealName == null)
                    return false;
                else if (!int.TryParse(this.SelectMealPrice, out int outNumber))
                    return false;
                else
                    return true;
            }
        }

        public bool ButtonDeleteCategoryEnabled
        {
            get
            {
                if (this.SelectMealList == null || this.CategoryAmount == 1)
                    return false;
                else
                    return true;
            }
        }

        public bool ButtonDeleteMealEnabled
        {
            get
            {
                if (this.SelectMeal == null)
                    return false;
                else
                    return true;
            }
        }

        public bool ButtonBrowseEnabled
        {
            get
            {
                if (this.SelectMealRelativePath == null)
                    return false;
                else
                    return true;
            }
        }

        public bool SelectMealNameEnabled
        {
            get
            {
                if (this.SelectMealName == null)
                    return false;
                else
                    return true;
            }
        }

        public bool SelectMealPriceEnabled
        {
            get
            {
                if (this.SelectMealPrice == null)
                    return false;
                else
                    return true;
            }
        }

        public bool SelectMealDescriptionEnabled
        {
            get
            {
                if (this.SelectMealDescription == null)
                    return false;
                else
                    return true;
            }
        }

        public bool SelectMealCategoryEnabled
        {
            get
            {
                if (this.SelectMealCategory == null)
                    return false;
                else
                    return true;
            }
        }
        public bool SelectMealRelativePathEnabled
        {
            get
            {
                if (this.SelectMealRelativePath == null)
                    return false;
                else
                    return true;
            }
        }

        public bool SaveCategoryButtonEnabled
        {
            get
            {
                if (this._categoryName == "" || this._categoryName == null)
                    return false;
                else
                    return true;
            }
        }

        public bool TextBoxCategoryNameEnabled
        {
            get
            {
                if (this._categoryName == null)
                    return false;
                else
                    return true;
            }
        }

        public string CategoryName
        {
            get
            {
                return this._categoryName;
            }
            set
            {
                this._categoryName = value;
                NotifyPropertyChanged(nameof(this.CategoryName));
                NotifyPropertyChanged(nameof(this.SaveCategoryButtonEnabled));
                NotifyPropertyChanged(nameof(this.TextBoxCategoryNameEnabled));
            }
        }

        public string SelectMealName
        {
            get
            {
                return this._selectMealName;
            }
            set
            {
                this._selectMealName = value;
                NotifyPropertyChanged(nameof(this.SelectMealName));
            }
        }

        public string SelectMealPrice
        {
            get
            {
                return this._selectMealPrice;
            }
            set
            {
                this._selectMealPrice = value;
                NotifyPropertyChanged(nameof(this.SelectMealPrice));
            }
        }

        public string SelectMealCategory
        {
            get
            {
                return this._selectMealCategory;
            }
            set
            {
                this._selectMealCategory = value;
                NotifyPropertyChanged(nameof(this.SelectMealCategory));
            }
        }

        public string SelectMealRelativePath
        {
            get
            {
                return this._selectMealRelativePath;
            }
            set
            {
                this._selectMealRelativePath = value;
                NotifyPropertyChanged(nameof(this.SelectMealRelativePath));
            }
        }
        public string SelectMealDescription
        {
            get
            {
                return this._selectMealDescription;
            }
            set
            {
                this._selectMealDescription = value;
                NotifyPropertyChanged(nameof(this.SelectMealDescription));
            }
        }

        //通知變更
        public void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
