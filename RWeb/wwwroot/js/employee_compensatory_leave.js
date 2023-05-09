
const months = ["Tháng 1 /", "Tháng 2 /", "Tháng 3 /", "Tháng 4 /", "Tháng 5 /", "Tháng 6 /", "Tháng 7 /", "Tháng 8 /", "Tháng 9 /", "Tháng 10 /", "Tháng 11 /", "Tháng 12 /"];
let c_date = new Date();

$(document).ready(function () {

    GetEmployeeCompensatoryLeaveByMonth();

    $('#month_schedule_work').change(function () {
        GetEmployeeCompensatoryLeaveByMonth();
    });
    $('#year_schedule_work').change(function () {
        GetEmployeeCompensatoryLeaveByMonth();
    });

    $('#btn_load_data_schedule_work').click(function () {
        GetEmployeeCompensatoryLeaveByMonth();
    })
});

//Render lịch
function renderCalendar(m, y, dateRegister) {
    //Month's first weekday
    let firstDay = new Date(y, m, 1).getDay();
    //Days in Month
    let d_m = new Date(y, m + 1, 0).getDate();
    //Days in Previous Month
    let d_pm = new Date(y, m, 0).getDate();


    let table = document.getElementById('dates');
    table.innerHTML = '';
    let s_m = document.getElementById('s_m');
    s_m.innerHTML = months[m] + ' ' + y;
    let date = 1;
    //remaining dates of last month
    let r_pm = (d_pm - firstDay) + 1;
    for (let i = 0; i < 6; i++) {
        let row = document.createElement('tr');
        for (let j = 0; j < 7; j++) {
            if (i === 0 && j < firstDay) {
                let cell = document.createElement('td');
                let span = document.createElement('span');
                let cellText = document.createTextNode(r_pm);
                span.classList.add('ntMonth');
                span.classList.add('prevMonth');
                cell.appendChild(span).appendChild(cellText);
                row.appendChild(cell);
                r_pm++;
            }
            else if (date > d_m && j < 7) {
                if (j !== 0) {
                    let i = 0;
                    for (let k = j; k < 7; k++) {
                        i++
                        let cell = document.createElement('td');
                        let span = document.createElement('span');
                        let cellText = document.createTextNode(i);
                        span.classList.add('ntMonth');
                        span.classList.add('nextMonth');
                        cell.appendChild(span).appendChild(cellText);
                        cell.addEventListener("click", showEvent);
                        row.appendChild(cell);
                    };
                }
                break;
            }
            else {
                let cell = document.createElement('td');
                let span = document.createElement('span');
                let cellText = document.createTextNode(date);
                span.classList.add('showEvent');
                cell.addEventListener("click", showEvent);
                if (date === c_date.getDate() && y === c_date.getFullYear() && m === c_date.getMonth()) {
                    cell.classList.add('bg-primary');
                }
                var find = dateRegister.indexOf(date);
                if (find != -1) {
                    cell.classList.add('bg-success');
                }
                cell.appendChild(span).appendChild(cellText);
                row.appendChild(cell);
                date++;
            }
        }
        table.appendChild(row);
    }
}

//Sự kiện khi click chọn ngày
function showEvent() {
    var year = $('#year_schedule_work').val();
    var month = $('#month_schedule_work').val();
    var day = $(this).text();

    var content = 'đăng ký'
    var date = new Date(year, month - 1, day);

    var className = $(this).attr('class');
    if (className == 'bg-success') {
        content = 'hủy đăng ký';
    }

    var ans = confirm("Bạn có muốn " + content + " nghỉ bù cho ngày " + getFormattedDateDMY(date) + " không?");
    if (ans) {
        var obj = {
            DateValue: getFormattedDateYMD(date),
        };
        Update(obj, $(this));

        if (className == 'bg-success') {
            $(this).removeClass('bg-success');
        } else {
            $(this).addClass('bg-success');
        }

    }
}

//Get đăng ký nghỉ bù theo tháng
function GetEmployeeCompensatoryLeaveByMonth() {
    var arrDate = [];
    var year = parseInt($('#year_schedule_work').val());
    var month = parseInt($('#month_schedule_work').val());
    $.ajax({
        url: _URL + 'EmployeeCompensatoryLeave/GetByMonth',
        type: 'GET',
        dataType: 'json',
        contentType: 'application/json;charset=utf-8',
        data: {
            month: month,
            year: year
        },
        success: function (result) {
            $.each(result, function (key, item) {
                arrDate.push(new Date(item.DateValue).getDate());
            })
            renderCalendar(month - 1, year, arrDate);
        },
        error: function (err) {
            MessageError(err);
        }
    });
}

//Đăng ký nghỉ bù
function Update(obj, tdclass) {
    $.ajax({
        url: _URL + 'EmployeeCompensatoryLeave/Update',
        type: 'POST',
        dataType: 'json',
        contentType: 'application/json;charset=utf-8',
        data: JSON.stringify(obj),
        success: function (result) {
            if (parseInt(result) == 1) {

                MessageSucces("Cập nhật ngày nghỉ bù thành công!");
            } else {
                MessageWarning(result);
                tdclass.removeClass('bg-success');
                return;
            }

        },
        error: function (err) {
            MessageError("Cập nhật ngày nghỉ bù thất bại! \n" + err);
        }
    });
}

//Sự kiện khi click next month
function onNext() {
    var year = parseInt($('#year_schedule_work').val());
    var month = parseInt($('#month_schedule_work').val());
    if (month == 12) {
        year += 1;
        month = 1;
    } else {
        month += 1;
    }

    $('#year_schedule_work').val(year);
    $('#month_schedule_work').val(month);
    GetEmployeeCompensatoryLeaveByMonth();
}

//Sự kiện khi click next month
function onPrev() {
    var year = parseInt($('#year_schedule_work').val());
    var month = parseInt($('#month_schedule_work').val());
    if (month == 1) {
        year -= 1;
        month = 12;
    } else {
        month -= 1;
    }

    $('#year_schedule_work').val(year);
    $('#month_schedule_work').val(month);
    GetEmployeeCompensatoryLeaveByMonth();
}