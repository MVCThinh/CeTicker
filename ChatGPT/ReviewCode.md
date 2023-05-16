<details>
<summary><h3 style="color:yellow">Sử dụng Enum kết hợp switch</h3></summary>
 <h3 style = "color : red">Code cũ</h3>

```
foreach (string camName in Enum.GetNames(typeof(eCamName)))
{
    RWFile.RWFilePath = Path.Combine(PathRoot, camName, ConfigName);

    switch (camName)
    {
        case "LoadingPre1":
            WriteCamSetting(camName, ref LoadingPre1);
            WriteCamOffset(camName, ref LoadingPre1);
            WriteCamLaser(camName, ref LoadingPre1);
            break;
        case "LoadingPre2":
            WriteCamSetting(camName, ref LoadingPre2);
            WriteCamOffset(camName, ref LoadingPre2);
            WriteCamLaser(camName, ref LoadingPre2);
            break;
        case "Laser1":
            WriteCamSetting(camName, ref Laser1);
            WriteCamOffset(camName, ref Laser1);
            WriteCamLaser(camName, ref Laser1);
            break;
        case "Laser2":
            WriteCamSetting(camName, ref Laser2);
            WriteCamOffset(camName, ref Laser2);
            WriteCamLaser(camName, ref Laser2);
            break;

        default: break;

    }
}
```

 <h3 style = "color : green">Code mới</h3>

```
string[] camNames = Enum.GetNames(typeof(eCamName));

foreach (string camName in camNames)
{
    RWFile.RWFilePath = Path.Combine(PathRoot, camName, ConfigName);

    CamSetting camSetting;

    switch (camName)
    {
        case "LoadingPre1":
            camSetting = LoadingPre1;
            break;
        case "LoadingPre2":
            camSetting = LoadingPre2;
            break;
        case "Laser1":
            camSetting = Laser1;
            break;
        case "Laser2":
            camSetting = Laser2;
            break;
        default:
            continue;
    }

    WriteCamSetting(camName, ref camSetting);
    WriteCamOffset(camName, ref camSetting);
    WriteCamLaser(camName, ref camSetting);
}
```
 
</details>

<details>
<summary><h3 style="color:yellow">Thay vì viết chung lấy tất cả Cam, Tách riêng getId từng cam sẽ dễ dàng hơn</h3></summary>
 <h3 style = "color : red">Code cũ</h3>

```
public void ReadParameterModelToView()
{
    eCamName camName = (eCamName)cboName.SelectedItem;
    if (camName == eCamName.LoadingPre1)
    {
        ReadCamSettingModelToView(LoadingPre1);
        ReadCamOffsetModelToView(LoadingPre1);
        ReadCamLaserModelToView(LoadingPre1);
    }
    if (camName == eCamName.LoadingPre2)
    {
        ReadCamSettingModelToView(LoadingPre2);
        ReadCamOffsetModelToView(LoadingPre2);
        ReadCamLaserModelToView(LoadingPre2);
    }
    if (camName == eCamName.Laser1)
    {
        ReadCamSettingModelToView(Laser1);
        ReadCamOffsetModelToView(Laser1);
        ReadCamLaserModelToView(Laser1);
    }
    if (camName == eCamName.Laser2)
    {
        ReadCamSettingModelToView(Laser2);
        ReadCamOffsetModelToView(Laser2);
        ReadCamLaserModelToView(Laser2);
    }
}
```

 <h3 style = "color : green">Code mới</h3>
 
```
public void ReadParameterModelToView()
{
    eCamName camName = (eCamName)cboName.SelectedItem;
    CamSetting cam = GetCamSettingByCamName(camName);
    
    if (cam != null)
    {
        ReadCamSettingModelToView(cam);
        ReadCamOffsetModelToView(cam);
        ReadCamLaserModelToView(cam);
    }
}

private CamSetting GetCamSettingByCamName(eCamName camName)
{
    switch (camName)
    {
        case eCamName.LoadingPre1:
            return LoadingPre1;
        case eCamName.LoadingPre2:
            return LoadingPre2;
        case eCamName.Laser1:
            return Laser1;
        case eCamName.Laser2:
            return Laser2;
        default:
            return null;
    }
}
```
 
</details>


<details>
<summary><h3 style="color:yellow">Đẩy list items vào trong Combobox</h3></summary>

 <h3 style = "color : red">Code cũ</h3>

