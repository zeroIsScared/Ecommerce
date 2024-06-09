import { Container, Grid } from "semantic-ui-react";
import { useStore } from "../../app/stores/store";
import { useEffect } from "react";
import PropertiesList from "../properties/PropertiesList";
import UserFavoritesList from "./UserFavoritesList";
import propertyStore from "../../app/stores/propertyStore";
import { observer } from "mobx-react-lite";

export default observer(function UserFavorites() {
    const { propertyStore } = useStore();
    const { loadUserFavorites } = propertyStore;

    useEffect(() => {
        // eslint-disable-next-line react-hooks/rules-of-hooks


        propertyStore.loadUserFavorites();
    }, [loadUserFavorites, propertyStore]);

    return (
        <Grid padded>
            <Grid.Column width='12'>
                <UserFavoritesList />
            </Grid.Column>
            <Grid.Column width='4'>
                <h2>Property filters</h2>
            </Grid.Column>

        </Grid>
    )
})