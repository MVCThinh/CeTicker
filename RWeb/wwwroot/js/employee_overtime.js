
var idNumber = 2;
var arrTypeOvertime = [];


$(document).ready(function () {

    onChangeDateRegister();

    GetTypeOvertime();

    //Update chosen chọn người duyệt
    $("#approvedtp_employee_overtime_bussiness").chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:"
    });
});

//Get danh sách kiểu làm thêm
function GetTypeOvertime() {
    $.ajax({
        url: '/EmployeeOvertime/GetAllTypeOvertime',
        type: 'GET',
        dataType: 'json',
        contentType: 'application/json;charset=utf-8',
        success: function (result) {
            arrTypeOvertime = result;
        },
        error: function (err) {
            MessageError(err.responseText);
        }
    });
}

//Add nghỉ thêm
function AddHtml() {
    var html = `<div class="row mx-0 bg-whitesmoke mb-3" id="employee__overtime__${idNumber}" style="margin-top:-10px;">
                    <div class="form-group col-12 col-md-2 col-lg-2 mb-1">
                        <a class="text-danger" onclick="return RemoveHtml('#employee__overtime__${idNumber}')" style="cursor:pointer;">
                            <i class="fas fa-times m-0"></i>
                        </a>
                        <label class="mb-0">Từ<span style="color:red;"> (*)</span></label>
                        <input type="text" id="time_start_employee_overtime_${idNumber}" class="form-control form-control-sm">
                    </div>
                    <div class="form-group col-12 col-md-2 col-lg-2 mb-1">
                        <label class="mb-0">Đến<span style="color:red;"> (*)</span></label>
                        <input type="text" id="time_end_employee_overtime_${idNumber}" class="form-control form-control-sm">
                    </div>
                    <div class="form-group col-12 col-md-2 col-lg-2 mb-1">
                        <label class="mb-0">Địa điểm<span style="color:red;"> (*)</span></label>
                        <select id="location_employee_overtime_${idNumber}" class="form-control mb-0 p-0" style="height: 31px !important;">
                            <option value="1">Văn phòng</option>
                            <option value="2">Địa điểm công tác</option>
                            <option value="3">Tại nhà</option>
                        </select>
                    </div>

                    <div class="form-group col-12 col-md-2 col-lg-2 mb-1">
                        <label class="mb-0">Phụ cấp</label>
                        <div class="form-control form-control-sm custom-checkbox">
                            <div class="big-account-check" style="margin-left:20px;">
                                <input type="checkbox" class="custom-control-input" id="overnight_employee_overtime_${idNumber}" onclick="return onClickOvernigh('#overnight_employee_overtime_${idNumber}','#time_end_employee_overtime_${idNumber}');"/>
                                <label class="custom-control-label" for="overnight_employee_overtime_${idNumber}">Phụ cấp ăn tối</label>
                            </div>
                        </div>
                    </div>

                    <div class="form-group col-12 col-md-2 col-lg-2 mb-1">
                        <label class="mb-0">Loại<span style="color:red;"> (*)</span></label>
                        <select id="type_employee_overtime_${idNumber}" class="form-control p-0" style="height: 31px !important;">
                            <option value="0">--Chọn kiểu làm thêm--</option>
                        </select>
                    </div>
                    <div class="form-group col-12 col-md-2 col-lg-2 mb-1">
                        <label class="mb-0">Lý do <span style="color:red;"> (*)</span></label>
                        <p contenteditable="true" id="reason_employee_overtime_${idNumber}" class="m-0 p-1" style="outline:none; border: 1px solid #e4e6fc; border-radius: 0.2rem;min-height: 31px;line-height:20px;"></p>
                    </div>
                </div>`;

    //Insert html mới lên đầu
    $('#employee_overtime').prepend(html);

    //Sự kiện đổi ngày đăng ký
    onChangeDateRegister();

    //Add combot kiểu làm thêm
    var htmlCombo = '<option value="0">--Chọn kiểu làm thêm--</option>';
    $.each(arrTypeOvertime, function (key, item) {
        htmlCombo += `<option value="${item.Id}">${item.Type}</option>`;
    });
    $('#type_employee_overtime_' + idNumber).html(htmlCombo);


    //Cộng stt của id thêm 1
    idNumber++;
}

