var idIndex = 2;
var listVehicle = [];

$(document).ready(function () {
    setCostVehicleBus();
    GetListVehicle();

    $('#btn_close').click(function () {
        GetVehicleContent();
    });


});

function OnImage(event, id_image_output) {
    var reader = new FileReader();
    reader.onload = function () {
        var output = document.getElementById('' + id_image_output + '');
        output.src = reader.result;

    };
    reader.readAsDataURL(event.target.files[0]);
}

function OnImage2(event, id_image_output) {
    var reader = new FileReader();
    reader.onload = function () {
        var output = document.getElementById('' + id_image_output + '');
        output.src = reader.result;

    };
    reader.readAsDataURL(event.target.files[0]);
}

//Thêm dòng phương tiện
function AddHtmlVehicle() {
    var idGroup = 'vehicle_detail_' + idIndex;
    var vehicleBus = 'vehicle_bus_' + idIndex;
    var vehicleImage = 'vehicle_image_' + idIndex;
    var vehicleCost = 'cost_vehicle_bus_' + idIndex;
    var imgoutput = 'image_output_' + idIndex;
    var param = "'" + idGroup + "'";

    var vehicleNote = 'vehicle_note_' + idIndex;

    var html = "";

    html += '<tr id="' + idGroup + '" class="vehicle-detail">';
    html += '<td scope="row"><button class="btn btn-danger btn-sm" onclick="return RemoveHtmlVehicle(' + param + ');"><i class="fas fa-trash"></i></button></td>';
    html += `<td>
            <select class="form-control" id = "${vehicleBus}" style = "padding:0 !important; height:31px !important;" onchange = "return setCostVehicleBus2('${vehicleBus}','${vehicleCost}');" >
                <option value="0"> Phương tiện khác</option>
            </select>
            </td>`;
    html += '<td><input type="number" id="' + vehicleCost + '" class="form-control form-control-sm text-right" value="" ></td>';
    html += `<td>
                <input type="text" id="${vehicleNote}" class="form-control form-control-sm" value=""/>
            </td>`;
    html += `<td>
                <input type="file" class="form-control form-control-sm p-0 mt-1" name="file" accept="image/*" id="${vehicleImage}"
                    onchange="return OnImage2(event,'${imgoutput}')" />
                <img class="p-1" id="${imgoutput}" style="width:150px; height: 150px;" />
             </td>`;

    //html += '<td> <div class="row"> <input type="file" class="form-control form-control-sm" name="file" accept="image/*" id="' + vehicleImage + '" onchange="return OnImage2(event,' + imgoutput + ')" style="padding: 2px;width: 90px;margin-top: 20px;margin-top: 60px;margin-left: 10px;" /> <img id="' + imgoutput + '" style="width: 45% !important;margin-left: 34px; height: 152px !important;padding:5px;" /> </div> </td>';
    $('#tbody_vehicle_detail').append(html);


    //Add list project select
    $.each(listVehicle, function (key, item) {
        $('#' + vehicleBus).append($('<option>', {
            value: item.Id,
            text: item.VehicleName,

        }));
    });
    //$('#' + vehicleBus).append($('<option>', {
    //    value: -1,
    //    text: "Chọn phương tiện",

    //}));
    $('#' + vehicleBus).val(-1);
    idIndex++;

}

////Get phương tiện
//function GetListVehicle() {
//    $.ajax({
//        url: _URL + 'EmployeeBussiness/GetListVehicle',
//        type: 'GET',
//        dataType: 'json',
//        contentType: 'application/json',
//        success: function (result) {

//            $.each(result, function (key, item) {
//                listVehicle.push(item);
//            })

//        },

//        error: function () {
//            MessageError("Error loading data! Please try again.");
//        }
//    });

//    return listVehicle;
//}

////Set chi phí đi lại khi công tác
//function setCostVehicleBus() {

//    var vehicleId = parseInt($('#vehicle_bus_1').val());
//    var arrValue = GetArrValueSelect();
//    $('#vehicle_bus_1').find('[value="-1"]').remove();
//    let check = array_is_unique(arrValue, arrValue.length);
//    if (check == 1) {
//        MessageWarning("Phương tiện đã tồn tại");
//        $('#vehicle_bus_1').append($('<option>', {
//            value: -1,
//            text: "Chọn phương tiện",

//        }));
//        $('#vehicle_bus_1').val(-1);
//        return;
//    }

//    if (vehicleId == 0 || vehicleId == 3) {
//        $('#vehicle_image_1').show();
//        $('#image_output_1').show();

//        $('#cost_vehicle_bus_1').prop("disabled", false);
//        $('#cost_vehicle_bus_1').get(0).type = 'number';
//    } else {

//        $('#vehicle_image_1').hide();
//        $('#image_output_1').hide();

//        $('#cost_vehicle_bus_1').prop("disabled", true);
//        $('#cost_vehicle_bus_1').get(0).type = 'text';
//        $.ajax({
//            url: _URL + 'EmployeeBussiness/GetVehicle',
//            type: 'GET',
//            dataType: 'json',
//            contentType: 'application/json;charset=utf-8',
//            data: { id: vehicleId },
//            success: function (data) {

//                $('#cost_vehicle_bus_1').val(data);
//                $('#cost_vehicle_bus').val(formatter.format(data));
//            },
//            error: function (err) {
//                MessageError(err.responseText);
//            }
//        });
//    }
//}

/*Tạo hàm kiểm tra phần tử trùng trong mảng JavaScript*/
function array_is_unique(array, size) {
    //flag =  1 =>  tồn tại phần tử trùng nhau
    //flag =  0 =>  không tồn tại phần tử trùng nhau
    let flag = 0;
    for (let i = 0; i < size - 1; ++i) {
        for (let j = i + 1; j < size; ++j) {
            if (array[i] == array[j]) {
                /*Tìm thấy 1 phần tử trùng là đủ và dừng vòng lặp*/
                flag = 1;
                break;
            }
        }
    }

    return flag;
}


