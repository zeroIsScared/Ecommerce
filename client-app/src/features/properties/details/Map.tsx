

import { useStore } from "../../../app/stores/store";
import { APIProvider, Map, Marker } from '@vis.gl/react-google-maps';

const mapContainerStyle = {
    height: "400px",
    width: "100%",
    padding: "1em"
};

const MapComponent = () => {
    const { propertyStore } = useStore();
    const { selectedProperty } = propertyStore;

    console.log(selectedProperty?.address.latitude, selectedProperty?.address.longitude)
    const position = { lat: Number(selectedProperty?.address.latitude), lng: Number(selectedProperty?.address.longitude) };
    return (


        <APIProvider apiKey={'AIzaSyDrmRNAFpEq6rjiQjMzp-rgcN3pNaXgxbY'}>
            <Map
                center={position}
                defaultZoom={15}
                gestureHandling={'greedy'}
                disableDefaultUI={true}
                style={mapContainerStyle}
            >
                <Marker position={position} />
            </Map>
        </APIProvider>
    );
};

export default MapComponent;