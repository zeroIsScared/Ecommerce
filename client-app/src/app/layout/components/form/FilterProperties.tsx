import { Formik } from "formik";
import MySelectInput from "./MySelectInput";
import { Form, Grid } from "semantic-ui-react";
import { propertyCategoryOptions } from "../options/propertyCategoryOptions";
import Buttons from "../Buttons";

interface Props {
    handleSubmit: (propertyCategory: number) => void;
    handleClearFilter: () => void;
    filter: boolean;
}

export default function FilterProperties({ handleSubmit, filter, handleClearFilter }: Props) {

    return (
        <Formik
            enableReinitialize
            initialValues={{ category: 1 }}
            onSubmit={values => handleSubmit(values.category)}
            style={{ float: "right" }}>
            {({ handleSubmit }) => {
                return (
                    <Form className='ui form' onSubmit={handleSubmit} autoComplete='off'>
                        <Grid padded >
                            {/* <Grid.Column width='6'> */}
                            <MySelectInput label='Filter properties by category' name='category' options={propertyCategoryOptions} placeholder='Property Category' width='2' />
                            {/* </Grid.Column> */}
                            <Grid.Column width='6' style={{ marginTop: '0.8em' }}>
                                <Buttons
                                    content={'Apply'}
                                    color={'olive'}
                                    role={'submit'} />
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