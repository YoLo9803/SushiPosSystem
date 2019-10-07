using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PosSystem
{
    public partial class PosRestaurantSideForm : Form
    {
        PosRestaurantSidePresentationModel _posRestaurantSidePresentationModel;
        StartUpFormPresentationModel _startUpFormPresentationModel;
        Model _model;

        public PosRestaurantSideForm(PosRestaurantSidePresentationModel presentationModel, Model model
            , StartUpFormPresentationModel startUpModel)
        {
            this._posRestaurantSidePresentationModel = presentationModel;
            this._startUpFormPresentationModel = startUpModel;
            this._model = model;
            InitializeComponent();
            InitializeOpenFileDialogue();
            BindData();
            
        }
        //初始化OpenFileDialogue
        private void InitializeOpenFileDialogue()
        {
            string projectPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            this._openFileDialog.InitialDirectory = projectPath;
            const string FILTER = "Image | *.png; *.jpg; *.jpeg";
            this._openFileDialog.Filter = FILTER;
        }

        //資料繫結
        private void BindData()
        {
            this._listBoxMeals.DataSource = this._model.TotalMeals;
            this._listBoxMeals.DisplayMember = "MealName";
            this._listBoxCategory.DataSource = this._model.MealCategoryList;
            this._listBoxCategory.DisplayMember = nameof(Category.MealCategory);
            this._comboBoxCategory.DataSource = _model.MealCategoryList;
            this._comboBoxCategory.DisplayMember = "MealCategory";
            this._textBoxMealName.DataBindings.Add(nameof(TextBox.Text), _posRestaurantSidePresentationModel, nameof(PosRestaurantSidePresentationModel.SelectMealName));
            this._textBoxMealPrice.DataBindings.Add(nameof(TextBox.Text), _posRestaurantSidePresentationModel, nameof(PosRestaurantSidePresentationModel.SelectMealPrice));
            this._textBoxMealDescription.DataBindings.Add(nameof(TextBox.Text), _posRestaurantSidePresentationModel, nameof(PosRestaurantSidePresentationModel.SelectMealDescription));
            this._comboBoxCategory.DataBindings.Add(nameof(ComboBox.Text), _posRestaurantSidePresentationModel, nameof(PosRestaurantSidePresentationModel.SelectMealCategory));
            this._textBoxCategoryName.DataBindings.Add(nameof(TextBox.Text), _posRestaurantSidePresentationModel, nameof(PosRestaurantSidePresentationModel.CategoryName));
            BindData2();
        }

        //DataBinding
        void BindData2()
        {
            this._textBoxMealName.DataBindings.Add(nameof(TextBox.Enabled), _posRestaurantSidePresentationModel, nameof(PosRestaurantSidePresentationModel.SelectMealNameEnabled));
            this._textBoxMealPrice.DataBindings.Add(nameof(TextBox.Enabled), _posRestaurantSidePresentationModel, nameof(PosRestaurantSidePresentationModel.SelectMealPriceEnabled));
            this._textBoxMealDescription.DataBindings.Add(nameof(TextBox.Enabled), _posRestaurantSidePresentationModel, nameof(PosRestaurantSidePresentationModel.SelectMealDescriptionEnabled));
            this._comboBoxCategory.DataBindings.Add(nameof(ComboBox.Enabled), _posRestaurantSidePresentationModel, nameof(PosRestaurantSidePresentationModel.SelectMealCategoryEnabled));
            this._textBoxPath.DataBindings.Add(nameof(TextBox.Text), _posRestaurantSidePresentationModel, nameof(PosRestaurantSidePresentationModel.SelectMealRelativePath));
            this._textBoxPath.DataBindings.Add(nameof(TextBox.Enabled), _posRestaurantSidePresentationModel, nameof(PosRestaurantSidePresentationModel.SelectMealRelativePathEnabled));
            this._buttonBrowse.DataBindings.Add(nameof(Button.Enabled), _posRestaurantSidePresentationModel, nameof(PosRestaurantSidePresentationModel.ButtonBrowseEnabled));
            this._buttonDeleteMeal.DataBindings.Add(nameof(Button.Enabled), _posRestaurantSidePresentationModel, nameof(PosRestaurantSidePresentationModel.ButtonDeleteMealEnabled));
            this._buttonDeleteCategory.DataBindings.Add(nameof(Button.Enabled), _posRestaurantSidePresentationModel, nameof(PosRestaurantSidePresentationModel.ButtonDeleteCategoryEnabled));
            this._textBoxCategoryName.DataBindings.Add(nameof(TextBox.Enabled), _posRestaurantSidePresentationModel, nameof(PosRestaurantSidePresentationModel.TextBoxCategoryNameEnabled));
            this._buttonSaveCategory.DataBindings.Add(nameof(Button.Enabled), _posRestaurantSidePresentationModel, nameof(PosRestaurantSidePresentationModel.SaveCategoryButtonEnabled));
            this._buttonSaveMeal.DataBindings.Add(nameof(Button.Enabled), _posRestaurantSidePresentationModel, nameof(PosRestaurantSidePresentationModel.SaveButtonEnabled));
        }

        //關閉Form
        private void ClosePosRestaurantSideForm(object sender, FormClosedEventArgs e)
        {
            _startUpFormPresentationModel.AlterRestaurantSideOpend();
        }

        //按下刪除餐點按紐
        private void ButtonDeleteMealClick(object sender, EventArgs e)
        {
            int selectIndex = this._listBoxMeals.SelectedIndex;
            _model.DeleteMeal(selectIndex);
            this._model.DeleteOrder(selectIndex);
            this._model.TotalMeals.RemoveAt(selectIndex);
            _posRestaurantSidePresentationModel.ResetMealInformation();
            this._listBoxMeals.ClearSelected();
        }

        //選擇左方餐點時更新右方資訊
        private void ListBoxMealsMouseClick(object sender, MouseEventArgs e)
        {
            int selectIndex = this._listBoxMeals.SelectedIndex;
            Meal selectMeal = _model.TotalMeals[selectIndex];
            _posRestaurantSidePresentationModel.SelectMeal = selectMeal;
            _posRestaurantSidePresentationModel.DisplayMealInformation(selectMeal);
            const string SAVE = "Save";
            this._buttonSaveMeal.Text = SAVE;
            const string Edit_MEAL = "Edit Meal";
            this._groupBoxEditMeal.Text = Edit_MEAL;
        }

        //停用餐點資訊TextBox
        private void DisableMealInformationTextBox()
        {
            this._textBoxMealName.Enabled = false;
            this._textBoxMealPrice.Enabled = false;
            this._textBoxMealDescription.Enabled = false;
            this._comboBoxCategory.Enabled = false;
            this._textBoxPath.Enabled = false;
        }

        //按下儲存餐點按紐
        private void ButtonSaveMealClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string buttonText = button.Text;
            int selectIndex = this._listBoxMeals.SelectedIndex;
            int selectCategory = this._comboBoxCategory.SelectedIndex;
            _posRestaurantSidePresentationModel.ClickButtonSaveMeal(buttonText, selectIndex, selectCategory);
        }

        //按下瀏覽按鈕
        private void ButtonBrowseClick(object sender, EventArgs e)
        {
            DialogResult result = this._openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string projectPath = Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory());
                _posRestaurantSidePresentationModel.ConvertToRelativePath(projectPath, this._openFileDialog.FileName);
            }
        }

        //按下新增新餐點按紐
        private void ButtonAddNewMealClick(object sender, EventArgs e)
        {
            _posRestaurantSidePresentationModel.SelectMeal = null;
            const string ADD = "Add";
            this._buttonSaveMeal.Text = ADD;
            const string ADD_MEAL = "Add Meal";
            this._groupBoxEditMeal.Text = ADD_MEAL;
            _posRestaurantSidePresentationModel.ClearMealInformation();
        }

        //刷新ListBoxUsingCategory
        private void RefreshListBoxUsingCategory(int selectIndex)
        {
            Category mealList = this._model.MealCategoryList[selectIndex];
            this._listBoxMealsUsingCategory.Items.Clear();
            for (int count = mealList.LowerLimit; count <= mealList.UpperLimit; count++)
            {
                this._listBoxMealsUsingCategory.Items.Add(this._model.TotalMeals[count].MealName);
            }
        }

        //點擊ListBoxCategory
        private void ListBoxCategoryMouseClick(object sender, MouseEventArgs e)
        {
            const string EDIT_CATEGORY = "Edit Category";
            this._groupBoxEditCategory.Text = EDIT_CATEGORY;
            ListBox listBox = sender as ListBox;
            int selectIndex = listBox.SelectedIndex;
            if (selectIndex != -1)
            {
                RefreshListBoxUsingCategory(selectIndex);
                _posRestaurantSidePresentationModel.CategoryAmount = this._model.MealCategoryList.Count;
                _posRestaurantSidePresentationModel.SelectMealList = this._model.MealCategoryList[selectIndex];
                Category mealList = this._model.MealCategoryList[selectIndex];
                _posRestaurantSidePresentationModel.DisplayCategoryName(mealList);
                const string SAVE = "Save";
                this._buttonSaveCategory.Text = SAVE;
            }
        }

        //按下tab時清空所有餐點資料
        private void ChangeTabControlManagerSelectedIndex(object sender, EventArgs e)
        {
            _posRestaurantSidePresentationModel.ResetMealInformation();
            this._listBoxMealsUsingCategory.Items.Clear();
            const string Edit_MEAL = "Edit Meal";
            this._groupBoxEditMeal.Text = Edit_MEAL;
        }

        //按下Add Category清空右方欄位並更改button字樣
        private void ButtonAddCategoryClick(object sender, EventArgs e)
        {
            const string ADD_CATEGORY = "Add Category";
            this._groupBoxEditCategory.Text = ADD_CATEGORY;
            _posRestaurantSidePresentationModel.ClearMealInformation();
            this._listBoxMealsUsingCategory.Items.Clear();
            const string ADD = "Add";
            this._buttonSaveCategory.Text = ADD;
        }

        //按下右下角save按紐儲存category資料
        private void ButtonSaveCategoryClick(object sender, EventArgs e)
        {
            const string EDIT_CATEGORY = "Edit Category";
            this._groupBoxEditCategory.Text = EDIT_CATEGORY;
            Button button = sender as Button;
            string buttonText = button.Text;
            int selectIndex = this._listBoxCategory.SelectedIndex;
            _posRestaurantSidePresentationModel.ClickButtonSaveCategory(buttonText, selectIndex);
            _posRestaurantSidePresentationModel.ResetMealInformation();
            const string Edit_MEAL = "Edit Meal";
            this._groupBoxEditMeal.Text = Edit_MEAL;
        }

        //按下刪除Category按紐
        private void ButtonDeleteCategoryClick(object sender, EventArgs e)
        {
            int selectIndex = this._listBoxCategory.SelectedIndex;
            this._model.TabPage = 1;
            _posRestaurantSidePresentationModel.DeleteCategory(selectIndex);
            _posRestaurantSidePresentationModel.ResetMealInformation();
            _posRestaurantSidePresentationModel.SelectMealList = null;
            this._listBoxCategory.ClearSelected();
            this._listBoxMealsUsingCategory.Items.Clear();
        }

        //餐點名稱資料改變
        private void ChangeTextBoxMealNameText(object sender, EventArgs e)
        {
            _posRestaurantSidePresentationModel.SelectMealName = ((TextBox)sender).Text;
        }

        //餐點價格改變
        private void ChangeTextBoxMealPriceText(object sender, EventArgs e)
        {
            _posRestaurantSidePresentationModel.SelectMealPrice = ((TextBox)sender).Text;
        }

        //Category名稱改變時
        private void ChangeTextBoxCategoryNameText(object sender, EventArgs e)
        {
            _posRestaurantSidePresentationModel.CategoryName = ((TextBox)sender).Text;
        }
    }
}