function GetArrValueSelect() {
    var arrValue = [];
    $("select[id *='vehicle_bus_']").each(function () {
        if (parseInt($(this).val()) != -1) {
            arrValue.push($(this).val());
        }


    });
    return arrValue;
}


////Set chi phí đi lại khi công tác - modal
//function setCostVehicleBus2(vehicleBus, vehicleCost) {

//    var vehicleId = parseInt($('#' + vehicleBus).val());
//    var numberId = vehicleBus.split('_')[vehicleBus.split('_').length - 1];

//    var arrValue = GetArrValueSelect();
//    $('#' + vehicleBus).find('[value="-1"]').remove();
//    let check = array_is_unique(arrValue, arrValue.length);
//    if (check == 1) {
//        MessageWarning("Phương tiện đã tồn tại");
//        $('#' + vehicleBus).append($('<option>', {
//            value: -1,
//            text: "Chọn phương tiện",

//        }));
//        $('#' + vehicleBus).val(-1);
//        return;
//    }
//    if (vehicleId == 0 || vehicleId == 3) {
//        $('#vehicle_image_' + numberId).show();
//        $('#image_output_' + numberId).show();

//        $('#' + vehicleCost).prop("disabled", false);
//        $('#' + vehicleCost).get(0).type = 'number';

//    } else {
//        $('#vehicle_image_' + numberId).hide();
//        $('#image_output_' + numberId).hide();

//        $('#' + vehicleCost).get(0).type = 'text';
//        $('#' + vehicleCost).prop("disabled", true);
//        $.ajax({
//            url: _URL + 'EmployeeBussiness/GetVehicle',
//            type: 'GET',
//            dataType: 'json',
//            contentType: 'application/json;charset=utf-8',
//            data: { id: vehicleId },
//            success: function (data) {

//                $('#' + vehicleCost).val(data);

//                // setTotalMoneyBus();
//            },
//            error: function (err) {
//                MessageError(err.responseText);
//            }
//        });
//    }
//}

//Set tổng chi phí công tác
function setTotalMoneyBus() {

    var costVehicle = $('#cost_vehicle_bus').val();
    var costBus = $('#cost_bus').val();
    var costOvernight = $('#cost_overnight_bus').val();
    var costWorkEarly = $('#cost_work_early').val();

    costVehicle = parseFloat(costVehicle.substring(0, costVehicle.length - 2).replace(/\./g, ''));
    costBus = parseFloat(costBus.substring(0, costBus.length - 2).replace(/\./g, ''));
    costOvernight = parseFloat(costOvernight.substring(0, costOvernight.length - 2).replace(/\./g, ''));
    costWorkEarly = parseFloat(costWorkEarly.substring(0, costWorkEarly.length - 2).replace(/\./g, ''));

    $('#total_money_bus').val(formatter.format(costVehicle + costBus + costOvernight + costWorkEarly));
}

//Xóa dòng
function RemoveHtmlVehicle(idName) {

    if ($('.vehicle-detail').length > 1) {
        $('#' + idName).remove();
    }

}

//Lấy phương tiện sau khi nhập
function GetVehicleContent() {
    var total = 0;
    var arrVehicle = [];
    var arrName = [];
    let result = false;


    $("tr[id*='vehicle_detail_']").each(function (i, el) {

        var id = $(this).attr('id');
        var index = id.split('_')[id.split('_').length - 1];
        var idVehicleBussiness = parseInt($('#vehicle_bus_' + index).val());
        var billImage = '#vehicle_image_' + index;
        var cost = parseFloat($('#cost_vehicle_bus_' + index).val());

        var note = $('#vehicle_note_' + index).val();

        //Tên phương tiện
        var nameVehicleBussiness = $('#vehicle_bus_' + index + ' option:selected').text();
        if (idVehicleBussiness == -1) {
            //$('#vehicle_detail_' + index).remove();
            MessageWarning("Vui lòng chọn phương tiện ");
            result = true;

        }

        //Check ảnh xem đã chọn hay chưa
        if (idVehicleBussiness == 0 && !$('#vehicle_image_' + index).val()) {

            MessageWarning("Vui lòng chọn ảnh cho phương tiện  " + nameVehicleBussiness);
            result = true;

        }
        //Check ảnh xem đã chọn hay chưa
        if (idVehicleBussiness == 3 && !$('#vehicle_image_' + index).val()) {

            MessageWarning("Vui lòng chọn ảnh cho phương tiện  " + nameVehicleBussiness);
            result = true;

        }
        if (idVehicleBussiness == 0 && cost < 1) {

            MessageWarning("Vui lòng nhập số tiền cho  " + nameVehicleBussiness);
            result = true;

        }
        if (idVehicleBussiness == 3 && cost < 1 || Number.isNaN(cost)) {

            MessageWarning("Vui lòng nhập số tiền cho  " + nameVehicleBussiness);
            result = true;

        }

        var obj = {
            EmployeeVehicleBussinessId: idVehicleBussiness,
            BillImage: billImage,
            Cost: cost,
            NameVehicle: nameVehicleBussiness,
            Note:note
        };


        arrName.push(nameVehicleBussiness);
        total += cost;
        $('#cost_vehicle_bus').val(formatter.format(total));
        //$('#title_vehicle').text(arrName);
        $('#title_vehicle').val(arrName.join(';', arrName));
        arrVehicle.push(obj);


    });
    if (result == true) {
        return;
    }
    setTotalMoneyBus();
    $('#modal_select_vehicle').modal('hide');
    return arrVehicle;
}