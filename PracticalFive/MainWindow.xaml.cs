using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LIB_5_3;

namespace PracticalFive
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Man person; //Создает поле person типа Man для хранения информации о человеке
        public MainWindow()
        {
            InitializeComponent();
            person = new Man(); 
        }
        private void Exit_Click(object sender, RoutedEventArgs e) //Создание кнопки для меню "Справка" - выход
        {
            Application.Current.Shutdown();
        }

        // Обработчик кнопки "О программе"
        private void About_Click(object sender, RoutedEventArgs e) //Создание кнопки для меню "Справка" - о программе
        {
            MessageBox.Show("Разработчик: Сухомяткина Ксения\nНомер работы: 5\nЗадание: Создать класс Man (человек), с полями: имя, возраст, пол и вес. Создать необходимые методы и свойства.Создать перегруженные методы SetParams, дляустановки параметров человека", "О программе");
        }
        private void SetParams_Click(object sender, RoutedEventArgs e)
        {
            person.SetParams(NameTB.Text, int.Parse(AgeTB.Text), GenderTB.Text, double.Parse(WeightTB.Text));//Передает введеные методы в SetParams
            OutputTB.Text = person.ToString();//Обновляет текст в текстовом блоке, выводя информацию о человеке
        }
    }
}