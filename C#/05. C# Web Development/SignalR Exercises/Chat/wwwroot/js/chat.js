let connection = new signalR
    .HubConnectionBuilder()
    .withUrl("/chat")
    .build();

connection.on("ReceiveMessage", function (user, message) {
    let msg = message
        .replace(/&/g, "&amp;")
        .replace(/</g, "&lt;")
        .replace(/>/g, "&gt;");

    let encodedMsg = "[" + user + "]: " + msg;

    let messageElement = document.createElement("h3");
    messageElement.textContent = encodedMsg;

    document.getElementById("messageList").appendChild(messageElement);
});

connection.start().catch(function (err) {
    return console.error(err.toString());

});

document.getElementById("sendButton").addEventListener("click", function (event) {

    let user = document.getElementById("userInput").value;
    let message = document.getElementById("messageInput").value;

    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString());
    });

    event.preventDefault();

})

