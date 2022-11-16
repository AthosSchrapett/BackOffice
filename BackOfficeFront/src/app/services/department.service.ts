import { Department } from './../models/department.model';
import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http'
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DepartmentService {

  endpoint: string = `${environment.backOfficeApi}/Department`

  constructor(
    private httpClient: HttpClient
  ) { }

  getDepartments(skip: number, take: number): Observable<Department[]> {
    const url = `${this.endpoint}?skip=${skip}&take=${take}`
    return this.httpClient.get<Department[]>(url);
  }

  getDepartmentById(id: string): Observable<Department> {
    const url = `${this.endpoint}/${id}`
    return this.httpClient.get<Department>(url);
  }

  getCountDepartment(): Observable<any> {
    const url = `${this.endpoint}/count`
    return this.httpClient.get<any>(url);
  }

  postDepartment(department: Department): Observable<Department> {
    return this.httpClient.post<Department>(this.endpoint, department);
  }

  deleteDepartmentById(id: string): Observable<Department> {
    const url = `${this.endpoint}/${id}`
    return this.httpClient.delete<Department>(url);
  }

  updateDepartment(department: Department): Observable<Department> {
    return this.httpClient.put<Department>(this.endpoint, department);
  }

}
