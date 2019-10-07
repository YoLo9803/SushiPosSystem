namespace PosSystem
{
    partial class StartUpForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this._buttonStartCustomerProgram = new System.Windows.Forms.Button();
            this._buttonStartRestaurantProgram = new System.Windows.Forms.Button();
            this._buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _buttonStartCustomerProgram
            // 
            this._buttonStartCustomerProgram.AccessibleName = "ButtonStartCustomerProgram";
            this._buttonStartCustomerProgram.Dock = System.Windows.Forms.DockStyle.Top;
            this._buttonStartCustomerProgram.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._buttonStartCustomerProgram.Location = new System.Drawing.Point(0, 0);
            this._buttonStartCustomerProgram.Name = "_buttonStartCustomerProgram";
            this._buttonStartCustomerProgram.Size = new System.Drawing.Size(578, 83);
            this._buttonStartCustomerProgram.TabIndex = 0;
            this._buttonStartCustomerProgram.Text = "Start the Customer Program (Frontend)";
            this._buttonStartCustomerProgram.UseVisualStyleBackColor = true;
            this._buttonStartCustomerProgram.Click += new System.EventHandler(this.ButtonStartCustomerProgramClick);
            // 
            // _buttonStartRestaurantProgram
            // 
            this._buttonStartRestaurantProgram.AccessibleName = "ButtonStartRestaurantProgram";
            this._buttonStartRestaurantProgram.Dock = System.Windows.Forms.DockStyle.Top;
            this._buttonStartRestaurantProgram.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._buttonStartRestaurantProgram.Location = new System.Drawing.Point(0, 83);
            this._buttonStartRestaurantProgram.Name = "_buttonStartRestaurantProgram";
            this._buttonStartRestaurantProgram.Size = new System.Drawing.Size(578, 83);
            this._buttonStartRestaurantProgram.TabIndex = 1;
            this._buttonStartRestaurantProgram.Text = "Start the Restaurant Program (Backend)";
            this._buttonStartRestaurantProgram.UseVisualStyleBackColor = true;
            this._buttonStartRestaurantProgram.Click += new System.EventHandler(this.ButtonStartRestaurantProgramClick);
            // 
            // _buttonExit
            // 
            this._buttonExit.AccessibleName = "ButtonExit";
            this._buttonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this._buttonExit.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._buttonExit.Location = new System.Drawing.Point(432, 166);
            this._buttonExit.Name = "_buttonExit";
            this._buttonExit.Size = new System.Drawing.Size(146, 79);
            this._buttonExit.TabIndex = 2;
            this._buttonExit.Text = "Exit";
            this._buttonExit.UseVisualStyleBackColor = true;
            this._buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // StartUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 245);
            this.Controls.Add(this._buttonExit);
            this.Controls.Add(this._buttonStartRestaurantProgram);
            this.Controls.Add(this._buttonStartCustomerProgram);
            this.Name = "StartUpForm";
            this.Text = "StartUp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _buttonStartCustomerProgram;
        private System.Windows.Forms.Button _buttonStartRestaurantProgram;
        private System.Windows.Forms.Button _buttonExit;
    }
}

