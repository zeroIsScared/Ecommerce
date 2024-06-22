import { Button, Card, CardContent, CardDescription, CardHeader, Divider, Grid, GridColumn, Image, Segment } from "semantic-ui-react";
import { useStore } from "../../../app/stores/store";
import { SyntheticEvent, useEffect, useState } from "react";
import LoadingComponent from "../../../app/layout/LoadingComponent";
import { Link, useNavigate, useParams } from "react-router-dom";
import { observer } from "mobx-react-lite";
import { PropertyCategory } from "../../../app/enums/propertyCategory";
import { AuthorType } from "../../../app/enums/authorType";
import { BuildingType } from "../../../app/enums/buildingType";
import { ParkingType } from "../../../app/enums/parkingType";
import { PropertyState } from "../../../app/enums/propertyState";
import MapComponent from "./Map";

interface ImageArray {
    original: string,
    thumbnail: string
}

export default observer(function PropertiesDetails() {

    const { propertyStore } = useStore();
    const { selectedProperty, loading, loadSelectedProperty,
        deleteProperty, addToUserFavorites, userFavorites, yourProperties } = propertyStore;
    const { id } = useParams();
    const navigate = useNavigate();
    const [target, setTarget] = useState('');
    const [propertyIdToAdd, setPropertyIdToAdd] = useState<number | undefined>(undefined);

    const isFavorite = userFavorites.find(property => property.propertyId === Number(id));
    const isUsersProperty = yourProperties.find(property => property.id === Number(id));
    const handleAddToUserFavorite = (propertyId: number) => {
        setPropertyIdToAdd(propertyId);
    }

    useEffect(() => {
        if (propertyIdToAdd && !userFavorites.find(x => x.propertyId == propertyIdToAdd)) {
            addToUserFavorites({ userId: 3, propertyId: propertyIdToAdd });
        }
    }, [propertyIdToAdd, addToUserFavorites, userFavorites]);

    useEffect(() => {
        if (id) loadSelectedProperty(id)
    }, [id, loadSelectedProperty]);

    const handleDeleteProperty = async (e: SyntheticEvent<HTMLButtonElement>, id: number) => {
        setTarget(e.currentTarget.name);
        await deleteProperty(id);
        navigate(`/userProperties`);
    }

    const images1: ImageArray[] = [
        {
            original: "../../../../public/assets/3BI78kU.jpg",
            thumbnail: "../../../../public/assets/4I78kU.jpg",
        },
    ]

    if (loading) return <LoadingComponent content='Loading property details' />
    if (selectedProperty == undefined) return <h2>The property was not found!</h2>

    return (
        <Grid textAlign='center'>
            <Grid.Column width='8' >
                <Card fluid>
                    <CardContent>
                        <Image src={`${images1[0].original}`}
                        />
                        <Segment>
                            <Grid columns={2} relaxed='very' textAlign='left'>
                                <GridColumn>
                                    <h3>{selectedProperty?.title}</h3>
                                    <p><strong>Category: </strong> {PropertyCategory[selectedProperty!.category]}</p>
                                    <p><strong>Description: </strong> {selectedProperty?.description}</p>
                                    {selectedProperty!.details.authorType && (
                                        <p><strong>Author Type: </strong> {AuthorType[selectedProperty!.details.authorType]}</p>
                                    )}
                                    {selectedProperty!.details.buildingType && (
                                        <p><strong>Building Type: </strong> {BuildingType[selectedProperty!.details.buildingType]}</p>
                                    )
                                    }
                                    {selectedProperty?.details.floor && (
                                        <p><strong>Floor: </strong> {selectedProperty?.details.floor}</p>
                                    )}
                                    {selectedProperty!.details.floorsNumber && (
                                        <p><strong>Number of floor in building: </strong> {selectedProperty!.details.roomNumber}</p>
                                    )}
                                    {selectedProperty!.details.parkingType && (
                                        <p><strong>Parking Type: </strong> {ParkingType[selectedProperty!.details.parkingType]}</p>
                                    )}
                                    {selectedProperty!.details.livingArea && (
                                        <p><strong>Living area: </strong> {selectedProperty!.details.livingArea}</p>
                                    )}
                                </GridColumn >
                                <GridColumn>
                                    {selectedProperty!.details.roomNumber && (
                                        <p><strong>Number of rooms: </strong> {selectedProperty!.details.roomNumber}</p>
                                    )}
                                    {selectedProperty!.details.state && (
                                        <p><strong>Property state: </strong>{PropertyState[selectedProperty!.details.state]} </p>
                                    )}
                                    <Divider orizontal></Divider>
                                    <h4>Address:</h4>
                                    <p><strong>Locality: </strong>{selectedProperty!.address.localityName}</p>
                                    <p><strong>District: </strong>{selectedProperty!.address.districtName}</p>
                                    {selectedProperty!.address.street && (
                                        <p><strong>Street: </strong>{selectedProperty!.address.street} </p>
                                    )}
                                    {selectedProperty!.address.houseNumber && (
                                        <p><strong>House number: </strong>{selectedProperty!.address.houseNumber} </p>
                                    )}
                                </GridColumn>
                            </Grid>
                            <Divider vertical></Divider>
                        </Segment>
                    </CardContent>
                    <MapComponent />
                    <Card.Content extra >
                        <Button as={Link} to={'/'} standard color='grey' content='Back' />
                        {!isFavorite &&
                            <Button standards color='orange' content='Add to favorites' onClick={() => handleAddToUserFavorite(Number(id))} />}
                        {isUsersProperty && (
                            <>
                                <Button as={Link} to={`/editProperty/${Number(id)}`} standard color='olive' content='Edit' />
                                <Button standards color='red' content='Delete' onClick={(e) => handleDeleteProperty(e, Number(id))} />
                            </>
                        )}
                    </Card.Content>
                </Card>
            </Grid.Column>
        </Grid>
    )
})