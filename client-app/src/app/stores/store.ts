import { createContext, useContext } from "react";
import PropertyStore from "./propertyStore";
import { AsyncTrunk } from 'mobx-sync';
import propertyStore from "./propertyStore";

interface Store {
    propertyStore: PropertyStore;
}

export const store: Store = {
    propertyStore: new PropertyStore(),

}
export const trunk = new AsyncTrunk(propertyStore, { storage: localStorage });

export const StoreContext = createContext(store);

export function useStore() {
    return useContext(StoreContext);
}