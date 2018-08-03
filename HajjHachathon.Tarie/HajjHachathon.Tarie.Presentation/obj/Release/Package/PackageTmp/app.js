
const dbRef = firebase.database().ref();
const usersRef = dbRef.child('users');

const userListUI = document.getElementById("userList");
const addUserBtnUI = document.getElementById("add-user-btn");
addUserBtnUI.addEventListener("click", addUserBtnClicked);
const addUserInputsUI = document.getElementsByClassName("user-input");
let newUser = {};
usersRef.on("child_added", snap => {
   let user = snap.val();
   let $li = document.createElement("li");
   $li.innerHTML = user.name;
   $li.setAttribute("child-key", snap.key); 
   $li.addEventListener("click", userClicked)
   userListUI.append($li);
});

   function addUserBtnClicked(e) {
       // loop through View to get the data for the model 
       for (let i = 0, len = addUserInputsUI.length; i < len; i++) {

           let key = addUserInputsUI[i].getAttribute('data-key');
           let value = addUserInputsUI[i].value;
           newUser[key] = value;
       }
       usersRef.push(newUser, function() {
           console.log("data has been inserted");
       });
   }
   function userClicked(e) {

       var userID = e.target.getAttribute("child-key");

       const userRef = dbRef.child('users/' + userID);

       const userDetailUI = document.getElementById("userDetail");
       userDetailUI.innerHTML = ""

       userRef.on("child_added", snap => {
           var $p = document.createElement("p");
       $p.innerHTML = snap.key + " - " + snap.val()
       userDetailUI.append($p);
   });

   }