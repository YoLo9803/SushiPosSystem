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
    public partial class StartUpForm : Form
    {
        StartUpFormPresentationModel _startUpFormPresentationModel;
        Model _model = new Model();
        const string ENABLED = "Enabled";
        public StartUpForm(StartUpFormPresentationModel model)
        {
            InitializeComponent();
            this._startUpFormPresentationModel = model;
            _buttonStartCustomerProgram.DataBindings.Add(ENABLED, _startUpFormPresentationModel, "IsCustomerSideOpened");
            _buttonStartRestaurantProgram.DataBindings.Add(ENABLED, _startUpFormPresentationModel, "IsRestaurantSideOpened");
        }

        //開啟客戶端
        private void ButtonStartCustomerProgramClick(object sender, EventArgs e)
        {
            this. _startUpFormPresentationModel.AlterCustomerSideOpend();
            Form customerProgram = new PosCustomerSideForm(new PosCustomerSidePresentationModel(_model),_model,
                _startUpFormPresentationModel);
            customerProgram.Show();  
        }

        //開啟營業端
        private void ButtonStartRestaurantProgramClick(object sender, EventArgs e)
        {
            this._startUpFormPresentationModel.AlterRestaurantSideOpend();
            Form restaurantProgram = new PosRestaurantSideForm(new PosRestaurantSidePresentationModel(_model), _model,
                _startUpFormPresentationModel);
            restaurantProgram.Show();
        }

        //關閉程式
        private void ButtonExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
