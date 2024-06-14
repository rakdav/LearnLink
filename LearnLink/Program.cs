using LearnLink.Model;

//using (UchebContext db = new UchebContext())
//{
//    University u1 = new University { UnivName = "МГУ", Rating = 606, City = "Москва" };
//    University u2 = new University { UnivName = "BГУ", Rating = 296, City = "Москва" };
//    University u3 = new University { UnivName = "НГУ", Rating = 345, City = "Новосибирск" };
//    University u4 = new University { UnivName = "РГУ", Rating = 416, City = "Ростов" };
//    University u5 = new University { UnivName = "БГУ", Rating = 345, City = "Белгород" };
//    University u6 = new University { UnivName = "ТГУ", Rating = 368, City = "Томск" };
//    University u7 = new University { UnivName = "ВГМА", Rating = 327, City = "Воронеж" };
//    db.Universities.AddRange(u1, u2,u3,u4,u5,u6,u7);
//    await db.SaveChangesAsync();
//}

//using (UchebContext db = new UchebContext())
//{
//    List<University> universites = db.Universities.ToList();
//    foreach (var item in universites)
//    {
//        Console.WriteLine(item.UnivName+" "+item.Rating+" "+item.City);
//    }
//}

//using (UchebContext db = new UchebContext())
//{
//    Student st1 = new Student
//    {
//        Surname = "Иванов",
//        Name = "Иван",
//        Stipend = 150,
//        Kurs = 1,
//        City = "Орел",
//        BirthDay = new DateTime(1982, 12, 3).ToShortDateString(),
//        UnivId = 2
//    };
//    Student st2 = new Student
//    {
//        Surname = "Петров",
//        Name = "Петр",
//        Stipend = 200,
//        Kurs = 3,
//        City = "Курск",
//        BirthDay = new DateTime(1980, 12, 1).ToShortDateString(),
//        UnivId = 2
//    };
//    Student st3 = new Student
//    {
//        Surname = "Сидоров",
//        Name = "Вадим",
//        Stipend = 150,
//        Kurs = 4,
//        City = "Москва",
//        BirthDay = new DateTime(1979, 6, 7).ToShortDateString(),
//        UnivId = 2
//    };
//    Student st4 = new Student
//    {
//        Surname = "Кузнецов",
//        Name = "Борис",
//        Stipend = 0,
//        Kurs = 2,
//        City = "Брянск",
//        BirthDay = new DateTime(1981, 12, 8).ToShortDateString(),
//        UnivId = 1
//    };
//    Student st5 = new Student
//    {
//        Surname = "Зайцева",
//        Name = "Ольга",
//        Stipend = 250,
//        Kurs = 2,
//        City = "Липецк",
//        BirthDay = new DateTime(1981, 5, 1).ToShortDateString(),
//        UnivId = 1
//    };
//    Student st6 = new Student
//    {
//        Surname = "Павлов",
//        Name = "Андрей",
//        Stipend = 0,
//        Kurs = 3,
//        City = "Воронеж",
//        BirthDay = new DateTime(1979, 11, 5).ToShortDateString(),
//        UnivId = 1
//    };
//    Student st7 = new Student
//    {
//        Surname = "Котов",
//        Name = "Павел",
//        Stipend = 150,
//        Kurs = 5,
//        City = "Белгород",
//        BirthDay = null,
//        UnivId = 5
//    };
//    Student st8 = new Student
//    {
//        Surname = "Лукин",
//        Name = "Артем",
//        Stipend = 200,
//        Kurs = 3,
//        City = "Воронеж",
//        BirthDay = new DateTime(1981, 12, 1).ToShortDateString(),
//        UnivId = 1
//    };
//    Student st9 = new Student
//    {
//        Surname = "Петров",
//        Name = "Антон",
//        Stipend = 200,
//        Kurs = 3,
//        City = "Воронеж",
//        BirthDay = new DateTime(1981, 8, 5).ToShortDateString(),
//        UnivId = 2
//    };
//    Student st10 = new Student
//    {
//        Surname = "Белкин",
//        Name = "Вадим",
//        Stipend = 250,
//        Kurs = 5,
//        City = "Воронеж",
//        BirthDay = new DateTime(1980, 1, 7).ToShortDateString(),
//        UnivId = 1

//    };
//    db.Students.AddRange(st1, st2,st3,st4,st5,st6,st7,st8,st9,st10);
//    await db.SaveChangesAsync();
//}

//using (UchebContext db = new UchebContext())
//{
//    List<Subject> list = db.Subjects.ToList();
//	foreach (var item in list)
//	{
//		Console.WriteLine(item.SubjName+" "+item.Hour+" "+item.Semester);
//	}
//}

//using (UchebContext db = new UchebContext())
//{
//	List<ExamMark> list = db.ExamMarks.Where(p=>p.SubjId==2).ToList();
//	foreach (var item in list)
//	{
//		Console.WriteLine(item.ExamDate + " " + item.Mark + " " + item.StudentId);
//	}
//}

//using (UchebContext db = new UchebContext())
//{
//    var list = db.Students.Select(p => new
//    {
//        Kurs=p.Kurs,
//        Surname=p.Surname,
//        Name=p.Name,
//        Stipent=p.Stipend
//    }).ToList();
//    foreach(var i in list)
//    {
//        Console.WriteLine(i.Kurs+" "+i.Surname+" "+i.Name+" "+i.Stipent);
//    }
//}

//using (UchebContext db = new UchebContext())
//{
//    var list = db.Subjects.Where(p=>p.Semester==4).Select(p => new
//    {
//        SUBJ_NAME=p.SubjName,
//        HOUR=p.Hour
//    });
//    foreach (var i in list)
//    {
//        Console.WriteLine(i.SUBJ_NAME + " " + i.HOUR);
//    }
//}

using (UchebContext db = new UchebContext())
{
    var list = db.ExamMarks.Select(p=>p.Mark).Distinct().ToList();
    foreach (var i in list)
    {
        Console.WriteLine(i.Value);
    }
}