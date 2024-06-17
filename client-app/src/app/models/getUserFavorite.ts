import { Favorite } from "./favorite";

export interface GetUserFavorites {
    userId: number,
    propertyId: number,
    property: Favorite
}