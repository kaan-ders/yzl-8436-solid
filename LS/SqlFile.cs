using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.LS
{
    //YANLIŞŞŞŞ!!!!
    //public class SqlFile
    //{
    //    public string FilePath { get; set; }
    //    public string SQL { get; set; }

    //    //dosyayı oku
    //    public virtual string LoadText()
    //    {
    //        //dosyadan okunan query'ler
    //        return "select * from Employee";
    //    }

    //    //dosyaya kaydet
    //    public virtual void SaveText()
    //    {
    //        //SQL değişkeninin içindeki queryi dosyaya kaydet
    //    }
    //}

    //public class ReadOnlySqlFile : SqlFile
    //{
    //    public override string LoadText()
    //    {
    //        //dosyadan okunan query'ler
    //        return "select * from Employee";
    //    }

    //    public override void SaveText()
    //    {
    //        throw new IOException("Can't Save");
    //    }
    //}

    //public class SqlFileManager
    //{
    //    public List<SqlFile> Files { get; set; } = new List<SqlFile>();
    //    public string GetTextFromFiles()
    //    {
    //        string sql = "";
    //        foreach (var item in Files)
    //        {
    //            sql += item.LoadText() + Environment.NewLine;
    //        }

    //        return sql;
    //    }

    //    public void SaveTextIntoFiles()
    //    {
    //        foreach (var item in Files)
    //        {
    //            if(item.GetType() !=  typeof(ReadOnlySqlFile))
    //                item.SaveText();
    //        }
    //    }
    //}

    //DOĞRU
    //--------------------------------

    public interface IReadableSqlFile
    {
        string LoadText();
    }

    public interface IWritableSqlFile
    {
        void SaveText();
    }

    public class ReadOnlySqlFile : IReadableSqlFile
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }
        public string LoadText()
        {
            return "";
            /* Code to read text from sql file */
        }
    }

    public class SqlFile : IWritableSqlFile, IReadableSqlFile
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }
        public string LoadText()
        {
            return "";
            /* Code to read text from sql file */
        }
        public void SaveText()
        {
            /* Code to save text into sql file */
        }
    }

    public class SqlFileManager
    {
        public string GetTextFromFiles(List<IReadableSqlFile> aLstReadableFiles)
        {
            string sql = "";
            foreach (var objFile in aLstReadableFiles)
            {
                sql += objFile.LoadText() + Environment.NewLine;
            }
            return sql;
        }

        public void SaveTextIntoFiles(List<IWritableSqlFile> aLstWritableFiles)
        {
            foreach (var objFile in aLstWritableFiles)
            {
                objFile.SaveText();
            }
        }
    }
}
