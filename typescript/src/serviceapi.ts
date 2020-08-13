import Card from "./card";
import Deck from "./deck";
import Dealer from "./dealer";
import Player from "./player";




let deck: Deck = {
  cards: [],
  remaining : 0,
};



  fetch("https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1",
  {
    method: "GET",
    headers: { "Accept": "application/json" }
  })
  .then(response => response.json())
  .then(cardData => {
    deck.cards = cardData.cards;
    deck.remaining = cardData.remaining;
  });


const startButton = document.getElementById("start");
let dealer: Dealer;
let player: Player;





document.addEventListener("DOMContentLoaded", () => {
  
  startButton?.addEventListener("onclick", () =>{

    fetch("https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1",
    {
      method: "GET",
      headers: { "Accept": "application/json" }
    })
    .then(response => response.json())
    .then(cardData => {
      deck.cards = cardData.cards;
      deck.remaining = cardData.remaining;
      dealer.deck = deck;
      player.deck = deck;
    });


  });
   
});
