
$(document).ready(function () {
    $('#modal_update_employee_food_order').modal('show');
    GetAll();
});

//Get danh sách đặt cơm
function GetAll() {
    var html = '';
    $.ajax({
        url: _URL + 'EmployeeFoodOrder/GetAll',
        type: 'GET',
        dataType: 'json',
        data: {
            dateStart: $('#date_start_empoyee_food_order').val(),
            dateEnd: $('#date_end_empoyee_food_order').val(),
            keyword: $('#keyword_empoyee_food_order').val(),
        },
        contentType: 'application/json',
        success: function (result) {
            $.each(result, function (key, item) {
                var paramDelete = "'" + item.ID + "','" + item.DateOrder + "'";
                html += `<tr>
                            <td>
                                <button class="btn btn-danger btn-sm" title="Hủy" onclick="return Delete(${paramDelete})"><i class="fas fa-times"></i></button>
                            </td>
                            <td>${getFormattedDateDMY(item.DateOrder)}</td>
                            <td>${item.FullName}</td>
                            <td>${item.Quantity}</td>
                        </tr>`;
            });
            $('#tbody_employee_foodorder').html(html);

        },

        error: function () {
            MessageError("Error loading data! Please try again.");
        }
    });
}

//Check validate
function Validate() {
    //var date = $('#dateorder_employee_foodorder').val();
    var quantity = parseInt($('#quantity_employee_foodorder').val());

    if (quantity != 1) {
        MessageWarning("Số lượng tối đa là 1.\nVui lòng kiểm tra lại!");
        return false;
    }

    return true;
}

//Đăng ký cơm ca
function Create() {
    var obj = {
        DateOrder: $('#dateorder_employee_foodorder').val(),
        Quantity: parseInt($('#quantity_employee_foodorder').val()),
    };

    if (Validate()) {
        $.ajax({
            url: _URL + 'EmployeeFoodOrder/Create',
            type: 'POST',
            dataType: 'json',
            data: JSON.stringify(obj),
            contentType: 'application/json',
            success: function (result) {
                if (parseInt(result) == 1) {
                    MessageSucces("Đăng ký thành công!");
                    $('#modal_update_employee_food_order').modal('hide');
                    GetAll();
                } else {
                    MessageWarning(result);
                }

            },

            error: function () {
                MessageError("Đăng ký thất bại!");
            }
        });
    }
}

//Hủy cơm ca
function Delete(id, date) {
    var dateNow = new Date(getFormattedDateYMD(new Date));
    date = new Date(getFormattedDateYMD(date));

    if ((dateNow - date) != 0) {
        MessageWarning("Bạn không thể hủy cơm ca của ngày hôm trước!");
        return;
    }

    var ans = confirm("Bạn có chắc muốn hủy cơm ca ngày: " + getFormattedDateDMY(date) + " không?");
    if (ans) {
        $.ajax({
            url: _URL + 'EmployeeFoodOrder/Delete',
            type: 'GET',
            data: {
                id: id,
            },
            contentType: 'application/json;charset=utf-8',
            dataType: 'json',
            success: function (result) {
                if (parseInt(result) == 1) {
                    GetAll();
                } else {
                    MessageWarning(result);
                }
                
            },
            error: function (err) {
                MessageError("Xóa thất bại!\n" + err.responseText.split('\n')[0]);
            }
        });
    }
}