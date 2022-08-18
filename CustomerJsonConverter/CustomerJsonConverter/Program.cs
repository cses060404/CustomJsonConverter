using System;
using System.Text.Json;

namespace CustomerJsonConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Populate data

            PersonalDetails studentDetail = new PersonalDetails("Mark", "312-51-2512");

            PersonalDetails teachersamDetail = new PersonalDetails("Sam", "312-51-1111");

            Student studentA = new Student();

            Teacher teacherB = new Teacher();

            studentA.score = 100;
            studentA.detail = studentDetail;

            teacherB.subject = "English";
            teacherB.detail = teachersamDetail;

            #endregion Populate data

            #region Serialize Student and Teach objects

            var ssnSerializeOptions = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var studentJson = JsonSerializer.Serialize(studentA, ssnSerializeOptions);
            var teacherJson = JsonSerializer.Serialize(teacherB, ssnSerializeOptions);

            Console.WriteLine(studentJson);
            Console.WriteLine(teacherJson);

            #endregion serialize Student and Teach objects
        }
    }
}
