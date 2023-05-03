using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamMultipleChoice.Model
{
    public class ExamQuestionBankModel
    {
        public int ID { get; set; }
        public int ExamListTestID { get; set; }
        public int STT { get; set; }
        public string ContentTest { get; set; }
        public string Image { get; set; }
        public string CorrectAnswer { get; set; }
        public int ExamCategoryID { get; set; }
        public int ExamQuestionBankID { get; set; }
        public int EmployeeID { get; set; }
        public string ResultChose { get; set; }
        public int Status { get; set; } = 0;//check xem câu hỏi đã được làm hay chưa
        public int Score { get; set; }
    }
}
