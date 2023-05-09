
var dataSourceWorkPlan = [];
var listProject = [];

var idNumber = 1;

$(document).ready(function () {
    GetAll();
    dataSourceWorkPlan = GetWorkPlan();
    listProject = GetAllProject();

    $('#modal_update_daily_report_technical').modal('show');

    $("#project_dailyreporttechnical_1").chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:",
    });

    //$('#tab_default').click();
});

//Get All project
function GetAllProject() {
    var project = [];

    $.ajax({
        url: _URL + 'DailyReportTechnicalNew/GetAllProject',
        type: 'GET',
        dataType: 'json',
        contentType: 'application/json',
        success: function (result) {
            $.each(result, function (key, item) {
                project.push(item);
            })

        },

        error: function () {
            MessageError("Error loading data! Please try again.");
        }
    });

    return project;
}

//Select tab
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


//Get báo cáo công việc
function GetAll() {
    $.ajax({
        url: _URL + 'DailyReportTechnicalNew/GetAll',
        type: 'GET',
        dataType: 'json',
        data: {
            dateStart: $('#date_start_drt_index').val(),
            dateEnd: $('#date_end_drt_index').val(),
            teamId: 0,
            keyword: '',
            userId: parseInt(1181),
            departmentId: parseInt(2)
        },
        contentType: 'application/json',
        success: function (result) {

            //$('#tbl_daily_report_technical').DataTable({
            //    data: result,
            //    columns: [
            //        { data: 'Id' },
            //        { data: 'UserReport' },
            //        { data: 'DateReport' },
            //        { data: 'Project' },
            //        { data: 'TotalHours' },
            //        { data: 'Content' },
            //        { data: 'Results' },
            //        { data: 'PlanNextDay' },
            //        { data: 'Backlog' },
            //        { data: 'Problem' },
            //        { data: 'ProblemSolve' },
            //        { data: 'Note' },
            //        { data: 'CreatedDate' },
            //        { data: 'Type' },
            //    ],
            //    responsive: true,
            //    fixedHeader: {
            //        header: true
            //    },
            //    fixedColumns: {
            //        left: 1,
            //    },
            //});
        },

        error: function () {
            MessageError("Error loading data! Please try again.");
        }
    })
}

//Check validate form
function Validate() {
    var dateReport = $('#datereport_dailyreporttechnical').val();
    if (dateReport == '') {
        MessageWarning("Vui lòng nhập Ngày báo cáo", 2000);
        $('#datereport_dailyreporttechnical').focus();
        $('#datereport_dailyreporttechnical').css("border-color", "#d13438");
        return false;
    }

    $("tr[id*='dailyreporttechnical_detail_']").each(function (i, el) {
        var id = $(this).attr('id');

        var projectId = $('#project_' + id).val();
        var totalHours = $('#totalhours_' + id).val();
        var content = $('#content_' + id).val();
        var status = $('#status_' + id).val();

        if (parseInt(projectId) <= 0) {
            MessageWarning("Vui lòng nhập Dự án!", 2000);
            $('#project_' + id).focus();
            $('#project_' + id + '_chosen').children().css("border-color", "#d13438");
            return false;
        }

        if (parseFloat(totalHours) <= 0 || parseFloat(totalHours) > 24) {
            MessageWarning("Vui lòng nhập Số giờ (lớn hơn 0 và nhỏ hơn 24)!", 2000);
            $('#totalhours_' + id).focus();
            $('#totalhours_' + id).css("border-color", "#d13438");
            return false;
        }

        if (content.trim() =='') {
            MessageWarning("Vui lòng nhập Nội dung công việc", 2000);
            $('#content_' + id).focus();
            $('#content_' + id).css("border-color", "#d13438");
            return false;
        }

        //if (parseInt(status) <= 0) {
        //    MessageWarning("Vui lòng nhập Kết quả", 2000);
        //    $('#status_' + id).focus();
        //    $('#status_' + id).css("border-color", "#d13438");
        //    return false;
        //}
    });

    return true;
}

