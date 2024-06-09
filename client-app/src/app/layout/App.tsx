
import { Fragment, useEffect, useState } from 'react';
import 'semantic-ui-css/semantic.min.css'
import { Container } from 'semantic-ui-react';
import { Properties } from '../models/properties';
import Navbar from './NavBar';
import PropertiesDashboard from '../../features/properties/PropertiesDashboard';
import { Property } from '../models/property';
import agent from '../api/agent';
import LoadingComponent from './LoadingComponent';
import { trunk, useStore } from '../stores/store';
import { Outlet } from 'react-router-dom';

function App() {
  const { propertyStore } = useStore();


  const [submiting, setSubmiting] = useState(false);



  // useEffect(() => {
  //   if (propertyStore.selectedPropertyId) {
  //     agent.Properties.details(propertyStore.selectedPropertyId)
  //       .then(response => {
  //         setSelectedProperty(response);
  //       })
  //   }

  // }, [propertyStore.selectedPropertyId]);

  function handleCreateOrEditProperty(property: Property) {
    setSubmiting(true);

    if (property.id) {
      {
        agent.Properties.update(property).then(() => {

          setSelectedProperty(property);
          setSelectedPropertyId(property.id);
          setEditMode(false);
          setSubmiting(false);
        })
      }
    } else {
      property.id = 0;
      agent.Properties.create(property).then(() => {

        setSelectedProperty(property);
        setEditMode(false);
        setSubmiting(false);
      })
    }
  }




  if (propertyStore.loadingInitial) return <LoadingComponent content='Loading app' />

  return (
    <Fragment>
      <Navbar />
      <section style={{ marginTop: '7em' }}>
        <Outlet />
      </section>
    </Fragment>
  )
}

export default App
