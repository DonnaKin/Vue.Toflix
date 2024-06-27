import axios, { AxiosRequestConfig, AxiosResponse } from "axios";
import { ref } from 'vue'

export async function get<T>(config: AxiosRequestConfig): Promise<T> {
  config.url = path(config.url!);
  config.method = 'GET';
  const response: AxiosResponse<T> = await axios(config); 
  return response.data;
}

export async function post<T>(config: AxiosRequestConfig): Promise<T> {
  config.url = path(config.url!);
  config.method = 'POST';

  if (config.data instanceof FormData)
    config.headers = { "Content-Type" : "multipart/form-data" };
  else
    config.headers = { "Content-Type" : "application/json" };
  
  const response: AxiosResponse<T> = await axios(config);
  return response.data;
}

const path = (url: string): string => {
  const rootUrl = ref<string>('');

  if (process.env.NODE_ENV == 'production')
    rootUrl.value = '/cm';

  const path = ref<string>('');

  if (url.startsWith('/')) {
    path.value = rootUrl.value + url
  } else if (url.startsWith('http://') || url.startsWith('https://')) {
    path.value = url;
  } else {
    path.value = url;
  }

  return path.value;
}