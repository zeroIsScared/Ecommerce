
import { Fragment, useEffect, useState } from 'react';
import axios from 'axios';
import 'semantic-ui-css/semantic.min.css'
import { Container } from 'semantic-ui-react';
import { Properties } from '../models/properties';
import Navbar from './NavBar';
import PropertiesDashboard from '../../features/properties/PropertiesDashboard';
import { Property } from '../models/property';
import agent from '../api/agent';
import LoadingComponent from './LoadingComponent';

function App() {
  const [properties, setProperties] = useState<Properties[]>([]);
  const [selectedProperty, setSelectedProperty] = useState<Property | undefined>(undefined);
  const [selectedPropertyId, setSelectedPropertyId] = useState<number>(undefined);
  const [editMode, setEditMode] = useState(false);
  const [loading, setLoading] = useState(true);
  const [submiting, setSubmiting] = useState(false);

  useEffect(() => {
    agent.Properties.list()
      .then(response => {
        setProperties(response);
        setLoading(false);
      })
  }, [submiting]);

  useEffect(() => {

    agent.Properties.details(selectedPropertyId)
      .then(response => {
        setSelectedProperty(response);
        setLoading(false);
      })

  }, [selectedPropertyId]);

  function handleSelectPropertyId(id: number) {
    setSelectedPropertyId(id);
  }

  function handleCancelSelectProperty() {
    setSelectedPropertyId(properties[0].id);
    setSelectedProperty(undefined);
  }

  function handleFormOpen(id?: number) {
    id ? handleSelectPropertyId(id) : handleCancelSelectProperty();
    setEditMode(true);
  }

  function handleFormClose() {
    setEditMode(false);
  }

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


  function deleteProperty(id: number) {
    setSubmiting(true);
    agent.Properties.delete(id).then(() => {
      setProperties([...properties.filter(x => x.id !== id)]);
      setSubmiting(false);
    })
  }

  if (loading) return <LoadingComponent content='Loading app' />

  return (
    <Fragment>
      <Navbar openForm={handleFormOpen} />
      <Container style={{ marginTop: '7em' }}>
        <PropertiesDashboard
          properties={properties}
          selectedProperty={selectedProperty}
          selectPropertyId={handleSelectPropertyId}
          cancelSelectProperty={handleCancelSelectProperty}
          editMode={editMode}
          openForm={handleFormOpen}
          closeForm={handleFormClose}
          createOrEdit={handleCreateOrEditProperty}
          submiting={submiting}
          deleteProperty={deleteProperty}

        />
      </Container>
    </Fragment>
  )
}

export default App
