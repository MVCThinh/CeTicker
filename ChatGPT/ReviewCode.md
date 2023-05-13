<details>
<summary><h1 style="color:yellow">Sử dụng Enum kết hợp switch</h2></summary>
 <h2 style = "color : red">Code cũ</h2>

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

 <h2 style = "color : green">Code mới</h2>

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
<summary><h1 style="color:yellow">Thay vì viết chung lấy tất cả Cam, Tách riêng getId từng cam sẽ dễ dàng hơn</h2></summary>
 <h2 style = "color : red">Code cũ</h2>

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

 <h2 style = "color : green">Code mới</h2>
 
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
<summary><h1 style="color:yellow">Đẩy list items vào trong Combobox</h1></summary>

 <h2 style = "color : red">Code cũ</h2>

```
cbCamList.Items.Clear();

foreach (string camName in Enum.GetNames(typeof(eCamName)))
{
    cbCamList.Items.Add(camName);
}
```

 <h2 style = "color : green">Code mới</h2>

```
cbCamList.DataSource = Enum.GetValues(typeof(eCamName));
```

</details>

<details>
<summary><h1 style="color:yellow">Thay vì sử dụng Invoker hãy sử dụng BeginInvoker</h2></summary>
 <h2 style = "color : red">Code cũ</h2>

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

 <h2 style = "color : green">Code mới</h2>


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
<summary><h1 style="color:yellow">Đẩy </h2></summary>



</details>

