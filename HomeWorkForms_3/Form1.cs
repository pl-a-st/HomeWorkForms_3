using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkForms_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string [] countcountries ={ "Россия", "США", "Канада", "Великобритания", "Франция" };
           

            countriesCB.Items.AddRange(countcountries);

        }

        private void countriesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            regionsCB.Items.Clear();
            regionsCB.Text = "Выберите регион";
            citiesCB.Items.Clear();
            citiesCB.Text = "Выберите город";
            Dictionary<string, List<string>> regions = new Dictionary<string, List<string>>()
            {
                { "Россия", new List<string>{ "Лелинградская область", "Московская область", "Ярославская область", "Забайкальский край", "Челябинская область" }  },
                { "США", new List<string>{ "Вирджиния", "Делавэр", "Джорджия", "Западная Вирджиния", "Мэриленд" }  },
                { "Канада", new List<string>{ "Альберта", "Квебек", "Манитоба", "Новая Шотландия", "Нунавут" }  },
                { "Великобритания", new List<string>{ "Англия", "Шотландия", "Уэльс", "Северная Ирландия", "Гернси" }  },
                { "Франция", new List<string>{ "Аквитания", "Бретань", "Бургундия", "Верхняя Нормандия", "Иль-де-Франс" }  },
            };
            regionsCB.Items.AddRange(regions[countriesCB.Text].ToArray());
        }

        private void regionsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            citiesCB.Items.Clear();
            citiesCB.Text = "Выберите город";
            Dictionary<string, List<string>> cities = new Dictionary<string, List<string>>()
            {
                { "Лелинградская область", new List<string>{ "Бокситогорск", "Волосово", "Волхов", "Всеволожск", "Выборг" }  },
                { "Московская область", new List<string>{ "Балашиха", "Волоколамск", "Воскресенск", "Дмитров", "Домодедово" }  },
                { "Ярославская область", new List<string>{ "Гаврилов Ям", "Данилов", "Любим", "Мышкин", "Новый Некоуз" }  },
                { "Забайкальский край", new List<string>{ "Балей", "Борзя", "Краснокаменск", "Могоча", "Нерчинск" }  },
                { "Челябинская область", new List<string>{ "Аша", "Верхнеуральск", "Касли", "Куса", "Нязепетровск" }  },
                { "Вирджиния", new List<string>{ "Александрия", "Линчберг", "Норфолк", "Ньюпорт-Ньюс", "Портсмут" }  },
                { "Делавэр", new List<string>{ "Нью-Касл", "Уилмингтон", "Довер", "Льюис", "Сванендал" }  },
                { "Джорджия", new List<string>{ "Атланта", "Огаста", "Колумбус", "Саванна", "Атенс" }  },
                { "Западная Вирджиния", new List<string>{ "Чарлстон", "Хантингтон", "Паркерсберг", "Уилинг", "Моргантаун" }  },
                { "Мэриленд", new List<string>{ "Аннаполис", "Балтимор", "Силвер-Спринг" }  },
                { "Альберта", new List<string>{ "Брукс", "Летбридж", "Медисин-Хат", "Бассано", "Боу-Айленд" }  },
                { "Квебек", new List<string>{ "Бленвиль", "Викториавилл", "Гатино", "Гранби", "Драммонвилль" }  },
                { "Манитоба", new List<string>{ "Брандон", "Виннипег", "Гранд-Рапидс", "Дофин", "Маниту" }  },
                { "Новая Шотландия", new List<string>{ "Новая Шотландия" }  },
                { "Нунавут", new List<string>{ "Арвиат", "Арктик-Бей", "Батерст-Инлет", "Бейкер-Лейк", "Грис-Фьорд" }  },
                { "Англия", new List<string>{ "Бокситогорск", "Волосово", "Волхов", "Всеволожск", "Выборг" }  },
                { "Шотландия", new List<string>{ "Брукс", "Летбридж", "Медисин-Хат", "Бассано", "Боу-Айленд" }  },
                { "Уэльс", new List<string>{ "Атланта", "Огаста", "Колумбус", "Саванна", "Атенс" }  },
                { "Северная Ирландия", new List<string>{ "Балей", "Борзя", "Краснокаменск", "Могоча", "Нерчинск" }  },
                { "Гернси", new List<string>{ "Брукс", "Летбридж", "Медисин-Хат", "Бассано", "Боу-Айленд" }  },
                { "Аквитания", new List<string>{ "Бленвиль", "Викториавилл", "Гатино", "Гранби", "Драммонвилль" }  },
                { "Бретань", new List<string>{ "Нью-Касл", "Уилмингтон", "Довер", "Льюис", "Сванендал" }  },
                { "Бургундия", new List<string>{ "Брукс", "Летбридж", "Медисин-Хат", "Бассано", "Боу-Айленд" }  },
                { "Верхняя Нормандия", new List<string>{ "Брандон", "Виннипег", "Гранд-Рапидс", "Дофин", "Маниту" }  },
                { "Иль-де-Франс", new List<string>{ "Балашиха", "Волоколамск", "Воскресенск", "Дмитров", "Домодедово" }  }
            };
            citiesCB.Items.AddRange(cities[regionsCB.Text].ToArray());
        }
    }
}
