
$(document).ready(function () {

    //Sự kiện khi thay đổi giá trị ngày bắt đầu
    $('#startdate_workplan').change(function () {
        var ds = new Date($(this).val()).getTime();

        var dsIndex = new Date($('#ds').val());
        var deIndex = new Date($('#de').val());
        if (ds < dsIndex || ds > deIndex) {
            $('#feedback_compare_startdate').css("display", "none");

            $('#feedback_out_of_range_startdate').css("display", "block");
            $('#feedback_out_of_range_startdate').text("Phải nằm trong khoảng " + getFormattedDateDMY(dsIndex) + " và " + getFormattedDateDMY(deIndex));
            $('#btn_add_workplan').prop("disabled", true);
        } else if ($('#enddate_workplan').val() != '') {
            $('#feedback_out_of_range_startdate').css("display", "none");

            var de = new Date($('#enddate_workplan').val()).getTime();
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
    })

     //Sự kiện khi thay đổi giá trị ngày kết thúc
    $('#enddate_workplan').change(function () {
        var de = new Date($(this).val());

        var dsIndex = new Date($('#ds').val());
        var deIndex = new Date($('#de').val());

        if (de < dsIndex || de > deIndex) {
            $('#feedback_compare_enddate').css("display", "none");

            $('#feedback_out_of_range_enddate').css("display", "block");
            $('#feedback_out_of_range_enddate').text("Phải nằm trong khoảng " + getFormattedDateDMY(dsIndex) + " và " + getFormattedDateDMY(deIndex));
            $('#btn_add_workplan').prop("disabled", true);
        } else if ($('#startdate_workplan').val() != '') {
            $('#feedback_out_of_range_enddate').css("display", "none");
            

            var ds = new Date($('#startdate_workplan').val()).getTime();
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
    })
})


//Check validate form
function checkVaidate() {

    var startdate = $('#startdate_workplan').val();
    var enddate = $('#enddate_workplan').val();
    var loaction = $('#location_workplan').val();
    var workcontent = $('#workcontent_workplan').val();

    var location = $('input[name=location]:checked').val();

    if (startdate == '') {
        MessageWarning('Bạn chưa chọn ngày bắt đầu!');

        $('#startdate_workplan').focus();
        return false;
    }

    if (enddate == '') {
        MessageWarning('Bạn chưa chọn ngày kết thúc!');
        $('#enddate_workplan').focus();
        return false;
    }

    if (parseInt(location) == 0) {
        if (loaction == '') {
            MessageWarning('Bạn chưa nhập nơi làm việc!');
            $('#location_workplan').focus();
            return false;
        }
    }
    

    if (workcontent == '') {
        MessageWarning('Bạn chưa nhập nội dung công việc!');
        $('#workcontent_workplan').focus();
        return false;
    }
    return true;
}

//sự kiện thay đổi địa điểm làm việc
function onChangeLocation() {
    var location = $('input[name=location]:checked').val();
    var locationText = $('#location_workplan').val();
    if (location == 0) {
        $('#location_workplan').prop('disabled', false);
        if (locationText == 'VP RTC') {
            $('#location_workplan').val('');
        }
    } else {
        $('#location_workplan').prop('disabled', true);
    }
}


