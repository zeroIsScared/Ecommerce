import { useField } from "formik";
import { Form, Label, SemanticWIDTHS } from "semantic-ui-react";

interface Props {
    placeholder: string;
    name: string;
    label?: string;
    width?: SemanticWIDTHS;
    inline?: boolean;
}

export default function MytextInput(props: Props) {
    const [field, meta] = useField(props.name);
    return (
        <Form.Field error={meta.touched && !!meta.error} width={props.width} inline={props.inline}>
            <label>{props.label}</label>
            <input {...field}
                placeholder={props.placeholder}
                name={props.name} />
            {meta.touched && meta.error ? (
                <Label basic color='red'> {meta.error}</Label>
            ) : null}
        </Form.Field>

        // <div>
        //     <label htmlFor={props.name}> {props.label}</label>
        //     <Field name={props.name} placeholder={props.placeholder} value={props.name} />
        //     <ErrorMessage name={props.name} />
        // </div>
    )
}