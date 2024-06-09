import { RouteObject, createBrowserRouter } from "react-router-dom";
import App from "../layout/App";
import HomePage from "../../features/userProperties/UserProperties";
import PropertiesDashboard from "../../features/properties/PropertiesDashboard";
import PropertyFrom from "../../features/properties/form/PropertyForm";
import UserProperties from "../../features/userProperties/UserProperties";
import PropertyForm from "../../features/properties/form/PropertyForm";
import UserFavorites from "../../features/userFavorites/UserFAvorites";
import { store } from "../stores/store";
import PropertiesDetails from "../../features/properties/details/PropertiesDetails";

export const routes: RouteObject[] = [
    {
        path: '/',
        element: <App />,
        children: [
            { path: '', element: <PropertiesDashboard /> },
            { path: 'userProperties', element: <UserProperties /> },
            { path: 'createProperty', element: <PropertyForm /> },
            { path: 'userFavorites', element: <UserFavorites /> },
            { path: 'Properties/:id', element: <PropertiesDetails /> },
        ]
    },
]
export const router = createBrowserRouter(routes);