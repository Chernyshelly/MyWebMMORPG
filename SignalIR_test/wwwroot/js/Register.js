"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButtonReg").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg = user + " says " + msg;
    switch (msg) {
        case "successReg": alert("Registered new user"); window.location.href = "Privacy/"; break;
        case "failReg": alert("Please, try to use other username"); break;
    }
    var li = document.createElement("li");
    li.textContent = encodedMsg;
    document.getElementById("messagesList").appendChild(li);
});

connection.start().then(function () {
    document.getElementById("sendButtonReg").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButtonReg").addEventListener("click", function (event) {
    var user = document.getElementById("userInputReg").value;
    var message = document.getElementById("messageInputReg").value;
    connection.invoke("Register", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});