import axios from 'axios';

const httpclient = axios.create({
    baseURL: 'http://localhost:5272/api',
    timeout: 3000,
    defaults: {
        headers: {
            common: 'Access-Control-Allow-Origin'
        }
    }
    // auth: {
    //     username: 'identifiant',
    //     password: 'identifiant'
    // }
})

httpclient.defaults.headers.post['Content-Type'] = 'application/json'

export default httpclient