//Xóa chi tiết khai bao làm thêm
function RemoveHtml(id) {

    var number = id.split('_')[id.split('_').length - 1];

    var datestart = $('#time_start_employee_overtime_' + number).val();
    var dateend = $('#time_end_employee_overtime_' + number).val();

    var confirmtext = 'Bạn có chắc muốn xóa khai báo làm thêm\n';
    confirmtext += `từ: ${moment(datestart).format("DD/MM/YYYY HH:mm")}\n`;
    confirmtext += `đến: ${moment(dateend).format("DD/MM/YYYY HH:mm")}\nkhông?`;

    var ans = confirm(confirmtext);
    if (ans) {
        $(id).remove();
    }
}

//Sự kiện khi đổi ngày đăng ký
function onChangeDateRegister() {

    var dateRegister = new Date($('#date_register_overtime_bussiness').val());

    var minDate = new Date($('#date_register_overtime_bussiness').val());
    var maxDate = new Date(dateRegister.setDate(dateRegister.getDate() + 1));

    $('input[id^="time_start_employee_overtime_"]').each(function (i, el) {

        var hourStart = new Date($(this).val()).getHours();
        var minuteStart = new Date($(this).val()).getMinutes();

        hourStart = hourStart < 10 ? '0' + hourStart : hourStart;
        minuteStart = minuteStart < 10 ? '0' + minuteStart : minuteStart;

        if ($(this).val() == '') {
            hourStart = '18';
            minuteStart = '00';
        } else {
            var startTime = new Date($(this).val());
            hourEnd = startTime.getHours() < 10 ? '0' + startTime.getHours() : startTime.getHours();
            minuteEnd = startTime.getMinutes() < 10 ? '0' + startTime.getMinutes() : startTime.getMinutes();
        }
        var valueTimeStart = `${moment(minDate).format("DD/MM/YYYY")}T${hourStart}:${minuteStart}`;
        $(this).val(valueTimeStart);

        //$(this).prop("min", `${moment(minDate).format("YYYY-MM-DD")}T00:00`);
        //$(this).prop("max", `${moment(maxDate).format("YYYY-MM-DD")}T00:00`);

        //Update datetime picker thời gian kết thúc
        flatpickr(this, {
            enableTime: true,
            noCalendar: false,
            time_24hr: true,
            dateFormat: "d/m/Y H:i",
            minDate: moment(minDate).format("DD/MM/YYYY"),
            maxDate: moment(maxDate).format("DD/MM/YYYY"),
        });
    });


    $('input[id^="time_end_employee_overtime_"]').each(function (i, el) {
        var date = new Date();

        var hourEnd = date.getHours() >= 10 ? date.getHours() : '0' + date.getHours();
        var minuteEnd = date.getMinutes() >= 10 ? date.getMinutes() : '0' + date.getMinutes();

        if ($(this).val() != '') {
            var endTime = new Date($(this).val());
            hourEnd = endTime.getHours() < 10 ? '0' + endTime.getHours() : endTime.getHours();
            minuteEnd = endTime.getMinutes() < 10 ? '0' + endTime.getMinutes() : endTime.getMinutes();
        }

        var valueTimeEnd = `${moment(minDate).format("DD/MM/YYYY")} ${hourEnd}:${minuteEnd}`;
        $(this).val(valueTimeEnd);

        //$(this).prop("min", `${moment(minDate).format("YYYY-MM-DD")}T00:00`);
        //$(this).prop("max", `${moment(maxDate).format("YYYY-MM-DD")}T00:00`);

        //Update datetime picker thời gian kết thúc
        flatpickr(this, {
            enableTime: true,
            noCalendar: false,
            time_24hr: true,
            dateFormat: "d/m/Y H:i",
            minDate: moment(minDate).format("DD/MM/YYYY"),
            maxDate: moment(maxDate).format("DD/MM/YYYY"),
        });
    });
}


//Sự kiện khi click nút thêm mới
function onAdd() {

    var arrOvertime = [];

    if (CheckValidate() == 1) {

        $('div[id*="employee__overtime__"]').each(function () {

            var id = $(this).attr('id');
            var numberId = id.substring(id.lastIndexOf('_') + 1);
            
            var obj = {
                ApprovedId: parseInt($('#approvedtp_employee_overtime_bussiness').val()),
                DateRegister: $('#date_register_overtime_bussiness').val(),

                TimeStart: $(`#time_start_employee_overtime_${numberId}`).val(),
                EndTime: $(`#time_end_employee_overtime_${numberId}`).val(),
                Location: parseInt($(`#location_employee_overtime_${numberId}`).val()),
                Overnight: $(`#overnight_employee_overtime_${numberId}`).is(":checked") ? true : false,
                TypeId: parseInt($(`#type_employee_overtime_${numberId}`).val()),
                Reason: $(`#reason_employee_overtime_${numberId}`).text(),
            };

            var matchValue = arrOvertime.find(x => (x.TimeStart <= obj.TimeStart && x.EndTime >= obj.TimeStart) || (x.TimeStart <= obj.EndTime && x.EndTime >= obj.EndTime));


            arrOvertime.push(obj);

            
        });
        console.log(arrOvertime);
    }
}

