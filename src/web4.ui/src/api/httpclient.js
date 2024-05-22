import axios from 'axios';
import mainOidc from './authClient';

const httpclient = axios.create({
    baseURL: 'http://localhost:5272/api', 
    timeout: 3000,
    // auth: {
    //     username: 'identifiant',
    //     password: 'identifiant'
    // }
})

httpclient.defaults.headers.post['Content-Type'] = 'application/json'

httpclient.interceptors.request.use(request => {
    const account = mainOidc.user;
    const isLoggedIn = mainOidc.isAuthenticated;
    const isApiUrl = request.url.startsWith('/api')//prefix de votre api
    if (isLoggedIn && isApiUrl) {
   Request.headers.common.Authorization = `Bearer
   ${account.access_token}`;
    }
    return request;
   });
export default httpclient