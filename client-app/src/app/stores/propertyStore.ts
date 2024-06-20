import { makeAutoObservable, runInAction } from "mobx";
import { Properties } from "../models/properties";
import { Property } from "../models/property";
import agent from "../api/agent";
import axios from "axios";
import { GetUserFavorites } from "../models/getUserFavorite";
import { AddUserFavoritesPayload } from "../models/addUserFavoritesPayload";
import { CreateProperty } from "../models/createProperty";
import { getUtility } from "../models/getUtility";
import { Locality } from "../models/locality";
import { District } from "../models/district";


export default class PropertyStore {
    properties: Properties[] = [];
    selectedProperty: Property | undefined = undefined;
    userFavorites: GetUserFavorites[] = [];
    loading = false;
    loadingInitial = false;
    yourProperties: Properties[] = [];
    isSubmitting = false;
    filteredPropertiesByCategory: Properties[] = this.properties;
    localities: Locality[] = [];
    utilities: getUtility[] = [];
    districts: District[] = [];

    constructor() {
        makeAutoObservable(this, {}, { autoBind: true });
    }

    loadProperties = async () => {
        this.setLoadingInitial(true);
        try {
            const token = localStorage.getItem("accessToken");
            axios.defaults.headers.common = { 'Authorization': `Bearer ${token}` }
            const properties = await agent.Properties.list();
            this.setProperties(properties);
            this.setLoadingInitial(false);
        } catch (error) {
            console.log(error);
            this.setLoadingInitial(false);
        }
    }

    loadYourProperties = async () => {
        this.setLoading(true);
        try {
            const properties = await agent.Properties.list();
            const yourProperties = properties.filter(property => property.userId == 1);
            this.setYourProperties(yourProperties);
            this.setLoading(false);
        } catch (error) {
            console.log(error);
            this.setLoading(false);
        }
    }

    loadFilteredPropertiesByCategory = async (id: string | number | undefined) => {
        this.setLoading(true);
        try {
            const filteredPropertiesByCategory = await agent.Properties.filter(id);
            runInAction(() => {
                this.setFilteredPropertiesByCategory(filteredPropertiesByCategory);
                this.setLoading(false);
            })

        } catch (error) {
            console.log(error);
            this.setLoading(false);
        }
    }

    loadUserFavorites = async () => {
        this.setLoading(true);
        try {
            const favorites: GetUserFavorites[] = (await axios.get(`http://localhost:5172/api/UserFavorites/${1}`)).data;
            this.setUserFavorites(favorites);
            this.setLoading(false);
        } catch (error) {
            console.log(error);
            this.setLoading(false);
        }
    }

    deleteFromUserFavorites = async (payload: AddUserFavoritesPayload) => {
        this.setLoading(true);
        try {
            await agent.UserFavorites.remove(payload);
            runInAction(() => {
                this.setUserFavorites(this.userFavorites.filter(x => x.propertyId !== payload.propertyId));
                this.setLoading(false);
            })
        } catch (error) {
            console.log(error);
            this.setLoading(false);
        }
    }

    addToUserFavorites = async (payload: AddUserFavoritesPayload) => {
        this.setLoading(true);
        try {
            await agent.UserFavorites.create(payload);
            runInAction(() => {
                const newFavorite = this.properties.find(property => property.id === payload.propertyId);
                if (!this.userFavorites.find(x => x.propertyId === newFavorite?.id)) {
                    this.userFavorites.push({
                        userId: payload.userId,
                        propertyId: payload.propertyId!,
                        property: newFavorite!
                    });
                }
                this.setLoading(false);
            })
        } catch (error) {
            console.log(error);
            this.setLoading(false);
        }
    }

    loadSelectedProperty = async (id: string) => {
        this.setLoading(true);
        try {
            const property: Property = await agent.Properties.details(id);
            runInAction(() => {
                this.setSelectedProperty(property);
            })
            this.setLoading(false);
            return property;
        } catch (error) {
            console.log(error);
            this.setLoading(false);
        }
    }