```
cbCamList.Items.Clear();

foreach (string camName in Enum.GetNames(typeof(eCamName)))
{
    cbCamList.Items.Add(camName);
}
```

 <h3 style = "color : green">Code mới</h3>

```
cbCamList.DataSource = Enum.GetValues(typeof(eCamName));
```

</details>

<details>
<summary><h3 style="color:yellow">Thay vì sử dụng Invoker hãy sử dụng BeginInvoker</h3></summary>
 <h3 style = "color : red">Code cũ</h3>

```
if (Recipedgv.InvokeRequired)
{
    Recipedgv.Invoke(new MethodInvoker(delegate
    {
        Recipedgv.Rows.Clear();

        foreach (string name in Enum.GetNames(typeof(eRecipe)))
        {
            Recipedgv.Rows.Add(RcpNo.ToString(), name, 0);
            RcpNo += 1;
        }
    }));
}
else
{
    try 
    {
        Recipedgv.Rows.Clear();
        foreach (var name in Enum.GetNames(typeof(eRecipe)))
        {
            Recipedgv.Rows.Add(RcpNo.ToString(), name, 0);
            RcpNo += 1;
        }
    }
    catch { }
}
```

 <h3 style = "color : green">Code mới</h3>


```
Recipedgv.BeginInvoke(new MethodInvoker(delegate
{
    Recipedgv.Rows.Clear();

    foreach (string name in Enum.GetNames(typeof(eRecipe)))
    {
        Recipedgv.Rows.Add(RcpNo.ToString(), name, 0);
        RcpNo++;
    }
}));
```

</details>

<details>
<summary><h3 style="color:yellow">enum kết hợp switch  </h3></summary>
 <h3 style = "color : red">Code cũ</h3>

```
// Xử lý đảo chiều ảnh
if (CamReverseMode == eImageReverse.None)
{

}
else if (CamReverseMode == eImageReverse.XReverse)
{
    bmpTest.RotateFlip(RotateFlipType.RotateNoneFlipX);
}
else if (CamReverseMode == eImageReverse.YReverse)
{
    bmpTest.RotateFlip(RotateFlipType.RotateNoneFlipY);
}
else if (CamReverseMode == eImageReverse.AllReverse)
{
    bmpTest.RotateFlip(RotateFlipType.RotateNoneFlipXY);
}
else if (CamReverseMode == eImageReverse.Reverse90)
{
    bmpTest.RotateFlip(RotateFlipType.Rotate90FlipX);
}
else if (CamReverseMode == eImageReverse.Reverse270)
{
    bmpTest.RotateFlip(RotateFlipType.Rotate270FlipX);
}
else if (CamReverseMode == eImageReverse.Reverse90XY)
{
    bmpTest.RotateFlip(RotateFlipType.Rotate90FlipXY);
}
else if (CamReverseMode == eImageReverse.Reverse270XY)
{
    bmpTest.RotateFlip(RotateFlipType.Rotate270FlipXY);
}           
```           

 <h3 style = "color : green">Code mới</h3>

```
// Xử lý đảo chiều ảnh
switch (CamReverseMode)
{
    case eImageReverse.None:
        break;
    case eImageReverse.XReverse:
        bmpTest.RotateFlip(RotateFlipType.RotateNoneFlipX);
        break;
    case eImageReverse.YReverse:
        bmpTest.RotateFlip(RotateFlipType.RotateNoneFlipY);
        break;
    case eImageReverse.AllReverse:
        bmpTest.RotateFlip(RotateFlipType.RotateNoneFlipXY);
        break;
    case eImageReverse.Reverse90:
        bmpTest.RotateFlip(RotateFlipType.Rotate90FlipX);
        break;
    case eImageReverse.Reverse270:
        bmpTest.RotateFlip(RotateFlipType.Rotate270FlipX);
        break;
    case eImageReverse.Reverse90XY:
        bmpTest.RotateFlip(RotateFlipType.Rotate90FlipXY);
        break;
    case eImageReverse.Reverse270XY:
        bmpTest.RotateFlip(RotateFlipType.Rotate270FlipXY);
        break;
}
```

</details>


<details>
<summary><h3 style="color:yellow">Cách sử dụng bool vào vòng lặp if else </h3></summary>
 <h3 style = "color : red">Code cũ</h3>

