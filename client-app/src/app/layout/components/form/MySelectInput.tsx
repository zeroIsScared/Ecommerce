import { ErrorMessage, Field } from "formik";
import { Form, SemanticWIDTHS } from "semantic-ui-react";
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

    return (
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