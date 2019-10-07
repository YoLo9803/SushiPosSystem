namespace PosSystem
{
    partial class PosRestaurantSideForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._tabControlManager = new System.Windows.Forms.TabControl();
            this._tabPageMealManager = new System.Windows.Forms.TabPage();
            this._listBoxMeals = new System.Windows.Forms.ListBox();
            this._buttonDeleteMeal = new System.Windows.Forms.Button();
            this._buttonAddNewMeal = new System.Windows.Forms.Button();
            this._groupBoxEditMeal = new System.Windows.Forms.GroupBox();
            this._buttonSaveMeal = new System.Windows.Forms.Button();
            this._buttonBrowse = new System.Windows.Forms.Button();
            this._textBoxMealDescription = new System.Windows.Forms.TextBox();
            this._comboBoxCategory = new System.Windows.Forms.ComboBox();
            this._textBoxPath = new System.Windows.Forms.TextBox();
            this._labelMealCategory = new System.Windows.Forms.Label();
            this._textBoxMealPrice = new System.Windows.Forms.TextBox();
            this._labelMealDescription = new System.Windows.Forms.Label();
            this._labelMealImage = new System.Windows.Forms.Label();
            this._labelMealPrice = new System.Windows.Forms.Label();
            this._labelMealName = new System.Windows.Forms.Label();
            this._textBoxMealName = new System.Windows.Forms.TextBox();
            this._tabPageCategoryManager = new System.Windows.Forms.TabPage();
            this._listBoxCategory = new System.Windows.Forms.ListBox();
            this._buttonDeleteCategory = new System.Windows.Forms.Button();
            this._buttonAddCategory = new System.Windows.Forms.Button();
            this._groupBoxEditCategory = new System.Windows.Forms.GroupBox();
            this._listBoxMealsUsingCategory = new System.Windows.Forms.ListBox();
            this._buttonSaveCategory = new System.Windows.Forms.Button();
            this._labelUsingThisCategory = new System.Windows.Forms.Label();
            this._labelCategoryName = new System.Windows.Forms.Label();
            this._textBoxCategoryName = new System.Windows.Forms.TextBox();
            this._openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this._tabControlManager.SuspendLayout();
            this._tabPageMealManager.SuspendLayout();
            this._groupBoxEditMeal.SuspendLayout();
            this._tabPageCategoryManager.SuspendLayout();
            this._groupBoxEditCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tabControlManager
            // 
            this._tabControlManager.AccessibleName = "TabControlManager";
            this._tabControlManager.Controls.Add(this._tabPageMealManager);
            this._tabControlManager.Controls.Add(this._tabPageCategoryManager);
            this._tabControlManager.Location = new System.Drawing.Point(12, 12);
            this._tabControlManager.Name = "_tabControlManager";
            this._tabControlManager.SelectedIndex = 0;
            this._tabControlManager.Size = new System.Drawing.Size(776, 426);
            this._tabControlManager.TabIndex = 0;
            this._tabControlManager.SelectedIndexChanged += new System.EventHandler(this.ChangeTabControlManagerSelectedIndex);
            // 
            // _tabPageMealManager
            // 
            this._tabPageMealManager.Controls.Add(this._listBoxMeals);
            this._tabPageMealManager.Controls.Add(this._buttonDeleteMeal);
            this._tabPageMealManager.Controls.Add(this._buttonAddNewMeal);
            this._tabPageMealManager.Controls.Add(this._groupBoxEditMeal);
            this._tabPageMealManager.Location = new System.Drawing.Point(4, 22);
            this._tabPageMealManager.Name = "_tabPageMealManager";
            this._tabPageMealManager.Padding = new System.Windows.Forms.Padding(3);
            this._tabPageMealManager.Size = new System.Drawing.Size(768, 400);
            this._tabPageMealManager.TabIndex = 0;
            this._tabPageMealManager.Text = "Meal Manager";
            this._tabPageMealManager.UseVisualStyleBackColor = true;
            // 
            // _listBoxMeals
            // 
            this._listBoxMeals.AccessibleName = "ListBoxMeals";
            this._listBoxMeals.FormattingEnabled = true;
            this._listBoxMeals.ItemHeight = 12;
            this._listBoxMeals.Location = new System.Drawing.Point(6, 7);
            this._listBoxMeals.Name = "_listBoxMeals";
            this._listBoxMeals.Size = new System.Drawing.Size(305, 352);
            this._listBoxMeals.TabIndex = 0;
            this._listBoxMeals.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxMealsMouseClick);
            // 
            // _buttonDeleteMeal
            // 
            this._buttonDeleteMeal.AccessibleName = "ButtonDeleteMeal";
            this._buttonDeleteMeal.Location = new System.Drawing.Point(194, 371);
            this._buttonDeleteMeal.Name = "_buttonDeleteMeal";
            this._buttonDeleteMeal.Size = new System.Drawing.Size(117, 23);
            this._buttonDeleteMeal.TabIndex = 2;
            this._buttonDeleteMeal.Text = "Delete Selected Meal";
            this._buttonDeleteMeal.UseVisualStyleBackColor = true;
            this._buttonDeleteMeal.Click += new System.EventHandler(this.ButtonDeleteMealClick);
            // 
            // _buttonAddNewMeal
            // 
            this._buttonAddNewMeal.AccessibleName = "ButtonAddNewMeal";
            this._buttonAddNewMeal.Location = new System.Drawing.Point(6, 371);
            this._buttonAddNewMeal.Name = "_buttonAddNewMeal";
            this._buttonAddNewMeal.Size = new System.Drawing.Size(117, 23);
            this._buttonAddNewMeal.TabIndex = 1;
            this._buttonAddNewMeal.Text = "Add New Meal";
            this._buttonAddNewMeal.UseVisualStyleBackColor = true;
            this._buttonAddNewMeal.Click += new System.EventHandler(this.ButtonAddNewMealClick);
            // 
            // _groupBoxEditMeal
            // 
            this._groupBoxEditMeal.Controls.Add(this._buttonSaveMeal);
            this._groupBoxEditMeal.Controls.Add(this._buttonBrowse);
            this._groupBoxEditMeal.Controls.Add(this._textBoxMealDescription);
            this._groupBoxEditMeal.Controls.Add(this._comboBoxCategory);
            this._groupBoxEditMeal.Controls.Add(this._textBoxPath);
            this._groupBoxEditMeal.Controls.Add(this._labelMealCategory);
            this._groupBoxEditMeal.Controls.Add(this._textBoxMealPrice);
            this._groupBoxEditMeal.Controls.Add(this._labelMealDescription);
            this._groupBoxEditMeal.Controls.Add(this._labelMealImage);
            this._groupBoxEditMeal.Controls.Add(this._labelMealPrice);
            this._groupBoxEditMeal.Controls.Add(this._labelMealName);
            this._groupBoxEditMeal.Controls.Add(this._textBoxMealName);
            this._groupBoxEditMeal.Location = new System.Drawing.Point(321, 7);
            this._groupBoxEditMeal.Name = "_groupBoxEditMeal";
            this._groupBoxEditMeal.Size = new System.Drawing.Size(444, 390);
            this._groupBoxEditMeal.TabIndex = 3;
            this._groupBoxEditMeal.TabStop = false;
            this._groupBoxEditMeal.Text = "Edit Meal";
            // 
            // _buttonSaveMeal
            // 
            this._buttonSaveMeal.AccessibleName = "ButtonSaveMeal";
            this._buttonSaveMeal.Location = new System.Drawing.Point(355, 364);
            this._buttonSaveMeal.Name = "_buttonSaveMeal";
            this._buttonSaveMeal.Size = new System.Drawing.Size(83, 23);
            this._buttonSaveMeal.TabIndex = 11;
            this._buttonSaveMeal.Text = "Save";
            this._buttonSaveMeal.UseVisualStyleBackColor = true;
            this._buttonSaveMeal.Click += new System.EventHandler(this.ButtonSaveMealClick);
            // 
            // _buttonBrowse
            // 
            this._buttonBrowse.AccessibleName = "ButtonBrowse";
            this._buttonBrowse.Location = new System.Drawing.Point(355, 124);
            this._buttonBrowse.Name = "_buttonBrowse";
            this._buttonBrowse.Size = new System.Drawing.Size(83, 23);
            this._buttonBrowse.TabIndex = 10;
            this._buttonBrowse.Text = "Browse...";
            this._buttonBrowse.UseVisualStyleBackColor = true;
            this._buttonBrowse.Click += new System.EventHandler(this.ButtonBrowseClick);
            // 
            // _textBoxMealDescription
            // 
            this._textBoxMealDescription.AccessibleName = "TextBoxMealDescription";
            this._textBoxMealDescription.Location = new System.Drawing.Point(8, 189);
            this._textBoxMealDescription.Multiline = true;
            this._textBoxMealDescription.Name = "_textBoxMealDescription";
            this._textBoxMealDescription.Size = new System.Drawing.Size(430, 165);
            this._textBoxMealDescription.TabIndex = 9;
            // 
            // _comboBoxCategory
            // 
            this._comboBoxCategory.AccessibleName = "ComboBoxCategory";
            this._comboBoxCategory.FormattingEnabled = true;
            this._comboBoxCategory.Location = new System.Drawing.Point(308, 76);
            this._comboBoxCategory.Name = "_comboBoxCategory";
            this._comboBoxCategory.Size = new System.Drawing.Size(130, 20);
            this._comboBoxCategory.TabIndex = 8;
            // 
            // _textBoxPath
            // 
            this._textBoxPath.AccessibleName = "TextBoxPath";
            this._textBoxPath.Location = new System.Drawing.Point(150, 124);
            this._textBoxPath.Name = "_textBoxPath";
            this._textBoxPath.ReadOnly = true;
            this._textBoxPath.Size = new System.Drawing.Size(199, 22);
            this._textBoxPath.TabIndex = 7;
            // 
            // _labelMealCategory
            // 
            this._labelMealCategory.AutoSize = true;
            this._labelMealCategory.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._labelMealCategory.Location = new System.Drawing.Point(179, 79);
            this._labelMealCategory.Name = "_labelMealCategory";
            this._labelMealCategory.Size = new System.Drawing.Size(123, 12);
            this._labelMealCategory.TabIndex = 6;
            this._labelMealCategory.Text = "NTD    Meal Category(*)";
            // 
            // _textBoxMealPrice
            // 
            this._textBoxMealPrice.AccessibleName = "TextBoxMealPrice";
            this._textBoxMealPrice.Location = new System.Drawing.Point(84, 74);
            this._textBoxMealPrice.Name = "_textBoxMealPrice";
            this._textBoxMealPrice.Size = new System.Drawing.Size(89, 22);
            this._textBoxMealPrice.TabIndex = 5;
            this._textBoxMealPrice.TextChanged += new System.EventHandler(this.ChangeTextBoxMealPriceText);
            // 
            // _labelMealDescription
            // 
            this._labelMealDescription.AutoSize = true;
            this._labelMealDescription.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._labelMealDescription.Location = new System.Drawing.Point(6, 173);
            this._labelMealDescription.Name = "_labelMealDescription";
            this._labelMealDescription.Size = new System.Drawing.Size(84, 12);
            this._labelMealDescription.TabIndex = 4;
            this._labelMealDescription.Text = "Meal Description";
            // 
            // _labelMealImage
            // 
            this._labelMealImage.AutoSize = true;
            this._labelMealImage.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._labelMealImage.Location = new System.Drawing.Point(6, 127);
            this._labelMealImage.Name = "_labelMealImage";
            this._labelMealImage.Size = new System.Drawing.Size(138, 12);
            this._labelMealImage.TabIndex = 3;
            this._labelMealImage.Text = "Meal Image Relative Path(*)";
            // 
            // _labelMealPrice
            // 
            this._labelMealPrice.AutoSize = true;
            this._labelMealPrice.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._labelMealPrice.Location = new System.Drawing.Point(6, 79);
            this._labelMealPrice.Name = "_labelMealPrice";
            this._labelMealPrice.Size = new System.Drawing.Size(68, 12);
            this._labelMealPrice.TabIndex = 2;
            this._labelMealPrice.Text = "Meal Price(*)";
            // 
            // _labelMealName
            // 
            this._labelMealName.AutoSize = true;
            this._labelMealName.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._labelMealName.Location = new System.Drawing.Point(6, 33);
            this._labelMealName.Name = "_labelMealName";
            this._labelMealName.Size = new System.Drawing.Size(72, 12);
            this._labelMealName.TabIndex = 1;
            this._labelMealName.Text = "Meal Name(*)";
            // 
            // _textBoxMealName
            // 
            this._textBoxMealName.AccessibleName = "TextBoxMealName";
            this._textBoxMealName.Location = new System.Drawing.Point(84, 30);
            this._textBoxMealName.Name = "_textBoxMealName";
            this._textBoxMealName.Size = new System.Drawing.Size(354, 22);
            this._textBoxMealName.TabIndex = 0;
            this._textBoxMealName.TextChanged += new System.EventHandler(this.ChangeTextBoxMealNameText);
            // 
            // _tabPageCategoryManager
            // 
            this._tabPageCategoryManager.AccessibleName = "";
            this._tabPageCategoryManager.Controls.Add(this._listBoxCategory);
            this._tabPageCategoryManager.Controls.Add(this._buttonDeleteCategory);
            this._tabPageCategoryManager.Controls.Add(this._buttonAddCategory);
            this._tabPageCategoryManager.Controls.Add(this._groupBoxEditCategory);
            this._tabPageCategoryManager.Location = new System.Drawing.Point(4, 22);
            this._tabPageCategoryManager.Name = "_tabPageCategoryManager";
            this._tabPageCategoryManager.Padding = new System.Windows.Forms.Padding(3);
            this._tabPageCategoryManager.Size = new System.Drawing.Size(768, 400);
            this._tabPageCategoryManager.TabIndex = 1;
            this._tabPageCategoryManager.Text = "Category Manager";
            this._tabPageCategoryManager.UseVisualStyleBackColor = true;
            // 
            // _listBoxCategory
            // 
            this._listBoxCategory.AccessibleName = "ListBoxCategory";
            this._listBoxCategory.FormattingEnabled = true;
            this._listBoxCategory.ItemHeight = 12;
            this._listBoxCategory.Location = new System.Drawing.Point(6, 7);
            this._listBoxCategory.Name = "_listBoxCategory";
            this._listBoxCategory.Size = new System.Drawing.Size(305, 352);
            this._listBoxCategory.TabIndex = 7;
            this._listBoxCategory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxCategoryMouseClick);
            // 
            // _buttonDeleteCategory
            // 
            this._buttonDeleteCategory.AccessibleName = "ButtonDeleteCategory";
            this._buttonDeleteCategory.Location = new System.Drawing.Point(173, 371);
            this._buttonDeleteCategory.Name = "_buttonDeleteCategory";
            this._buttonDeleteCategory.Size = new System.Drawing.Size(138, 23);
            this._buttonDeleteCategory.TabIndex = 6;
            this._buttonDeleteCategory.Text = "Delete Selected Category";
            this._buttonDeleteCategory.UseVisualStyleBackColor = true;
            this._buttonDeleteCategory.Click += new System.EventHandler(this.ButtonDeleteCategoryClick);
            // 
            // _buttonAddCategory
            // 
            this._buttonAddCategory.AccessibleName = "ButtonAddCategory";
            this._buttonAddCategory.Location = new System.Drawing.Point(6, 371);
            this._buttonAddCategory.Name = "_buttonAddCategory";
            this._buttonAddCategory.Size = new System.Drawing.Size(117, 23);
            this._buttonAddCategory.TabIndex = 5;
            this._buttonAddCategory.Text = "Add Category";
            this._buttonAddCategory.UseVisualStyleBackColor = true;
            this._buttonAddCategory.Click += new System.EventHandler(this.ButtonAddCategoryClick);
            // 
            // _groupBoxEditCategory
            // 
            this._groupBoxEditCategory.Controls.Add(this._listBoxMealsUsingCategory);
            this._groupBoxEditCategory.Controls.Add(this._buttonSaveCategory);
            this._groupBoxEditCategory.Controls.Add(this._labelUsingThisCategory);
            this._groupBoxEditCategory.Controls.Add(this._labelCategoryName);
            this._groupBoxEditCategory.Controls.Add(this._textBoxCategoryName);
            this._groupBoxEditCategory.Location = new System.Drawing.Point(321, 7);
            this._groupBoxEditCategory.Name = "_groupBoxEditCategory";
            this._groupBoxEditCategory.Size = new System.Drawing.Size(444, 390);
            this._groupBoxEditCategory.TabIndex = 4;
            this._groupBoxEditCategory.TabStop = false;
            this._groupBoxEditCategory.Text = "Edit Category";
            // 
            // _listBoxMealsUsingCategory
            // 
            this._listBoxMealsUsingCategory.FormattingEnabled = true;
            this._listBoxMealsUsingCategory.ItemHeight = 12;
            this._listBoxMealsUsingCategory.Location = new System.Drawing.Point(8, 89);
            this._listBoxMealsUsingCategory.Name = "_listBoxMealsUsingCategory";
            this._listBoxMealsUsingCategory.Size = new System.Drawing.Size(430, 268);
            this._listBoxMealsUsingCategory.TabIndex = 8;
            // 
            // _buttonSaveCategory
            // 
            this._buttonSaveCategory.AccessibleName = "ButtonSaveCategory";
            this._buttonSaveCategory.Location = new System.Drawing.Point(355, 364);
            this._buttonSaveCategory.Name = "_buttonSaveCategory";
            this._buttonSaveCategory.Size = new System.Drawing.Size(83, 23);
            this._buttonSaveCategory.TabIndex = 11;
            this._buttonSaveCategory.Text = "Save";
            this._buttonSaveCategory.UseVisualStyleBackColor = true;
            this._buttonSaveCategory.Click += new System.EventHandler(this.ButtonSaveCategoryClick);
            // 
            // _labelUsingThisCategory
            // 
            this._labelUsingThisCategory.AutoSize = true;
            this._labelUsingThisCategory.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._labelUsingThisCategory.Location = new System.Drawing.Point(6, 74);
            this._labelUsingThisCategory.Name = "_labelUsingThisCategory";
            this._labelUsingThisCategory.Size = new System.Drawing.Size(135, 12);
            this._labelUsingThisCategory.TabIndex = 4;
            this._labelUsingThisCategory.Text = "Meal(s) Using this Category";
            // 
            // _labelCategoryName
            // 
            this._labelCategoryName.AutoSize = true;
            this._labelCategoryName.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._labelCategoryName.Location = new System.Drawing.Point(6, 33);
            this._labelCategoryName.Name = "_labelCategoryName";
            this._labelCategoryName.Size = new System.Drawing.Size(92, 12);
            this._labelCategoryName.TabIndex = 1;
            this._labelCategoryName.Text = "Category Name(*)";
            // 
            // _textBoxCategoryName
            // 
            this._textBoxCategoryName.AccessibleName = "TextBoxCategoryName";
            this._textBoxCategoryName.Location = new System.Drawing.Point(104, 30);
            this._textBoxCategoryName.Name = "_textBoxCategoryName";
            this._textBoxCategoryName.Size = new System.Drawing.Size(334, 22);
            this._textBoxCategoryName.TabIndex = 0;
            this._textBoxCategoryName.TextChanged += new System.EventHandler(this.ChangeTextBoxCategoryNameText);
            // 
            // PosRestaurantSideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._tabControlManager);
            this.Name = "PosRestaurantSideForm";
            this.Text = "POS-Restaurant Side";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClosePosRestaurantSideForm);
            this._tabControlManager.ResumeLayout(false);
            this._tabPageMealManager.ResumeLayout(false);
            this._groupBoxEditMeal.ResumeLayout(false);
            this._groupBoxEditMeal.PerformLayout();
            this._tabPageCategoryManager.ResumeLayout(false);
            this._groupBoxEditCategory.ResumeLayout(false);
            this._groupBoxEditCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _tabControlManager;
        private System.Windows.Forms.TabPage _tabPageMealManager;
        private System.Windows.Forms.TabPage _tabPageCategoryManager;
        private System.Windows.Forms.Button _buttonDeleteMeal;
        private System.Windows.Forms.Button _buttonAddNewMeal;
        private System.Windows.Forms.ListBox _listBoxMeals;
        private System.Windows.Forms.GroupBox _groupBoxEditMeal;
        private System.Windows.Forms.Label _labelMealDescription;
        private System.Windows.Forms.Label _labelMealImage;
        private System.Windows.Forms.Label _labelMealPrice;
        private System.Windows.Forms.Label _labelMealName;
        private System.Windows.Forms.TextBox _textBoxMealName;
        private System.Windows.Forms.TextBox _textBoxMealDescription;
        private System.Windows.Forms.ComboBox _comboBoxCategory;
        private System.Windows.Forms.TextBox _textBoxPath;
        private System.Windows.Forms.Label _labelMealCategory;
        private System.Windows.Forms.TextBox _textBoxMealPrice;
        private System.Windows.Forms.OpenFileDialog _openFileDialog;
        private System.Windows.Forms.Button _buttonBrowse;
        private System.Windows.Forms.Button _buttonSaveMeal;
        private System.Windows.Forms.GroupBox _groupBoxEditCategory;
        private System.Windows.Forms.Button _buttonSaveCategory;
        private System.Windows.Forms.Label _labelUsingThisCategory;
        private System.Windows.Forms.Label _labelCategoryName;
        private System.Windows.Forms.TextBox _textBoxCategoryName;
        private System.Windows.Forms.Button _buttonDeleteCategory;
        private System.Windows.Forms.Button _buttonAddCategory;
        private System.Windows.Forms.ListBox _listBoxCategory;
        private System.Windows.Forms.ListBox _listBoxMealsUsingCategory;
    }
}