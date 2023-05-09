var idIndex = 2;
var listProject = [];

$(document).ready(function () {
    ChangeStartDate();
    ChangeEndDate();
    GetWorkPlan(1);

    $('#modal_update_workplan').modal("show");

    //AutoResizeTextArea();
    GetProjectWorkPlan();

    //Add js chosen jquery
    $("#project_workplan_detail_1").chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:"
    });

    $(this).keydown(function (e) {
        if ($('#modal_update_workplan').is(':visible')) {

            if (e.which == 9) {
                var stringCompare = 'location_workplan_detail_';

                var focused = document.activeElement.getAttribute('id');

                if (focused.length <= stringCompare.length) {
                    return;
                } else {
                    focused = focused.substr(0, stringCompare.length);
                    if (focused == stringCompare) {
                        AddHtml();
                    }
                }
            }
        } else {
            //alert('modal hide')
        }
        
    })
})

//Tự động thay đổi kích thước khi input textarea
function AutoResizeTextArea() {
    $("textarea[id*='workcontent_workplan_detail_']").each(function () {
        if ($(this).val().trim() == '') {
            this.setAttribute("style", "height: 31px; min-height:31px; max-hight:31px;");
        } else {
            this.setAttribute("style", "height:" + (this.scrollHeight) + "px; min-height:" + (this.scrollHeight) + " px; max-hight:" + (this.scrollHeight) + " px;");
        }
    }).on("input", function () {
        if ($(this).val().trim() == '') {
            this.style.height = "31px";
            this.style.minHeight = "31px";
            this.style.maxHeight = "31px";
        } else {
            this.style.height = (this.scrollHeight) + "px";
            this.style.minHeight = (this.scrollHeight) + "px";
            this.style.maxHeight = (this.scrollHeight) + "px";
        }
    });
}

//Get danh sách kế hoạch công việc
function GetWorkPlan(pagenumber) {
    var html = '';
    $.ajax({
        url: _URL + 'WorkPlanNew/GetWorkPlan',
        type: 'GET',
        dataType: 'json',
        data: {
            startDate: $('#ds_index_workplan').val(),
            endDate: $('#de_index_workplan').val(),
            userID: $('#user_id_workplan').val(),
            pageNumber: pagenumber,
            pageSize: parseInt($('#change_page_size_workplan').val())
        },
        contentType: 'application/json',
        success: function (result) {
            $('#page_number_pagination_workplan').text(pagenumber);
            $('#show_page_number_workplan').val(pagenumber);
            $.each(result, function (key, item) {
                html += '<tr>';
                html += '<td class="text-center">'
                html += '<button class="btn btn-primary btn-sm" onclick="return onUpdate(' + item.Id + ')"><i class="fas fa-pen"></i></button>';
                html += '<button id="btn_delete_workplan" class="btn btn-danger btn-sm" onclick="return Delete(' + item.Id + ')"><i class="fas fa-trash"></i></button>';
                html += '</td>'
                html += '<td class="text-center">' + getFormattedDateDMY(item.StartDate) + '</td>';
                html += '<td class="text-center">' + getFormattedDateDMY(item.EndDate) + '</td>';
                html += '<td>' + item.TotalDay + '</td>';
                html += '<td>' + item.FullName + '</td>';
                html += '<td>' + item.Project + '</td>';
                html += '<td>' + item.Location + '</td>';
                html += '<td class ="text-left">' + item.WorkContent + '</td>';
                html += '</tr>';
            });
            $('.tbody_work_plan').html(html);
        },

        error: function () {
            MessageError("Error loading data! Please try again.");
        }
    })
}

//Check validate form
function ValidateRegisterWork() {

    var startdate = $('#date_start_workplan').val();
    var enddate = $('#date_end_workplan').val();
    var loaction = $('#location_workplan').val();
    var workcontent = GetWorkContent();

    if (startdate == '') {
        MessageWarning('Bạn chưa chọn ngày bắt đầu!');

        $('#date_start_workplan').focus();
        return false;
    }

    if (enddate == '') {
        MessageWarning('Bạn chưa chọn ngày kết thúc!');
        $('#date_end_workplan').focus();
        return false;
    }

    $("tr[id*='location_workplan_']").each(function (i, el) {

        if ($(this).val() == '') {
            MessageWarning('Bạn chưa nhập nơi làm việc!');
            $(this).focus();
            return false;
        }

    });

    //if (loaction == '') {
    //    MessageWarning('Bạn chưa nhập nơi làm việc!');
    //    $('#location_workplan').focus();
    //    return false;
    //}

    if (workcontent.length <= 0) {
        MessageWarning('Bạn chưa nhập nội dung công việc!');
        return false;
    }
    return true;
}

