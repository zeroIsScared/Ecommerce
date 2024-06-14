
import { useStore } from "../../app/stores/store";
import { useEffect, useState } from "react";
import UserFavoritesList from "./UserFavoritesList";
import { observer } from "mobx-react-lite";
import LoadingComponent from "../../app/layout/LoadingComponent";
import { Grid } from "semantic-ui-react";

export default observer(function UserFavorites() {
    const { propertyStore } = useStore();
    const { userFavorites, loading, deleteFromUserFavorites } = propertyStore;

    useEffect(() => {
        // eslint-disable-next-line react-hooks/rules-of-hooks
        propertyStore.loadUserFavorites();

    }, [propertyStore, deleteFromUserFavorites]);

    if (loading == true) return <LoadingComponent content={'Loading favorites properties'} />

    if (loading == false && userFavorites.length === 0) return <h1>No results were loaded!</h1>

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