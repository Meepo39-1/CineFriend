const connection = new signalR.HubConnectionBuilder()
    .withUrl("https://localhost:7129/ChatHub")
    .configureLogging(signalR.LogLevel.Information)
    .build();

async function start() {
    try {
        await connection.start();
    
        console.log("SignalR Connected.");
    
        
    } catch (err) {
        console.log(err);
        setTimeout(start, 5000);
    }
};


connection.onclose(async () => {
    await start();
});

connection.on("RecieveMessage", function (message) {
    console.log("messaged recieved from backend");
    var li = document.createElement("li");
    var user = message.sender;
    var content = message.content;
    var dateTime = message.dateTime;

    document.getElementById("messagesList").appendChild(li);
    // We can assign user-supplied strings to an element's textContent because it
    // is not interpreted as markup. If you're assigning in any other way, you 
    // should be aware of possible script injection concerns.
    li.textContent = `${user} says ${content} at ${dateTime}`;
});


/*connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
}).then( () => {
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString())
    });
});*/
/*
document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
    //const response = fetch("https://localhost:7129/Message?user=edi&content=merge");
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});
*/
const video = document.getElementById("video");
video.onplaying = (event) => {
    console.log('playing event is triggered');
    var vid = document.getElementById("video");
    connection.invoke("UpdateTimeServer", vid.currentTime).catch(function (err) {
        return console.error(err.toString());
    });
    
};

function succcesAddToGroup(){

    console.log(`connection with id: ${connection.connectionId} has been added to group TestGroup`);
}
function failureAddToGroup(){
    console.error("connection failed to be added to group");
}
function AddToGroup(){
    document.getElementById("sendButton").disabled = false;
    connection.invoke("AddToGroup", "GroupTest");
}
// Start the connection.
start()
.then(AddToGroup)
.then(succcesAddToGroup,failureAddToGroup);