```
private void Live(bool live)
{
    if (live)
    {
        cogDisplay.AutoFit = true;
        imCnt= 0;
        tmrLive.Enabled = live;
        LiveOn = live;
    }
    else
    {
        tmrLive.Enabled = false;
        LiveOn = false;
    }
}    
```

 <h3 style = "color : green">Code mới</h3>

```
private void Live(bool live)
{
    cogDisplay.AutoFit = live;
    imCnt = 0;
    tmrLive.Enabled = live;
    LiveOn = live;
} 
```

</details>

<details>
<summary><h3 style="color:yellow">Kế thừa lớp EventArgs</h3></summary>

```
// Lớp con kế thừa từ EventArgs
public class MyEventArgs : EventArgs
{
    public int Data { get; set; }

    public MyEventArgs(int data)
    {
        Data = data;
    }
}

// Lớp chứa sự kiện
public class MyClass
{
    // Định nghĩa một sự kiện sử dụng lớp con kế thừa từ EventArgs
    public event EventHandler<MyEventArgs> MyEvent;

    public void DoSomething()
    {
        // Gọi sự kiện và truyền dữ liệu thông qua đối tượng MyEventArgs
        OnMyEvent(new MyEventArgs(10));
    }

    protected virtual void OnMyEvent(MyEventArgs e)
    {
        // Kiểm tra xem sự kiện có người đăng ký hay không
        if (MyEvent != null)
        {
            // Gửi sự kiện với đối tượng MyEventArgs
            MyEvent(this, e);
        }
    }
}

// Lớp chứa hàm Main để thử nghiệm
public class Program
{
    public static void Main()
    {
        MyClass myObj = new MyClass();

        // Đăng ký xử lý sự kiện
        myObj.MyEvent += MyEventHandler;

        // Gọi phương thức để kích hoạt sự kiện
        myObj.DoSomething();
    }

    private static void MyEventHandler(object sender, MyEventArgs e)
    {
        // Xử lý sự kiện và truy cập dữ liệu từ đối tượng MyEventArgs
        Console.WriteLine("Data received: " + e.Data);
    }
}
```

```
using System;

// Định nghĩa lớp EmployeeEventArgs kế thừa từ lớp EventArgs
public class EmployeeEventArgs : EventArgs
{
    public Employee Employee { get; }

    public EmployeeEventArgs(Employee employee)
    {
        Employee = employee;
    }
}

// Định nghĩa lớp Employee
public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
}

// Đối tượng phát ra sự kiện
public class EmployeeManager
{
    // Khai báo sự kiện với kiểu delegate EventHandler và đối số EmployeeEventArgs
    public event EventHandler<EmployeeEventArgs> EmployeeAdded;

    // Phương thức thêm nhân viên vào danh sách và phát ra sự kiện EmployeeAdded
    public void AddEmployee(Employee employee)
    {
        // Thêm nhân viên vào danh sách

        // Tạo đối tượng EmployeeEventArgs với thông tin nhân viên được truyền vào
        EmployeeEventArgs args = new EmployeeEventArgs(employee);

        // Kiểm tra xem sự kiện có người đăng ký hay không
        if (EmployeeAdded != null)
        {
            // Gửi sự kiện với đối tượng EmployeeEventArgs
            EmployeeAdded(this, args);
        }
    }
}

// Lớp đăng ký và xử lý sự kiện
public class PayrollSystem
{
    public PayrollSystem(EmployeeManager employeeManager)
    {
        // Đăng ký phương thức xử lý sự kiện vào sự kiện EmployeeAdded của đối tượng employeeManager
        employeeManager.EmployeeAdded += CalculateSalary;
    }

    // Phương thức xử lý sự kiện
    private void CalculateSalary(object sender, EmployeeEventArgs e)
    {
        Employee employee = e.Employee;
        // Tính toán lương cho nhân viên và thực hiện các tác vụ khác liên quan

        Console.WriteLine("Tính lương cho nhân viên: " + employee.Name);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        EmployeeManager employeeManager = new EmployeeManager();
        PayrollSystem payrollSystem = new PayrollSystem(employeeManager);

        // Thêm nhân viên vào hệ thống và kích hoạt sự kiện EmployeeAdded
        Employee employee = new Employee { Name = "John", Age = 30 };
        employeeManager.AddEmployee(employee);

        Console.ReadKey();
    }
}
```

