using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public delegate long delegateNumber(long number);
    public delegate string delegateText(string text);
    internal class StudentInfoClass
    {
        public static string firstName, lastName, middleName, adress, program;
        public static long age, contactNo, studentNo;
        public static string GetfirstName(string firstName)
        {
            return firstName;
        }
        public static string GetlastName(string lastName)
        {
            return lastName;
        }
        public static string GetmiddleName(String middleName)
        {
            return middleName;
        }
        public static string GetAdress(String adress)
        {
            return adress;
        }
        public static string GetProgram(String program)
        {
            return program;
        }
        public static long GetAge(long age)
        {
            return age;
        }
        public static long GetContactNo(long contactNo)
        {
            return contactNo;
        }
        public static long GetStudentNo(long studentNo)
        {
            return studentNo;
        }
    }
    
}