//Sự kiện thay đổi ngày bắt đầu
function ChangeStartDate() {
    var ds = new Date($('#date_start_workplan').val()).getTime();

    var dsIndex = new Date($('#ds_index_workplan').val());
    var deIndex = new Date($('#de_index_workplan').val());

    if (ds < dsIndex || ds > deIndex) {
        $('#feedback_compare_startdate').css("display", "none");

        $('#feedback_out_of_range_startdate').css("display", "block");
        $('#feedback_out_of_range_startdate').text("Phải nằm trong khoảng " + getFormattedDateDMY(dsIndex) + " và " + getFormattedDateDMY(deIndex));
        $('#btn_add_workplan').prop("disabled", true);
    } else if ($('#date_end_workplan').val() != '') {
        $('#feedback_out_of_range_startdate').css("display", "none");

        var de = new Date($('#date_end_workplan').val()).getTime();
        var totalDay = (de - ds) / (24 * 60 * 60 * 1000);
        if (totalDay < 0) {
            $('#feedback_compare_startdate').css("display", "block");
            $('#btn_add_workplan').prop("disabled", true);
        } else {
            $('#totalday_workplan').val(totalDay + 1);
            $('#feedback_compare_startdate').css("display", "none");
            $('#feedback_compare_enddate').css("display", "none");
            $('#btn_add_workplan').prop("disabled", false);
        }
    } else {
        $('#feedback_compare_startdate').css("display", "none");
        $('#feedback_out_of_range_startdate').css("display", "none");
        $('#btn_add_workplan').prop("disabled", false);
    }
}

//Sự kiện thay đổi ngày kết thúc
function ChangeEndDate() {
    var de = new Date($('#date_end_workplan').val());

    var dsIndex = new Date($('#ds_index_workplan').val());
    var deIndex = new Date($('#de_index_workplan').val());

    if (de < dsIndex || de > deIndex) {
        $('#feedback_compare_enddate').css("display", "none");

        $('#feedback_out_of_range_enddate').css("display", "block");
        $('#feedback_out_of_range_enddate').text("Phải nằm trong khoảng " + getFormattedDateDMY(dsIndex) + " và " + getFormattedDateDMY(deIndex));
        $('#btn_add_workplan').prop("disabled", true);
    } else if ($('#date_start_workplan').val() != '') {
        $('#feedback_out_of_range_enddate').css("display", "none");


        var ds = new Date($('#date_start_workplan').val()).getTime();
        var totalDay = (de - ds) / (24 * 60 * 60 * 1000);
        if (totalDay < 0) {
            $('#feedback_compare_enddate').css("display", "block");
            $('#btn_add_workplan').prop("disabled", true);
        } else {
            $('#totalday_workplan').val(totalDay + 1);
            $('#feedback_compare_enddate').css("display", "none");
            $('#feedback_compare_startdate').css("display", "none");
            $('#btn_add_workplan').prop("disabled", false);
        }
    } else {
        $('#feedback_out_of_range_enddate').css("display", "none");
        $('#feedback_compare_enddate').css("display", "none");
        $('#btn_add_workplan').prop("disabled", false);
    }
}

//Thêm dòng
function AddHtml() {
    var idGroup = 'workplan_detail_' + idIndex;
    var sttworkdetail = 'stt_workplan_detail_' + idIndex;
    var workcontentId = 'workcontent_workplan_detail_' + idIndex;   
    var projectworkplan = 'project_workplan_detail_' + idIndex;
    var locationworkplan = 'location_workplan_detail_' + idIndex;
    var param = "'" + idGroup + "'";

    var valuePreviousRow = GetValuePreviouRow();

    var html = '';
    html += '<tr id="' + idGroup + '"  class="work-plan-detail">';
    html += '<td scope="row"><button class="btn btn-danger btn-sm" onclick="return RemoveHtml(' + param + ');"><i class="fas fa-trash"></i></button></td>';
    html += '<td><input type="number" class="form-control form-control-sm border border-dark text-right" id="' + sttworkdetail + '" value="1" min="1" disabled></td>';
    html += '<td><textarea type="text" class="form-control-text-area rounded" id="'+workcontentId+'"></textarea></td>';
    html += '<td class="text-left"><select class="form-control" id="' + projectworkplan + '"><option value="0">-- Chọn dự án --</option></select></td>';
    html += '<td><input type="text" class="form-control form-control-sm" id="' + locationworkplan + '" value="Văn phòng RTC"></td>';
    html += '</tr>';
    
    $('#tbody_workplan_detail').append(html);

    //Set focus kế hoạch công việc
    $('#' + workcontentId).focus();

    //AutoResizeTextArea();

    //Update Stt
    $("input[id*='stt_workplan_detail_']").each(function (i, el) {
        var id = $(this).attr('id');
        $('#' + id).val(i + 1);
    });

    //Kéo thả dòng
    $('#tbody_workplan_detail').sortable({
        update: function () {
            $("input[id*='stt_workplan_detail_']").each(function (i, el) {
                var id = $(this).attr('id');
                $('#' + id).val(i + 1);
            });
        }
    });

    //Add list project select
    $.each(listProject, function (key, item) {
        $('#' + projectworkplan).append($('<option>', {
            value: item.Id,
            text: item.Project
        }));
    });

    //Add js chosen jquery
    $("#" + projectworkplan).chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:",
        //search_contains: true
    });

     //Set value
    $('#' + workcontentId).val(valuePreviousRow.workcontent);
    $('#' + projectworkplan).val(valuePreviousRow.project).trigger("chosen:updated");
    $('#' + locationworkplan).val(valuePreviousRow.location);

    idIndex++;
    
}

