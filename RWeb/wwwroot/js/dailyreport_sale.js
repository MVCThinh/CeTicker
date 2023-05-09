function Validate() {
    var customerCode = $('#CustomerCode').val();
    var customerShortname = $('#CustomerShortName').val();
    var customerName = $('#CustomerName').val();
    var address = $('#Address').val();

    var customer = [];

    if (customerCode == '') {
        MessageWarning("Vui lòng nhập Mã khách hàng!", 2000);
        return false;
    }

    if (customerShortname == '') {
        MessageWarning("Vui lòng nhập Tên ký hiệu!", 2000);
        return false;
    }

    if (customerName == '') {
        MessageWarning("Vui lòng nhập Tên khách hàng!", 2000);
        return false;
    }

    if (address == '') {
        MessageWarning("Vui lòng nhập Địa chỉ!", 2000);
        return false;
    }

    var customerCodeExist = 0;
    var customerShortNameExist = 0;

    
    return true;
}

//Add Customer
function CreateCustomer() {
    if (Validate()) {
        var obj = {
            CustomerCode: $('#CustomerCode').val(),
            CustomerShortName: $('#CustomerShortName').val(),
            CustomerName: $('#CustomerName').val(),
            TaxCode: $('#TaxCode').val(),
            CustomerType: parseInt($('#Type option:selected').val()),
            Debt: $('#Debt').val(),
            ClosingDateDebt: $('#ClosingDateDebt').val() == '' ? null : $('#ClosingDateDebt').val(),
            Address: $('#Address').val(),
            NoteVoucher: $('#NoteVoucher').val(),
            NoteDelivery: $('#NoteDelivery').val(),
            HardCopyVoucher: $('#HardCopyVoucher').val(),
            CheckVoucher: $('#CheckVoucher').val(),
            AdressStock: $('#AddressStock').val(),
        };

        $.ajax({
            url: _URL + 'DailyReportSale/GetCustomerByCodeAndName',
            type: "GET",
            data: {
                code: obj.CustomerCode,
                shortName: obj.CustomerShortName
            },
            dataType: "json",
            contentType: "application/json;charset=utf-8",
            success: function (result) {

                if (result == null) {
                    $.ajax({
                        url: _URL + 'DailyReportSale/CreateCustomer',
                        type: "POST",
                        data: JSON.stringify(obj),
                        dataType: "json",
                        contentType: "application/json;charset=utf-8",
                        success: function (result) {

                            var text = result.CustomerCode + ' - ' + result.CustomerShortName + ' - ' + result.CustomerName;
                            $('#customer_id_sale').append(new Option(text, result.Id));
                            $('#customer_id_sale').val(result.Id).trigger("chosen:updated");
                            onChangeCustomer(result.Id);
                            $('#modal_add_customer').modal('hide');
                        },
                        error: function (err) {
                            alert(err.responseText);
                        }
                    })
                } else {
                    if (obj.CustomerCode == result.CustomerCode) {
                        MessageWarning("Mã khách hàng đã tồn tại!");
                    } else if (obj.CustomerShortName == result.CustomerShortName) {
                        MessageWarning("Tên ký hiệu đã tồn tại!");
                    }
                }
                
            },
            error: function (err) {
                alert(err.responseText);
            }
        });
    }
}

function onChangeCustomer(customerID) {
    $('#btn-add-contact').prop("disabled", false);
    $('#btn-add-end-user').prop("disabled", false);

    $('#contact').empty();
    $('#contact').trigger("chosen:updated");

    $('#end_user').empty();
    $('#end_user').trigger("chosen:updated");

    $('#quotation_kh').empty();
    $('#quotation_kh').trigger("chosen:updated");

    //var customerID = parseInt($('#customer_id_sale option:selected').val());

    //Customer contact
    var arrIdContact = [];
    $.ajax({
        url: _URL + 'DailyReportSale/GetContactByID',
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        data: {
            id: customerID
        },
        success: function (items) {

            var html = '';
            $.each(items, function (key, item) {
                arrIdContact.push(item);

                html += '<tr id="item-contact" onclick="GetContact()">';
                html += '<td>' + item.ContactName + '</td>';
                html += '<td>' + item.CustomerPart + '</td>';
                html += '<td>' + item.CustomerPosition + '</td>';
                html += '<td>' + item.CustomerTeam + '</td>';
                html += '<td>' + item.ContactPhone + '</td>';
                html += '<td>' + item.ContactEmail + '</td>';
                html += '</tr>';

            });
            $('.tbody').html(html);

            if (arrIdContact.length > 0) {
                for (var i = 0; i < arrIdContact.length; i++) {
                    var id = arrIdContact[i].idConCus;
                    var text = arrIdContact[i].ContactName;
                    $('#contact option[value=""]').remove();
                    $('#contact').append(new Option(text, id));
                    $('#contact').trigger("chosen:updated");

                }
            } else {
                $('#contact option[value=""]').remove();
                $('#contact').append(new Option("Không có người liên hệ", ""));
                $('#contact').trigger("chosen:updated");
            }
        },
        error: function (errorMessage) {
            alert(errorMessage.responseText);
        }
    })
    $('#CustomerId').val(customerID);

    //EndUser
    var arrIdConPart = [];
    $.ajax({
        //url: '@Url.Action("GetEndUserByID", "DailyReportSale")',
        url: _URL + 'DailyReportSale/GetEndUserByID',
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        data: {
            id: customerID
        },
        success: function (items) {

            var html = '';
            $.each(items, function (key, item) {
                arrIdConPart.push(item);

                html += '<tr>';
                html += '<td>' + item.PartCode + '</td>';
                html += '<td>' + item.PartName + '</td>';
                html += '</tr>';

            });
            $('.tbody-end-user').html(html);

            if (arrIdConPart.length > 0) {
                for (var i = 0; i < arrIdConPart.length; i++) {
                    var id = arrIdConPart[i].idConPart;
                    var text = arrIdConPart[i].PartCode;
                    $('#end_user option[value=""]').remove();
                    $('#end_user').append(new Option(text, id));
                    $('#end_user').trigger("chosen:updated");

                }
            } else {
                $('#end_user option[value=""]').remove();
                $('#end_user').append(new Option("Không có End User", ""));
                $('#end_user').trigger("chosen:updated");
            }
        },
        error: function (errorMessage) {
            alert(errorMessage.responseText);
        }
    })
    $('#CustomerId_EndUser').val(customerID);
}
