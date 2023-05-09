
$(function () {
    $("#customer_id_sale").chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:",
        //search_contains: true
    });

    $("#contact_name").chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:",
        //search_contains: true
    });

    $("#group_type").chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:",
        //search_contains: true
    });

    $("#end_user").chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:",
        //search_contains: true
    });

    $("#project_id").chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:",
        //search_contains: true
    });

    $("#project_id_1").chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:",
        //search_contains: true
    });

    $("#project_id_2").chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:",
        //search_contains: true
    });

    $("#project_id_3").chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:",
        //search_contains: true
    });

    $("#project_id_4").chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:",
        //search_contains: true
    });
    $("#project_id_5").chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:",
        //search_contains: true
    });

    $("#user_confirm").chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:",
        //search_contains: true
    });

    $("#user_leave").chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:",
        //search_contains: true
    });
    $("#user_report").chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:",
        //search_contains: true
    });

    $("#user_order").chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:",
        //search_contains: true
    });

    $("#contact").chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:",
        //search_contains: true
    });

    $("#type_customer").chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:",
        //search_contains: true
    });

    $("#quotation_kh").chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:",
        //search_contains: true
    });

    $("#status_edit").chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:",
        //search_contains: true
    });

    $("#team").chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:",
        //search_contains: true
    });

    $("#user_id").chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:",
        //search_contains: true
    });

    $("#user_id_workplan").chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:",
        //search_contains: true
    });

    $("#userid_inputmodal_workplan").chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:",
        //search_contains: true
    });

    $("#projectid_inputmodal_workplan").chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:",
        //search_contains: true
    });

    $("#department_workplan_detail_id").chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:",
        //search_contains: true
    });

    $("#user_team_workplan_detail_id").chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:",
        //search_contains: true
    });

    //$("#employee_workplan_detail_id").chosen({
    //    width: "100%",
    //    no_results_text: "Không tìm thấy kết quả:",
    //    //search_contains: true
    //});

    $("#employee_project_item").chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:",
        //search_contains: true
    });

    $("#userid_workplan_detail").chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:",
        //search_contains: true
    });

    $("#projectid_workplan_detail").chosen({
        width: "100%",
        no_results_text: "Không tìm thấy kết quả:",
        //search_contains: true
    });

    //$("#department_id_drt").chosen({
    //    width: "100%",
    //    no_results_text: "Không tìm thấy kết quả:",
    //    //search_contains: true
    //});

});

var active = 0;
for (var i = 0; i < document.links.length; i++) {
    if (document.links[i].href === document.URL) {
        active = i;
    }
}

function selectAll(source) {
    var checkboxes = new Array();
    checkboxes = document.getElementsByTagName('input');
    for (var i = 0; i < checkboxes.length; i++) {
        if (checkboxes[i].type == 'checkbox') {
            checkboxes[i].checked = source.checked;
        }
    }
}
