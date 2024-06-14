import { useField } from "formik";
import { Form, Label, SemanticWIDTHS } from "semantic-ui-react";

interface Props {
    placeholder: string;
    name: string;
    rows: number;
    label?: string;
    width?: SemanticWIDTHS;
}

export default function MyTextArea(props: Props) {
    const [field, meta] = useField(props.name);
    return (
        <Form.Field error={meta.touched && !!meta.error} width={props.width}>
            <label>{props.label}</label>
            <textarea {...field} {...props} />
            {meta.touched && meta.error ? (
                <Label basic color='red'> {meta.error}</Label>
            ) : null}
        </Form.Field>

        // <div>
        //     <label htmlFor={props.name}>{props.label}</label>
        //     <Field
        //         as="textarea"
        //         id={props.name}
        //         name={props.name}

        //         placeholder={props.placeholder} />
        //     <ErrorMessage name={props.name} />
        // </div>
    )
}