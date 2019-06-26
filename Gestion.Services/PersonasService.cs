using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gestion.Entities;

namespace Gestion.Services {
    public class PersonasService {
        private static PersonasDAL GetDAL() {
            return new PersonasDAL();
        }
        
        public static Persona GetById(int intId) {
            Persona     returnEntity;
            PersonasDAL currentDAL = GetDAL();

            returnEntity = currentDAL.GetById(intId);

            return returnEntity;
        }

        public static List<Persona> GetAll() {
            List<Persona>   returnList = new List<Persona>();
            PersonasDAL     currentDAL = GetDAL();

            returnList = currentDAL.GetAll();

            return returnList;
        }


        public static List<Persona> GetActivos() {
            List<Persona>   returnList = new List<Persona>();
            PersonasDAL     currentDAL = GetDAL();

            returnList = currentDAL.GetByActivo(true);

            return returnList;
        }

        public static List<Persona> GetInActivos() {
            List<Persona>   returnList = new List<Persona>();
            PersonasDAL     currentDAL = GetDAL();

            returnList = currentDAL.GetByActivo(false);

            return returnList;
        }

        public static int Insert(Persona newEntity) {
            PersonasDAL currentDAL = GetDAL();

            //return currentDAL.Insert(newEntity);
            return currentDAL.InsertScalar(newEntity);
        }
    }
}
