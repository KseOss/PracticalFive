using System;
using System.Windows.Media.Media3D;
namespace LIB_5_3
{
    public class Man
    {
        public string Name {  get; set; }
        public int Age {  get; set; }
        public string Gender { get; set; }
        public double Weight { get; set; }
    public void SetParams(string name, int age, string gender,double weight) // Метод для установки всех параметров
    {
        Name = name; //Устанавливает имя
        Age = age; //Устанавливает возраст
        Gender = gender; //Устанавливает пол
        Weight = weight; // Устанавлвиает возраст
    }
        public void SetParams(string name, int age) //Перегруженный метод для установки только имени и возраста
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"Имя: {Name}, Возраст: {Age}, Пол: {Gender}, Вес: {Weight}";
        }
    }
    

}
