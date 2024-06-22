import { Formik } from "formik";
import MySelectInput from "./MySelectInput";
import { Form, Grid } from "semantic-ui-react";
import { propertyCategoryOptions } from "../options/propertyCategoryOptions";
import Buttons from "../Buttons";
import { useStore } from "../../../stores/store";

interface Props {
    handleSubmit: (propertyCategory: string | number) => void;
    handleClearFilter: () => void;
    filter: boolean;
}

export default function FilterProperties({ handleSubmit, filter, handleClearFilter }: Props) {
    const { propertyStore } = useStore();
    const { loading } = propertyStore;

    return (
        <Formik
            enableReinitialize
            initialValues={{ category: 0 }}
            onSubmit={values => handleSubmit(Number(values.category) + 1)}
            style={{ float: "right" }}>
            {({ handleSubmit }) => {
                return (
                    <Form className='ui form' onSubmit={handleSubmit} autoComplete='off'>
                        <Grid padded >
                            <MySelectInput label='Filter properties by category' name='category' options={propertyCategoryOptions} placeholder='Property Category' width='3' />
                            <Grid.Column width='4' style={{ marginTop: '0.8em' }}>
                                <Buttons
                                    content={'Apply'}
                                    color={'olive'}
                                    role={'submit'}
                                    loading={loading} />
                                {filter &&
                                    <Buttons
                                        content={'Clear filter'}
                                        color={'red'}
                                        role={'submit'}
                                        onClick={handleClearFilter} />
                                }
                            </Grid.Column>
                        </Grid>
                    </Form>
                );
            }}
        </Formik>
    )
}