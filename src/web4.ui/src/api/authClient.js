import { createOidcAuth, SignInType,LogLevel } from 'vue-oidc-client/vue3';

const appRootUrl = 'http://localhost:8080/'

// SignInType could be Window or Popup
const mainOidc = createOidcAuth('vuejs',
    SignInType.Popup,
    appRootUrl,
        {
            authority: 'https://localhost:5001/',
            client_id: 'web4_ui',
            response_type: 'code',
            scope: 'openid profile web2ApiScope' //web2ApiScope
        },
    console,
    LogLevel.Debug  
);
export default mainOidc