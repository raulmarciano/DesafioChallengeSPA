import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Profissao } from '../models/profissao';

@Injectable()
export class ProfissaoService {
    urlApi = '/api/profissoes';

    constructor(private httpClient: HttpClient) { }

    getProfissao(): Observable<Profissao[]> {
        return this.httpClient.get<Profissao[]>(this.urlApi);
    }
}