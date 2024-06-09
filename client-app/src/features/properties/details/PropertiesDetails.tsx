import { Button, Card, CardContent, CardDescription, CardHeader, CardMeta, Grid } from "semantic-ui-react";
import { useStore } from "../../../app/stores/store";
import { useEffect } from "react";
import LoadingComponent from "../../../app/layout/LoadingComponent";
import { Link, useParams } from "react-router-dom";
import { observer } from "mobx-react-lite";
import ImageGallery from 'react-image-gallery';

interface ImageArray {
    original: string,
    thumbnail: string
}

export default observer(function PropertiesDetails() {

    const { propertyStore } = useStore();
    const { selectedProperty, loading, loadSelectedProperty } = propertyStore;
    const { id } = useParams();

    useEffect(() => {
        if (id) loadSelectedProperty(id)
    }, [id, loadSelectedProperty]);

    const images: ImageArray[] = [];

    const images1: ImageArray[] = [
        {
            original: "https://github.com/zeroIsScared/Ecommerce/blob/master/client-app/public/assets/BI78kU.jpg",
            thumbnail: ""
        }
    ]

    selectedProperty?.photos.flatMap(image => images.push({
        original: image.url,
        thumbnail: image.url
    }));

    if (loading) return <LoadingComponent content='Loading property details' />

    return (
        <Grid>
            <Grid.Column width='10'>
                <Card fluid>
                    <div className="image-gallery-wrapper">
                        <ImageGallery items={images1} />
                    </div>
                    <CardContent>
                        <CardHeader>{selectedProperty?.title}</CardHeader>
                        <CardMeta>
                            <span>{selectedProperty?.address.localityName}</span>
                        </CardMeta>
                        <CardDescription>
                            {selectedProperty?.description}
                        </CardDescription>
                    </CardContent>
                    <Card.Content extra>
                        <Button as={Link} to={'/'} basic color='grey' content='Back' />
                        <Button basic color='olive' content='Edit' />
                    </Card.Content>
                </Card>
            </Grid.Column>
        </Grid>
    )
})