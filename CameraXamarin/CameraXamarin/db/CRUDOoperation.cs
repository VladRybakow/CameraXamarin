using CameraXamarin.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CameraXamarin.db
{
    public class CRUDOperation
    {
        SQLiteConnection DB;
        public CRUDOperation(string database)
        {
            DB = new SQLiteConnection(database);
            DB.CreateTable<ProjectPhoto>();
        }

        public IEnumerable<ProjectPhoto> GetProjectPhotos()
        {
            return DB.Table<ProjectPhoto>();
        }
        public int SaveItem(ProjectPhoto projectphoto)
        {
            if (projectphoto.Id != 0)
            {
                DB.Update(projectphoto);
                return projectphoto.Id;
            }

            else
            {
                return DB.Insert(projectphoto);
            }
        }
    }
}
