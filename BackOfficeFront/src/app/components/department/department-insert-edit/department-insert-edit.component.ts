import { NaturalPerson } from 'src/app/models/natural-person.model';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { Department } from 'src/app/models/department.model';
import { DepartmentService } from 'src/app/services/department.service';
import { v4 as uuidv4 } from 'uuid';
import { NaturalPersonService } from 'src/app/services/natural-person.service';

@Component({
  selector: 'app-department-insert-edit',
  templateUrl: './department-insert-edit.component.html',
  styleUrls: ['./department-insert-edit.component.css']
})
export class DepartmentInsertEditComponent implements OnInit {

  idDepartment: string = '';
  department: Department = new Department();
  naturalPersons: NaturalPerson[] = [];

  displayStyle: string = "none";
  modalTitle: string = '';
  telaDeCadastroOuEdicao: string = '';

  constructor(
    private activatedRoute: ActivatedRoute,
    private formBuilder: FormBuilder,
    private naturalPersonService: NaturalPersonService,
    private departmentService: DepartmentService,
  ) { }

  ngOnInit(): void {
    this.getDepartment();
  }

  getDepartment() {

    this.getAllNaturalPersons();

    if(this.activatedRoute.snapshot.url[0].path !== 'department-insert'){
      this.idDepartment = this.activatedRoute.snapshot.params["id"];
      this.telaDeCadastroOuEdicao = 'Editar Departamento'

      this.departmentService.getDepartmentById(this.idDepartment).subscribe(
        (res: Department) => {
          this.department = res;
          this.formDepartment.patchValue(this.department);
        }
      );
    }
    else {
      this.telaDeCadastroOuEdicao = 'Cadastrar Departamento'
      this.formDepartment.controls['id'].setValue(uuidv4());
    }
  }

  onSubmit(): void{
    if(this.idDepartment !== ''){
      this.departmentService.updateDepartment(this.formDepartment.value).subscribe(
        res => {
          this.openPopup();
        }
      );
    }
    else {
      this.departmentService.postDepartment(this.formDepartment.value).subscribe(
        res => {
          this.openPopup();
        }
      );
    }
  }

  getAllNaturalPersons(): void {
    this.naturalPersonService.getAllNaturalPersons().subscribe(
      (res: NaturalPerson[]) => {
        this.naturalPersons = res;
      }
    );
  }

  formDepartment: FormGroup = this.formBuilder.group({
    id: ['', [Validators.required]],
    nome: ['', [Validators.required]],
    naturalPersonId: ['', [Validators.required]],
  });

  openPopup() {

    if(this.idDepartment === ''){
      this.modalTitle = "Departamento incluído."
    }
    else {
      this.modalTitle = "Departamento editado."
    }

    this.displayStyle = "block";
  }

}
