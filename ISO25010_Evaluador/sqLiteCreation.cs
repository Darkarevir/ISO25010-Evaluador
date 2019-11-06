using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.IO;

namespace ISO25010_Evaluador
{
    class sqLiteCreation
    {
        private const string dbName = "iso25010.sqlite";
        private const string SQLScript = @"..\..\Util\iso25010.sqlite";
        private static bool isDbRecentlyCreated = false;

        public static void up() {
            if (!File.Exists(Path.GetFullPath(dbName)))
            {
                SQLiteConnection.CreateFile(dbName);
                isDbRecentlyCreated = true;
            }

            using (var ctx = GetInstance()) {
                if (isDbRecentlyCreated)
                {
                    using (var reader = new StreamReader(Path.GetFullPath(SQLScript))) {
                        var query = "";
                        var line = "";
                        while ((line = reader.ReadLine()) != null) {
                            query += line;
                        }

                        using (var command = new SQLiteCommand(query, ctx)) {
                            command.ExecuteNonQuery();
                        }
                    }

                    for (var i = 1; i <= 100; i++)
                    {

                    }
    
                }
            }

        }

        public static SQLiteConnection GetInstance() {
            var db = new SQLiteConnection(
                string.Format("Data Source=(0);Version=3;",dbName));
            db.Open();

            return db;
        }

    }
}
