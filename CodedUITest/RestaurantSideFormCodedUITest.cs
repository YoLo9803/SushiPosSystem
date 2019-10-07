using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace CodedUITest
{
    /// <summary>
    /// CodedUITest1 的摘要說明
    /// </summary>
    [CodedUITest]
    public class RestaurantSideFormCodedUITest
    {
        private const string FILE_PATH = @"../../../PosSystem/bin/Debug/PosSystem.exe";
        private const string START_UP_FORM_TEXT = "StartUp";
        private const string CUSTOMER_SIDE_FORM_TEXT = "POS-Customer Side";
        private const string RESTAURANT_SIDE_FORM_TEXT = "POS-Restaurant Side";
        private const string START_RESTAURANT_FORM = "ButtonStartRestaurantProgram";
        private const string BUTTON_START_RESTAURANT = "ButtonStartRestaurantProgram";
        private const string BUTTON_ADD_MEAL = "ButtonAddNewMeal";
        private const string LIST_BOX_MEALS = "ListBoxMeals";
        private const string MEAL1 = "炸蝦天婦羅";
        private const string TEXT_BOX_MEAL_NAME = "TextBoxMealName";
        private const string TEXT_BOX_MEAL_NAME_VALUE = "測試餐點";
        private const string TEXT_BOX_MEAL_PRICE = "TextBoxMealPrice";
        private const string TEXT_BOX_MEAL_PRICE_VALUE = "150";
        private const string TEXT_BOX_MEAL_DESCRIPTION = "TextBoxMealDescription";
        private const string TEXT_BOX_MEAL_DESCRIPTION_VALUE = "測試描述測試描述測試描述";
        private const string OPEN_FILE_TITLE = "開啟";
        private const string OPEN_FILE_PATH = "/Resources/Assets/Sushi/4.jpg";
        public RestaurantSideFormCodedUITest()
        {
        }

        [TestMethod]
        public void RestaurantFormIntializeTest()
        {
            Robot.SetForm(RESTAURANT_SIDE_FORM_TEXT);
            Robot.AssertButtonEnable("ButtonDeleteMeal", false);
            Robot.AssertButtonEnable("ButtonBrowse", false);
            Robot.AssertButtonEnable("ButtonSaveMeal", false);
            Robot.ClickButton(BUTTON_ADD_MEAL);
        }

        [TestMethod]
        public void RestaurantFormEditMealTest()
        {
            Robot.SetForm(RESTAURANT_SIDE_FORM_TEXT);
            Robot.ClickListViewByValue(LIST_BOX_MEALS, MEAL1);
            Robot.SetEdit(TEXT_BOX_MEAL_NAME, TEXT_BOX_MEAL_NAME_VALUE);
            Robot.SetEdit(TEXT_BOX_MEAL_PRICE, TEXT_BOX_MEAL_PRICE_VALUE);
            Robot.SetEdit("ComboBoxCategory", "甜點");
            Robot.ClickButton("ButtonBrowse");
            Robot.SelectFileByOpenFileDialog(OPEN_FILE_TITLE, OPEN_FILE_PATH.Trim('/').Split('/'));
            Robot.SetEdit(TEXT_BOX_MEAL_DESCRIPTION, TEXT_BOX_MEAL_DESCRIPTION_VALUE);
            Robot.ClickButton("ButtonSaveMeal");
            Robot.ClickListViewByValue(LIST_BOX_MEALS, TEXT_BOX_MEAL_NAME_VALUE);
            Robot.AssertEdit(TEXT_BOX_MEAL_NAME, TEXT_BOX_MEAL_NAME_VALUE);
            Robot.AssertEdit(TEXT_BOX_MEAL_PRICE, TEXT_BOX_MEAL_PRICE_VALUE);
            Robot.AssertEdit("ComboBoxCategory", "甜點");
            Robot.AssertEdit("TextBoxPath", "/Resources/Assets/Sushi/4.jpg");
            Robot.AssertEdit(TEXT_BOX_MEAL_DESCRIPTION, TEXT_BOX_MEAL_DESCRIPTION_VALUE);
            Robot.ClickButton("ButtonDeleteMeal");
        }

        [TestMethod]
        public void RestaurantFormAddMealTest()
        {
            Robot.SetForm(RESTAURANT_SIDE_FORM_TEXT);
            Robot.ClickButton("ButtonAddNewMeal");
            Robot.SetEdit("TextBoxMealName", "新增餐點");
            Robot.SetEdit("TextBoxMealPrice", "70");
            Robot.SetEdit("ComboBoxCategory", "飲料");
            Robot.ClickButton("ButtonBrowse");
            Robot.SelectFileByOpenFileDialog(OPEN_FILE_TITLE, OPEN_FILE_PATH.Trim('/').Split('/'));
            Robot.SetEdit(TEXT_BOX_MEAL_DESCRIPTION, TEXT_BOX_MEAL_DESCRIPTION_VALUE);
            Robot.ClickButton("ButtonSaveMeal");
            Robot.ClickListViewByValue(LIST_BOX_MEALS, "新增餐點");
            Robot.AssertEdit(TEXT_BOX_MEAL_NAME, "新增餐點");
            Robot.AssertEdit(TEXT_BOX_MEAL_PRICE, "70");
            Robot.AssertEdit("ComboBoxCategory", "飲料");
            Robot.AssertEdit("TextBoxPath", "/Resources/Assets/Sushi/4.jpg");
        }

        [TestMethod]
        public void RestaurantFormInitializeTest()
        {
            Robot.SetForm(RESTAURANT_SIDE_FORM_TEXT);
            Robot.ClickTabControl("Category Manager");
            Robot.AssertButtonEnable("ButtonDeleteCategory", false);
            Robot.AssertButtonEnable("ButtonSaveCategory", false);
            Robot.AssertButtonEnable("ButtonAddCategory", true);
        }

        [TestMethod]
        public void RestaurantFormEditCategoryTest()
        {
            Robot.SetForm(RESTAURANT_SIDE_FORM_TEXT);
            Robot.ClickTabControl("Category Manager");
            Robot.ClickListViewByValue("ListBoxCategory", "壽司");
            Robot.SetEdit("TextBoxCategoryName", "修改餐點種類");
            Robot.ClickButton("ButtonSaveCategory");
            Robot.ClickListViewByValue("ListBoxCategory", "修改餐點種類");
            Robot.AssertEdit("TextBoxCategoryName", "修改餐點種類");
        }

        [TestMethod]
        public void RestaurantFormAddCategoryTest()
        {
            Robot.SetForm(RESTAURANT_SIDE_FORM_TEXT);
            Robot.ClickTabControl("Category Manager");
            Robot.ClickButton("ButtonAddCategory");
            Robot.SetEdit("TextBoxCategoryName", "測試新增餐點");
            Robot.ClickButton("ButtonSaveCategory");
            Robot.AssertButtonEnable("ButtonSaveCategory", false);
            Robot.ClickListViewByValue("ListBoxCategory", "測試新增餐點");
            Robot.AssertEdit("TextBoxCategoryName", "測試新增餐點");
            Robot.ClickButton("ButtonDeleteCategory");
        }

        #region 其他測試屬性

        [TestInitialize()]
        public void MyTestInitialize()
        {
            Robot.Initialize(FILE_PATH, START_UP_FORM_TEXT);
            Robot.ClickButton(START_RESTAURANT_FORM);
        }

        ////在每項測試執行後使用 TestCleanup 執行程式碼
        [TestCleanup()]
        public void MyTestCleanup()
        {
            Robot.CleanUp();
        }

        #endregion

        /// <summary>
        ///取得或設定提供目前測試回合
        ///相關資訊與功能的測試內容。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if (this.map == null)
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
