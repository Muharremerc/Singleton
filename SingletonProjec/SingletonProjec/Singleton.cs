using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingletonProjec.Model;
namespace SingletonProjec
{
    public class Singleton
    {
        private Singleton()
        {

        }

        public static Singleton SingeltonObject;

        public static Singleton getSingeltonEntitiy()
        {
            if (SingeltonObject == null)
                SingeltonObject = new Singleton();
            return SingeltonObject;

        }

        public List<Student> getAllStudent()
        {
            try
            {

                using (var db = Model.SchoolEntities.DbEntity())
                {
                    var stList = db.Students.ToList();
                    return stList;
                }

            }
            catch (Exception)
            {

                throw;
            }


        }




    }
}
