// JavaScript source code
let addRow =  ()=> alert("Row added"); 
function addEvent() {
    document.getElementById("btnAdd").addEventListener("click", addRow);
}
function understandObject() {
    var user = {
        username: "",
        password: ""
    };
    user.username = "Ramu";
    user.password = "1234";
    user.role = "Admin"
    console.log(user);
    document.getElementById("divContent").innerHTML = "Welcome " + user.username+" your role is "+user.role;
}
function understandingArray() {
    //var names = ["Ramu", "Bimu", "Somu", "Komu"];
    //names[6] = "Himu";
    //for (var name in names) {
    //    console.log(name);
    //}
    //for (var i = 0; i < names.length; i++) {
    //    console.log(names[i])
    //}
    var num = 5;
    var mychar = "5" 
    if (num === mychar)
        alert("same")
    else
        alert("nope")
}