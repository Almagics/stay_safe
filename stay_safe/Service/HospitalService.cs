using stay_safe.Data;
using stay_safe.Models;

namespace stay_safe.Service
{
    public class HospitalService
    {

        private readonly ApplicationDbContext _db;


        public HospitalService(ApplicationDbContext db) { 
            
            _db = db;
        
        }


        public int Create(HospitalModel model)
        {

            _db.Hospital.Add(model);

          var reult =   _db.SaveChanges();


            if(reult > 0)
            {

                return  1;


            }else
            {

                return 0;
            }


        }




    }
}
