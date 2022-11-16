import { LegalPerson } from './../models/legal-person.model';
import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http'
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ViaCep } from '../models/viacep.model';

@Injectable({
  providedIn: 'root'
})
export class ViaCepService {

  endpoint: string = `${environment.viaCepApi}`

  constructor(
    private httpClient: HttpClient
  ) { }

  getAddressViaCep(cep: string): Observable<ViaCep> {
    const url = `${this.endpoint}/${cep}/json/`
    return this.httpClient.get<ViaCep>(url);
  }

}