//Get danh sách kế hoạch khi chọn ngày
function GetWorkPlan() {
    var dataSoure = [];

    $.ajax({
        url: _URL + 'DailyReportTechnicalNew/GetWorkPlanByDate',
        type: 'GET',
        dataType: 'json',
        data: {
            date: $('#datereport_dailyreporttechnical').val()
        },
        contentType: 'application/json',
        success: function (result) {
            $.each(result, function (key, item) {
                dataSoure.push(item);
            })

        },

        error: function () {
            MessageError("Error loading data! Please try again.");
        }
    });

    return dataSoure;
}

//Sự kiện khi click nút Add
function onChoseWorkContent() {
    if (!$.fn.DataTable.isDataTable('#tbl_chose_workplan')) {
        var table = $('#tbl_chose_workplan').DataTable({
            data: dataSourceWorkPlan,
            columns: [
                { data: 'ID' },
                { data: 'DateDay', },
                { data: 'WorkContent' },
                { data: 'Project' },
            ],

            'columnDefs': [{
                'targets': 0,
                'searchable': false,
                'orderable': false,
                'className': 'dt-body-center',
                'render': function (data, type, full, meta) {
                    return '<input type="checkbox" name="idWorkPlanChose[]" value="' + $('<div/>').text(data).html() + '">';
                }
            },
            {
                targets: 1,
                render: $.fn.dataTable.render.moment('Do MMM YYYY')
            }
            ],
            'order': [1, 'asc'],

            responsive: true,
            fixedHeader: {
                header: true
            }
        });

        // Handle click on "Select all" control
        $('#example-select-all').on('click', function () {
            // Check/uncheck all checkboxes in the table
            var rows = table.rows({ 'search': 'applied' }).nodes();
            $('input[type="checkbox"]', rows).prop('checked', this.checked);
        });

        // Handle click on checkbox to set state of "Select all" control
        $('#tbl_chose_workplan tbody').on('change', 'input[type="checkbox"]', function () {
            // If checkbox is not checked
            if (!this.checked) {
                var el = $('#example-select-all').get(0);
                // If "Select all" control is checked and has 'indeterminate' property
                if (el && el.checked && ('indeterminate' in el)) {
                    // Set visual state of "Select all" control 
                    // as 'indeterminate'
                    el.indeterminate = true;
                }
            }
        });
    }
}

//Sau khi click nút chọn kế hoạch công việc
function ChoseWorkContentProcess() {

    var arrId = [];

    if ($('input[id*="workplanid_dailyreporttechnical_"]').val() != undefined) {
        $('input[id*="workplanid_dailyreporttechnical_"]').each(function (i, e) {
            arrId.push(parseInt($(this).val()));
        });
    }

    $("input[name='idWorkPlanChose[]']").each(function (i, el) {
        if ($(this).is(':checked')) {
            var idChose = parseInt($(this).val());

            var obj = dataSourceWorkPlan.find(x => x.ID == idChose);
            AddHtml(idChose, 'disabled', arrId, obj);

        }
    });

    $('#modal_table_workplan').modal('hide');
}

//Thêm công việc phát sinh
function onAdd() {
    AddHtml(0, '', new Array, new Object);
}

//Sự kiện khi click nút xóa 1 dòng báo cáo công việc
function Remove(idName) {
    var valueChecked = idName.split('_')[idName.split('_').length - 1];

    $('#' + idName).remove();
    $("input[name='idWorkPlanChose[]'][value='" + valueChecked + "']").prop('checked', false);
}

