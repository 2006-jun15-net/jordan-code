'use strict';

const loadButton = document.getElementById("load-button");
const videoDiv = document.getElementById("display-vid");
const errorMessageDiv = document.getElementById("error-message");
const dropList = document.getElementById("dropdown-items");

errorMessageDiv.style.display = "none";

loadButton.addEventListener("click", () => {

  fetch("https://www.scorebat.com/video-api/v1/",
    {
      method: "GET",
      headers: { "Accept": "application/json" }
    })
    .then(response => response.json())
    .then(videoData => {
      videoDiv.innerHTML = videoData[0].videos[0].embed;
      for(const title in videoData.title){
        const newItem = document.createElement("li");
        newItem.innerHTML = (title);
        dropList.appendChild(newItem);
      }

      
    })
    .catch(error => {
      console.log(error);
      errorMessageDiv.style.display = "block";
      errorMessageDiv.innerHTML = error.toString();
    });

    
});

function dropdownFunction() {
    document.getElementById("myDropdown").classList.toggle("show");
  }