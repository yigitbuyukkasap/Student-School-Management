using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace ogrenciSistemi_Utility
{
    public class WebConst
    {
        public const string Success = "Success";
        public const string Error = "Error";

        // Roller
        public const string AdminRole = "Admin";
        public const string TeacherRole = "Öğretmen";
        public const string ManagerRole= "Müdür";

        public static readonly IEnumerable<string> roleList = new ReadOnlyCollection<string>(
            new List<string>
            {
                AdminRole,TeacherRole,ManagerRole
            });
    }
}