//Append HTML vào bảng
function AddHtml(idIndex, attribute, arrIdChose, obj) {

    var idWorkPlan = 0;
    var workContent = '';
    var matchValue = arrIdChose.find(element => element == idIndex);
    if (idIndex == matchValue) {
        return;
    }

    if (idIndex == 0) {
        idIndex = 'add_' + idNumber;
    } else {
        idWorkPlan = idIndex;
        workContent = obj.WorkContent;
    }

    var html = '';

    var trId = 'dailyreporttechnical_detail_' + idIndex;
    var selectProjectId = 'project_dailyreporttechnical_detail_' + idIndex;
    var inputTotalhourId = 'totalhours_dailyreporttechnical_detail_' + idIndex;
    var inputWorkplanId = 'workplanid_dailyreporttechnical_detail_' + idIndex;
    var inputContentId = 'content_dailyreporttechnical_detail_' + idIndex;
    var selectStatusId = 'status_dailyreporttechnical_detail_' + idIndex;
    var inputProplemId = 'problem_dailyreporttechnical_detail_' + idIndex;
    var inputProplemsolveId = 'problemsolve_dailyreporttechnical_detail_' + idIndex;

    var paramRemove = "'" + trId + "'";

    html += '<tr id="' + trId + '" class="daily-reporttechnical-detail">';
    html += '<td scope="row"><button class="btn btn-danger btn-sm" onclick="return Remove(' + paramRemove + ');"><i class="fas fa-trash"></i></button></td>';
    html += '<td class="text-left"><select class="form-control" id="' + selectProjectId + '" ' + attribute + '><option value="0">-- Chọn dự án --</option></select></td>';
    html += '<td class="text-right"><input type="number" step=".5" id="' + inputTotalhourId + '" class="form-control form-control-sm" min="0" max="24" value="8" /></td>';
    html += '<td class="text-right" style="display:none;"><input type="number" id="' + inputWorkplanId + '" class="form-control form-control-sm" value="' + idWorkPlan + '" /></td>';
    html += '<td class="text-left"><textarea id="' + inputContentId + '" class="form-control-text-area rounded">' + workContent + '</textarea></td>';

    html += '<td class="text-left">';
    html += '<select class="form-control" id="' + selectStatusId + '">';
    html += '<option value="1">Chưa hoàn thành</option>';
    html += '<option value="2">Đã hoàn thành</option>';
    html += '<option value="3">Pending</option>';
    html += '<option value="4">Hủy bỏ</option>';
    html += '</select>';
    html += '</td>';

    html += '<td class="text-left"><textarea id="' + inputProplemId + '" class="form-control-text-area rounded"></textarea></td>';
    html += '<td class="text-left"><textarea id="' + inputProplemsolveId + '" class="form-control-text-area rounded"></textarea></td>';
    html += '</tr>';

    if (matchValue == undefined) {
        $('#tbody_dailyreporttechnical').append(html);
    }

    //Sự kiện khi thay đổi số giờ
    $('#' + inputTotalhourId).on('input', function () {
        if ($(this).val().trim() != '') {
            $(this).css("border-color", "#e4e6fc");
        }
    });

    //Sự kiện khi thay đổi số giờ
    $('#' + inputContentId).on('input', function () {
        if ($(this).val().trim() != '') {
            $(this).css("border-color", "#e4e6fc");
        }
    });

    //Sự kiện thay đổi dự án
    $('#' + selectProjectId).change(function () {
        if ($(this).val().trim() != '') {
            $('#' + selectProjectId + '_chosen').children().css("border-color", "#ccc");
        }
    })


    //Add list project select
    $.each(listProject, function (key, item) {
        $('#' + selectProjectId).append($('<option>', {
            value: item.Id,
            text: item.Project
        }));
    });

    //Add js chosen jquery
    $("#" + selectProjectId).chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:",
    });

    //Set value
    var valueSelected = obj.ProjectID == undefined ? 0 : obj.ProjectID;

    $('#' + selectProjectId).val(valueSelected).trigger("chosen:updated");

    idNumber++;
}

