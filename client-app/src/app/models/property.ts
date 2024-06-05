import { Address } from "./address"
import { Currency } from "./currency"
import { Details } from "./details"
import { Photo } from "./photo"
import { User } from "./user"
import { Utility } from "./utility"

export interface Property {
    id: number
    title: string
    description: string
    price: number
    category: number
    transactionType: number
    currency: Currency
    user: User
    details: Details
    address: Address
    utilities: Utility[]
    photos: Photo[]
}