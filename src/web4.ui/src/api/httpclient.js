import axios from 'axios';

const httpclient = axios.create({
    baseURL: 'https://localhost:8194/',
    timeout: 3000,
    auth: {
        username: 'identifiant',
        password: 'identifiant'
    }
})

httpclient.defaults.headers.post['Content-Type'] = 'application/json'

export default httpclient