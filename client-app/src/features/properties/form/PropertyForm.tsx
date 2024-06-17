import { Button, FormGroup, Grid, Header, Segment } from "semantic-ui-react"
import { Property } from "../../../app/models/property";
import { useStore } from "../../../app/stores/store";
import { useNavigate, useParams } from "react-router-dom";
import { observer } from "mobx-react-lite";
import LoadingComponent from "../../../app/layout/LoadingComponent";
import { Currency } from "../../../app/models/currency";
import { Details } from "../../../app/models/details";
import { Formik, Form } from "formik";
import * as Yup from 'yup';
import MytextInput from "../../../app/layout/components/form/MyTextInput";
import MyTextArea from "../../../app/layout/components/form/MyTextArea";
import MySelectInput from "../../../app/layout/components/form/MySelectInput";
import { authorTypeOptions } from "../../../app/layout/components/options/authorTypeOptions";
import { useState } from "react";
import { transactionTypeOptions } from "../../../app/layout/components/options/transactionTypeOptions";
import { propertyCategoryOptions } from "../../../app/layout/components/options/propertyCategoryOptions";
import { propertyStateOptions } from "../../../app/layout/components/options/propertyStateOptions";
import { buildingTypeOptions } from "../../../app/layout/components/options/buildingTypeOptions";
import { parkingTypeOptions } from "../../../app/layout/components/options/parkingTypeOptions";
import { landTypeOptions } from "../../../app/layout/components/options/landTypeOptions";
import { currencyOptions } from "../../../app/layout/components/options/currencyOptions";
import { CreateProperty } from "../../../app/models/createProperty";

