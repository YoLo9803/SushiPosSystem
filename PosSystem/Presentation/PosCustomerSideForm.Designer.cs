namespace PosSystem
{
    partial class PosCustomerSideForm
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
            this._groupBoxMeals = new System.Windows.Forms.GroupBox();
            this._tabControlMeals = new System.Windows.Forms.TabControl();
            this._richTextBox1 = new System.Windows.Forms.RichTextBox();
            this._labelPage = new System.Windows.Forms.Label();
            this._buttonAdd = new System.Windows.Forms.Button();
            this._buttonPreviousPage = new System.Windows.Forms.Button();
            this._buttonNextPage = new System.Windows.Forms.Button();
            this._tableLayoutPanelMeal1 = new System.Windows.Forms.TableLayoutPanel();
            this._labelTotalPrice = new System.Windows.Forms.Label();
            this._recordDataGridView = new System.Windows.Forms.DataGridView();
            this._groupBoxMeals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._recordDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _groupBoxMeals
            // 
            this._groupBoxMeals.Controls.Add(this._tabControlMeals);
            this._groupBoxMeals.Controls.Add(this._richTextBox1);
            this._groupBoxMeals.Controls.Add(this._labelPage);
            this._groupBoxMeals.Controls.Add(this._buttonAdd);
            this._groupBoxMeals.Controls.Add(this._buttonPreviousPage);
            this._groupBoxMeals.Controls.Add(this._buttonNextPage);
            this._groupBoxMeals.Controls.Add(this._tableLayoutPanelMeal1);
            this._groupBoxMeals.Location = new System.Drawing.Point(12, 12);
            this._groupBoxMeals.Name = "_groupBoxMeals";
            this._groupBoxMeals.Size = new System.Drawing.Size(393, 573);
            this._groupBoxMeals.TabIndex = 0;
            this._groupBoxMeals.TabStop = false;
            this._groupBoxMeals.Text = "Meals";
            // 
            // _tabControlMeals
            // 
            this._tabControlMeals.AccessibleDescription = "TabControlMeals";
            this._tabControlMeals.Location = new System.Drawing.Point(10, 21);
            this._tabControlMeals.Name = "_tabControlMeals";
            this._tabControlMeals.SelectedIndex = 0;
            this._tabControlMeals.Size = new System.Drawing.Size(376, 387);
            this._tabControlMeals.TabIndex = 7;
            this._tabControlMeals.SelectedIndexChanged += new System.EventHandler(this.ChangeTabControlMealsSelectedIndex);
            // 
            // _richTextBox1
            // 
            this._richTextBox1.AccessibleName = "RichTextBox1";
            this._richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this._richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._richTextBox1.Location = new System.Drawing.Point(6, 414);
            this._richTextBox1.Name = "_richTextBox1";
            this._richTextBox1.ReadOnly = true;
            this._richTextBox1.Size = new System.Drawing.Size(379, 86);
            this._richTextBox1.TabIndex = 6;
            this._richTextBox1.Text = "";
            // 
            // _labelPage
            // 
            this._labelPage.AccessibleName = "LabelPage";
            this._labelPage.AutoSize = true;
            this._labelPage.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._labelPage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this._labelPage.Location = new System.Drawing.Point(6, 538);
            this._labelPage.Name = "_labelPage";
            this._labelPage.Size = new System.Drawing.Size(71, 20);
            this._labelPage.TabIndex = 3;
            this._labelPage.Text = "Page: 1/";
            // 
            // _buttonAdd
            // 
            this._buttonAdd.AccessibleName = "ButtonAdd";
            this._buttonAdd.Location = new System.Drawing.Point(268, 506);
            this._buttonAdd.Name = "_buttonAdd";
            this._buttonAdd.Size = new System.Drawing.Size(114, 23);
            this._buttonAdd.TabIndex = 2;
            this._buttonAdd.Text = "Add";
            this._buttonAdd.UseVisualStyleBackColor = true;
            this._buttonAdd.Click += new System.EventHandler(this.ButtonAddClick);
            // 
            // _buttonPreviousPage
            // 
            this._buttonPreviousPage.AccessibleName = "ButtonPreviousPage";
            this._buttonPreviousPage.Location = new System.Drawing.Point(148, 535);
            this._buttonPreviousPage.Name = "_buttonPreviousPage";
            this._buttonPreviousPage.Size = new System.Drawing.Size(114, 23);
            this._buttonPreviousPage.TabIndex = 1;
            this._buttonPreviousPage.Text = "Previous Page";
            this._buttonPreviousPage.UseVisualStyleBackColor = true;
            this._buttonPreviousPage.Click += new System.EventHandler(this.ButtonPreviousPageClick);
            // 
            // _buttonNextPage
            // 
            this._buttonNextPage.AccessibleDescription = "";
            this._buttonNextPage.AccessibleName = "ButtonNextPage";
            this._buttonNextPage.ForeColor = System.Drawing.Color.Black;
            this._buttonNextPage.Location = new System.Drawing.Point(268, 535);
            this._buttonNextPage.Name = "_buttonNextPage";
            this._buttonNextPage.Size = new System.Drawing.Size(114, 23);
            this._buttonNextPage.TabIndex = 0;
            this._buttonNextPage.Text = "Next Page";
            this._buttonNextPage.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this._buttonNextPage.UseVisualStyleBackColor = true;
            this._buttonNextPage.Click += new System.EventHandler(this.ButtonNextPageClick);
            // 
            // _tableLayoutPanelMeal1
            // 
            this._tableLayoutPanelMeal1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._tableLayoutPanelMeal1.ColumnCount = 1;
            this._tableLayoutPanelMeal1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanelMeal1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._tableLayoutPanelMeal1.Location = new System.Drawing.Point(3, 210);
            this._tableLayoutPanelMeal1.Name = "_tableLayoutPanelMeal1";
            this._tableLayoutPanelMeal1.RowCount = 1;
            this._tableLayoutPanelMeal1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tableLayoutPanelMeal1.Size = new System.Drawing.Size(387, 360);
            this._tableLayoutPanelMeal1.TabIndex = 0;
            // 
            // _labelTotalPrice
            // 
            this._labelTotalPrice.AccessibleName = "LabelTotalPrice";
            this._labelTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._labelTotalPrice.AutoSize = true;
            this._labelTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._labelTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this._labelTotalPrice.Location = new System.Drawing.Point(662, 538);
            this._labelTotalPrice.Name = "_labelTotalPrice";
            this._labelTotalPrice.Size = new System.Drawing.Size(174, 47);
            this._labelTotalPrice.TabIndex = 3;
            this._labelTotalPrice.Text = "Total:0元";
            this._labelTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _recordDataGridView
            // 
            this._recordDataGridView.AccessibleName = "RecordDataGridView";
            this._recordDataGridView.AllowUserToAddRows = false;
            this._recordDataGridView.AllowUserToDeleteRows = false;
            this._recordDataGridView.AllowUserToResizeColumns = false;
            this._recordDataGridView.AllowUserToResizeRows = false;
            this._recordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._recordDataGridView.Location = new System.Drawing.Point(411, 12);
            this._recordDataGridView.MultiSelect = false;
            this._recordDataGridView.Name = "_recordDataGridView";
            this._recordDataGridView.RowHeadersVisible = false;
            this._recordDataGridView.RowTemplate.Height = 24;
            this._recordDataGridView.Size = new System.Drawing.Size(563, 523);
            this._recordDataGridView.TabIndex = 4;
            this._recordDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecordDataGridViewCellContentClick);
            this._recordDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecordDataGridViewCellValueChanged);
            // 
            // PosCustomerSideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 594);
            this.Controls.Add(this._recordDataGridView);
            this.Controls.Add(this._labelTotalPrice);
            this.Controls.Add(this._groupBoxMeals);
            this.Name = "PosCustomerSideForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "POS-Customer Side";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClosePosCustomerSideForm);
            this._groupBoxMeals.ResumeLayout(false);
            this._groupBoxMeals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._recordDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox _groupBoxMeals;
        private System.Windows.Forms.Label _labelPage;
        private System.Windows.Forms.Button _buttonAdd;
        private System.Windows.Forms.Button _buttonPreviousPage;
        private System.Windows.Forms.Button _buttonNextPage;
        private System.Windows.Forms.RichTextBox _richTextBox1;
        private System.Windows.Forms.Label _labelTotalPrice;
        private System.Windows.Forms.DataGridView _recordDataGridView;
        private System.Windows.Forms.TabControl _tabControlMeals;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanelMeal1;
    }
}