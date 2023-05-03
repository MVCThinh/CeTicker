using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamMultipleChoice.Model
{
    public class ExamQuestionBank
    {
        public int StatusCode { get; set; }
        public List<ExamQuestionBankModel> QuestionBank { get; set; }
    }
}
