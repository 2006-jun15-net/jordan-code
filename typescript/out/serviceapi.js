"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var deck = {
    cards: [],
    remaining: 0,
};
fetch("https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1", {
    method: "GET",
    headers: { "Accept": "application/json" }
})
    .then(function (response) { return response.json(); })
    .then(function (cardData) {
    deck.cards = cardData.cards;
    deck.remaining = cardData.remaining;
});
var startButton = document.getElementById("start");
var dealer;
var player;
document.addEventListener("DOMContentLoaded", function () {
    startButton === null || startButton === void 0 ? void 0 : startButton.addEventListener("onclick", function () {
        fetch("https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1", {
            method: "GET",
            headers: { "Accept": "application/json" }
        })
            .then(function (response) { return response.json(); })
            .then(function (cardData) {
            deck.cards = cardData.cards;
            deck.remaining = cardData.remaining;
            dealer.deck = deck;
            player.deck = deck;
        });
    });
});
