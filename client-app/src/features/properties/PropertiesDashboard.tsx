import { Grid } from "semantic-ui-react";
import { Properties } from "../../app/models/properties";
import PropertiesList from "./PropertiesList";
import PropertiesDetails from "./details/PropertiesDetails";
import PropertyForm from "./form/PropertyForm";
import { Property } from "../../app/models/property";


interface Props {
    properties: Properties[];
    selectedProperty: Property | undefined;
    selectPropertyId: (id: number) => void;
    cancelSelectProperty: () => void;
    editMode: boolean;
    openForm: (id: number) => void;
    closeForm: () => void;
    createOrEdit: (property: Property) => void;
    submiting: boolean;
    deleteProperty: (id: number) => void;
}

export default function PropertiesDashboard({ properties,
    selectPropertyId, cancelSelectProperty, selectedProperty, editMode, openForm, closeForm, createOrEdit, submiting, deleteProperty }: Props) {

    return (
        <Grid padded>
            <Grid.Column width='10'>
                <PropertiesList properties={properties}
                    selectPropertyId={selectPropertyId}
                    deleteProperty={deleteProperty}
                    submiting={submiting} />
            </Grid.Column>
            <Grid.Column width='6'>
                {selectedProperty && !editMode &&
                    <PropertiesDetails
                        selectedProperty={selectedProperty}
                        cancelSelectProperty={cancelSelectProperty}
                        openForm={openForm}
                    />}

                {editMode &&
                    <PropertyForm
                        closeForm={closeForm}
                        selectedProperty={selectedProperty}
                        createOrEdit={createOrEdit}
                        submiting={submiting} />}
            </Grid.Column>
        </Grid>
    )
}