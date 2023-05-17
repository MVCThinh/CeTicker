using AppVision.Properties;
using System;
using System.Collections.Generic;
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

namespace AppVision
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static StringValueObject strViewButton, logString;
        private CameraIndex cameraIndex;

        public MainWindow()
        {
            InitializeComponent();

            // Khai bao hien thi
            DisplayInitial();

            VisionProInitial();
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
    }
