using LearnLink.Model;

//using (UchebContext db=new UchebContext())
//{
//    University u1 = new University { UnivName = "МГУ", Rating = 606, City = "Москва" };
//    University u2 = new University { UnivName = "BГУ", Rating = 296, City = "Москва" };
//    db.Universities.AddRange(u1, u2);
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
//        BirthDay = new DateTime(1982,12,3).ToShortDateString(),
//        UnivId=2
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
//    db.Students.AddRange(st1, st2);
//    await db.SaveChangesAsync();
//}

