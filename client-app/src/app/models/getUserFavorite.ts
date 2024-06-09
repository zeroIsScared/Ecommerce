import { Property } from "./property";

export interface GetUserFavorites {
    userId: number,
    propertyId: number,
    property: Property
}