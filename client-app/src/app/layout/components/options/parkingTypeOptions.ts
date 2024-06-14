import { ParkingType } from "../../../enums/parkingType";

export const parkingTypeOptions: { label: string; value: string | number }[] = [];

const labels = Object.keys(ParkingType).filter(key => !isNaN(Number(ParkingType[key])));

labels.forEach((label, index) =>
    parkingTypeOptions.push({ label: label, value: index })
);