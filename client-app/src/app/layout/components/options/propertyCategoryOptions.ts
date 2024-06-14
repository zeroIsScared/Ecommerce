import { PropertyCategory } from "../../../enums/propertyCategory";

export const propertyCategoryOptions: { label: string; value: string | number }[] = [];
const labels = Object.keys(PropertyCategory).filter(key => !isNaN(Number(PropertyCategory[key])));

labels.forEach((label, index) =>
    propertyCategoryOptions.push({ label: label, value: index })
);