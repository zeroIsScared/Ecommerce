import { BuildingType } from "../../../enums/buildingType";

export const buildingTypeOptions: { label: string; value: string | number }[] = [];

const labels = Object.keys(BuildingType).filter(key => !isNaN(Number(BuildingType[key])));

labels.forEach((label, index) =>
    buildingTypeOptions.push({ label: label, value: index })
);