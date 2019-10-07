using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PosSystem
{
    public class PosRestaurantSidePresentationModel : PosRestaurantSidePresentationModelBase, INotifyPropertyChanged
    {
        Model _model;
        public PosRestaurantSidePresentationModel(Model model)
        {
            this._model = model;
        }

        public Model Model
        {
            get
            {
                return this._model;
            }
        }

        //餐點類別更改
        public void ChangeMealCategoryInformation(int selectIndex, int selectCategory)
        {
            Meal selectMeal = _model.TotalMeals[selectIndex];
            BindingList<Category> selectMealList = this._model.MealCategoryList;
            if (selectMeal.MealCategoryIndex != selectCategory)
            {
                this._model.DeleteMeal(selectIndex);
                this._model.AddMeal(selectCategory);
                selectMeal.MealCategory = this.SelectMealCategory;
                ChangeMealLocation(selectMeal, selectMealList, selectIndex, selectCategory);
                selectMeal.MealCategoryIndex = selectCategory;
            }
        }

        //更改餐點位置
        private void ChangeMealLocation(Meal selectMeal, BindingList<Category> selectMealList, int selectIndex, int selectCategory)
        {
            if (selectMeal.MealCategoryIndex > selectCategory)
            {
                this._model.TotalMeals.Insert(selectMealList[selectCategory].UpperLimit, selectMeal);
                this._model.TotalMeals.RemoveAt(selectIndex + 1);
            }
            else
            {
                this._model.TotalMeals.Insert(selectMealList[selectCategory].UpperLimit + 1, selectMeal);
                this._model.TotalMeals.RemoveAt(selectIndex);
            }
        }

        //按下刪除餐點類型按紐
        public void DeleteCategory(int selectIndex)
        {
            this.Model.DeleteCategory(selectIndex);
        }
        
        //按下儲存或增加按鈕
        public void ClickButtonSaveMeal(string text, int selectIndex , int selectCategory)
        {
            const string SAVE = "Save";
            const string ADD = "Add";
            if (text == SAVE)
            {
                this.ChangeMealInformation(selectIndex, selectCategory);
            }
            else if (text == ADD)
            {
                Category mealList = _model.MealCategoryList[selectCategory];
                Meal newMeal = new Meal(this.SelectMealName, Convert.ToInt32(this.SelectMealPrice), this.SelectMealDescription, this.SelectMealCategory,selectCategory ,this.SelectMealRelativePath);
                _model.AddMeal(selectCategory);
                mealList.InsertMeal(newMeal);
                this.ResetMealInformation();
            }
        }

        //按下儲存餐點種類按紐
        public void ClickButtonSaveCategory(string text, int selectIndex)
        {
            const string SAVE = "Save";
            const string ADD = "Add";
            BindingList<Category> mealList = this._model.MealCategoryList;
            if (text == SAVE)
            {
                mealList[selectIndex].ChangeCategoryName(this.CategoryName);
                Category list = new Category(this._model.TotalMeals, SAVE, 0, -1);
                mealList.Add(list);
                mealList.Remove(list);
            }
            else if (text == ADD)
            {
                this._model.AddCategory(this.CategoryName);
            }
        }

        //絕對路徑轉相對路徑
        public void ConvertToRelativePath(String basePath, String targetPath)
        {
            Uri baseUri = new Uri(basePath);
            Uri targetUri = new Uri(targetPath);
            const string SLASH = "/";
            string relativePath = SLASH + baseUri.MakeRelativeUri(targetUri).ToString().Replace(@SLASH, @SLASH);
            this.SelectMealRelativePath = relativePath;
        }

        //顯示餐點類別名稱
        public void DisplayCategoryName(Category mealList)
        {
            this.CategoryName = mealList.MealCategory;
            NotifyPropertyChanged(nameof(this.CategoryName));
            NotifyPropertyChanged(nameof(this.TextBoxCategoryNameEnabled));
            NotifyPropertyChanged(nameof(this.SaveCategoryButtonEnabled));
        }

        //更改餐點資料
        public void ChangeMealInformation(int selectIndex, int selectCategory)
        {
            Meal selectMeal = _model.TotalMeals[selectIndex];
            BindingList<Category> selectMealList = this._model.MealCategoryList;
            selectMeal.MealName = this.SelectMealName;
            selectMeal.MealPrice = Convert.ToInt32(this.SelectMealPrice);
            selectMeal.MealDescription = this.SelectMealDescription;
            selectMeal.ImageRelativePath = this.SelectMealRelativePath;
            this.ChangeMealCategoryInformation(selectIndex,selectCategory);
            ResetMealInformation();
            NotifyPropertyChanging();
        }

        //重置餐點資料
        public void ResetMealInformation()
        {
            this.SelectMeal = null;
            this.SelectMealName = null;
            this.SelectMealPrice = null;
            this.SelectMealCategory = null;
            this.SelectMealDescription = null;
            this.SelectMealRelativePath = null;
            this.SelectMealList = null;
            this.CategoryName = null;
        }

        //清空餐點資訊
        public void ClearMealInformation()
        {
            this.SelectMealName = "";
            this.SelectMealPrice = "";
            this.SelectMealCategory = "";
            this.SelectMealDescription = "";
            this.SelectMealRelativePath = "";
            this.CategoryName = "";
        }

        //顯示餐點資訊
        public void DisplayMealInformation(Meal selectMeal)
        {
            this.SelectMealName = selectMeal.MealName;
            this.SelectMealPrice = selectMeal.MealPrice.ToString();
            this.SelectMealCategory = selectMeal.MealCategory;
            this.SelectMealDescription = selectMeal.MealDescription;
            this.SelectMealRelativePath = selectMeal.ImageRelativePath;
            NotifyPropertyChanging();
        }

        //通知TextBox變更
        void NotifyPropertyChanging()
        {
            NotifyPropertyChanged(nameof(this.SelectMeal));
            NotifyPropertyChanged(nameof(this.SelectMealName));
            NotifyPropertyChanged(nameof(this.SelectMealPrice));
            NotifyPropertyChanged(nameof(this.SelectMealDescription));
            NotifyPropertyChanged(nameof(this.SelectMealCategory));
            NotifyPropertyChanged(nameof(this.SelectMealRelativePath));
        }
    }
}
