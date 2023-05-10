using Bending.Data.Enums;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bending.Data.Helpers
{
    public class csRecipe
    {
        // ConcurrentDictionary . Dictionary cho phép truy xuất từ đa luồng. truy xuất an toàn.
        public ConcurrentDictionary<eRecipe, double> Param = new ConcurrentDictionary<eRecipe, double>();

        public string RecipeName;
        public string OldRecipeName;

        public csRecipe()
        {
            // Tạo giá trị mặc định
            foreach (eRecipe e in Enum.GetValues(typeof(eRecipe)))
            {
                Param.TryAdd(e, 0);
            }
        }
    }
}
