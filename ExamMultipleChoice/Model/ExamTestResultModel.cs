using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamMultipleChoice.Model
{
    public class ExamTestResultModel
    {
        public int ID { get; set; }

        public int ExamListTestID { get; set; }

        public int ExamQuestionBankID { get; set; }

        public int EmployeeID { get; set; }

        public string CandidateName { get; set; }

        public string ResultChose { get; set; }
    }
}
