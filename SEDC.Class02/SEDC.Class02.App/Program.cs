using SEDC.Class02.Exercise.Class;

Students student1 = new Students(1, "Sanja", "sanja", "password", new List<int>() { 2,6,5,4});
Students student2 = new Students(2, "Marija", "marija", "password2", new List<int>() { 3, 5, 6, 6 });

Console.WriteLine("Student 1:");
student1.PrintUser();
student1.PrintGrades();


Console.WriteLine("Student 2:");
student2.PrintUser();
student2.PrintGrades();


Teacher teacher1 = new Teacher(3,"Angel", "angel", "password3", new List<string>(){"Javascript", "C#"});
Teacher teacher2 = new Teacher(4, "Danilo", "danilo", "password4", new List<string>() { "HTML", "CSS" });

Console.WriteLine("Teacher 1:");
teacher1.PrintUser();
teacher1.PrintSubject();

Console.WriteLine("Teacher 2:");
teacher2.PrintUser();
teacher2.PrintSubject();