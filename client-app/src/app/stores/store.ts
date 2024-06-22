import { createContext, useContext } from "react";
import PropertyStore from "./propertyStore";
import { AsyncTrunk } from 'mobx-sync';
import propertyStore from "./propertyStore";
import DistrictStore from "./districtStore";
import LocalityStore from "./localitiesStore";
import UtilitiesStore from "./utilitiesStore";

interface Store {
    propertyStore: PropertyStore;
    districtStore: DistrictStore;
    localityStore: LocalityStore;
    utilitiesStore: UtilitiesStore;

}

export const store: Store = {
    propertyStore: new PropertyStore(),
    districtStore: new DistrictStore(),
    localityStore: new LocalityStore(),
    utilitiesStore: new UtilitiesStore(),
}

export const trunk = new AsyncTrunk(propertyStore, { storage: localStorage });

export const StoreContext = createContext(store);

export function useStore() {
    return useContext(StoreContext);
}