import { RouteObject, createBrowserRouter } from "react-router-dom";
import App from "../layout/App";
import PropertiesDashboard from "../../features/properties/PropertiesDashboard";
import UserProperties from "../../features/userProperties/UserProperties";
import PropertyForm from "../../features/properties/form/PropertyForm";
import UserFavorites from "../../features/userFavorites/UserFavorites";
import PropertiesDetails from "../../features/properties/details/PropertiesDetails";

export const routes: RouteObject[] = [
    {
        path: '/',
        element: <App />,
        children: [
            { path: '', element: <PropertiesDashboard /> },
            { path: 'userProperties', element: <UserProperties /> },
            { path: 'createProperty', element: <PropertyForm key='create' /> },
            { path: 'userFavorites', element: <UserFavorites /> },
            { path: 'Properties/:id', element: <PropertiesDetails /> },
            { path: 'editProperty/:id', element: <PropertyForm key='manage' /> },
        ]
    },
]
export const router = createBrowserRouter(routes);