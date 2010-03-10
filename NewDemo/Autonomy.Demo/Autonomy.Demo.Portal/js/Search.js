﻿function GetPager(page_count) {
    
    var display_page_count = 10;
    if (page_count < 10) {
        display_page_count = page_count;
    }
    
    var pager_content=new StringBuffer();
    //pager_content.append("<span>上一页</span>");
    pager_content.append("<span class=\"current\" id=\"Pager" + 1 + "\" style=\"margin-left:10px;\" >[" + 1 + "]</span>");

    var keyword = $("#keyword").val();
    for (var i = 2; i <= display_page_count; i++)
    {
        pager_content.append("<span id=\"Pager" + i + "\" style=\"margin-left:10px;\" onclick=\"GetFocus('Pager'," + i + "," + page_count + ",'" + keyword + "')\"><a href=\"javascript:void(null);\" >[" + i + "]</a></span>");
    }

    //pager_content.append("<span><a href=\"javascript:void(null);\">下一页</a></span>");
    $("#PagerList").html(pager_content.toString());
}

function GetFocus(obj,current_page,page_count,keyword) {
    var start = (current_page - 1) * 15 + 1;
    $.get("Handler/SearchResult.ashx", { 'keyword': keyword.toString(), 'Start': start },
        function(data) {
            var a_data = data.split('※');
            $("#SearchResult").html(a_data[0]);
        });
        
    if (current_page > 6) {
        var pager_content = new StringBuffer();
        for (var page_index = current_page - 5; page_index < current_page + 5; page_index++) {
            pager_content.append("<span id=\"Pager" + page_index + "\" style=\"margin-left:10px;\" onclick=\"GetFocus('Pager'," + page_index + "," + page_count + ",'" + keyword + "')\"><a href=\"javascript:void(null);\" >[" + page_index + "]</a></span>");
        }
        $("#PagerList").empty().html(pager_content.toString());
        $("#" + obj + current_page).attr("class", "current");
    } 
    else
    {
        $("span[class='current']").removeClass("current");
        $("#" + obj + current_page).attr("class", "current");
    }
}