import { makeAutoObservable, runInAction } from "mobx";
import agent from "../api/agent";
import { Locality } from "../models/locality";

export default class LocalityStore {
    localityLoading = false;
    localities: Locality[] = [];
    selectedLocality: Locality | undefined = undefined;


    constructor() {
        makeAutoObservable(this, {}, { autoBind: true });
    }
    loadLocalities = async (id: number) => {
        this.setLocalityLoading(true);
        try {
            const localities: Locality[] = await agent.Localities.list(id);
            runInAction(() => {
                this.setLocalities(localities);
            })
            this.setLocalityLoading(false);
        } catch (error) {
            console.log(error);
            this.setLocalityLoading(false);
        }
    }

    setLocalities = (localities: Locality[]) => {
        this.localities = localities;
    }

    setSelectedLocality = (locality: Locality | undefined) => {
        this.selectedLocality = locality;
    }

    setLocalityLoading = (loading: boolean) => {
        this.localityLoading = loading;
    }
}