</details>

<details>
<summary><h3 style="color:yellow">Thay vì dùng for hãy dùng foreach, dùng CastControl kết hợp với foreach </h3></summary>
 <h3 style = "color : red">Code cũ</h3>

```
for (int i = 0; i < btnMenu.Length; i++)
{
    btnMenu[i].Click += btnMenu_Click;
}
for (int i = 0; i < btnMenu.Length; i++)
{
    if (btnText == btnMenu[i].Text)
    {
        DisplayChange(btnMenu[i].Name);
        btnMenu[i].ForeColor = Color.Yellow;
    }
    else
        btnMenu[i].ForeColor = Color.White;
}
for (int i = 0; i < pnMenu.Controls.Count; i++)
{
    pnMenu.Controls[i].Visible = btnName.ToLower().Substring(3, btnName.Length - 3)
        == pnMenu.Controls[i].Name.ToLower().Substring(2, pnMenu.Controls[i].Name.Length - 2) ? true : false;
}
```


 <h3 style = "color : green">Code mới</h3>

```
Array.ForEach(btnMenu, btn => btn.Click += btnMenu_Click);
foreach (Button btn in btnMenu)
{
    if (btnText == btn.Text)
    {
        DisplayChange(btn.Name);
        btn.ForeColor = Color.Yellow;
    }
    else
        btn.ForeColor = Color.White;
}
pnMenu.Controls.Cast<Control>().ToList().ForEach(control =>
{
    control.Visible = btnName.ToLower().Substring(3) == control.Name.ToLower().Substring(2);
});
```

</details>

<details>
<summary><h3 style="color:yellow">Sử dụng API SendMessage để truyền thông điệp(Message) giữa 2 ứng dụng window  </h3></summary>
 <h3 style = "color : red">Code cũ (Xây dưng 1 hàm chứa thông điệp )</h3>

```
[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "ageage")]
public static extern int SendMessage(IntPtr hWnd, Int32 Msg, IntPtr wParam, ref Win32API.COPYDATASTRUCT lParam);
public static class Win32API
{
    public const Int32 WM_COPYDATA = 0x004A;

    public struct COPYDATASTRUCT
    {
        public IntPtr dwData;
        public int cbData;

        [MarshalAs(UnmanagedType.LPStr)]
        public string lpData;
    }
}
private void SendData(string Msg)
{
    if (hwnd == IntPtr.Zero)
    {
        hwnd = FindWindow(null, "BD_IF");
    }
    if (hwnd != IntPtr.Zero)
    {
        Win32API.COPYDATASTRUCT cds = new Win32API.COPYDATASTRUCT();
        cds.dwData = (IntPtr)(1024 + 604);  // default value
        cds.cbData = Encoding.Default.GetBytes(Msg).Length + 1;
        cds.lpData = Msg;
        SendMessage(hwnd, Win32API.WM_COPYDATA, IntPtr.Zero, ref cds);
        SetlbMXLabel(Msg);
        // csLog.LogSave("[MX -> Vision] : " + Msg);
        if (lbMX.Items.Count > 100) lbMX.Items.Clear();
    }
}
```

 <h3 style = "color : green">Code mới (sử dụng Marshal.StringToHGlobalAnsi để chuyển đổi chuỗi Msg thành con trỏ IntPtr)</h3>

```
[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "SendMessage")]
public static extern int SendMessage(IntPtr hWnd, Int32 Msg, IntPtr wParam, IntPtr lParam);
private void SendData(string Msg)
{
    if (hwnd == IntPtr.Zero)
    {
        hwnd = FindWindow(null, "BD_IF");
    }
    if (hwnd != IntPtr.Zero)
    {
        IntPtr msgPtr = Marshal.StringToHGlobalAnsi(Msg);
        try
        {
            SendMessage(hwnd, Win32API.WM_COPYDATA, IntPtr.Zero, msgPtr);
            SetlbMXLabel(Msg);
            if (lbMX.Items.Count > 100) lbMX.Items.Clear();
        }
        finally
        {
            Marshal.FreeHGlobal(msgPtr);
        }
    }
}
```

</details>

<details>
<summary><h3 style="color:yellow">Đẩy </h3></summary>
 <h3 style = "color : red">Code cũ</h3>

 <h3 style = "color : green">Code mới</h3>


</details>

