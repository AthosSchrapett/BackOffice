import { LegalPerson } from './../models/legal-person.model';
import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http'
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LegalPersonService {

  endpoint: string = `${environment.backOfficeApi}/LegalPerson`

  constructor(
    private httpClient: HttpClient
  ) { }

  getLegalPersons(skip: number, take: number): Observable<LegalPerson[]> {
    const url = `${this.endpoint}?skip=${skip}&take=${take}`
    return this.httpClient.get<LegalPerson[]>(url);
  }

  getLegalPersonById(id: string): Observable<LegalPerson> {
    const url = `${this.endpoint}/${id}`
    return this.httpClient.get<LegalPerson>(url);
  }

  getCountLegalPerson(): Observable<any> {
    const url = `${this.endpoint}/count`
    return this.httpClient.get<any>(url);
  }

  postLegalPerson(legalPerson: LegalPerson): Observable<LegalPerson> {
    return this.httpClient.post<LegalPerson>(this.endpoint, legalPerson);
  }

  deleteLegalPersonById(id: string): Observable<LegalPerson> {
    const url = `${this.endpoint}/${id}`
    return this.httpClient.delete<LegalPerson>(url);
  }

  updateLegalPerson(legalPerson: LegalPerson): Observable<LegalPerson> {
    return this.httpClient.put<LegalPerson>(this.endpoint, legalPerson);
  }

}