    cancelSelectedProperty = () => {
        this.setSelectedProperty(undefined);
    }

    deleteProperty = async (id: number) => {
        this.setLoading(true);
        try {
            await agent.Properties.del(id);
            runInAction(() => {
                this.properties = [...this.properties.filter(x => x.id !== id)];
                this.yourProperties = [...this.properties.filter(x => x.id !== id)];
                if (this.selectedProperty?.id === id) this.cancelSelectedProperty();
                this.setLoading(false);
            })
        } catch (error) {
            console.log(error);
            runInAction(() => {
                this.setLoading(false);
            })
        }
    }

    createProperty = async (property: CreateProperty) => {
        this.loading = true;

        try {
            const newProperty = (await agent.Properties.create(property)).data;
            runInAction(() => {
                this.properties.push({
                    id: newProperty.id,
                    title: newProperty.title,
                    price: newProperty.price,
                    currency: newProperty.currency.code,
                    photoURL: newProperty.photos[0].url,
                    userId: newProperty.user.id
                });

                if (newProperty) this.setSelectedProperty(newProperty);
            })
        } catch (error) {
            console.log(error);
            runInAction(() => {
                this.loading = false;
                this.setSelectedProperty(undefined);
            })
        }
    }

    updateProperty = async (property: CreateProperty) => {
        this.loading = true;
        try {
            const newProperty = (await agent.Properties.update(property)).data;
            runInAction(() => {
                this.properties = [...this.properties.filter(x => x.id !== newProperty.id), {
                    id: newProperty.id,
                    title: newProperty.title,
                    price: newProperty.price,
                    currency: newProperty.currency.code,
                    photoURL: newProperty.photos[0].url,
                    userId: newProperty.user.id
                }];
                this.selectedProperty = newProperty;
                this.loading = false;
            })
        } catch (error) {
            console.log(error);
            runInAction(() => {
                this.loading = false;
            })
        }
    }

    loadLocalities = async (id: number) => {
        this.setLoading(true);
        try {
            const localities: Locality[] = await agent.Localities.list(id);
            runInAction(() => {
                this.setLocalities(localities);
            })
            this.setLoading(false);
        } catch (error) {
            console.log(error);
            this.setLoading(false);
        }
    }

    loadDistricts = async () => {
        this.setLoading(true);
        try {
            const districts: District[] = await agent.Districts.list();
            runInAction(() => {
                this.setDistricts(districts);
            })
            this.setLoading(false);
        } catch (error) {
            console.log(error);
            this.setLoading(false);
        }
    }

    setDistricts = (districts: District[]) => {
        this.districts = districts;
    }

    loadUtilities = async (id: number) => {
        this.setLoading(true);
        try {
            const utilities: getUtility[] = await agent.Utilities.list(id);
            runInAction(() => {
                this.setUtilities(utilities);
            })
            this.setLoading(false);
        } catch (error) {
            console.log(error);
            this.setLoading(false);
        }
    }

    setUtilities = (utilities: getUtility[]) => {
        this.utilities = utilities;
    }

    setFilteredPropertiesByCategory = (properties: Properties[]) => {
        this.filteredPropertiesByCategory = properties;
    }

    setUserFavorites = (favorites: GetUserFavorites[]) => {
        this.userFavorites = favorites;
    }

    setSelectedProperty = (property: Property | undefined) => {
        this.selectedProperty = property;
    }

    setProperties = (properties: Properties[]) => {
        this.properties = properties;
    }

    setYourProperties = (properties: Properties[]) => {
        this.yourProperties = properties;
    }

    setLocalities = (localities: Locality[]) => {
        this.localities = localities;
    }

    setLoadingInitial = (state: boolean) => {
        this.loadingInitial = state;
    }

    setLoading = (state: boolean) => {
        this.loading = state;
    }

}

