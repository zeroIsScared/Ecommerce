import { Button, Form, FormField, FormGroup, Segment } from "semantic-ui-react"
import { AuthorType } from "../../../app/enums/authorType"
import { Property } from "../../../app/models/property";
import { ChangeEvent, useState } from "react";
import LoadingComponent from "../../../app/layout/LoadingComponent";


interface Props {
    selectedProperty: Property | undefined;
    closeForm: () => void;
    createOrEdit: (property: Property) => void;
    submiting: boolean;
}

export default function PropertyFrom({ selectedProperty, closeForm, createOrEdit, submiting }: Props) {

    const initialState = selectedProperty ?? {
        id: 0,
        title: '',
        description: '',
        price: 0,
        category: 0,
        transactionType: 0,
        currency: {
            symbol: '',
            code: ''
        },
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
    }

    const [property, setProperty] = useState(initialState);

    function handleSubmit() {
        console.log(property);
        createOrEdit(property)
    }

    function handleInputChange(event: ChangeEvent<HTMLInputElement | HTMLTextAreaElement>) {
        const { name, value } = event.target;
        setProperty({ ...property, [name]: value });
    }


    return (
        <Segment clearing>
            <Form onSubmit={handleSubmit} autoComplete='off'>
                <Form.Input placeholder='Title' value={property.title} name='title' onChange={handleInputChange}></Form.Input>
                <Form.TextArea placeholder='Description' value={property.description} name='description' onChange={handleInputChange}></Form.TextArea>
                <Form.Input placeholder='Price' value={property.price} name='price' onChange={handleInputChange}></Form.Input>

                <FormField label='Author type' control='select' value={property.details.authorType} name='authorType' onChange={handleInputChange}>
                    <option value='1'>{AuthorType[1]}</option>
                    <option value='2'>{AuthorType[2]}</option>
                </FormField>
                <FormGroup grouped>
                    <label>Author</label>
                    <FormField
                        label='Natural Person'
                        control='input'
                        type='radio'
                        value={property.details.authorType} name='authorType' onChange={handleInputChange}
                    />
                    <FormField
                        label='Legal Person'
                        control='input'
                        type='radio'
                        value={property.details.authorType} name='authorType' onChange={handleInputChange}
                    />
                </FormGroup>
                <Button loading={submiting} floated="right" type='submit' content='Submit' color="olive" />
                <Button floated="right" type='button' content='Cancel' onClick={closeForm} />
            </Form>
        </Segment>
    )
}