export default observer(function PropertyFrom() {
    const { propertyStore } = useStore();
    const { loading, selectedProperty, updateProperty, createProperty } = propertyStore;
    const { id } = useParams();
    const navigate = useNavigate();

    console.log(selectedProperty);

    const initialStateCreate = {
        id: 0,
        title: '',
        description: '',
        price: 0,
        category: 0,
        transactionType: 0,
        currency: 0,
        user: {
            id: 0,
            username: '',
            phoneNumber: '',
        },
        details: {
            livingArea: '',
            floor: '',
            roomNumber: 0,
            floorsNumber: 0,
            state: 0,
            authorType: 0,
            buildingType: 0,
            parkingType: 0,
            landType: 0
        },
        address: {
            street: '',
            houseNumber: '',
            localityName: '',
            localityRegion: '',
            districtName: '',
        },
        utilities: [{
            utilityId: 0
        }],
        photos: [{
            url: '',
            title: ''
        }]
    };

    const initialState: Property = id ? selectedProperty : initialStateCreate;


    const validationSchema = Yup.object({
        title: Yup.string().required('Property title is required!'),
        description: Yup.string().required('Property description is required!'),
        currency: Yup.string().required(),
    })

    const [property, setProperty] = useState<Property>(initialState);

    // useEffect(() => {
    //     if (id) loadSelectedProperty(id).then((property) => setProperty(property!))
    // }, [id, loadSelectedProperty])

    const handleSubmit = async (property: Property) => {
        console.log(property);
        const currencyId = currencyOptions[property.currency.currencyId]

        const submitingProperty: CreateProperty = {
            id: property.id,
            title: property.title,
            description: property.description,
            price: Number(property.price),
            category: Number(property.category),
            transactionType: Number(property.transactionType),
            currencyId: Number(property.currency),
            userId: 3,
            details: {
                livingArea: property.details.livingArea,
                floor: property.details.floor,
                roomNumber: Number(property.details.roomNumber),
                floorsNumber: Number(property.details.floorsNumber),
                state: Number(property.details.state),
                authorType: Number(property.details.authorType),
                buildingType: Number(property.details.buildingType),
                parkingType: Number(property.details.parkingType),
                landType: Number(property.details.landType),
            },
            address: {
                street: property.address.street,
                houseNumber: property.address.houseNumber,
                localityName: property.address.localityName,
                localityRegion: property.address.localityRegion,
                districtName: property.address.districtName,
            },
            utilities: [{
                utilityId: 1
            }],
            photos: [{
                url: property.photos[0].url,
                title: 'front view'
            }]
        };

        console.log(submitingProperty);
        if (id) {
            //submitingProperty.currencyId = currencyId;
            await updateProperty(submitingProperty);
            navigate(`/Properties/${id}`);
        }
        else {
            await createProperty(submitingProperty);
            if (selectedProperty) navigate(`/Properties/${selectedProperty?.id}`);
        }
    }

    if (loading) return <LoadingComponent />
    return (
        <Grid columns={6} stackable textAlign='center'>
            <Segment clearing >
                <Formik
                    //validationSchema={validationSchema}
                    enableReinitialize
                    initialValues={property}
                    onSubmit={values => handleSubmit(values)}>
                    {({ handleSubmit, isValid, isSubmitting, dirty }) => (
                        <Form className='ui form' onSubmit={handleSubmit} autoComplete='off'>
                            <h2>Property information</h2>
                            <hr></hr>
                            <MytextInput label='Title' name='title' placeholder='title' width='12' />
                            <MyTextArea rows={3} placeholder='Description' name='description' width='16' />
                            <FormGroup >
                                <MytextInput label='Price' name='price' placeholder='Price' width='4' inline={true} />
                                <MySelectInput label='Currency' name='currency' options={currencyOptions} placeholder='Currency' width='2' default=" " />
                            </FormGroup>
                            <FormGroup >
                                <MySelectInput label='Trabsaction Type' name='transactionType' options={transactionTypeOptions} placeholder='Transaction Type' width='4' />
                                <MySelectInput label='Property Category' name='category' options={propertyCategoryOptions} placeholder='Property Category' width='4' />
                                <MySelectInput label='Author Type' name='details.authorType' options={authorTypeOptions} placeholder='Author Type' width='4' />
                            </FormGroup>
                            <h3>Property details</h3>
                            <hr></hr>
                            <FormGroup>
                                <MytextInput label='Living area, m2' placeholder='Enter living area  in m2' name='details.livingArea' width='4' />
                                <MytextInput label='Floor' placeholder='Enter the floor' name='details.floor' width='4' />
                                <MytextInput label='Total number of floors' placeholder='Enter the total number of floors of the building' name='details.floorsNumber' width='4' />
                                <MytextInput label='Number of rooms' placeholder='Enter the number of rooms' name='details.roomNumber' width='4' />
                            </FormGroup>
                            <FormGroup>

                                <MySelectInput label='Property State' name='details.state' options={propertyStateOptions} placeholder='Property state' width='5' />
                                <MySelectInput label='Building Type' name='details.buildingType' options={buildingTypeOptions} placeholder='Building type' width='5' />
                            </FormGroup>
                            <FormGroup>
                                <MySelectInput label='Parking Type' name='details.parkingType' options={parkingTypeOptions} placeholder='Parking type' width='5' />
                                <MySelectInput label='Land Type' name='details.landType' options={landTypeOptions} placeholder='Land type' width='5' />
                            </FormGroup>

                            <MytextInput label='Photo' name='photos[0].url' placeholder="Photo URL" width='12' />

                            <h3>Address</h3>
                            <hr></hr>
                            <FormGroup>
                                <MytextInput label='Street' name='address.street' placeholder='Street' width='5' />
                                <MytextInput label='House nr.' name='address.houseNumber' placeholder='House nr.' width='3' />
                                <MytextInput label='Locality' name='address.localityName' placeholder='Locality' width='5' />
                            </FormGroup>
                            <FormGroup>
                                <MytextInput label='Region' name='address.localityRegion' placeholder='Region' width='5' />
                                <MytextInput label='District' name='address.districtName' placeholder='District' width='5' />
                            </FormGroup>
                            <Button disabled={isSubmitting} floated="right" type='submit' content='Submit' color="olive" />
                            <Button floated="right" type='button' content='Cancel' />
                        </Form>
                    )}

                </Formik>

            </Segment>
        </Grid>
    )
})