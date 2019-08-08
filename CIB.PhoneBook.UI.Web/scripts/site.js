/* All validations in here*/
/* BEGIN Extend jquery*/
(function ($) {
    $.fn.extend({

        // With every keystroke capitalize first letter of ALL words in the text
        upperFirstAll: function () {
            $(this).keyup(function (event) {
                var box = event.target;
                var txt = $(this).val();
                var start = box.selectionStart;
                var end = box.selectionEnd;

                $(this).val(txt.toLowerCase().replace(/^(.)|(\s|\-)(.)/g,
                function (c) {
                    return c.toUpperCase();
                }));
                box.setSelectionRange(start, end);
            });
            return this;
        },

        // With every keystroke capitalize first letter of the FIRST word in the text
        upperFirst: function () {
            $(this).keyup(function (event) {
                var box = event.target;
                var txt = $(this).val();
                var start = box.selectionStart;
                var end = box.selectionEnd;

                $(this).val(txt.toLowerCase().replace(/^(.)/g,
                function (c) {
                    return c.toUpperCase();
                }));
                box.setSelectionRange(start, end);
            });
            return this;
        },

        // Converts with every keystroke the hole text to lowercase
        lowerCase: function () {
            $(this).keyup(function (event) {
                var box = event.target;
                var txt = $(this).val();
                var start = box.selectionStart;
                var end = box.selectionEnd;

                $(this).val(txt.toLowerCase());
                box.setSelectionRange(start, end);
            });
            return this;
        },

        // Converts with every keystroke the hole text to uppercase
        upperCase: function () {
            $(this).keyup(function (event) {
                var box = event.target;
                var txt = $(this).val();
                var start = box.selectionStart;
                var end = box.selectionEnd;

                $(this).val(txt.toUpperCase());
                box.setSelectionRange(start, end);
            });
            return this;
        }

    });
}(jQuery));
/* END Extend jquery*/

/*-- BEGIN toastr --*/
function toastify(type, msg, title, position, showclosebutton, timeout) {

    timeout = (typeof timeout !== 'undefined') ? timeout : '50000';

    if (position === null || position === '') {
        toastr.options.positionClass = 'toast-bottom-right';
    }
    else {
        toastr.options.positionClass = position;
    }

    toastr.options.closeButton = true;
    toastr.options.timeOut = timeout;
    toastr.options.progressBar = true;

    switch (type) {
    case 'success': toastr.success(msg, title);
        break;
    case 'info': toastr.info(msg, title);
        break;
    case 'warning': toastr.warning(msg, title);
        break;
    case 'error': toastr.error(msg, title);
        break;
    }

    toastr.options.newestOnTop = false;
    toastr.options.preventDuplicates = false;
    //toastr.clear();
}
/*-- END toastr --*/

/*
$(function () {

    //alert($("#supMessageCount").html());

    showHideMessageCounter();

    // Enable logging for development purpose
    $.connection.hub.logging = true;
    // Declare a proxy to reference the hub.
    var messageHub = $.connection.messageHub;
    // Create a function that the hub can call to broadcast messages.
    messageHub.client.displayMessage = function (sender, message) {
        //if sender is current user
        updateMessageCounter();
        showHideMessageCounter();

        addNewItemRow("NewTask", message);
        //toastify('info', message, 'New Message', 'toast-top-right', 'true', 5000);
    };

    messageHub.client.displayNotification = function(sender, recipient, type, message, itemId) {
        updateMessageCounter();
        showHideMessageCounter();

        addNewItemRow(itemId, type, message);
    };

    //$.connection.hub.start().done(function () {
    $.connection.hub.start("~/signalr").done(function () {

    });
});*/

function showHideMessageCounter() {
    if ($("#supMessageCount").html() === "0") {
        $("#supMessageCount").hide();
    } else {
        $("#supMessageCount").show();
    }
}

function updateMessageCounter() {
    var count = parseInt($("#supMessageCount").html());
    $("#supMessageCount").html(count + 1);
}

function addNewItemRow(itemId, type, message) {
    if (type === "NewTask") {
        toastify('info', message, 'New Task Created', 'toast-top-right', 'true', 5000);
        $("#ulTodaysMessages li:eq(0)")
            .after(
                "<li><a class='alert alert-warning' href='AddALead.aspx?id=" + itemId +"'><img class='pull-right img-circle dropdown-avatar' alt='' src='Boostbox/assets/img/avatar2.jpg?1400333014'><strong>New Task Created</strong><br><small>" +
                message +
                "</small></a></li>");

    } else {
        toastify('info', message, 'New Lead Created', 'toast-top-right', 'true', 5000);
        $("#ulTodaysMessages li:eq(0)")
            .after(
                "<li><a class='alert alert-info' href='AddALead.aspx?id=" + itemId +"'><img class='pull-right img-circle dropdown-avatar' alt='' src='Boostbox/assets/img/avatar2.jpg?1400333014'><strong>New Lead Created</strong><br><small>" +
                message +
                "</small></a></li>");
    }
    clearAllToDo();
    saveAllTodo();
}

function saveAllTodo() {
    var listContents = [];
    //var limit = 7;
    $("#ulTodaysMessages").each(function () {
      //  if (i < limit) {
            listContents.push(this.innerHTML);
        //}
    });
    localStorage.setItem('todoList', JSON.stringify(listContents));
    localStorage.setItem('messageCount', $("#supMessageCount").html());

};

function clearAllToDo() {
    localStorage.clear();
    //location.reload();
    
};

function resetToDoList() {
    localStorage.clear();

    $("#ulTodaysMessages ul").append('<li class="dropdown-header">Today\'s messages</li >');
    $("#ulTodaysMessages ul").append('<li class="dropdown-header">Options</li>');
    $("#ulTodaysMessages ul").append('<li><a href="#">View all messages <span class="pull-right"><i class="fa fa-arrow-right"></i></span></a></li>');
    $("#ulTodaysMessages ul").append('<li><a href="javascript:resetToDoList();">Mark as read <span class="pull-right"><i class="fa fa-arrow-right"></i></span></a></li>');
    
    saveAllTodo();
}

function loadToDo() {
    if (localStorage.getItem('todoList')) {
        
        var listContents = JSON.parse(localStorage.getItem('todoList'));
        $("#ulTodaysMessages").each(function (i) {
            this.innerHTML = listContents[i]; 
        });
    }
    if (localStorage.getItem('messageCount')) {
        var a = localStorage.getItem('messageCount');
        if (a === "0") {
            $("#supMessageCount").hide();
        } else {
            $("#supMessageCount").html(a);
            $("#supMessageCount").show();
        }
    }
}



$(document).ready(function () {

    //resetToDoList();
    loadToDo();

    
});

$(document).ajaxError(function (xhr, props) {
    if (props.status === 401) {
        location.reload();
    }
});