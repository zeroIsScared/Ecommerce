import axios, { AxiosResponse } from 'axios';
import { Properties } from '../models/properties';
import { Property } from '../models/property';

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
    post: <Property>(url: string, body: object) => axios.post<Property>(url, body).then(responseBody),
    put: <Property>(url: string, body: object) => axios.put<Property>(url, body).then(responseBody),
    del: <Property>(url: string) => axios.delete<Property>(url).then(responseBody),
};

const Properties = {
    list: () => requests.get<Properties[]>('/Properties'),
    details: (id: number) => requests.get<Property>(`/Properties/${id}`),
    create: (property: Property) => axios.post<Property>(`/Properties/`, property),
    update: (property: Property) => axios.put<Property>(`/Properties/${property.id}`, property),
    delete: (id: number) => axios.delete<void>(`/Properties/${id}`)
};

const agent = {
    Properties
}

export default agent;