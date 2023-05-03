using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamMultipleChoice.Model
{
    public class ExamTestResultMasterModel
    {
        public int ID { get; set; }
        public int ExamCategoryID { get; set; }
        public int ExamListTestID { get; set; }
        public int EmployeeID { get; set; }
        public int TotalQuestion { get; set; }
        public int TotalChose { get; set; }
        public int TotalCorrect { get; set; }
        public int TotalIncorrect { get; set; }
        public decimal TotalMarks { get; set; }
    }
}
