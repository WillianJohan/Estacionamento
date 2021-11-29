using Estacionamento_WPF.Model;
using System.Collections.Generic;
using System.Linq;

namespace Estacionamento_WPF.Database
{
    public static class ParkingOperations
    {
        public static bool Insert(ParkingRecord pr)
        {
            //Verifica se os valores obrigatórios são válidos
            if (!pr.CanSaveInDatabase())
                return false;

            return SQLiteBaseOperations.Insert<ParkingRecord>(pr);
        }

        public static bool Insert(ParkingRecord pr, out string message)
        {
            message = "No Message";

            //Verifica se os valores obrigatórios são válidos
            if (!pr.CanSaveInDatabase())
            {
                message = "Item possui valores inválidos ou nulos.";
                return false;
            }

            bool result = SQLiteBaseOperations.Insert<ParkingRecord>(pr);
            message = (result) ?
                "Registro cadastrado com sucesso!" :
                "Houve um problema ao registrar. Consulte o administrador do sistema.";

            return result;
        }

        //Verificar
        public static bool Update(ParkingRecord pr, ParkingRecord updatedPr)
        {
            //Verifica se os valores obrigatórios são válidos
            if (!pr.CanSaveInDatabase())
                return false;

            //Pega o usuário do banco
            ParkingRecord dbPR = GetByID(pr.ID);

            //Altera as informações
            int originalPR_ID = dbPR.ID;
            dbPR = updatedPr;
            dbPR.ID = originalPR_ID;

            return SQLiteBaseOperations.Update<ParkingRecord>(dbPR);
        }
        
        public static bool Remove(int ID)
        {
            ParkingRecord pr = GetByID(ID);
            if (pr == null)
                return false;

            return SQLiteBaseOperations.Remove<ParkingRecord>(pr);
        }

        public static List<ParkingRecord> Read()
            => SQLiteBaseOperations.Read<ParkingRecord>();

        public static ParkingRecord GetByID(int ID)
        {
            List<ParkingRecord> prList = SQLiteBaseOperations.Read<ParkingRecord>();
            var result = from pr in prList where pr.ID == ID select pr;
            return result.SingleOrDefault();
        }

    }
}
