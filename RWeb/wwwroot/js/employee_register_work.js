
$(document).ready(function () {
    GetRegisterWork();

    $('#month_schedule_work').change(function () {
        GetRegisterWork();
    });

    $('#year_schedule_work').change(function () {
        GetRegisterWork();
    });

    $('#btn_load_data_schedule_work').click(function () {
        GetRegisterWork();
    });


});

//Get danh sách đăng ký làm việc thứ bảy
function GetRegisterWork() {
    var htmlRegister = '';
    var htmlIndex = '';

    $.ajax({
        url: _URL + 'EmployeeRegisterWork/GetRegisterWork',
        type: 'GET',
        data: {
            year: parseInt($('#year_schedule_work').val()),
            month: parseInt($('#month_schedule_work').val())
        },
        dataType: 'json',
        contentType: 'application/json',
        success: function (result) {

            $.each(result, function (key, item) {

                var style = item.Status == true ? 'style="background-color: #bdbdbd; col' : '';
                var textStyle = item.Status == true ? 'font-weight-bold' : 'text-danger font-weight-bold';
                var checked = item.ID > 0 ? 'checked' : '';

                htmlRegister += '<tr id="employee_register_work_' + (key + 1) + '" ' + style + '>';
                htmlRegister += '<td style="display:none;"><input type="number" id="id_register_work_' + (key + 1) + '" value="' + item.ID + '" disabled/></td>';
                htmlRegister += '<td style="display:none;"><input type="number" id="id_schedule_work_' + (key + 1) + '" value="' + item.SchuduldeID + '" disabled/></td>';
                htmlRegister += '<td onclick="return onSelect(event);"><input onclick="return onSelect(event);" type="checkbox" id="check_register_work_' + (key + 1) + '" ' + checked + '/></td>';
                htmlRegister += '<td><input type="date" id="date_register_work_' + (key + 1) + '" class="form-control" disabled value="' + getFormattedDateYMD(item.ScheduleDate) + '" /></td>';
                htmlRegister += '<td style="display:none;"><input type="text" id="status_schedule_work_' + (key + 1) + '" value="' + item.Status + '" disabled/></td>';
                htmlRegister += '<td class = "' + textStyle + '">' + item.StatusText + '</td>';
                htmlRegister += '</tr>';

                var isApprovedClass = item.IsApproved == true ? 'text-success' : 'text-danger';
                var statusClass = item.Status == true ? 'text-success' : 'text-danger';
                var register = item.ID > 0 ? '<i class="fa fa-check fa-2x text-success"></i>' : '<i class="fa fa-times fa-2x text-danger"></i>';

                htmlIndex += '<tr>';
                htmlIndex += '<td class="' + isApprovedClass + '">' + item.IsApprovedText + '</td>';
                htmlIndex += '<td>' + getFormattedDateDMY(item.ScheduleDate) + '</td>';
                htmlIndex += '<td class="' + statusClass + '">' + item.StatusText + '</td>';
                htmlIndex += '<td>' + register + '</td>';
                htmlIndex += '</tr>';
            });

            $('#tbody_employee_register_work').html(htmlRegister);
            $('#tbody_schedule_work').html(htmlIndex);
        },

        error: function () {
            MessageError("Error loading data! Please try again.");
        }
    });
}

//Sự kiện khi click dòng
function onSelect(event) {
    var element = $(event.target);

    var idName = $(element).children().length == 0 ? element.attr('id') : $($(element).children()).attr('id');
    var idNumber = idName.split('_')[idName.split('_').length - 1]

    var status = $('#status_schedule_work_' + idNumber).val();
    var dateValue = new Date($('#date_register_work_' + idNumber).val());
    var datenow = new Date();

    if (datenow > dateValue) {
        MessageWarning("Bạn không thể đăng ký làm ngày: " + getFormattedDateDMY(dateValue));
        return;
    }


    if (status == 'true') {
        MessageWarning("Bạn không thể đăng ký làm ngày: " + getFormattedDateDMY(dateValue));
        return;
    }

    if (element.attr('type') == 'checkbox') {
        if ($(event.target).is(":checked")) {
            $($(event.target).parent()).parent().css("background-color", 'yellow');
        } else {
            $($(event.target).parent()).parent().css("background-color", '#fff');
        }
    } else {
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

//Update đăng ký làm việc
function UpdateRegisterWork() {
    $('tr[id*="employee_register_work_"]').each(function (i, el) {
        var idName = $(this).attr('id');
        var idNumber = idName.split('_')[idName.split('_').length - 1];

        var id = $('#id_register_work_' + idNumber).val();
        var dateValue = $('#date_register_work_' + idNumber).val();
        var scheduleId = $('#id_schedule_work_' + idNumber).val();
        var checked = $('#check_register_work_' + idNumber).is(":checked");
        var obj = {
            Id: parseInt(id),
            EmployeeScheduleWorkId: parseInt(scheduleId),
            DateValue: getFormattedDateYMD(dateValue),
            checked: checked
        }

        if (obj.Id > 0 && !obj.checked) {
            //console.log('update', obj);
            $.ajax({
                url: _URL + 'EmployeeRegisterWork/Update',
                type: 'POST',
                dataType: 'json',
                contentType: 'application/json;charset=utf-8',
                data: JSON.stringify(obj),
                success: function (result) {
                    if (result == 1) {
                        MessageSucces("Cập nhật thành công!");
                    } else {
                        MessageError(result);
                    }

                    //$('#modal_update_schedule_work').modal('hide');
                    GetRegisterWork();
                },
                error: function (err) {
                    MessageError("Cập nhật thất bại! \n" + err);
                }
            });
        }
        if (obj.Id <= 0 && obj.checked) {
            //console.log('insert', obj);
            $.ajax({
                url: _URL + 'EmployeeRegisterWork/Create',
                type: 'POST',
                dataType: 'json',
                contentType: 'application/json;charset=utf-8',
                data: JSON.stringify(obj),
                success: function (result) {
                    MessageSucces("Cập nhật thành công!");
                    //$('#modal_update_schedule_work').modal('hide');
                    GetRegisterWork();
                },
                error: function (err) {
                    MessageError("Cập nhật thất bại! \n" + err);
                }
            });
        }
    })
}