import { Button, Card, CardContent, CardHeader, CardMeta, Image, Segment } from "semantic-ui-react";
import { useStore } from "../../app/stores/store";
import { Link } from "react-router-dom";
import { observer } from "mobx-react-lite";
import { useEffect, useState } from "react";



export default observer(function UserFavoritesList() {

    const { propertyStore } = useStore();
    const { deleteFromUserFavorites, userFavorites } = propertyStore;
    const [propertyIdDeleted, setPropertyIdDeleted] = useState<number | undefined>(undefined);

    const handleDeleteUserFavorite = (propertyId: number) => {
        setPropertyIdDeleted(propertyId);
    };

    useEffect(() => {
        if (propertyIdDeleted) {
            deleteFromUserFavorites({ userId: 3, propertyId: propertyIdDeleted });
        }
    }, [propertyIdDeleted]);

    if (userFavorites.length === 0) return <h1>No results were loaded!</h1>

    return (
        <Segment>
            <Card.Group divided>
                {userFavorites.map((favorite) => (

                    <Card key={favorite.property.id} clearing>
                        <CardContent>
                            <Image src={favorite.property.photoURL} />
                            <CardHeader>{favorite.property.title}</CardHeader>
                            <CardMeta>{`${favorite.property.price} ${favorite.property.currency.code}`}</CardMeta>
                        </CardContent>
                        <CardContent extra>
                            <div className="ui three buttons">
                                <Button as={Link} to={`/Properties/${favorite.propertyId}`} standard color='olive' >
                                    View
                                </Button>
                                <Button onClick={() => handleDeleteUserFavorite(favorite.property.id)}>
                                    Delete from favorites
                                </Button>
                            </div>
                        </CardContent>
                    </Card>
                ))}
            </Card.Group>
        </Segment >
    )
})


