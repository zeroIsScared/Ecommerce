import { PropertyState } from "../../../enums/propertyState";

export const propertyStateOptions: { label: string; value: string | number }[] = [];

const labels = Object.keys(PropertyState).filter(key => !isNaN(Number(PropertyState[key])));

labels.forEach((label, index) =>
    propertyStateOptions.push({ label: label, value: index })
);