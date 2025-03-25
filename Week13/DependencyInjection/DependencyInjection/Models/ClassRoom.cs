using DependencyInjection.Interfaces;

namespace DependencyInjection.Models
{
    public class ClassRoom
    {
        public IOgretmen Teacher { get; set; }

        public ClassRoom(IOgretmen teacher)
        {
            Teacher = teacher;
        }

        public string GetTeacherInfo()
        {
            return Teacher.GetInfo();
        }
    }
}