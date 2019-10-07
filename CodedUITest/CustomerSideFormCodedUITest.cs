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
    public class CustomerSideFormCodedUITest
    {
        private const string FILE_PATH = @"../../../PosSystem/bin/Debug/PosSystem.exe";

        //startUpForm
        private const string START_UP_FORM_TEXT = "StartUp";
        private const string CUSTOMER_SIDE_FORM_TEXT = "POS-Customer Side";
        private const string RESTAURANT_SIDE_FORM_TEXT = "POS-Restaurant Side";
        private const string START_CUSTOMER_FORM = "ButtonStartCustomerProgram";
        private const string START_RESTAURANT_FORM = "ButtonStartRestaurantProgram";
        private const string BUTTON_START_CUSTOMER = "ButtonStartCustomerProgram";
        private const string BUTTON_START_RESTAURANT = "ButtonStartRestaurantProgram";
        private const string BUTTON_EXIT = "ButtonExit";

        //CustomerSideForm
        private const string LABEL_PAGE_TEXT_1_2 = "Page: 1 / 2";
        private const string LABEL_PAGE_TEXT_2_2 = "Page: 2 / 2";
        private const string LABEL_PAGE_TEXT_1_1 = "Page: 1 / 1";
        private const string LABEL_PAGE_NAME = "LabelPage";
        private const string TAB_CONTROL_DESSERT = "甜點";
        private const string TAB_CONTROL_DRINKS = "飲料";
        private const string BUTTON_NEXT_PAGE = "ButtonNextPage";
        private const string BUTTON_PREVIOUS_PAGE = "ButtonPreviousPage";
        private const string BUTTON_MEAL_1 = "ButtonMeal1";
        private const string BUTTON_MEAL_2 = "ButtonMeal2";
        private const string BUTTON_MEAL_3 = "ButtonMeal3";
        private const string BUTTON_MEAL_7 = "ButtonMeal7";
        private const string BUTTON_MEAL_8 = "ButtonMeal8";
        private const string RICH_TEXTBOX = "RichTextBox1";
        private const string RICH_TEXTBOX_VALUE = "巧克力法式金磚，超好吃！\r";
        private const string BUTTON_ADD = "ButtonAdd";
        private const string DATA_GRID_VIEW_NAME = "RecordDataGridView";
        private readonly string[]  _stringMeal = new string[]{ "X", "巧克力法式金磚", "甜點", "90", "1", "90NTD" };
        private const string LABEL_TOTAL_PRICE = "LabelTotalPrice";
        private const string LABEL_TOTAL_PRICE_1 = "Total:370元";
        private const string LABEL_TOTAL_PRICE_2 = "Total:690元";
        public CustomerSideFormCodedUITest()
        {
        }



        [TestMethod]
        public void StartUpFormTest()
        {
            Robot.ClickButton(START_CUSTOMER_FORM);
            Robot.SetForm(CUSTOMER_SIDE_FORM_TEXT);
            Robot.AssertButtonEnable(BUTTON_START_CUSTOMER, false);
            Robot.CloseWindow(CUSTOMER_SIDE_FORM_TEXT);
            Robot.SetForm(START_UP_FORM_TEXT);
            Robot.ClickButton(START_RESTAURANT_FORM);
            Robot.AssertButtonEnable(BUTTON_START_RESTAURANT, false);
            Robot.CloseWindow(RESTAURANT_SIDE_FORM_TEXT);
            Robot.ClickButton(BUTTON_EXIT);
            // 若要為這個測試產生程式碼，請在捷徑功能表上選取 [產生自動程式化 UI 測試的程式碼]，並選取其中一個功能表項目。
        }

        [TestMethod]
        public void CustomerSideInitializeTest()
        {
            Robot.SetForm(CUSTOMER_SIDE_FORM_TEXT);
            Robot.AssertText(LABEL_PAGE_NAME, LABEL_PAGE_TEXT_1_2);
            Robot.ClickButton(BUTTON_NEXT_PAGE);
            Robot.AssertText(LABEL_PAGE_NAME, LABEL_PAGE_TEXT_2_2);
            Robot.ClickButton(BUTTON_PREVIOUS_PAGE);
            Robot.AssertText(LABEL_PAGE_NAME, LABEL_PAGE_TEXT_1_2);
            Robot.ClickTabControl(TAB_CONTROL_DESSERT);
            Robot.AssertText(LABEL_PAGE_NAME, LABEL_PAGE_TEXT_1_1);
            Robot.ClickButton(BUTTON_MEAL_2);
            Robot.AssertEdit(RICH_TEXTBOX, RICH_TEXTBOX_VALUE);
            Robot.ClickButton(BUTTON_ADD);
            Robot.AssertDataGridViewByIndex(DATA_GRID_VIEW_NAME, 1.ToString(), _stringMeal);

            Robot.CloseWindow(CUSTOMER_SIDE_FORM_TEXT);
        }

        [TestMethod]
        public void CustomerSideDataGridViewTest()
        {
            Robot.SetForm(CUSTOMER_SIDE_FORM_TEXT);
            Robot.ClickButton(BUTTON_MEAL_1);
            Robot.ClickButton(BUTTON_ADD);
            Robot.ClickButton(BUTTON_MEAL_2);
            Robot.ClickButton(BUTTON_ADD);
            Robot.ClickButton(BUTTON_MEAL_7);
            Robot.ClickButton(BUTTON_ADD);
            Robot.ClickTabControl(TAB_CONTROL_DESSERT);
            Robot.ClickButton(BUTTON_MEAL_2);
            Robot.AssertEdit(RICH_TEXTBOX, RICH_TEXTBOX_VALUE);
            Robot.ClickButton(BUTTON_ADD);
            Robot.ClickTabControl(TAB_CONTROL_DRINKS);
            Robot.ClickButton(BUTTON_MEAL_3);
            Robot.ClickButton(BUTTON_ADD);
            Robot.ClickButton(BUTTON_MEAL_1);
            Robot.ClickButton(BUTTON_ADD);
            Robot.AssertDataGridViewByIndex(DATA_GRID_VIEW_NAME, 4.ToString(), _stringMeal);
            Robot.AssertText(LABEL_TOTAL_PRICE, LABEL_TOTAL_PRICE_1);
            Robot.SetDataGridViewQuantity(DATA_GRID_VIEW_NAME, 4.ToString(), 5.ToString());
            Robot.DeleteDataGridViewRowByIndex(DATA_GRID_VIEW_NAME, 2.ToString());
            Robot.AssertText(LABEL_TOTAL_PRICE, LABEL_TOTAL_PRICE_2);
        }

        #region 其他測試屬性

        // 您可以使用下列其他屬性撰寫測試: 

        ////在每項測試執行前先使用 TestInitialize 執行程式碼 
        [TestInitialize()]
        public void MyTestInitialize()
        {
            Robot.Initialize(FILE_PATH, START_UP_FORM_TEXT);
            Robot.ClickButton(START_CUSTOMER_FORM);
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
