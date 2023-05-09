////alert(_URL);
var data = [];
$(document).ready(function () {
    GetAllDate();
    //$('#tab_default').click();

    $('#month_schedule_work').change(function () {
        GetAllDate();
    });
    $('#year_schedule_work').change(function () {
        GetAllDate();
    });

    $('#btn_load_data_schedule_work').click(function () {
        GetAllDate();
    });

    $('#tab_default').click();
});

//Sự kiện chọn tab
function SelectTab(evt, idName) {
    // Declare all variables
    var i, tabcontent, tablinks;

    // Get all elements with class="tabcontent" and hide them
    tabcontent = document.getElementsByClassName("tabcontent");
    for (i = 0; i < tabcontent.length; i++) {
        tabcontent[i].style.display = "none";
    }

    // Get all elements with class="tablinks" and remove the class "active"
    tablinks = document.getElementsByClassName("tablinks");
    for (i = 0; i < tablinks.length; i++) {
        tablinks[i].className = tablinks[i].className.replace(" active", "");
    }

    // Show the current tab, and add an "active" class to the button that opened the tab
    document.getElementById(idName).style.display = "block";
    evt.currentTarget.className += " active";
}

//Get All project
function GetAllDate() {
    var html = '';

    $.ajax({
        url: _URL + 'EmployeeScheduleWork/GetAllDate',
        type: 'GET',
        data: {
            year: parseInt($('#year_schedule_work').val()),
            month: parseInt($('#month_schedule_work').val())
        },
        dataType: 'json',
        contentType: 'application/json',
        success: function (result) {
            data = result;
            $.each(result, function (key, item) {

                var checked = item.Status == true ? 'checked' : '';
                html += '<tr id = "saturday_date_schedule_' + (key + 1) + '" onclick="return onSelect(event);">';
                html += '<td><input id="status_date_schedule_' + (key + 1) + '" type="checkbox" value="true" onclick="return onSelect(event);" ' + checked + '/></td>';
                html += '<td style="display:none;"><input id="id_date_schedule_' + (key + 1) + '" value="' + item.Id + '" disabled/></td>';
                html += '<td id="value_date_schedule_' + (key + 1) + '">' + getFormattedDateDMY(item.DateValue) + '</td>'
                html += '</tr>';
            });

            $('#tbody_schedule_all_date_saturday').html(html);
        },

        error: function () {
            MessageError("Error loading data! Please try again.");
        }
    });
}

//Sự kiện khi click dòng
function onSelect(event) {

    if ($(event.target).attr('type') == 'checkbox') {
        if ($(event.target).is(":checked")) {
            $($(event.target).parent()).parent().css("background-color", 'yellow');
        } else {
            $($(event.target).parent()).parent().css("background-color", '#fff');
        }
    } else {
        var element = $(event.target).parent().children()[0];

        var checkbox = $(element).children();

        var isCheck = checkbox.is(":checked");
        $(checkbox).prop("checked", !isCheck);

        if (checkbox.is(":checked")) {
            $(event.target).parent().css("background-color", 'yellow');
        } else {
            $(event.target).parent().css("background-color", '#fff');
        }
    }
}

//Sự kiện khi click nút thêm mới
function onUpdateSchedule() {

    var matchValue = data.filter(x => x.Id > 0);
    if (matchValue.length <= 0) {
        //Thêm mới
        $('#btn_update_schedule_work').hide();
        $('#btn_create_schedule_work').show();

    } else {
        //Update
        $('#btn_update_schedule_work').show();
        $('#btn_create_schedule_work').hide();
    }

}

//Cập nhật lịch làm việc
function UpdateSchedule(method) {
    var arr = [];
    $('tr[id*=saturday_date_schedule_]').each(function (i, el) {
        var id = $(this).attr('id');

        var idNumber = id[id.length - 1];

        var status = $('#status_date_schedule_' + idNumber).is(":checked") ? true : false;
        var idSchedule = $('#id_date_schedule_' + idNumber).val();
        var dateValue = $('#value_date_schedule_' + idNumber).text();

        var obj = {
            Status: status,
            Id: parseInt(idSchedule),
            DateValue: ChangeFormatDate(dateValue)
        };

        arr.push(obj);
    });

    var matchValue = arr.filter(x => x.Status == true);

    if (matchValue.length == 0) {
        MessageWarning("Bạn phải chọn ít nhất 1 ngày!");
    } else {
        $.each(arr, function (key, item) {

            $.ajax({
                url: _URL + 'EmployeeScheduleWork/' + method,
                type: 'POST',
                dataType: 'json',
                contentType: 'application/json;charset=utf-8',
                data: JSON.stringify(item),
                success: function (result) {
                    if (parseInt(result) == 1) {
                        MessageSucces("Cập nhật thành công!");
                        $('#modal_update_schedule_work').modal('hide');
                        GetAllDate();
                    } else {
                        MessageWarning(result);
                    }
                },
                error: function (err) {
                    MessageError("Cập nhật thất bại! \n" + err);
                }
            });
        })
    }
}

//Đổi định dạng ngày sang yyyy-MM-dd
function ChangeFormatDate(value) {
    var dateArr = value.split('/');
    var newDate = dateArr[2] + '-' + dateArr[1] + '-' + dateArr[0];
    return newDate;
}