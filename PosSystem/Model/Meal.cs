using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;
using System.Drawing;

namespace PosSystem
{
    public class Meal : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        string _mealName;
        string _mealDescription;
        string _mealCategory;
        int _mealPrice;
        int _mealCategoryIndex;
        string _imageRelativePath;
        const string MEAL_PRICE = "MealPrice";
        const string MEAL_DESCRIPTION = "MealDescription";

        //Constructor
        public Meal(string name, int price, string description,string category, int categoryIndex ,string relativePath)
        {
            this.MealName = name;
            this.MealPrice = price;
            this.MealDescription = description;
            this.ImageRelativePath = relativePath;
            this.MealCategory = category;
            this.MealCategoryIndex = categoryIndex;
            NotifyPropertyChanged(nameof(this.MealName));
            NotifyPropertyChanged(nameof(this.MealDescription));
            NotifyPropertyChanged(nameof(this.MealPrice));
        }

        public int MealCategoryIndex
        {
            get
            {
                return this._mealCategoryIndex;
            }
            set
            {
                this._mealCategoryIndex = value;
            }
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
        //相對路徑
        public string ImageRelativePath
        {
            get
            {
                return this._imageRelativePath;
            }
            set
            {
                this._imageRelativePath = value;
                NotifyPropertyChanged(nameof(this.ImageRelativePath));
                NotifyPropertyChanged(nameof(this.ImagePath));
            }
        }

        //圖片路徑
        public Image ImagePath
        {
            get
            {
                string projectPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
                return Image.FromFile(projectPath + this._imageRelativePath);
            }
        }

        //餐點名稱
        public string MealName
        {
            get
            {
                return this._mealName;
            }
            set
            {
                this._mealName = value;
                NotifyPropertyChanged(nameof(Meal.MealName));
            }
        }

        //餐點描述
        public string MealDescription
        {
            get
            {
                return this._mealDescription;
            }
            set
            {
                this._mealDescription = value;
                NotifyPropertyChanged(MEAL_DESCRIPTION);
            }
        }

        //餐點價格
        public int MealPrice
        {
            get
            {
                return this._mealPrice;
            }
            set
            {
                this._mealPrice = value;
                NotifyPropertyChanged(MEAL_PRICE);
            }
        }

        //餐點按紐字樣
        public string MealButtonInformation
        { 
            get
            {
                const string INFORMATION_FORMAT = "{0}\n${1}元";
                return string.Format(INFORMATION_FORMAT, this.MealName, this.MealPrice);
            }
        }

        //更變通知
        void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