//Check validate làm thêm
function CheckValidate() {

    var result = 1;
    var countDinner = [];
    var approveId = $('#approvedtp_employee_overtime_bussiness').val();
    var dateRegister = $('#date_register_overtime_bussiness').val();

    if (parseInt(approveId) <= 0) {
        MessageWarning("Vui lòng nhập Người duyệt!");
        result = 0;
    }

    if (dateRegister == '') {
        MessageWarning("Vui lòng nhập Ngày!");
        result = 0;
    }

    $('div[id*="employee__overtime__"]').each(function () {

        var id = $(this).attr('id');
        var numberId = id.substring(id.lastIndexOf('_') + 1);

        var timeStart = $(`#time_start_employee_overtime_${numberId}`).val();
        var endTime = $(`#time_end_employee_overtime_${numberId}`).val();
        
        var overnight = $(`#overnight_employee_overtime_${numberId}`).is(":checked") ? true : false;
        var typeId = parseInt($(`#type_employee_overtime_${numberId}`).val());
        var reason = $(`#reason_employee_overtime_${numberId}`).text();

        if (overnight) {
            countDinner.push(overnight);
        }

        if (timeStart == '') {
            MessageWarning("Vui lòng nhập Thời gian bắt đầu!");
            $(`#time_start_employee_overtime_${numberId}`).addClass('border border-danger');
            result = 0;
        } 

        if (endTime == '') {
            MessageWarning("Vui lòng nhập Thời gian kết thúc!");
            $(`#time_end_employee_overtime_${numberId}`).addClass('border border-danger');
            result = 0;
        }

        if (typeId <= 0) {
            MessageWarning("Vui lòng nhập Loại!");
            $(`#type_employee_overtime_${numberId}`).addClass('border border-danger');
            result = 0;
        } 

        if (reason == '') {
            MessageWarning("Vui lòng nhập Lý do!");
            $(`#reason_employee_overtime_${numberId}`).addClass('border border-danger');
            result = 0;
        }

    });

    if (countDinner.length > 0) {
        MessageWarning("Bạn không thể chọn nhiều phụ cấp trong 1 ngày.\nVui lòng kiểm tra lại!");
        result = 0;
    }

    return result;
}


//Sự kiện khi click chọn phụ cấp
function onClickOvernigh(id, idEndtime) {

    var totalChecked = 0;

    if ($(id).is(":checked")) {

        var date = $('#date_register_overtime_bussiness').val();

        var endTime = new Date($(idEndtime).val());

        if (endTime.getHours() < 20) {
            MessageWarning(`Bạn không thể chọn phụ cấp ăn tối trước 20h.\nVui lòng kiểm tra lại!`);
            $(id).prop('checked', false);
        } else {
            //Check trong db đã có dữ liệu chưa
            $.ajax({
                url: '/EmployeeOvertimeAndBussiness/GetTotalDinner',
                type: 'GET',
                dataType: 'json',
                contentType: 'application/json;charset=utf-8',
                data: {
                    date: $('#date_register_overtime_bussiness').val()
                },
                success: function (result) {

                    if (parseInt(result) > 0) {
                        MessageWarning(`Bạn đã chọn phụ cấp ăn tối cho ngày ${moment(date).format("DD/MM/YYYY")}.\nVui lòng kiểm tra lại!`);
                        $(id).prop('checked', false);
                    } else {

                        //Check ko đc click chọn 2 lần phụ cấp
                        $('div[id*="employee__overtime__"]').each(function () {

                            var id = $(this).attr('id');
                            var numberId = id.substring(id.lastIndexOf('_') + 1);

                            var overnight = $(`#overnight_employee_overtime_${numberId}`).is(":checked") ? 1 : 0;
                            totalChecked += overnight;
                        });

                        if (totalChecked > 1) {
                            MessageWarning(`Bạn không thể chọn phụ cấp 2 lần cho 1 ngày.\nVui lòng kiểm tra lại!`);
                            $(id).prop('checked', false);
                        }
                    }

                },
                error: function (err) {
                    MessageError(err.responseText);
                }
            });
        }
    }

    
}