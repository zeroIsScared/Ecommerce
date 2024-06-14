import axios, { AxiosResponse } from 'axios';
import { Properties } from '../models/properties';
import { Property } from '../models/property';
import { AddUserFavoritesPayload } from '../models/addUserFavoritesPayload';
import { CreateProperty } from '../models/createProperty';


const sleep = (delay: number) => {
    return new Promise((resolve) => {
        setTimeout(resolve, delay)
    })
}

axios.defaults.baseURL = 'http://localhost:5172/api';

axios.interceptors.response.use(async response => {
    try {
        await sleep(1000);
        return response;
    } catch (error) {
        console.log(error);
        return await Promise.reject(error);
    }
})

const responseBody = <T>(response: AxiosResponse<T>) => response.data;

const requests = {
    get: <T>(url: string) => axios.get<T>(url).then(responseBody),
    post: <T>(url: string, body: object) => axios.post<T>(url, body).then(responseBody),
    put: <T>(url: string, body: object) => axios.put<T>(url, body).then(responseBody),
    del: <T>(url: string) => axios.delete<T>(url).then(responseBody),
    delete: <T>(url: string, body: object) => axios.delete<T>(url, body).then(responseBody),
};

const Properties = {
    list: () => requests.get<Properties[]>('/Properties'),
    details: (id: string | undefined) => requests.get<Property>(`/Properties/${id}`),
    create: (property: CreateProperty) => axios.post<Property>(`/Properties`, property),
    update: (property: CreateProperty) => axios.put<Property>(`/Properties/${property.id}`, property),
    del: (id: number) => axios.delete<void>(`/Properties/${id}`)
};

const UserFavorites = {
    list: () => requests.get<Property[]>('/UserFavorites'),
    create: (addUserFavorite: AddUserFavoritesPayload) => axios.post<void>(`/UserFavorites?userId=${addUserFavorite.userId}&propertyId=${addUserFavorite.propertyId}`),
    remove: (addUserFavorite: AddUserFavoritesPayload) => axios.delete<void>(`/UserFavorites?userId=${addUserFavorite.userId}&propertyId=${addUserFavorite.propertyId}`),
}

const agent = {
    Properties,
    UserFavorites
}

export default agent;