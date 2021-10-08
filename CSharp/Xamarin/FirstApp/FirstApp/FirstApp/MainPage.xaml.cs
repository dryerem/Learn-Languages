using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstApp
{
    public partial class MainPage : ContentPage
    {
        string[] students = new string[] 
        {
            "Аветисян Ростислав",
            "Борзухин Андрей",
            "Генхель Иван",
            "Дятлова Александра",
            "Евдокимов Сергей",
            "Егоров Кирилл",
            "Еременко Денис",
            "Каданчик Андрей",
            "Корнинский Денис",
            "Маматов Никита",
            "Могучева Софья",
            "Плиев Давид",
            "Реута Максим",
            "Семкив Виталий",
            "Соловьев Виктор",
            "Тебеньков Владислав",
            "Ховрат Тимофей",
            "Черняков Артем",
            "Чикинев Алексей",
            "Шубарина Дарья"
        };

        public MainPage()
        {
            InitializeComponent();

            StudentsList.ItemsSource = students;
        }

        private async void studentSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new StudentPage());
        }
    }
}