//Xóa dòng
function RemoveHtml(idName) {

    if ($('.work-plan-detail').length > 1) {
        $('#' + idName).remove();
    }
    
    $("input[id*='stt_workplan_detail_']").each(function (i, el) {
        var id = $(this).attr('id');
        $('#' + id).val(i + 1);
    });
}

//Get giá trị của dòng bên trên
function GetValuePreviouRow() {
    var value;
    var element = $('.work-plan-detail').last();

    var workcontent = $(element).find("textarea[id*='workcontent_workplan_detail_']").val();
    var project = $(element).find("select[id*='project_workplan_detail_']").val();
    var location = $(element).find("input[id*='location_workplan_detail_']").val();
    value = {
        workcontent: workcontent,
        project: parseInt(project),
        location:location
    }
    return value;
}

//Get nội dung công việc
function GetWorkContent() {
    var arrWorkcontent = [];
    $("tr[id*='workplan_detail_']").each(function (i, el) {

        var id = $(this).attr('id');
        var index = id.split('_')[id.split('_').length - 1];

        var idWorkContent = parseInt($('#id_workplan_detail_' + index).val());
        var sttWorkContent = parseInt($('#stt_workplan_detail_' + index).val());
        var content = $('#workcontent_workplan_detail_' + index).val();
        var project = $('#project_workplan_detail_' + index).val();
        var location = $('#location_workplan_detail_' + index).val();

        if (content != '') {
            var obj = {
                Id: parseInt(idWorkContent),
                Stt: parseInt(sttWorkContent),
                Content: content,
                ProjectId: parseInt(project),
                Location: location
            };

            arrWorkcontent.push(obj);
        }

    });

    return arrWorkcontent;
}

//Sự kiên khi click nút thêm
function onCreate() {
    $('#id_workplan').val(0);
    $('#btn_add_workplan').show();
    $('#btn_update_workplan').hide();
}

//Sự kiện khi click nút sửa
function onUpdate(id) {
    var html = '';

    $.ajax({
        url: _URL + 'WorkPlanNew/GetWorkPlanByID',
        type: 'GET',
        data: { id: id },
        contentType: 'application/json;charset=utf-8',
        dataType: 'json',
        success: function (result) {

            $('#id_workplan').val(result[0].workPlan.Id);
            $('#date_start_workplan').val(getFormattedDateYMD(result[0].workPlan.StartDate));
            $('#date_end_workplan').val(getFormattedDateYMD(result[0].workPlan.EndDate));
            $('#totalday_workplan').val(result[0].workPlan.TotalDay);
            $('#workcontent_workplan').val(result[0].workPlan.WorkContent);

            idIndex = result[0].workPlanDetails.length + 1;

            $.each(result[0].workPlanDetails, function (key, item) {

                var idGroup = 'workplan_detail_' + (key + 1);
                var sttworkdetail = 'stt_workplan_detail_' + (key + 1);
                var workcontentId = 'workcontent_workplan_detail_' + (key + 1);
                var projectworkplan = 'project_workplan_detail_' + (key + 1);
                var locationworkplan = 'location_workplan_detail_' + (key + 1);
                var param = "'" + idGroup + "'";

                var project = item.ProjectId <= 0 ? '-- Chọn tất cả --' : listProject.find(x => x.Id = item.ProjectId).Project;

                html += '<tr id="' + idGroup + '"  class="work-plan-detail">';
                html += '<td scope="row"><button class="btn btn-danger btn-sm" onclick="return RemoveHtml(' + param + ');"><i class="fas fa-trash"></i></button></td>';
                html += '<td><input type="number" class="form-control form-control-sm border border-dark" id="' + sttworkdetail + '" value="' + (key + 1) + '" min="1" disabled></td>';
                html += '<td><textarea type="text" class="form-control-text-area rounded" id="' + workcontentId + '">' + item.WorkContent + '</textarea></td>';
                html += '<td class="text-left"><select class="form-control" id="' + projectworkplan + '"><option value="' + item.ProjectId + '">' + project + '</option></select></td>';
                html += '<td><input type="text" class="form-control form-control-sm" id="' + locationworkplan + '" value="' + item.Location + '"></td>';
                html += '</tr>';
            });
            $('#tbody_workplan_detail').html(html);

            //Kéo thả dòng
            $('#tbody_workplan_detail').sortable({
                update: function () {
                    $("input[id*='stt_workplan_detail_']").each(function (i, el) {
                        var id = $(this).attr('id');
                        $('#' + id).val(i + 1);
                    });
                }
            });

            //Add list option and add choson jquery select project
            $("select[id*='project_workplan_detail_']").each(function (i, el) {

                var id = $(this).attr('id');
              
                //Add list project select
                $.each(listProject, function (index, val) {
                    $('#' + id).append($('<option>', {
                        value: val.Id,
                        text: val.Project
                    }));
                });

                //Add js chosen jquery
                $('#' + id).chosen({
                    width: "100%",
                    no_results_text: "Không tìm thấy kết quả:",
                });
            });


            $('#modal_update_workplan').modal('show');
            $('#btn_add_workplan').hide();
            $('#btn_update_workplan').show();
        },
        error: function (err) {
            alert("Không tồn tại kế hoạch công việc này!");
        }
    });
}

