using System;
using System.Collections.Generic;
using System.Text;

namespace CameraXamarin.db
{
    public interface ISqlite
    {
        string GetDatabase(string filename);
    }
}
