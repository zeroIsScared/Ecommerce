import React from 'react'
import ReactDOM from 'react-dom/client'
import './app/layout/style.css'
import { StoreContext, store } from './app/stores/store.ts'
import { RouterProvider } from 'react-router-dom'
import { router } from './app/router/Routes.tsx'
import { AsyncTrunk } from 'mobx-sync'




const trunk = new AsyncTrunk(store, { storage: localStorage });

/**
 * @desc load persisted stores
 */
trunk.init().then(() => {


});

ReactDOM.createRoot(document.getElementById('root')!).render(
  <React.StrictMode>
    <StoreContext.Provider value={store}>
      <RouterProvider router={router} />
    </StoreContext.Provider>
  </React.StrictMode>,
)
