import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Cliente } from '../models/cliente';

@Injectable()
export class ClienteService {
    urlApi = '/api/clientes';

    constructor(private httpClient: HttpClient) { }

    getCliente(): Observable<Cliente[]> {
        return this.httpClient.get<Cliente[]>(this.urlApi);
    }

    createCliente(cliente: Cliente): Observable<Cliente> {
        return this.httpClient.post<Cliente>(this.urlApi, cliente);
    }

    editCliente(cliente: Cliente): Observable<Cliente> {
        return this.httpClient.put<Cliente>(`${this.urlApi}?id=${cliente.id}`, cliente);
    }

    deleteCliente(id: number): Observable<any> {
        return this.httpClient.delete<any>(`${this.urlApi}?id=${id}`)
    }
}