//Create kế hoạch công việc
function Update(method) {
    var arrWorkContent = GetWorkContent();
    var workcontent = '';

    $.each(arrWorkContent, function (key, val) {
        workcontent += val.Content + '\n';
    })

    var obj = {
        Id: parseInt($('#id_workplan').val()),
        UserId: parseInt($('#user_id_workplan_modal').val()),
        WorkContent: workcontent,
        StartDate: $('#date_start_workplan').val(),
        EndDate: $('#date_end_workplan').val(),
        TotalDay: parseFloat($('#totalday_workplan').val()),
        ProjectId: parseInt($('#projetc_workplan').val()),
        Location: $('#location_workplan').val(),
    };

    if (ValidateRegisterWork()) {
        $.ajax({
            url: _URL + 'WorkPlanNew/' + method,
            type: 'POST',
            dataType: 'json',
            contentType: 'application/json;charset=utf-8',
            data: JSON.stringify(obj),
            success: function (result) {

                if (result == 0) {
                    MessageWarning("Bạn đã khai báo kế hoạch cho ngày: " + getFormattedDateDMY(obj.StartDate) + ' - ' + getFormattedDateDMY(obj.EndDate));
                } else if (result == 1) {
                    MessageWarning("Bạn không thể cập nhật kế hoạch công việc!", 3000);
                }else {
                    CreateDetail(obj, arrWorkContent, result);
                }
                GetWorkPlan(1);
            },
            error: function (err) {
                MessageError("Thêm thất bại! \n" + err);
            }
        });
    }
}

//Create kế hoạch công việc chi tiết
function CreateDetail(obj, content, workplanId) {

    var dateStart = new Date($('#date_start_workplan').val());       

    Date.prototype.addDays = function (days) {
        var date = new Date(this.valueOf());
        date.setDate(date.getDate() + days);
        return date;
    }

    var dateday = new Date();

    for (var i = 0; i < obj.TotalDay; i++) {
        dateday = dateStart.addDays(i);

        $.each(content, function (key, item) {
            var objDetail = {
                UserId: obj.UserId,
                DateDay: dateday,
                WorkContent: item.Content,
                Location: item.Location,
                ProjectId: item.ProjectId,
                WorkPlanId: workplanId,
                Stt: item.Stt
            };

            $.ajax({
                url: _URL + 'WorkPlanDetail/Create',
                type: 'POST',
                dataType: 'json',
                contentType: 'application/json;charset=utf-8',
                data: JSON.stringify(objDetail),
                success: function (result) {
                    MessageSucces('Thêm thành công!');
                },
                error: function (err) {
                    MessageError("Thêm thất bại! \n" + err);
                }
            });
            
        })
    }
}

//Get danh sách dự án
function GetProjectWorkPlan() {
    $.ajax({
        url: _URL + 'WorkPlanNew/GetProjectWorkPlan',
        type: 'GET',
        dataType: 'json',
        contentType: 'application/json',
        success: function (result) {

            $.each(result, function (key, item) {
                listProject.push(item);
            })
            
        },

        error: function () {
            MessageError("Error loading data! Please try again.");
        }
    });

    return listProject;
}