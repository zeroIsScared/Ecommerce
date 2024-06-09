import { Button, Card, CardContent, CardHeader, CardMeta, Image, Segment } from "semantic-ui-react";
import { useStore } from "../../app/stores/store";
import { Link } from "react-router-dom";



export default function UserFavoritesList() {
    const { propertyStore } = useStore();
    const { userFavorites } = propertyStore;
    console.log(userFavorites);

    return (
        <Segment>
            <Card.Group divided>
                {userFavorites.map((favorite) => (

                    <Card key={favorite.property.id} clearing>
                        <CardContent>
                            {favorite.property.photos.map(photo =>
                                <Image src={photo.url}
                                />
                            )}
                            <CardHeader>{favorite.property.title}</CardHeader>
                            <CardMeta>{`${favorite.property.price} ${favorite.property.currency.code}`}</CardMeta>
                        </CardContent>
                        <CardContent extra>
                            <div className="ui three buttons">
                                <Button as={Link} to={`/Properties/${favorite.propertyId}`} standard color='olive' >
                                    View
                                </Button>

                                <Button>
                                    Delete
                                </Button>
                            </div>
                        </CardContent>
                    </Card>
                ))}
            </Card.Group>
        </Segment >
    )
}


