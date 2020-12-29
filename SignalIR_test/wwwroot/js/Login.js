"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButtonLog").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg = user + " says " + msg;
    switch (msg) {
        case "successLog": alert("Login success"); localStorage.setItem('mywebmmocur', user); window.location.href = "../MainPage/"; break;
        case "failLog": alert("Login failed"); break;
    }
    var li = document.createElement("li");
    li.textContent = encodedMsg;
    document.getElementById("messagesList").appendChild(li);
});

connection.start().then(function () {
    document.getElementById("sendButtonLog").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButtonLog").addEventListener("click", function (event) {
    var user = document.getElementById("userInputLog").value;
    var message = document.getElementById("messageInputLog").value;
    connection.invoke("Login", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});