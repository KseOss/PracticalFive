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
    public void SetParams(string name, int age, string gender,double weight) // ����� ��� ��������� ���� ����������
    {
        Name = name; //������������� ���
        Age = age; //������������� �������
        Gender = gender; //������������� ���
        Weight = weight; // ������������� �������
    }
        public void SetParams(string name, int age) //������������� ����� ��� ��������� ������ ����� � ��������
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"���: {Name}, �������: {Age}, ���: {Gender}, ���: {Weight}";
        }
    }
    

}
