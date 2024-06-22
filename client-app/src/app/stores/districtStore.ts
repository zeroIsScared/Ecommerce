import { makeAutoObservable, runInAction } from "mobx";
import { District } from "../models/district";
import agent from "../api/agent";

export default class DistrictStore {
    districtLoading = false;
    districts: District[] = [];
    selectedDistrict: District | undefined = undefined;


    constructor() {
        makeAutoObservable(this, {}, { autoBind: true });
    }

    loadDistricts = async () => {
        this.setDistrictLoading(true);
        try {
            const districts: District[] = await agent.Districts.list();
            runInAction(() => {
                this.setDistricts(districts);
            })
            this.setDistrictLoading(false);
        } catch (error) {
            console.log(error);
            this.setDistrictLoading(false);
        }
    }

    setDistricts = (districts: District[]) => {
        this.districts = districts;
    }

    setDistrictLoading = (loading: boolean) => {
        this.districtLoading = loading;
    }

    setSelectedDistrict = (district: District | undefined) => {
        this.selectedDistrict = district;
    }
}