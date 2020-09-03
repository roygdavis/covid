import axios from "axios";
import { Row } from "./model";

const http = {
    get: axios.get,
    post: axios.post,
    put: axios.put,
    delete: axios.delete,
    patch: axios.patch
};

const endpoint = `${process.env.API_URL}`;

export const getDataForCountry = async (country: string) => {
    return http.get<Row[]>(`/api/CovidData/ByCountry?country=${country}`);
}