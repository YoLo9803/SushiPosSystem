using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PosSystem
{
    public class Model
    {
        BindingList<Meal> _meals = new BindingList<Meal>();
        BindingList<Category> _mealList = new BindingList<Category>();
        Order _presentOrder;
        Meal _selectMeal;
        int _tabPage = 1;
        public Model()
        {
            CreateMealList();
            CreateMealList2();
            CreateMealList3();
            this._presentOrder = new Order();
        }

        //創立餐點
        private void CreateMealList2()
        {
            const string MEAL2 = "甜點";
            const string MEAL2PATH1 = "/Resources/Assets/Dessert/1.jpg";
            const string MEAL2PATH2 = "/Resources/Assets/Dessert/2.jpg";
            const string MEAL2PATH3 = "/Resources/Assets/Dessert/3.jpg";
            const string MEAL2PATH4 = "/Resources/Assets/Dessert/4.jpg";
            const string MEAL2PATH5 = "/Resources/Assets/Dessert/5.jpg";
            const string MEAL2PATH6 = "/Resources/Assets/Dessert/6.jpg";
            const int ONE = 2;
            const int LOWER2 = 15;
            const int UPPER2 = 20;
            _meals.Add(new Meal(MEAL21, MEAL2PRICE1, MEAL21 + YUMMY, MEAL2, ONE, MEAL2PATH1));
            _meals.Add(new Meal(MEAL22, MEAL2PRICE1, MEAL22 + YUMMY, MEAL2, ONE, MEAL2PATH2));
            _meals.Add(new Meal(MEAL23, MEAL2PRICE2, MEAL23 + YUMMY, MEAL2, ONE, MEAL2PATH3));
            _meals.Add(new Meal(MEAL24, MEAL2PRICE2, MEAL24 + YUMMY, MEAL2, ONE, MEAL2PATH4));
            _meals.Add(new Meal(MEAL25, MEAL2PRICE2, MEAL25 + YUMMY, MEAL2, ONE, MEAL2PATH5));
            _meals.Add(new Meal(MEAL26, MEAL2PRICE2, MEAL26 + YUMMY, MEAL2, ONE, MEAL2PATH6));
            _mealList.Add(new Category(_meals, MEAL2, LOWER2, UPPER2));
        }

        //初始化餐點
        private void CreateMealList3()
        {
            const string MEAL3 = "飲料";
            const string MEAL3PATH1 = "/Resources/Assets/Drinks/1.jpg";
            const string MEAL3PATH2 = "/Resources/Assets/Drinks/2.jpg";
            const string MEAL3PATH3 = "/Resources/Assets/Drinks/3.jpg";
            const int TWO = 2;
            const int LOWER3 = 21;
            const int UPPER3 = 26;
            _meals.Add(new Meal(MEAL31, PRICE2, MEAL31 + YUMMY, MEAL3, TWO, MEAL3PATH1));
            _meals.Add(new Meal(MEAL32, PRICE2, MEAL32 + YUMMY, MEAL3, TWO, MEAL3PATH2));
            _meals.Add(new Meal(MEAL33, PRICE2, MEAL33 + YUMMY, MEAL3, TWO, MEAL3PATH3));
            _meals.Add(new Meal(MEAL34, PRICE1, MEAL34 + YUMMY, MEAL3, TWO, MEAL3PATH3));
            _meals.Add(new Meal(MEAL35, PRICE1, MEAL35 + YUMMY, MEAL3, TWO, MEAL3PATH1));
            _meals.Add(new Meal(MEAL36, PRICE1, MEAL36 + YUMMY, MEAL3, TWO, MEAL3PATH2));
            _mealList.Add(new Category(_meals, MEAL3, LOWER3, UPPER3));
        }

        //創立餐點內容
        private void CreateMealList()
        {
            _meals.Add(new Meal(MEAL11, PRICE1, MEAL11 + YUMMY, MEAL1, ZERO, MEAL1PATH1));
            _meals.Add(new Meal(MEAL12, PRICE1, MEAL12 + YUMMY, MEAL1,0, MEAL1PATH2));
            _meals.Add(new Meal(MEAL13, PRICE1, MEAL13 + YUMMY, MEAL1,ZERO, MEAL1PATH3));
            _meals.Add(new Meal(MEAL14, PRICE1, MEAL14 + YUMMY, MEAL1,ZERO, MEAL1PATH4));
            _meals.Add(new Meal(MEAL15, PRICE1, MEAL15 + YUMMY, MEAL1,ZERO, MEAL1PATH5));
            _meals.Add(new Meal(MEAL16, PRICE2, MEAL16 + YUMMY, MEAL1,ZERO, MEAL1PATH6));
            _meals.Add(new Meal(MEAL17, PRICE1, MEAL17 + YUMMY, MEAL1,ZERO, MEAL1PATH7));
            _meals.Add(new Meal(MEAL18, PRICE2, MEAL18 + YUMMY, MEAL1,ZERO, MEAL1PATH8));
            _meals.Add(new Meal(MEAL19, PRICE1, MEAL19 + YUMMY, MEAL1,ZERO, MEAL1PATH9));
            _meals.Add(new Meal(MEAL110, PRICE1, MEAL110 + YUMMY, MEAL1,ZERO, MEAL1PATH10));
            _meals.Add(new Meal(MEAL111, PRICE1, MEAL111 + YUMMY, MEAL1,ZERO, MEAL1PATH11));
            _meals.Add(new Meal(MEAL112, PRICE2, MEAL112 + YUMMY, MEAL1,ZERO, MEAL1PATH12));
            _meals.Add(new Meal(MEAL113, PRICE2, MEAL113 + YUMMY, MEAL1,ZERO, MEAL1PATH13));
            _meals.Add(new Meal(MEAL114, PRICE2, MEAL114 + YUMMY, MEAL1,ZERO, MEAL1PATH14));
            _meals.Add(new Meal(MEAL115, PRICE2, MEAL115 + YUMMY, MEAL1,ZERO, MEAL1PATH15));
            _mealList.Add(new Category(_meals, MEAL1, LOWER1, UPPER1));
        }

        public Order PresentOrder
        {
            get
            {
                return this._presentOrder;
            }
        }

        public Meal SelectMeal
        {
            get
            {
                return this._selectMeal;
            }
            set
            {
                this._selectMeal = value;

            }
        }

        public int TabPage
        {
            get
            {
                return this._tabPage;
            }
            set
            {
                this._tabPage = value;
            }
        }
        public BindingList<Meal> TotalMeals
        {
            get
            {
                return this._meals;
            }
        }

        public BindingList<Category> MealCategoryList
        {
            get
            {
                return this._mealList;
            }
        }

        public Category Meals
        {
            get
            {
                if (!_mealList.Any())
                    return null;
                else
                    return _mealList[this.TabPage - 1];
            }
        }

        //刪除餐點移動list標記點
        public void DeleteMeal(int selectedIndex)
        {
            for (int count = 0; count < this._mealList.Count; count++)
            {
                const int ONE = -1;
                if (this._mealList[count].UpperLimit >= selectedIndex)
                    this._mealList[count].SetUpperLimit(ONE);
                if (this._mealList[count].LowerLimit > selectedIndex)
                    this._mealList[count].SetLowerLimit(ONE);
            }
        }

        //新增餐點移動list標記點
        public void AddMeal(int categoryIndex)
        {
            this._mealList[categoryIndex].SetUpperLimit(1);
            if (categoryIndex < this._mealList.Count - 1)
            {
                for (int count = categoryIndex + 1; count < this._mealList.Count; count++)
                {
                    this._mealList[count].SetLowerLimit(1);
                    this._mealList[count].SetUpperLimit(1);

                }
            }
        }

        //增加餐點種類
        public void AddCategory(string category)
        {
            int upperLimit = this._mealList.Last().UpperLimit;
            this._mealList.Add(new Category(this._meals,category, upperLimit + 1, upperLimit));
        }

        //刪除Order已加的餐點
        public void DeleteOrder(int selectIndex)
        {
            Meal selectMeal = this.TotalMeals[selectIndex];
            BindingList<OrderCell> orderList = this._presentOrder.OrderList;
            for (int count = 0; count < orderList.Count; count++)
            {
                if (selectMeal == orderList[count].Meal)
                {
                    orderList.RemoveAt(count);
                    count -= 1;
                }
            }
        }

        //刪除餐點種類
        public void DeleteCategory(int selectIndex)
        {
            Category selectMealList = this._mealList[selectIndex];
            int lowerLimit = selectMealList.LowerLimit;
            int upperLimit = selectMealList.UpperLimit;
            for (int count = lowerLimit; count <= upperLimit; count++)
            {
                this.DeleteOrder(lowerLimit);
                this.TotalMeals.RemoveAt(lowerLimit);
                this.DeleteMeal(lowerLimit);
            }
            
            this.MealCategoryList.RemoveAt(selectIndex);
        }

        const string MEAL1 = "壽司";
        const string MEAL1PATH1 = "/Resources/Assets/Sushi/1.jpg";
        const string MEAL1PATH2 = "/Resources/Assets/Sushi/2.jpg";
        const string MEAL1PATH3 = "/Resources/Assets/Sushi/3.jpg";
        const string MEAL1PATH4 = "/Resources/Assets/Sushi/4.jpg";
        const string MEAL1PATH5 = "/Resources/Assets/Sushi/5.jpg";
        const string MEAL1PATH6 = "/Resources/Assets/Sushi/6.jpg";
        const string MEAL1PATH7 = "/Resources/Assets/Sushi/7.jpg";
        const string MEAL1PATH8 = "/Resources/Assets/Sushi/8.jpg";
        const string MEAL1PATH9 = "/Resources/Assets/Sushi/9.jpg";
        const string MEAL1PATH10 = "/Resources/Assets/Sushi/10.jpg";
        const string MEAL1PATH11 = "/Resources/Assets/Sushi/11.jpg";
        const string MEAL1PATH12 = "/Resources/Assets/Sushi/12.jpg";
        const string MEAL1PATH13 = "/Resources/Assets/Sushi/13.jpg";
        const string MEAL1PATH14 = "/Resources/Assets/Sushi/14.jpg";
        const string MEAL1PATH15 = "/Resources/Assets/Sushi/15.jpg";
        const int ZERO = 0;
        const int LOWER1 = 0;
        const int UPPER1 = 14;
        public const string MEAL11 = "熟成鰈魚";
        public const string MEAL12 = "黑胡椒醃漬長鰭鮪魚";
        public const string MEAL13 = "烤鯖魚押壽司";
        public const string MEAL14 = "稻荷天婦羅壽司";
        public const string MEAL15 = "長鰭鮪魚";
        public const string MEAL16 = "炙烤鮪魚腹鱒魚卵";
        public const string MEAL17 = "柚子胡椒醃漬長鰭鮪魚";
        public const string MEAL18 = "特選長鰭鮪魚";
        public const string MEAL19 = "燒炙鮭魚肚";
        public const string MEAL110 = "秋刀魚";
        public const string MEAL111 = "柚子胡椒醃漬生鮮蝦";
        public const string MEAL112 = "松葉蟹(一貫)";
        public const string MEAL113 = "北海道大帆立貝";
        public const string MEAL114 = "炸蝦天婦羅";
        public const string MEAL115 = "星鰻";
        public const string MEAL21 = "鯛魚燒霜淇淋";
        public const string MEAL22 = "巧克力法式金磚";
        public const string MEAL23 = "豆乳甜甜圈";
        public const string MEAL24 = "喀滋蜜核桃焦糖聖代";
        public const string MEAL25 = "抹茶牛奶霜淇淋";
        public const string MEAL26 = "靜岡抹茶霜淇淋";

        public const string MEAL31 = "100%純柳橙汁";
        public const string MEAL32 = "100%純蘋果汁";
        public const string MEAL33 = "啤酒(瓶)";
        public const string MEAL34 = "大罐不知道甚麼飲料";
        public const string MEAL35 = "黃色冰塊水";
        public const string MEAL36 = "淡黃色冰塊水";
        public const string YUMMY = "，超好吃！";
        public const int PRICE1 = 40;
        public const int PRICE2 = 80;
        public const int MEAL2PRICE1 = 90;
        public const int MEAL2PRICE2 = 60;
    }
}
