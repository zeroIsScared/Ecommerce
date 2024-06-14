

export interface GetUserFavorites {
    userId: number,
    propertyId: number,
    property: {
        id: number,
        title: string,
        price: number,
        currency: {
            code: string,
            simbol: string
        },
        photoURL: string,
        userId: number,
    }
}