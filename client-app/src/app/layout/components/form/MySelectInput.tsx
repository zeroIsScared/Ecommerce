import { ErrorMessage, Field, useField } from "formik";
import { Form, Label, SemanticWIDTHS } from "semantic-ui-react";
import Select from 'react-select';

interface Props {
    placeholder: string;
    name: string;
    options: { label: string, value: string | number }[];
    label?: string;
    width?: SemanticWIDTHS;
    inline?: boolean;
    default?: string;
}

export default function MySelectInput(props: Props) {
    //const [meta] = useField(props.name);
    return (
        // <Form.Field error={meta.touched && !!meta.error}>
        //     <label>{props.label}</label>
        //     <Select
        //         options={props.options}
        //         value={field.value || null}
        //         onChange={(_, d) => helpers.setValue(d.option)}
        //         onBlur={() => helpers.setTouched(true)}
        //         placeholder={props.placeholder}
        //     />
        //     {meta.touched && meta.error ? (
        //         <Label basic color='red'> {meta.error}</Label>
        //     ) : null}
        // </Form.Field>

        <Form.Field width={props.width} inline={props.inline}>
            <label htmlFor={props.name}>{props.label}</label>
            <Field as="select"
                id={props.name}
                name={props.name}
                placeholder={props.placeholder}
                default={null}
            >
                {props.options.map(option => {
                    return (
                        <option key={option.value} value={option.value}>
                            {option.label}
                        </option>
                    )
                })}
            </Field>
            <ErrorMessage name={props.placeholder} />
        </Form.Field>
    )
}