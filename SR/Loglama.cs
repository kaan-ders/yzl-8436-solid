using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SR
{
    public interface ILoglama
    {
        void LogYaz(string mesaj);
        //void OpenConnection(); YANLIŞŞŞ!!!!
    }

    public class LoglamaTxt : ILoglama
    {
        public void LogYaz(string mesaj)
        {
            File.AppendAllText(Environment.CurrentDirectory + "\\Log.txt", mesaj + Environment.NewLine);
        }

        //public void Deneme()
        //{

        //}
    }

    public class LoglamaDb : ILoglama
    {
        public void LogYaz(string mesaj)
        {
            //dbye log yaz
            throw new NotImplementedException();
        }
    }

    public class LoglamaElastic : ILoglama
    {
        public void LogYaz(string mesaj)
        {
            //elastic search'e log yaz
            throw new NotImplementedException();
        }
    }

    public class LoglamaCiviYazisi : ILoglama
    {
        public void LogYaz(string mesaj)
        {
            //çivi tablete'e log yaz
            throw new NotImplementedException();
        }
    }

    public class Deneme
    {

    }


    //YANLIŞ

    //public enum LogTipi
    //{
    //    Txt,
    //    Db,
    //    Elastic
    //}

    //public class Loglama
    //{
    //    public void LogYaz(string mesaj, LogTipi tip) //tip = 0 txtye yaz, tip 1 ise dbye yaz
    //    {
    //        if(tip == LogTipi.Txt)
    //            File.AppendAllText(Environment.CurrentDirectory + "\\Log.txt", mesaj + Environment.NewLine);
    //        else if(tip == LogTipi.Db)
    //        {
    //            //dbye log yaz
    //        }
    //        else if(tip == LogTipi.Elastic)
    //        {
    //            //elastic search'e yaz
    //        }
    //    }
    //}
}
