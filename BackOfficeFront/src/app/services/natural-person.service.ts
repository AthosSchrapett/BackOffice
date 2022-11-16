import { NaturalPerson } from './../models/natural-person.model';
import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http'
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class NaturalPersonService {

  endpoint: string = `${environment.backOfficeApi}/NaturalPerson`

  constructor(
    private httpClient: HttpClient
  ) { }

  getNaturalPersons(skip: number, take: number): Observable<NaturalPerson[]> {
    const url = `${this.endpoint}?skip=${skip}&take=${take}`
    return this.httpClient.get<NaturalPerson[]>(url);
  }

  getAllNaturalPersons(): Observable<NaturalPerson[]> {
    const url = `${this.endpoint}/GetAll`
    console.log(url)
    return this.httpClient.get<NaturalPerson[]>(url);
  }

  getNaturalPersonById(id: string): Observable<NaturalPerson> {
    const url = `${this.endpoint}/${id}`
    return this.httpClient.get<NaturalPerson>(url);
  }

  getCountNaturalPerson(): Observable<any> {
    const url = `${this.endpoint}/count`
    return this.httpClient.get<any>(url);
  }

  postNaturalPerson(naturalPerson: NaturalPerson): Observable<NaturalPerson> {
    return this.httpClient.post<NaturalPerson>(this.endpoint, naturalPerson);
  }

  deleteNaturalPersonById(id: string): Observable<NaturalPerson> {
    const url = `${this.endpoint}/${id}`
    return this.httpClient.delete<NaturalPerson>(url);
  }

  updateNaturalPerson(naturalPerson: NaturalPerson): Observable<NaturalPerson> {
    return this.httpClient.put<NaturalPerson>(this.endpoint, naturalPerson);
  }

}
