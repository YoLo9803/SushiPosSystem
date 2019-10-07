using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PosSystem
{
    public class StartUpFormPresentationModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        bool _isCustomerSideOpened = true;
        bool _isRestaurantSideOpened = true;

        //客戶端程式是否開啟
        public bool IsCustomerSideOpened
        {
            get
            {
                return _isCustomerSideOpened;
            }
        }

        //營業端程式是否開啟
        public bool IsRestaurantSideOpened
        {
            get
            {
                return _isRestaurantSideOpened;
            }
        }

        //營業端按鈕開關
        public void AlterRestaurantSideOpend()
        {
            _isRestaurantSideOpened = !_isRestaurantSideOpened;
            const string OPEND = "IsRestaurantSideOpened";
            NotifyPropertyChanged(OPEND);
        }

        //客戶端按鈕開關
        public void AlterCustomerSideOpend()
        {
            _isCustomerSideOpened = !_isCustomerSideOpened;
            const string OPEND = "IsCustomerSideOpened";
            NotifyPropertyChanged(OPEND);
        }

        //Property更變通知
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
