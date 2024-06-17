import { Currency } from "./currency";

export interface Favorite {
    id: number,
    title: string,
    price: number,
    currency: Currency,
    photoURL: string,
    userId: number,
}