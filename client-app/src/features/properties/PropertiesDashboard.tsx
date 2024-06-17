import { Grid } from "semantic-ui-react";
import PropertiesList from "./PropertiesList";
import { useStore } from "../../app/stores/store";
import { useEffect } from "react";
import { observer } from "mobx-react-lite";



export default observer(function PropertiesDashboard() {
    const { propertyStore } = useStore();

    useEffect(() => {
        propertyStore.loadProperties()
    }, [propertyStore]);

    return (
        <Grid padded>
            <Grid.Column width='16'>
                <PropertiesList />
            </Grid.Column>
        </Grid>
    )
})