//Get nội dung báo cáo
function GetContentReport() {

    var arrContentReport = [];
    $("tr[id*='dailyreporttechnical_detail_']").each(function (i, el) {
        var id = $(this).attr('id');

        var projectId = $('#project_'+ id).val();
        var totalHours = $('#totalhours_' + id).val();
        var workplanId = $('#workplanid_' + id).val();
        var content = $('#content_' + id).val();
        var status = $('#status_' + id).val();
        var problem = $('#problem_' + id).val();
        var problemSolve = $('#problemsolve_' + id).val();

        var projectText = $('#project_' + id + ' option:selected').text();
        var statusText = $('#status_' + id + ' option:selected').text();

        var obj = {
            ProjectId: parseInt(projectId),
            TotalHours: parseFloat(totalHours),
            WorkPlanId: workplanId,
            Content: content,
            Status: parseInt(status),
            Problem: problem,
            ProblemSolve: problemSolve,
            ProjectText: projectText,
            StatusText:statusText
        };

        arrContentReport.push(obj);
    });

    return arrContentReport;
}

//Create báo cáo công việc master
function CreateMaster() {
    var obj = {
        Type: parseInt($("input:radio[name ='type']:checked").val()),
        UserReport: parseInt($('#userreport_dailyreporttechnical').val()),
        DateReport: $('#datereport_dailyreporttechnical').val(),
    };

    if (Validate()) {
        var arrContentReport = GetContentReport();

        $.ajax({
            url: _URL + 'DailyReportTechnicalNew/CreateMaster',
            type: 'POST',
            dataType: 'json',
            data: JSON.stringify(obj),
            contentType: 'application/json',
            success: function (result) {
                if (result > 0) {
                    CreateDetail(result, arrContentReport);
                }
            },

            error: function () {
                MessageError("Thêm thất bại!");
            }
        })
        
    }

    
    
}

//Create báo cáo chi tiết
function CreateDetail(masterId, array) {

    $.each(array, function (key, item) {
        var obj = {
            MasterId: masterId,
            ProjectId: item.ProjectId,
            TotalHours: item.TotalHours,
            Content: item.Content,
            StatusResult: item.Status,
            Problem: item.Problem,
            ProblemSolve: item.ProblemSolve,

        };

        $.ajax({
            url: _URL + 'DailyReportTechnicalNew/Create',
            type: 'POST',
            dataType: 'json',
            data: JSON.stringify(obj),
            contentType: 'application/json',
            success: function (result) {
                MessageSucces("Thêm thành công!");
                GetAll();
                $('#modal_update_daily_report_technical').modal('hide');
            },

            error: function () {
                MessageError("Thêm thất bại!");
            }
        })
    })
    
}

//Tổng hợp báo báo cáo theo format
function SummaryReport() {
    $('#modal_summary_dailyreporttechnical').modal('show');
    var data = GetContentReport();
    var summaryReport = '';

    var dateReport = $('#datereport_dailyreporttechnical').val();
    var project = '';
    var content = '';
    var result = data.map(x => x.StatusText).join('\n');
    var proplem = data.map(x => x.Problem).join('\n').trim();
    var proplemSolve = data.map(x => x.ProblemSolve).join('\n').trim();
    var planeNextDay = 'aa';


    project = [...new Set(data.map(item => item.ProjectText))].join('\n');
    var projectId = [...new Set(data.map(item => item.ProjectId))];
    $.each(projectId, function (key, item) {
        var matchObj = data.filter(x => x.ProjectId == item);


        content += item + '\n';
        $.each(matchObj, function (i, val) {
            if (val.ProjectId == item) {

                content += val.Content + '\n';
                //console.log(item, val.Content);
            }
        })

        //console.log(matchObj);
    })

    summaryReport += 'BÁO CÁO CÔNG VIỆC NGÀY ' + getFormattedDateDMY(dateReport);

    summaryReport += '\n* Mã dự án - Tên dự án:\n';
    summaryReport += project;

    summaryReport += '\n* Nội dung công việc:\n';
    summaryReport += content;

    summaryReport += '\n* Kết quả công việc:\n';
    summaryReport += result;

    summaryReport += "\n* Vấn đề phát sinh:\n";
    summaryReport += proplem;

    summaryReport += "\n* Giải pháp cho vấn đề phát sinh:\n";
    summaryReport += proplemSolve;

    summaryReport += '\n* Kế hoạch ngày tiếp theo:\n';
    summaryReport += planeNextDay;

    console.log(summaryReport);

    $('#summary_dailyreporttechnical').val(summaryReport);
}