namespace _15_6_6_Praktika
{    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            // ???

            List<string> list = new List<string>();

            foreach (var student in classes) {
                foreach (var student2 in student.Students)
                {
                    list.Add(student2);
                }
            }

            string[] result = new string[list.Count];

            for (int i = 0; i < list.Count; i++)
            {
                result[i] = list[i].ToString();
            }            

            return result;
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}
