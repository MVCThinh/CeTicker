<details>
<summary><h1 style="color:yellow">từ khóa `ref` trong C#</h1></summary>
 <h2 style="color:red">1.Dưới đây là một số trường hợp phổ biến áp dụng từ khóa `ref` trong C#:</h2>

<h3 style="color:pink">1.1 Thay đổi giá trị của biến truyền vào:</h3> 
Khi bạn muốn thay đổi giá trị của biến truyền vào trong một phương thức và muốn thay đổi được phản ánh ngay cả bên ngoài phương thức, bạn có thể sử dụng từ khóa ```ref```. Bằng cách truyền biến qua tham số ``ref``, phương thức có thể thay đổi giá trị của biến đó và sự thay đổi này sẽ được phản ánh trực tiếp trong phạm vi gọi phương thức.
<br></br>

 <h3 style="color : pink">1.2 Truyền tham chiếu cho một biến chưa được khởi tạo:</h3>
 Khi bạn muốn truyền tham chiếu cho một biến chưa được khởi tạo và muốn phương thức có thể khởi tạo và thay đổi giá trị của biến đó, bạn có thể sử dụng từ khóa ``ref``. Điều này cho phép phương thức khởi tạo biến và gán giá trị cho nó, và sự thay đổi này sẽ được phản ánh trực tiếp bên ngoài phương thức.
<br></br>

 <h3 style = "color : pink">1.3 Truyền tham số tham chiếu cho hiệu suất: </h3>
 Trong một số trường hợp, việc sử dụng từ khóa ``ref`` có thể cải thiện hiệu suất của chương trình. Thay vì truyền giá trị của một đối tượng lớn qua tham số, bạn có thể truyền tham chiếu đến đối tượng đó bằng từ khóa ``ref``. Điều này giúp tránh việc sao chép dữ liệu lớn và tiết kiệm tài nguyên.
<br></br>


<h2 style = "color : yellow">Lưu ý: </h2>
 Khi sử dụng từ khóa ``ref``, biến truyền vào phải được khởi tạo trước khi truyền vào phương thức. Đồng thời, cả phương thức và nơi gọi phương thức cần truyền cùng một biến để đảm bảo tính nhất quán giữa hai phạm vi.
<br></br>


<h2 style ="color :red">2.Dưới đây là ví dụ về từng trường hợp sử dụng từ khóa ``ref`` trong C#: </h2>

<h3 style = "color : pink">2.1 Thay đổi giá trị của biến truyền vào: </h3>

```
public void ChangeValue(ref int number)
{
    number = 10;
}

int num = 5;
ChangeValue(ref num);
Console.WriteLine(num); // Kết quả: 10
```

Trong ví dụ này, giá trị của biến `num` được thay đổi trong phương thức `ChangeValue` thông qua việc sử dụng từ khóa ```ref```. Kết quả được in ra là `10` vì giá trị của biến đã được thay đổi bên trong phương thức
<br>

<h3 style = "color : pink">2.2 Truyền tham chiếu cho một biến chưa được khởi tạo: </h3>

```
public void InitializeValue(ref int number)
{
    number = 10;
}

int value;
InitializeValue(ref value);
Console.WriteLine(value); // Kết quả: 10
```

Trong ví dụ này, biến `value` chưa được khởi tạo trước khi truyền vào phương thức `InitializeValue` bằng từ khóa ```ref```. Bên trong phương thức, giá trị của biến được khởi tạo là `10`. Sau khi phương thức được gọi, biến `value` bên ngoài cũng sẽ có giá trị là `10`.
<br>

<h3 style ="color:pink">2.3 Truyền tham số tham chiếu cho hiệu suất:</h3>

```
public void ProcessLargeObject(ref LargeObject obj)
{
    // Thực hiện xử lý trên đối tượng lớn
}

LargeObject largeObj = new LargeObject();
ProcessLargeObject(ref largeObj);
```

Trong ví dụ này, đối tượng `largeObj` được truyền vào phương thức `ProcessLargeObject` bằng từ khóa `ref`. Việc này giúp tránh việc sao chép đối tượng lớn và tiết kiệm tài nguyên bộ nhớ. Phương thức có thể thực hiện các xử lý trên đối tượng `largeObj` mà không cần sao chép nó.
<br>

</details>


<details>
<summary><h1 style="color:yellow">từ khóa `out` trong C#</h1></summary>

<h2 style="color:red">3.Dưới đây là một vài trường hợp phổ biến áp dụng từ khóa `out` trong C#::</h2>

<h3 style="color:pink">3.1 Trả về nhiều giá trị từ một phương thức:</h3> 
Bạn có thể sử dụng từ khóa out để trả về nhiều giá trị từ một phương thức. Thay vì chỉ trả về một giá trị duy nhất, bạn có thể truyền các tham số đầu ra qua tham biến out để phương thức có thể cập nhật giá trị của chúng.

```
public void CalculateSumAndProduct(int a, int b, out int sum, out int product)
{
    sum = a + b;
    product = a * b;
}

int num1 = 5;
int num2 = 7;
int resultSum;
int resultProduct;

CalculateSumAndProduct(num1, num2, out resultSum, out resultProduct);

Console.WriteLine($"Tổng: {num1} + {num2} = {resultSum}");
Console.WriteLine($"Tích: {num1} * {num2} = {resultProduct}");
```

<h3 style ="color:pink">3.2 Xử lý lỗi và trạng thái</h3>
 Trong một số trường hợp, bạn muốn kiểm tra và xử lý lỗi hoặc trạng thái bên trong một phương thức. Bằng cách sử dụng từ khóa out, phương thức có thể truyền các biến đại diện cho lỗi hoặc trạng thái qua tham số out, và sau đó bạn có thể kiểm tra giá trị của chúng và thực hiện các xử lý tương ứng.

 ```
 public bool TryParseInt(string input, out int result)
{
    if (int.TryParse(input, out int parsedValue))
    {
        result = parsedValue;
        return true;
    }
    else
    {
        result = 0;
        return false;
    }
}

string userInput = "123";
int parsedInt;

if (TryParseInt(userInput, out parsedInt))
{
    Console.WriteLine($"Giá trị đã được phân tích: {parsedInt}");
}
else
{
    Console.WriteLine("Đầu vào không hợp lệ. Không thể phân tích thành số nguyên.");
}
```

<h3 style ="color:pink">3.3 Truyền tham số tham chiếu </h3>
Khi bạn muốn truyền tham số vào một phương thức và muốn phương thức có thể thay đổi giá trị của tham số đó, bạn có thể sử dụng từ khóa out. Điều này cho phép phương thức có thể cập nhật giá trị của biến được truyền vào và thay đổi nó trực tiếp trong phạm vi của phương thức.

```
public void Increment(ref int number)
{
    number++;
}

int value = 5;
Increment(ref value);
Console.WriteLine($"Giá trị sau khi tăng: {value}");

```

<h2 style= "color :yellow">Lưu ý : </h2>Tuy nhiên, cần lưu ý rằng khi sử dụng từ khóa out, các biến cần được khởi tạo trước khi truyền vào phương thức và không cần khởi tạo giá trị ban đầu. Đồng thời, phương thức cần gán giá trị cho các biến out trước khi kết thúc.


</details>




