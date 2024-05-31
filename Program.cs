using DoctorApplication.DataAccessLayer;

namespace DoctorApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                Models.Doctor Doc = new Models.Doctor();

                //Doc.DocName = "Dr.Ravi";
                //context.doctors.Add( Doc );
                //context.SaveChanges();

                //context.doctors.ToList().ForEach(doc =>
                //{
                //    Console.WriteLine("Name of Doctor is " + doc.DocName + " Id:" + doc.DocId);
                //});

                //var restore = context.doctors.Single(d => d.DocId == 1);
                //restore.DocName = "Dr.Preetam";
                //context.SaveChanges();

                var restore = context.doctors.Single(d => d.DocId == 1);
                context.doctors.Remove(restore);
                context.SaveChanges();



            }
        }


    }


    
}
