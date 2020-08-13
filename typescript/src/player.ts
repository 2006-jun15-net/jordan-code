import Deck from "./deck";
export default interface Player{
    deck: Deck;

    Draw() : void;
}