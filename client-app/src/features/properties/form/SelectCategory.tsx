import { useEffect, useState } from "react";
import { useStore } from "../../../app/stores/store";
import { propertyCategoryOptions } from "../../../app/layout/components/options/propertyCategoryOptions";
import { FormField } from "semantic-ui-react";
import { ErrorMessage, Field } from "formik";

interface Props {
    value: string;
}

export default function SelectCategory({ value }: Props) {

    const { propertyStore, utilitiesStore } = useStore();
    const { newPropertyCategory, setNewPropertyCategory } = propertyStore;
    const { loadUtilities } = utilitiesStore;
    const [hasChanged, setHasChanged] = useState(false);

    const handlePropertyCategoryChange = (e) => {
        const propertyCategoryId = (Number(e.target.value) + 1);
        const propertyCategory = propertyCategoryOptions.find(x => x.value === (propertyCategoryId - 1));

        setNewPropertyCategory({ label: propertyCategory?.label, value: propertyCategoryId });
        console.log(newPropertyCategory?.value);
        setHasChanged(true);
    }

    useEffect(() => {
        if (hasChanged) {
            loadUtilities(newPropertyCategory.value!);
            setHasChanged(false);
        }
    }, [loadUtilities, hasChanged, setNewPropertyCategory]);

    return (
        <FormField width={4} >
            <label htmlFor='category'>Property Category</label>
            <Field as="select"
                id='category'
                name='category'
                value={value}
                placeholder='Select District'
                default='select category'
                onChange={(e) => handlePropertyCategoryChange(e)}
            >
                {propertyCategoryOptions.map(option => {
                    return (
                        <option key={option.label} value={option.value}>
                            {option.label}
                        </option>
                    )
                })}
            </Field>
            <ErrorMessage name='district' />
        </FormField>
    )
}