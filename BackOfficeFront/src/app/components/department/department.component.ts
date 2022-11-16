import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Department } from 'src/app/models/department.model';
import { DepartmentService } from 'src/app/services/department.service';

@Component({
  selector: 'app-department',
  templateUrl: './department.component.html',
  styleUrls: ['./department.component.css']
})
export class DepartmentComponent implements OnInit {

  displayStyle: string = "none";
  idDepartment: string = '';

  constructor(
    private departmentService: DepartmentService,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.getCountDepartments();
    this.getDepartments(this.itensPorPagina * (this.paginaAtual - 1), this.itensPorPagina);
  }

  departments: Department[] = [];
  paginaAtual: number = 1;
  itensPorPagina: number = 10;
  totalDepartments: number = 0;

  getDepartments(skip: number, take: number){
    this.departmentService.getDepartments(skip, take).subscribe(
      (res: Department[]) => {
        this.departments = res;
      });
  }

  getCountDepartments(){
    this.departmentService.getCountDepartment().subscribe(
      res => {
        this.totalDepartments = res.totalDepartment;
      }
    );
  }

  pageChangeEvent(event: number) {
      this.paginaAtual = event;
      this.getDepartments(this.itensPorPagina * (this.paginaAtual - 1), this.itensPorPagina);
  }

  goToEdit(id: string): void {
    this.router.navigateByUrl(`department/department-edit/${id}`);
  }

  goToInsert(): void {
    this.router.navigateByUrl(`department/department-insert/`);
  }

  abreModalDelete(idDepartment: string){
    this.idDepartment = idDepartment;
    this.displayStyle = "block";
  }

  DeleteDepartment(): void {
    this.departmentService.deleteDepartmentById(this.idDepartment).subscribe();
    this.displayStyle = "none";
    setTimeout(() => {
      window.location.reload();
    }, 0.5);
  }

}
