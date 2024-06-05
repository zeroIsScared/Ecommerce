import { Button, Card, CardContent, CardDescription, CardHeader, CardMeta, Image } from "semantic-ui-react";
import { Property } from "../../../app/models/property";

interface Props {
    selectedProperty: Property;
    cancelSelectProperty: () => void;
    openForm: (id: number) => void;
}

export default function PropertiesDetails({ selectedProperty, cancelSelectProperty, openForm }: Props) {

    return (
        <Card fluid>
            <Image src={selectedProperty.photos[0].url} wrapped ui={false} />
            <CardContent>
                <CardHeader>{selectedProperty.title}</CardHeader>
                <CardMeta>
                    <span>{selectedProperty.address.localityName}</span>
                </CardMeta>
                <CardDescription>
                    {selectedProperty.description}
                </CardDescription>
            </CardContent>
            <Card.Content extra>
                <Button basic color='grey' content='Cancel' onClick={cancelSelectProperty} />
                <Button basic color='olive' content='Edit' onClick={() => openForm(selectedProperty.id)} />
            </Card.Content>
        </Card>
    )
}