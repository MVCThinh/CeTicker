using ExamMultipleChoice.Data;
using ExamMultipleChoice.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamMultipleChoice
{
    public partial class Form1 : Form
    {
        Login _login = new Login();
        string _server = "http://192.168.1.2:8083";
        //string _server = "https://localhost:44311";
        Thread _threadLive;
        int _totalSecond = 0;
        int _currentQuestionIndex = -1;
        int _oldQuestionIndex = -1;
        bool _isFinish = false;
        List<ExamQuestionBankModel> _lstExamQuestionBankModel = new List<ExamQuestionBankModel>();
        List<Button> _lstButton = new List<Button>();
        public Form1()
        {
            InitializeComponent();
        }

        private void RunCount()
        {
            while(true)
            {
                Thread.Sleep(1000);
                if (_totalSecond ==0 || _isFinish)
                {
                    Invoke(new Action(() =>
                    {
                        FinishExam();
                    }));
                    break;
                }
                _totalSecond--;
                try
                {
                    Invoke(new Action(() =>
                    {
                        TimeSpan time = TimeSpan.FromSeconds(_totalSecond);
                        lblTime.Text = time.ToString(@"hh\:mm\:ss");
                    }));
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void FinishExam()
        {
            try
            {
                if (!CreateExamTestResultMaster())
                {
                    MessageBox.Show("Lỗi lưu kết quả thi!");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu!\n" + ex.ToString());
                return;
            }

            btnSave.Enabled = false;
            int countTrue = _lstExamQuestionBankModel.Count(o => o.CorrectAnswer == o.ResultChose);
            decimal sumScore = _lstExamQuestionBankModel.Sum(x => x.Score);
            decimal sumTrue = _lstExamQuestionBankModel.Where(x => x.CorrectAnswer == x.ResultChose).Sum(x => x.Score);

            lblStatus.Text += $"\nBạn đã trả lời đúng\n{countTrue}/{_lstExamQuestionBankModel.Count}\nSố điểm: {Math.Round((sumTrue / sumScore), 2)}";

        }

        private bool CreateExamTestResultMaster()
        {
            bool resultData = false;
            try
            {
                HttpClient client = new HttpClient();
                string url = $"{_server}/api/ExamTestResultMaster/createexammaster";

                ExamTestResultMasterModel m = new ExamTestResultMasterModel();
                m.ExamCategoryID = _lstExamQuestionBankModel[0].ExamCategoryID; // Câu hỏi đâu tiên
                m.ExamListTestID = _lstExamQuestionBankModel[0].ExamListTestID;
                m.EmployeeID = _lstExamQuestionBankModel[0].EmployeeID;
                m.TotalChose = _lstExamQuestionBankModel.Count(o => o.Status == 1); // Số câu chọn
                m.TotalCorrect = _lstExamQuestionBankModel.Count(o => o.CorrectAnswer == o.ResultChose);
                m.TotalIncorrect = _lstExamQuestionBankModel.Count - m.TotalCorrect;
                m.TotalQuestion = _lstExamQuestionBankModel.Count;

                decimal totalScore = _lstExamQuestionBankModel.Sum(x => x.Score);
                decimal totalScoreTrue = _lstExamQuestionBankModel.Where(x => x.CorrectAnswer == x.ResultChose).Sum(x => x.Score);
                m.TotalMarks = Math.Round((totalScoreTrue / totalScore), 2);

                string postData = JsonConvert.SerializeObject(m);
                var stringContent = new StringContent(postData, Encoding.UTF8, "application/json");
                var result = client.PostAsync(url, stringContent);
                var r = result.Result;
                string resultJsonString = r.Content.ReadAsStringAsync().Result;
                ApiResult apiResult = JsonConvert.DeserializeObject<ApiResult>(resultJsonString);

                if (apiResult.StatusCode == 1)
                    resultData = true;
            }
            catch
            {
            }
            return resultData;
        }

        private void LoadAllQuestion(List<ExamQuestionBankModel> lstQuestion)
        {
            _lstButton.Clear();
            int count = lstQuestion.Count;
            lblStatus.Text = $"Số câu đã trả lời\n0/{count}";
            for (int i = 0; i < count; i++)
            {
                Button button = new Button();
                button.Tag = i;
                button.Name = "b" + i;
                button.Text = (i + 1).ToString();
                button.Width = 40;
                button.Height = 30;
                button.FlatStyle = FlatStyle.Flat;
                button.BackColor = Color.Gray;
                button.Click += Button_Click;
                flpListQuestion.Controls.Add(button);
                _lstButton.Add(button);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _oldQuestionIndex = _currentQuestionIndex;
            _currentQuestionIndex = (int)btn.Tag;
            chkA.Checked = chkB.Checked = chkC.Checked = chkD.Checked = false;
            LoadQuestion(_currentQuestionIndex);

        }

        private void LoadQuestion(int questionIndex)
        {
            if (questionIndex > _lstExamQuestionBankModel.Count - 1 || questionIndex < 0) return;

            _lstButton[questionIndex].BackColor = Color.Yellow;
            if (_oldQuestionIndex >= 0)
                _lstButton[_oldQuestionIndex].BackColor = _lstExamQuestionBankModel[_oldQuestionIndex].Status == 0 ? Color.Gray : Color.Lime;

            ExamQuestionBankModel question = _lstExamQuestionBankModel[questionIndex];
            if (question.Status == 1 && !string.IsNullOrEmpty(question.ResultChose))
            {
                if (question.ResultChose.Contains("A"))
                {
                    chkA.Checked = true;
                }
                if (question.ResultChose.Contains("B"))
                {
                    chkB.Checked = true;
                }
                if (question.ResultChose.Contains("C"))
                {
                    chkC.Checked = true;
                }
                if (question.ResultChose.Contains("D"))
                {
                    chkD.Checked = true;
                }
            }

            // Nội dung câu hỏi
            // Câu hỏi không có hình ảnh
            string contentQuestion = "";
            if (string.IsNullOrEmpty(question.Image))
            {
                string[] arr = question.ContentTest.Split('\n');
                contentQuestion = "<h2>";
                if (arr.Length > 0)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (i == 0)
                        {
                            // Tiêu đề
                            contentQuestion += arr[i] + "<br><br><br></h2>";
                        }
                        else
                        {
                            // Nôi dung
                            contentQuestion += "<p style=\"font-size:20px;\">" + arr[i] + "<br><br></p>";
                        }
                    }
                }
            }

            string htmlText = $"{contentQuestion} <img src='{_server}/api/Upload/Images/{question.Image}'>";

            wbQuestion.DocumentText = "";
            wbQuestion.Document.OpenNew(true);
            wbQuestion.Document.Write(htmlText);
            wbQuestion.Refresh();

        }
        


        private ExamListTest getExamTestByCategoryCode(string catCode)
        {
            HttpClient client = new HttpClient();
            string url = $"{_server}/api/ExamListTest/getexamlist?code=" + catCode;
            var result = client.GetAsync(url);
            var r = result.Result;
            string a = r.Content.ReadAsStringAsync().Result;
            ExamListTest obj = JsonConvert.DeserializeObject<ExamListTest>(a);

            return obj;
        }

        private ExamQuestionBank getListQuestion(int listTestID)
        {
            HttpClient client = new HttpClient();
            string url = $"{_server}/api/ExamQuestionBank/questionbank?examlistId=" + listTestID;
            var result = client.GetAsync(url);
            var r = result.Result;
            string a = r.Content.ReadAsStringAsync().Result;
            ExamQuestionBank obj = JsonConvert.DeserializeObject<ExamQuestionBank>(a);

            return obj;
        }

        private bool login()
        {
            try
            {
                HttpClient client = new HttpClient();
                string url = $"{_server}/api/Home/login";

                User user = new User();
                user.LoginName = txtUser.Text.Trim(); // bỏ khoảng trắng ở đầu và cuối
                user.PassWord = txtPass.Text.Trim(); // bỏ khoảng trắng ở đầu và cuối

                string postData = JsonConvert.SerializeObject(user);

                var stringContent = new StringContent(postData, Encoding.UTF8, "application/json");
                var result = client.PostAsync(url, stringContent); // Gửi tên đăng nhập và password
                var r = result.Result;
                string resultJsonString = r.Content.ReadAsStringAsync().Result;
                _login = JsonConvert.DeserializeObject<Login>(resultJsonString); // Giải mã chuôi resultJsonString rồi trả về class Login

                return _login.StatusCode == 1; // StatusCode từ Server trả về 1 thì true

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng nhập!\n" + ex.ToString()); // Xuống dòng
                return false;               
            }
        }

        private bool checkTest(string catCode)
        {
            bool status = true;
            try
            {
                HttpClient client = new HttpClient();
                string url = $"{_server}/api/ExamTestResultMaster/getexammaster?examCatCode={catCode}&employeeId={_login.user.EmployeeID}"; // 1 đường dẫn url get thẳng tới web

                var result = client.GetAsync(url);
                var r = result.Result;
                string a = r.Content.ReadAsStringAsync().Result;
                ApiResult obj = JsonConvert.DeserializeObject<ApiResult>(a);
                status = obj.StatusCode == 1; // So sánh liệu StatusCode trả về có = 1

            }
            catch (Exception)
            {

                throw;
            }
            return status;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isSuccess = login();
            if (!isSuccess)
            {
                MessageBox.Show("Lỗi đăng nhập!");
                return;
            }
            else
                lblUserInfo.Text = $"Xin chào, {_login.user.Code} - {_login.user.FullName}";
        }

        private void chkOnline_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOnline.Checked)
                _server = "http://14.232.152.154:8083";
            else
                _server = "http://192.168.1.2:8083";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string catCode = txtCatCode.Text.Trim();
            if (_login.user == null)
            {
                MessageBox.Show("Bạn chưa đăng nhập hệ thống!");
                return;
            }

            // Check xem đã thi chưa
            bool enable = checkTest(catCode);
            if (enable)
            {
                MessageBox.Show("Bạn không được tham gia thi!");
                return;
            }

            //lấy danh sách đề thi, chọn random 1 đề thi trong đó
            ExamListTest obj = getExamTestByCategoryCode(catCode);
            if (obj.StatusCode == 0)
            {
                MessageBox.Show("Bài thi không tồn tại!");
                return;
            }
            
            // Lấy được đề thi 
            List<ExamListTestModel> lstListTest = obj.ExamList;
            Random number = new Random();
            int index = number.Next(0, lstListTest.Count - 1);
            ExamListTestModel examListTestModel = lstListTest[index];

            //lấy danh sách câu hỏi theo đề thi đã chọn
            ExamQuestionBank examQuestionBank = getListQuestion(examListTestModel.ID); // Lấy 1 câu hỏi từ ngân hàng câu hỏi
            if (examQuestionBank.StatusCode == 0)
            {
                MessageBox.Show("Bài thi không tồn tại!");
                return;
            }

            _lstExamQuestionBankModel = new List<ExamQuestionBankModel>();
            _lstExamQuestionBankModel = examQuestionBank.QuestionBank.OrderBy(o => Guid.NewGuid()).ToList(); //Lấy 1 list câu hỏi Sắp xếp ngẫu nhiên

            if (!CreateExamTestResultMaster())
            {
                MessageBox.Show("Lỗi lưu kết quả thi!");
                return;
            }

            btnFinish.Enabled = btnNextQuestion.Enabled = btnSave.Enabled = true;
            txtPass.Enabled = txtUser.Enabled = chkOnline.Enabled = btnLogin.Enabled = txtCatCode.Enabled = btnStart.Enabled = false;

            for (int i = 0; i < _lstExamQuestionBankModel.Count; i++)
            {
                _lstExamQuestionBankModel[i].EmployeeID = _login.user.EmployeeID;
                _lstExamQuestionBankModel[i].ExamQuestionBankID = _lstExamQuestionBankModel[i].ID;
                _lstExamQuestionBankModel[i].ExamCategoryID = examListTestModel.ExamCategoryID;
            }

            LoadAllQuestion(_lstExamQuestionBankModel);

            // Load luôn câu hỏi đầu tiên
            _currentQuestionIndex = 0;
            LoadQuestion(_currentQuestionIndex);

            //Điếm ngược thời gian
            _totalSecond = examListTestModel.TestTime * 60;
            _threadLive = new Thread(new ThreadStart(RunCount));
            _threadLive.IsBackground = true; // Chương trình chính kết thúc , luồng phụ cũng kết thúc
            _threadLive.Start();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string result = "";
            if (chkA.Checked)
            {
                result += "A";
            }
            if (chkB.Checked)
            {
                result += "B";
            }
            if (chkC.Checked)
            {
                result += "C";
            }
            if (chkD.Checked)
            {
                result += "D";
            }
            if (result.Trim() == "") return;

            ExamQuestionBankModel question = _lstExamQuestionBankModel[_currentQuestionIndex];
            question.ResultChose = result;
            question.ID = 0;

            try
            {
                HttpClient client = new HttpClient();
                string url = $"{_server}/api/ExamTestResult/updatetestresult";

                string postData = JsonConvert.SerializeObject(question);
                var stringContent = new StringContent(postData, Encoding.UTF8, "application/json");
                var result1 = client.PostAsync(url, stringContent);
                var r = result1.Result;
                string resultJsonString = r.Content.ReadAsStringAsync().Result;
                Login saveResult = JsonConvert.DeserializeObject<Login>(resultJsonString);
                if (saveResult.StatusCode == 0)
                {
                    _lstExamQuestionBankModel[_currentQuestionIndex].Status = 0;
                    MessageBox.Show("Có lỗi xảy ra.\n Không lưu được kết quả câu trả lời");
                }
                else
                {
                    _lstExamQuestionBankModel[_currentQuestionIndex].Status = 1;
                    int count = _lstExamQuestionBankModel.Count(o => o.Status == 1);
                    lblStatus.Text = $"Bạn đã trả lời\n{count}/{_lstExamQuestionBankModel.Count}";
                    if (_currentQuestionIndex < _lstExamQuestionBankModel.Count - 1)
                    {
                        chkA.Checked = chkB.Checked = chkC.Checked = chkD.Checked = false;
                        btnNextQuestion_Click(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra.\n {ex.ToString()}");
            }
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            if (_currentQuestionIndex == _lstExamQuestionBankModel.Count - 1) return;
            _oldQuestionIndex = _currentQuestionIndex;
            _currentQuestionIndex++;
            chkA.Checked = chkB.Checked = chkC.Checked = chkD.Checked = false;
            LoadQuestion(_currentQuestionIndex);
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn nộp bài thi", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            _isFinish = true;
            btnFinish.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                CreateExamTestResultMaster();
            }
        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                 