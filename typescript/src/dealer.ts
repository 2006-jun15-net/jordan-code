import Deck from "./deck";
export default interface Dealer {
    deck: Deck;

    Draw(): void;

}