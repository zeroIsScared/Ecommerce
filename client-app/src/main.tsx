import React from 'react'
import ReactDOM from 'react-dom/client'
import './app/layout/style.css'
import { StoreContext, store } from './app/stores/store.ts'
import { RouterProvider } from 'react-router-dom'
import { router } from './app/router/Routes.tsx'
import { AsyncTrunk } from 'mobx-sync'
import { Auth0Provider } from '@auth0/auth0-react';

import history from './app/layout/utils/history.ts'

const domain = 'dev-wiyymhok8iumligg.us.auth0.com';  //import.meta.env.VITE_APP_AUTH0_DOMAIN;
const clientId = 'pIKQ0V5hgSwvM6LEP6gJXYiW0zAsZFX8'; //import.meta.env.VITE_APP_AUTH0_CLIENT_ID;
const audience = 'https://ecommerce.md/';//import.meta.env.VITE_APP_AUTH0_AUDIENCE;
console.log(domain);
console.log(clientId);
console.log(audience);

const onRedirectCallback = (appState) => {
  history.push(
    appState && appState.returnTo ? appState.returnTo : window.location.pathname
  );
};

const providerConfig = {
  domain: 'dev-wiyymhok8iumligg.us.auth0.com',
  clientId: 'pIKQ0V5hgSwvM6LEP6gJXYiW0zAsZFX8',
  onRedirectCallback,
  authorizationParams: {
    redirect_uri: window.location.origin,
    ...({ audience: 'https://ecommerce.md/' }),
  },
};

const trunk = new AsyncTrunk(store, { storage: localStorage });

/**
 * @desc load persisted stores
 */
trunk.init().then(() => { });

ReactDOM.createRoot(document.getElementById('root')!).render(
  <React.StrictMode>
    <Auth0Provider
      {...providerConfig}>
      <StoreContext.Provider value={store}>
        <RouterProvider router={router} />
      </StoreContext.Provider>
    </Auth0Provider>
  </React.StrictMode>,
)
