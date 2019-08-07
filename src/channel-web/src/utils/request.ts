import Axios, { AxiosRequestConfig } from "axios";

Axios.interceptors.response.use(response => {
    return response
}, error => {
    // error
    
    return Promise.reject(error);
})

export default (url: string, config?: AxiosRequestConfig) =>
    Axios(url, config)