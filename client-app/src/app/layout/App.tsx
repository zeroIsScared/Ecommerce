
import { Fragment, useState } from 'react';
import 'semantic-ui-css/semantic.min.css';
import LoadingComponent from './LoadingComponent';
import { useStore } from '../stores/store';
import { Outlet } from 'react-router-dom';
import Navbar from './NavBar';

function App() {
  const { propertyStore } = useStore();

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
