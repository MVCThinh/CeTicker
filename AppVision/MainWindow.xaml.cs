using AppVision.Properties;
using AppVision.VisionPro;
using Cognex.VisionPro.CalibFix;
using Cognex.VisionPro.PMAlign;
using Cognex.VisionPro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Net.Sockets;

namespace AppVision
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static StringValueObject strViewButton, logString;

        private CameraIndex cameraIndex;
        private IntValueObject logPanelHeight, intSettingButtonStage;
        private StringValueObject settingDisplayCameraInfo;

        private int numberCameraSign;
        private int _currentCameraSelected = 0;


        private ObservableCollection<CameraVPro> ListCameraVPro = new ObservableCollection<CameraVPro>();

        private System.Windows.Threading.DispatcherTimer TimerVision;

        private Thread socketThread;
        private Server myServer;


        public MainWindow()
        {
            InitializeComponent();

            // Khai bao hien thi
            DisplayInitial();

            VisionProInitial();
            SocketTCPInitial();

        }

        private void SocketTCPInitial()
        {
            Server.eventReceiveString += ProcessClientCommand;
            socketThread = new Thread(socketServerListenThread);
            socketThread.IsBackground = true;
            socketThread.Name = "Socket TCP Thread";
            socketThread.Start();
        }

        private void socketServerListenThread()
        {
            myServer = new Server();
            myServer.Start();
        }

        private void ProcessClientCommand(string rev, Socket socket)
        {
            string tempS = $"Time: {DateTime.Now.ToLongTimeString()} - Receive cmd = {rev}, from client = {socket.RemoteEndPoint}\r\n";
            string[] tempSarr = rev.Split(',');
            int getCameraIndex = -1;
            int.TryParse(tempSarr[1], out getCameraIndex);

            string toSend = "Err Command" + " Received!\r\n";

            if ((getCameraIndex >= 0) && (getCameraIndex < 9))
                toSend = ListCameraVPro[getCameraIndex].Command(rev) + " Received!\r\n";
            byte[] bytesToSend = Encoding.UTF8.GetBytes(toSend);
            socket.Send(bytesToSend);
        }

        private void DisplayInitial()
        {
            strViewButton = new StringValueObject("Show Log");
            logPanelHeight = new IntValueObject(20);

            intSettingButtonStage = new IntValueObject(1);
            logString = new StringValueObject("\r\n");
            cameraIndex = new CameraIndex();

            settingDisplayCameraInfo = new StringValueObject("");

            // Cài đặt các giá trị Context Binding
            // Chiều cao Box Log
            gridTotalMain.DataContext = logPanelHeight;
            // Nút Hide/View Log
            btnViewLog.DataContext = strViewButton;
            // Hộp hiển thị Log
            txtLogBox.DataContext = logString;
            // Số lượng Camera Setting 
            numberCameraSign = Settings.Default.NumberCamera;

            tab1Column.Width = new GridLength(10000, GridUnitType.Star);
            tab2Column.Width = new GridLength(1, GridUnitType.Star);
            tab3Column.Width = new GridLength(1, GridUnitType.Star);


        }

        private void VisionProInitial()
        {
            // Khởi tạo List Camera 
            ListCameraVPro.Add(new CameraVPro());
            ListCameraVPro[0].DoubleClickDisplayEvent += ChangeDisplayInDoubleClick; // Đầu tiên index = -1

            cbbCameraList.ItemsSource = ListCameraVPro;
            cbbCameraList.SelectionChanged += CbbCameraList_SelectionChanged;
            cbbCameraList.SelectedIndex = 0;


            TimerVision = new System.Windows.Threading.DispatcherTimer();
            TimerVision.Interval = new TimeSpan(0, 0, 10);
            TimerVision.Tick += LoadCamera;
            TimerVision.Start();

        }

        private void LoadCamera(object sender, EventArgs e)
        {

            TimerVision.Stop();
            for (int i = 0; i < numberCameraSign; i++)
            {
                ListCameraVPro[i].Load(i);
            }

        }




        private void ChangeDisplayInDoubleClick(int index)
        {
            cbbCameraList.SelectedIndex = index;
        }

        private void CbbCameraList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _currentCameraSelected = (sender as ComboBox).SelectedIndex;
            ReloadViewCamera();
        }

        private void ReloadViewCamera()
        {
            showControlTab(0);
            int tempIndex = 0;
            // Hiển thị Camera chính
            wfCogDisplayMain1.Child = ListCameraVPro[_currentCameraSelected].CogDisplayOut;
            // Hiển thị các Camera phụ
            if (tempIndex == _currentCameraSelected) tempIndex += 1;
            if (tempIndex < ListCameraVPro.Count) wfCogDisplayMain2.Child = ListCameraVPro[tempIndex].CogDisplayOut;
            tempIndex += 1;
            if (tempIndex == _currentCameraSelected) tempIndex += 1;
            if (tempIndex < ListCameraVPro.Count) wfCogDisplayMain3.Child = ListCameraVPro[tempIndex].CogDisplayOut;
            tempIndex += 1;
            if (tempIndex == _currentCameraSelected) tempIndex += 1;
            if (tempIndex < ListCameraVPro.Count) wfCogDisplayMain4.Child = ListCameraVPro[tempIndex].CogDisplayOut;
            tempIndex += 1;
            if (tempIndex == _currentCameraSelected) tempIndex += 1;
            if (tempIndex < ListCameraVPro.Count) wfCogDisplayMain5.Child = ListCameraVPro[tempIndex].CogDisplayOut;
            tempIndex += 1;
            if (tempIndex == _currentCameraSelected) tempIndex += 1;
            if (tempIndex < ListCameraVPro.Count) wfCogDisplayMain6.Child = ListCameraVPro[tempIndex].CogDisplayOut;
            tempIndex += 1;
            if (tempIndex == _currentCameraSelected) tempIndex += 1;
            if (tempIndex < ListCameraVPro.Count) wfCogDisplayMain7.Child = ListCameraVPro[tempIndex].CogDisplayOut;
            tempIndex += 1;
            if (tempIndex == _currentCameraSelected) tempIndex += 1;
            if (tempIndex < ListCameraVPro.Count) wfCogDisplayMain8.Child = ListCameraVPro[tempIndex].CogDisplayOut;
            tempIndex += 1;
            if (tempIndex == _currentCameraSelected) tempIndex += 1;
            if (tempIndex < ListCameraVPro.Count) wfCogDisplayMain9.Child = ListCameraVPro[tempIndex].CogDisplayOut;
        }

        private void showControlTab(int tabIndex)
        {
            int value1 = 0;
            int value2 = 0;
            int value3 = 0;
            switch (tabIndex)
            {
                case 0:
                    value1 = 10; value2 = 0; value3 = 0;
                    break;
                case 1:
                    value1 = 0; value2 = 10; value3 = 0;
                    break;
                case 2:
                    value1 = 0; value2 = 0; value3 = 10;
                    break;
                default:
                    MessageBox.Show("Wrong Setting! Select Menu Switch");
                    break;
            }
            tab1Column.Width = new GridLength(value1, GridUnitType.Star);
            tab2Column.Width = new GridLength(value2, GridUnitType.Star);
            tab3Column.Width = new GridLength(value3, GridUnitType.Star);
        }
    }
}
