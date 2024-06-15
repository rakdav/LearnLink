using LearnLink.Model;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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

//using (UchebContext db = new UchebContext())
//{
//    var list = db.ExamMarks.Select(p=>p.Mark).Distinct().ToList();
//    foreach (var i in list)
//    {
//        Console.WriteLine(i.Value);
//    }
//}

//using (UchebContext db = new UchebContext())
//{
//    var list = db.Students.Where(u => u.Kurs>=3).Select(p => new { Name = p.Surname }).ToList();
//    foreach (var i in list)
//    {
//        Console.WriteLine(i.Name);
//    }

//    var query = from s in db.Students
//                where s.Kurs >= 3
//                select new
//                {
//                    Name=s.Surname
//                };
//    foreach (var i in query.ToList())
//    {
//        Console.WriteLine(i.Name);
//    }
//}

//using (UchebContext db = new UchebContext())
//{
//    DateTime t1 = DateTime.Parse("10.01.1999");
//    DateTime t2 = DateTime.Parse("20.01.1999");
//    var list = db.ExamMarks.Select(p => new { Name = p.SubjId, Date=p.ExamDate }).ToList();
//    foreach (var i in list.ToList())
//    {
//        if(DateTime.Parse(i.Date)>=t1&&DateTime.Parse(i.Date)<=t2) Console.WriteLine(i.Name);
//    }
//}

//using (UchebContext db = new UchebContext())
//{
//    var list = db.ExamMarks.Where(p => p.StudentId == 5 || p.StudentId == 10).ToList();
//    foreach (var i in list){
//        Console.WriteLine(i.ExamDate+" "+i.Mark+" "+db.Students.FirstOrDefault(u=>u.StudentId==i.StudentId)!.Surname);
//    } 
//}

//using (UchebContext db = new UchebContext())
//{
//    var list = db.Subjects.Where(p => p.SubjName.StartsWith("И")).ToList();
//    foreach (var i in list)
//    {
//        Console.WriteLine(i.SubjName);
//    }
//}

//9.Н а п ишитез а п рос д ляп од сч ета колич еств а студ ентов , сд ав а вших экз амен
//п о п ред мету обуч енияс ид ентифика тором, рав ным20.
//using (UchebContext db = new UchebContext())
//{
//    int count = db.ExamMarks.Count(p=>p.StudentId==5);
//    Console.WriteLine(count);
//}

//а п ишитез а п рос, который п оз в оляет п од сч итатьв та блицеEXAM_MARKS
//колич еств о раз лич ных п ред метов обуч ения

//using (UchebContext db = new UchebContext())
//{
//    int count = db.ExamMarks.Select(p=>p.SubjId).Distinct().Count();
//    Console.WriteLine(count);
//}

//using (UchebContext db = new UchebContext())
//{
//    var students = db.ExamMarks.GroupBy(p => p.StudentId).Select(g => new
//    {
//        Id = g.Key,
//        min=db.ExamMarks.Where(p=>p.StudentId==g.Key).Select(p=>p.Mark).Min()
//    });
//    foreach(var i in students)
//    {
//        Console.WriteLine(i.Id+" "+i.min);
//    }
//}
//Н а п ишитез а п рос, в ып олняющ ий в ыв од фамилии п ерв ого в а лфа в итном
//п оряд ке (п о фамилии) студ ента, фамилия которого нач ина ется на букв у
//“И”.

//using (UchebContext db = new UchebContext())
//{
//    Student student = db.Students.Where(p => p.Name.StartsWith("И")).First();
//    Console.WriteLine(student.Name+" "+student.Surname);
//}

//Н а п ишите з ап рос, который в ып олняет в ыв од д ля кажд ого п ред мета
//обуч ения на именов а ние п ред мета и максима льное з нач ение номера
//семестр а, в которомэ тотп р ед мет п реп од а ется.
//using (UchebContext db = new UchebContext())
//{
//    var list = db.Subjects.GroupBy(p => p.SubjName).Select(g=>new {
//        Name=g.Key,
//        MaxSemestr=db.Subjects.Where(p=>p.SubjName==g.Key).Select(p=>p.Semester).Max()
//    });
//    foreach(var i in list)
//    Console.WriteLine(i.Name + " " + i.MaxSemestr);
//}

//а п ишите з ап рос, который в ып олняет в ыв од д анных д ля кажд ого
//конкретного д ня сд ач и экз амена о колич еств е студ ентов , сд а в а вших
//э кз амен в э тот д ень.
//using (UchebContext db = new UchebContext())
//{
//    var list = db.ExamMarks.GroupBy(p => p.ExamDate).Select(g => new
//    {
//        Name = g.Key,
//        MaxSemestr = db.ExamMarks.Where(p => p.ExamDate == g.Key).Select(p => p.StudentId).Count()
//    });
//    foreach (var i in list)
//        Console.WriteLine(i.Name + " " + i.MaxSemestr);
//}

//Запишите запрос для получения среднего балла для каждого курса по каждому предмету.
//using (UchebContext db = new UchebContext())
//{
//    var avgBalls = db.ExamMarks.Join(db.Students,
//                                   u => u.StudentId,
//                                   p => p.StudentId,
//                                   (u, p) => new 
//                                   {
//                                       Kurs=p.Kurs,
//                                       Predmet=db.Subjects.FirstOrDefault(c=>c.SubjId==u.SubjId)!.SubjName,
//                                       avg = db.ExamMarks.Where(c => c.SubjId == u.SubjId).Select(c => c.Mark).Average()
//}
//                                   ).Distinct();
//    foreach(var i in avgBalls)
//    {
//        Console.WriteLine(i.Kurs+" "+i.Predmet+" "+i.avg);

//    }
//}
//Пред п оложим, ч то стип енд ия в сем студ ентам ув елич ена на 20%.
//Н а п ишите з ап рос к таблице STUDENT, в ып олняющ ий в ыв од номера
//студ ента, фамилию студ ента и в елич ину ув елич енной стип енд ии.
//Выход ные д анные уп оряд оч ить: а) п о з нач ению п ослед него столбца
//(в елич инестип енд ии); б) в а лфав итномп оряд кефамилий студ ентов .

using (UchebContext db = new UchebContext())
{
    var list = db.Students.Select(p => new
    {
        Number = p.StudentId,
        FIO = p.Name + " " + p.Surname,
        Stip = p.Stipend + 0.2 * p.Stipend
    }).OrderBy(p => p.FIO);
    foreach(var i in list)
    {
        Console.WriteLine(i.Number+" "+i.FIO+" "+i.Stip);
    }
}