import __vite__cjsImport0_react_jsxDevRuntime from "/node_modules/.vite/deps/react_jsx-dev-runtime.js?v=3adb2922"; const _jsxDEV = __vite__cjsImport0_react_jsxDevRuntime["jsxDEV"];
import __vite__cjsImport1_react from "/node_modules/.vite/deps/react.js?v=3adb2922"; const React = __vite__cjsImport1_react.__esModule ? __vite__cjsImport1_react.default : __vite__cjsImport1_react;
import __vite__cjsImport2_reactDom_client from "/node_modules/.vite/deps/react-dom_client.js?v=3adb2922"; const ReactDOM = __vite__cjsImport2_reactDom_client.__esModule ? __vite__cjsImport2_reactDom_client.default : __vite__cjsImport2_reactDom_client;
import "/src/app/layout/style.css?t=1717944147402";
import { StoreContext, store } from "/src/app/stores/store.ts?t=1717945223241";
import { RouterProvider } from "/node_modules/.vite/deps/react-router-dom.js?v=3adb2922";
import { router } from "/src/app/router/Routes.tsx?t=1717946676761";
import { AsyncTrunk } from "/node_modules/.vite/deps/mobx-sync.js?v=3adb2922";
const trunk = new AsyncTrunk(store, {
    storage: localStorage
});
/**
 * @desc load persisted stores
 */ trunk.init().then(()=>{});
ReactDOM.createRoot(document.getElementById('root')).render(/*#__PURE__*/ _jsxDEV(React.StrictMode, {
    children: /*#__PURE__*/ _jsxDEV(StoreContext.Provider, {
        value: store,
        children: /*#__PURE__*/ _jsxDEV(RouterProvider, {
            router: router
        }, void 0, false, {
            fileName: "C:/Users/natalia.levinta/OneDrive - Amdaris/Internship/Ecommerce/client-app/src/main.tsx",
            lineNumber: 25,
            columnNumber: 7
        }, this)
    }, void 0, false, {
        fileName: "C:/Users/natalia.levinta/OneDrive - Amdaris/Internship/Ecommerce/client-app/src/main.tsx",
        lineNumber: 24,
        columnNumber: 5
    }, this)
}, void 0, false, {
    fileName: "C:/Users/natalia.levinta/OneDrive - Amdaris/Internship/Ecommerce/client-app/src/main.tsx",
    lineNumber: 23,
    columnNumber: 3
}, this));

//# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJzb3VyY2VzIjpbIm1haW4udHN4Il0sInNvdXJjZXNDb250ZW50IjpbImltcG9ydCBSZWFjdCBmcm9tICdyZWFjdCdcbmltcG9ydCBSZWFjdERPTSBmcm9tICdyZWFjdC1kb20vY2xpZW50J1xuaW1wb3J0ICcuL2FwcC9sYXlvdXQvc3R5bGUuY3NzJ1xuaW1wb3J0IHsgU3RvcmVDb250ZXh0LCBzdG9yZSB9IGZyb20gJy4vYXBwL3N0b3Jlcy9zdG9yZS50cydcbmltcG9ydCB7IFJvdXRlclByb3ZpZGVyIH0gZnJvbSAncmVhY3Qtcm91dGVyLWRvbSdcbmltcG9ydCB7IHJvdXRlciB9IGZyb20gJy4vYXBwL3JvdXRlci9Sb3V0ZXMudHN4J1xuaW1wb3J0IHsgQXN5bmNUcnVuayB9IGZyb20gJ21vYngtc3luYydcblxuXG5cblxuY29uc3QgdHJ1bmsgPSBuZXcgQXN5bmNUcnVuayhzdG9yZSwgeyBzdG9yYWdlOiBsb2NhbFN0b3JhZ2UgfSk7XG5cbi8qKlxuICogQGRlc2MgbG9hZCBwZXJzaXN0ZWQgc3RvcmVzXG4gKi9cbnRydW5rLmluaXQoKS50aGVuKCgpID0+IHtcblxuXG59KTtcblxuUmVhY3RET00uY3JlYXRlUm9vdChkb2N1bWVudC5nZXRFbGVtZW50QnlJZCgncm9vdCcpISkucmVuZGVyKFxuICA8UmVhY3QuU3RyaWN0TW9kZT5cbiAgICA8U3RvcmVDb250ZXh0LlByb3ZpZGVyIHZhbHVlPXtzdG9yZX0+XG4gICAgICA8Um91dGVyUHJvdmlkZXIgcm91dGVyPXtyb3V0ZXJ9IC8+XG4gICAgPC9TdG9yZUNvbnRleHQuUHJvdmlkZXI+XG4gIDwvUmVhY3QuU3RyaWN0TW9kZT4sXG4pXG4iXSwibmFtZXMiOlsiUmVhY3QiLCJSZWFjdERPTSIsIlN0b3JlQ29udGV4dCIsInN0b3JlIiwiUm91dGVyUHJvdmlkZXIiLCJyb3V0ZXIiLCJBc3luY1RydW5rIiwidHJ1bmsiLCJzdG9yYWdlIiwibG9jYWxTdG9yYWdlIiwiaW5pdCIsInRoZW4iLCJjcmVhdGVSb290IiwiZG9jdW1lbnQiLCJnZXRFbGVtZW50QnlJZCIsInJlbmRlciIsIlN0cmljdE1vZGUiLCJQcm92aWRlciIsInZhbHVlIl0sInJhbmdlTWFwcGluZ3MiOiI7Ozs7Ozs7Ozs7Ozs7Ozs7OzsiLCJtYXBwaW5ncyI6IjtBQUFBLE9BQU9BLFdBQVcsUUFBTztBQUN6QixPQUFPQyxjQUFjLG1CQUFrQjtBQUN2QyxPQUFPLHlCQUF3QjtBQUMvQixTQUFTQyxZQUFZLEVBQUVDLEtBQUssUUFBUSx3QkFBdUI7QUFDM0QsU0FBU0MsY0FBYyxRQUFRLG1CQUFrQjtBQUNqRCxTQUFTQyxNQUFNLFFBQVEsMEJBQXlCO0FBQ2hELFNBQVNDLFVBQVUsUUFBUSxZQUFXO0FBS3RDLE1BQU1DLFFBQVEsSUFBSUQsV0FBV0gsT0FBTztJQUFFSyxTQUFTQztBQUFhO0FBRTVEOztDQUVDLEdBQ0RGLE1BQU1HLElBQUksR0FBR0MsSUFBSSxDQUFDLEtBR2xCO0FBRUFWLFNBQVNXLFVBQVUsQ0FBQ0MsU0FBU0MsY0FBYyxDQUFDLFNBQVVDLE1BQU0sZUFDMUQsUUFBQ2YsTUFBTWdCLFVBQVU7Y0FDZixjQUFBLFFBQUNkLGFBQWFlLFFBQVE7UUFBQ0MsT0FBT2Y7a0JBQzVCLGNBQUEsUUFBQ0M7WUFBZUMsUUFBUUEifQ==