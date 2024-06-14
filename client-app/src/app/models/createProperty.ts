import { Address } from "./address"
import { Details } from "./details"
import { Photo } from "./photo"
import { User } from "./user"
import { Utility } from "./utility"

export interface CreateProperty {

    id: number
    title: string
    description: string
    price: number
    category: number
    transactionType: number
    currencyId: number
    userId: number
    details: Details
    address: Address
    utilities: Utility[]
    photos: Photo[]
}