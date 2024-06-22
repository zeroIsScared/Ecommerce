import { makeAutoObservable, runInAction } from "mobx";
import { getUtility } from "../models/getUtility";
import agent from "../api/agent";


export default class UtilitiesStore {
    utilitiesLoading = false;
    utilities: getUtility[] = [];
    selectedUtilities: getUtility[] | [] = [];

    constructor() {
        makeAutoObservable(this, {}, { autoBind: true });
    }

    loadUtilities = async (id: number) => {
        this.setUtilitiesLoading(true);
        try {
            const utilities: getUtility[] = await agent.Utilities.list(id);
            runInAction(() => {
                this.setUtilities(utilities);
            })
            this.setUtilitiesLoading(false);
        } catch (error) {
            console.log(error);
            this.setUtilitiesLoading(false);
        }
    }

    setUtilities = (utilities: getUtility[]) => {
        this.utilities = utilities;
    }

    setUtilitiesLoading = (loading: boolean) => {
        this.utilitiesLoading = loading;
    }

    setSelectedUtilities = (utilities: getUtility[] | []) => {
        this.selectedUtilities = utilities;
    }
}