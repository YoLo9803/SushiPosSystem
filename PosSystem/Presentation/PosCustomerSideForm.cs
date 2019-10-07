using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class PosCustomerSideForm : Form
    {
        PosCustomerSidePresentationModel _posCustomerSidePresentationModel;
        StartUpFormPresentationModel _startUpFormPresentationModel;
        Model _model;
        List<Button> _mealButton = new List<Button>();
        const int COLUMNS = PosCustomerSidePresentationModel.COLUMNS;
        const int ROWS = PosCustomerSidePresentationModel.ROWS;

        public PosCustomerSideForm(PosCustomerSidePresentationModel presentationModel, Model model,
            StartUpFormPresentationModel startUpModel)
        {   
            this._posCustomerSidePresentationModel = presentationModel;
            this._startUpFormPresentationModel = startUpModel;
            this._model = model;
            InitializeComponent();
            InitializeMealButton();
            InitializeTableLayout();
            InitializeDataGridView();
            BindData();
            _buttonPreviousPage.Enabled = false;
            _buttonAdd.Enabled = false;
            this._model.TotalMeals.ListChanged += TotalMealsListChanged;
            this._model.MealCategoryList.ListChanged += MealCategoryListListChanged;
            RefreshTabControl();
        }

        //MealList更改時刷新TabControls
        private void MealCategoryListListChanged(object sender, ListChangedEventArgs e)
        {
            RefreshTabControl();
        }

        //BindingList更變時
        private void TotalMealsListChanged(object sender, ListChangedEventArgs e)
        {
            this._recordDataGridView.Refresh();
            _posCustomerSidePresentationModel.NotifyPropertyChanged(nameof(PosCustomerSidePresentationModel.LabelTotalPrice));
            _posCustomerSidePresentationModel.NotifyPropertyChanged(nameof(PosCustomerSidePresentationModel.LabelPage));
            _posCustomerSidePresentationModel.NotifyPropertyChanged(nameof(PosCustomerSidePresentationModel.MealDescriptionText));
            RefreshButton();
        }

        //刷新tabControls
        private void RefreshTabControl()
        {
            this._tabControlMeals.Controls.Clear();
            BindingList<Category> categoryList = this._model.MealCategoryList;
            for (int count = 0; count < categoryList.Count; count++)
            {
                TabPage tabPage = new System.Windows.Forms.TabPage();
                tabPage.Text = categoryList[count].MealCategory;
                this._tabControlMeals.Controls.Add(tabPage);
            }
            this._tabControlMeals.SelectedTab.Controls.Add(this._tableLayoutPanelMeal1);
        }

        //增加按紐column
        DataGridViewButtonColumn AddDataGridViewButtonColumn(string headerText, string propertyName, bool isReadOnly)
        {
            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            column.HeaderText = headerText;
            column.DataPropertyName = propertyName;
            column.ReadOnly = isReadOnly;
            return column;
        }

        //增加文字column
        DataGridViewTextBoxColumn AddDataGridViewTextBoxColumn(string headerText, string propertyName)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.HeaderText = headerText;
            column.DataPropertyName = propertyName;
            column.ReadOnly = true;
            return column;
        }

        //初始化DataGridView
        private void InitializeDataGridView()
        {
            this._recordDataGridView.AutoGenerateColumns = false;
            this._recordDataGridView.DataSource = this._model.PresentOrder.OrderList;
            const string DELETE = "Delete";
            this._recordDataGridView.Columns.Add(AddDataGridViewButtonColumn(DELETE, nameof(OrderCell.MealDelete), true));
            const string MEAL_NAME = "Name";
            this._recordDataGridView.Columns.Add(AddDataGridViewTextBoxColumn(MEAL_NAME, nameof(OrderCell.MealName)));
            const string MEAL_CATEGORY = "Category";
            this._recordDataGridView.Columns.Add(AddDataGridViewTextBoxColumn(MEAL_CATEGORY, nameof(OrderCell.MealCategory)));
            const string MEAL_UNIT_PRICE = "UnitPrice";
            this._recordDataGridView.Columns.Add(AddDataGridViewTextBoxColumn(MEAL_UNIT_PRICE, nameof(OrderCell.MealUnitPrice)));
            InitializeDataGridView2();
        }

        //初始化
        void InitializeDataGridView2()
        {
            DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn mealQuantity =
                new DataGridViewNumericUpDownElements.DataGridViewNumericUpDownColumn();
            mealQuantity.HeaderText = "qty";
            mealQuantity.DataPropertyName = nameof(OrderCell.MealQuantity);
            mealQuantity.ReadOnly = false;
            this._recordDataGridView.Columns.Add(mealQuantity);
            const string MEAL_SUBTOTAL = "SubTotal";
            this._recordDataGridView.Columns.Add(AddDataGridViewTextBoxColumn(MEAL_SUBTOTAL, nameof(OrderCell.MealSubtotalLabel)));
        }

        //DataBinding
        private void BindData()
        {
            _labelPage.DataBindings.Add(nameof(Label.Text), _posCustomerSidePresentationModel, nameof(PosCustomerSidePresentationModel.LabelPage));
            _buttonNextPage.DataBindings.Add(nameof(Button.Enabled), _posCustomerSidePresentationModel, nameof(PosCustomerSidePresentationModel.NextPageEnabled));
            _buttonPreviousPage.DataBindings.Add(nameof(Button.Enabled), _posCustomerSidePresentationModel, nameof(PosCustomerSidePresentationModel.PreviousPageEnabled));
            _labelTotalPrice.DataBindings.Add(nameof(Label.Text), _posCustomerSidePresentationModel, nameof(PosCustomerSidePresentationModel.LabelTotalPrice));
            _richTextBox1.DataBindings.Add(nameof(TextBox.Text), _posCustomerSidePresentationModel, nameof(PosCustomerSidePresentationModel.MealDescriptionText));
            RefreshButton();
        }

        //刷新按紐
        void RefreshButton()
        {
            const string TEXT = "Text";
            const string BACKGROUND = "BackgroundImage";
            for (int count = 0; count < COLUMNS * ROWS; count++)
            {
                if (_mealButton[count].Visible = _posCustomerSidePresentationModel.IsListOutOfRange(count))
                {
                    Category mealList = _model.Meals;
                    Meal meal = mealList.MealBindingList[mealList.LowerLimit + _posCustomerSidePresentationModel.PageIndex + count];
                    _mealButton[count].DataBindings.Clear();
                    _mealButton[count].DataBindings.Add(TEXT, meal, "MealButtonInformation",true);
                    _mealButton[count].DataBindings.Add(BACKGROUND, meal, "ImagePath" ,true);
                }
            }
        }

        //初始化TableLayout
        private void InitializeTableLayout()
        {
            int width = this._tableLayoutPanelMeal1.Size.Width;
            int height = this._tableLayoutPanelMeal1.Size.Height;
            this._tableLayoutPanelMeal1.ColumnCount = COLUMNS;
            this._tableLayoutPanelMeal1.RowCount = ROWS;
            for (int Column = 0; Column < COLUMNS; Column++)
                this._tableLayoutPanelMeal1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, width / COLUMNS));
            for (int Row = 0; Row < ROWS; Row++)
                this._tableLayoutPanelMeal1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, height / ROWS));
            
        }

        //初始化餐點按紐
        private void InitializeMealButton()
        {
            const string BUTTON_MEAL = "ButtonMeal";
            int count = 0;
            for (int Row = 0; Row < ROWS; Row++)
            {
                for (int Column = 0; Column < COLUMNS; Column++)
                {
                    count++;
                    Button newButton = new Button();
                    _mealButton.Add(newButton);
                    this._tableLayoutPanelMeal1.Controls.Add(_mealButton.Last(), Column, Row);
                    newButton.AccessibleName = BUTTON_MEAL + count.ToString();
                    newButton.Dock = System.Windows.Forms.DockStyle.Fill;
                    newButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
                    newButton.ForeColor = System.Drawing.Color.White;
                    newButton.BackgroundImageLayout = ImageLayout.Stretch;
                    newButton.Click += new System.EventHandler(this.ButtonMealClick);
                    newButton.Tag = _mealButton.Count - 1;
                }
            }
        }

        //關閉客戶端後StartUp按鈕Enable
        private void ClosePosCustomerSideForm(object sender, FormClosedEventArgs e)
        {
            _startUpFormPresentationModel.AlterCustomerSideOpend();
        }

        //TabControl改變時
        private void ChangeTabControlMealsSelectedIndex(object sender, EventArgs e)
        {
            TabControl tabControl = sender as TabControl;
            _posCustomerSidePresentationModel.ChangeTabControlIndex(tabControl.SelectedIndex);
            if (tabControl.SelectedIndex != -1)
                tabControl.SelectedTab.Controls.Add(this._tableLayoutPanelMeal1);
            RefreshButton();
        }

        //按下Next Page
        private void ButtonNextPageClick(object sender, EventArgs e)
        {
            _posCustomerSidePresentationModel.PageTurning = 1;
            RefreshButton();
        }

        //按下Previous Page
        private void ButtonPreviousPageClick(object sender, EventArgs e)
        {
            _posCustomerSidePresentationModel.PageTurning = -1;
            RefreshButton();
        }

        //按下Add按紐
        private void ButtonAddClick(object sender, EventArgs e)
        {
            if (_model.SelectMeal != null)
            {
                Meal selectMeal = _model.SelectMeal;
                _posCustomerSidePresentationModel.AddMeal(selectMeal);
                _buttonAdd.Enabled = false;
                this._model.SelectMeal = null;
                _posCustomerSidePresentationModel.NotifyPropertyChanged("MealDescriptionText");
            }
        }

        //按下餐點按紐儲存餐點資訊
        private void ButtonMealClick(object sender, EventArgs e)
        {
            Button selectButton = sender as Button;
            Category mealList = _model.Meals;
            Meal selectMeal = mealList.MealBindingList[mealList.LowerLimit + _posCustomerSidePresentationModel.PageIndex + (int)selectButton.Tag];
            _model.SelectMeal = selectMeal;
            this._model.SelectMeal = selectMeal;
            _posCustomerSidePresentationModel.NotifyPropertyChanged(nameof(PosCustomerSidePresentationModel.MealDescriptionText));
            if (_buttonAdd.Enabled == false)
                _buttonAdd.Enabled = true;
        }

        //按下DGV
        private void RecordDataGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int mealIndex = e.RowIndex;
                _posCustomerSidePresentationModel.DeleteMeal(mealIndex);
            }
        }

        //DGV儲存格值變
        private void RecordDataGridViewCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow selectedRow = this._recordDataGridView.Rows[e.RowIndex];
                int quantity = Convert.ToInt32(selectedRow.Cells[e.ColumnIndex].Value);
                _posCustomerSidePresentationModel.ChangeQuantity(quantity, e.RowIndex);
            }
        }

    }
}
