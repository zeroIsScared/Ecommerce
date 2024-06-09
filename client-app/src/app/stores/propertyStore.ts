import { makeAutoObservable, runInAction } from "mobx";
import { Properties } from "../models/properties";
import { Property } from "../models/property";
import agent from "../api/agent";
import axios from "axios";
import { GetUserFavorites } from "../models/getUserFavorite";


export default class PropertyStore {
    properties: Properties[] = [];
    selectedProperty: Property | undefined = undefined;
    userFavorites: GetUserFavorites[] = [];
    loading = false;
    loadingInitial = false;


    constructor() {
        makeAutoObservable(this, {}, { autoBind: true });
    }

    loadProperties = async () => {
        this.setLoadingInitial(true);
        try {
            const properties = await agent.Properties.list();
            this.setProperties(properties);
            this.setLoadingInitial(false);
        } catch (error) {
            console.log(error);
            this.setLoadingInitial(false);
        }
    }

    loadUserFavorites = async () => {
        this.setLoading(true);
        try {
            const favorites: GetUserFavorites[] = (await axios.get(`http://localhost:5172/api/UserFavorites/${3}`)).data;
            this.setUserFavorites(favorites);
            this.setLoading(false);
        } catch (error) {
            console.log(error);
            this.setLoading(false);
        }
    }

    loadSelectedProperty = async (id: string) => {
        this.setLoading(true);
        try {
            const property: Property = await agent.Properties.details(id);
            this.setSelectedProperty(property);
            this.setLoading(false);
        } catch (error) {
            console.log(error);
            this.setLoading(false);
        }
    }

    deleteActivity = async (id: number) => {
        this.setLoadingInitial(true);
        this.setLoading(true);
        try {
            await agent.Properties.del(id);
            runInAction(() => {
                this.properties.filter(x => x.id !== id);
                this.setLoading(false);
                this.setLoadingInitial(true);
            })
        } catch (error) {
            console.log(error);
            runInAction(() => {
                this.setLoading(false);
                this.setLoadingInitial(true);
            })
        }
    }

    // setUserProperties = (id: number) => {
    //     this.userProperties.filter(x => x.userId == id);
    // }
    setUserFavorites = (favorites: GetUserFavorites[]) => {
        this.userFavorites = favorites;
    }

    setSelectedProperty = (property: Property) => {
        this.selectedProperty = property;
    }
    setProperties = (properties: Properties[]) => {
        this.properties = properties;
    }

    setLoadingInitial = (state: boolean) => {
        this.loadingInitial = state;
    }

    setLoading = (state: boolean) => {
        this.loading = state;
    }



}

