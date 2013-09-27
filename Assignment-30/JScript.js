// This is the function to enable the checkbox1 when user clicks on the respective Div.
function toggle1() {
    $(document).ready(function () {
        $("#Testing1").click(function () {
            if (document.getElementById("checkbox1").checked == true)
                document.getElementById("checkbox1").checked = false;
            else
                document.getElementById("checkbox1").checked = true;
        });
    });
}
// This is the function to enable the checkbox2 when user clicks on the respective Div.
function toggle2() {
    $(document).ready(function () {
        $("#Testing2").click(function () {
            if (document.getElementById("checkbox2").checked == true)
                document.getElementById("checkbox2").checked = false;
            else
                document.getElementById("checkbox2").checked = true;
        });
    });
}
// This is the function to enable the checkbox3 when user clicks on the respective Div.
function toggle3() {
    $(document).ready(function () {
        $("#Testing3").click(function () {
            if (document.getElementById("checkbox3").checked == true)
                document.getElementById("checkbox3").checked = false;
            else
                document.getElementById("checkbox3").checked = true;
        });
    });
}
// This is the function to enable the checkbox4 when user clicks on the respective Div.
function toggle4() {
    $(document).ready(function () {
        $("#Testing4").click(function () {
            if (document.getElementById("checkbox4").checked == true)
                document.getElementById("checkbox4").checked = false;
            else
                document.getElementById("checkbox4").checked = true;
        });
    });
}

// This is the function to Make the checkbox exclusive ,i.e., when user clicks on this all other gets disselected.
function Exclusive() {
    document.getElementById("checkbox1").checked = false;
    document.getElementById("checkbox2").checked = false;
    document.getElementById("checkbox3").checked = false;
};

// This is the function to Make the checkbox exclusive ,i.e., when user clicks on this the exclusive checkbox gets disselected.
function Exclusive1() {
    document.getElementById("checkbox4").checked = false;
    
};