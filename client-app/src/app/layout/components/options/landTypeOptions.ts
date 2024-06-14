import { LandType } from "../../../enums/landType";

export const landTypeOptions: { label: string; value: string | number }[] = [];

const labels = Object.keys(LandType).filter(key => !isNaN(Number(LandType[key])));

labels.forEach((label, index) =>
    landTypeOptions.push({ label: label, value: index })
);