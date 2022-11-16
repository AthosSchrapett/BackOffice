import { Qualification } from './../../models/enums/qualification.enum';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NaturalPerson } from 'src/app/models/natural-person.model';
import { NaturalPersonService } from 'src/app/services/natural-person.service';
import { VerificaEnum } from 'src/app/methods/verifica-enum.methods';

@Component({
  selector: 'app-natural-person',
  templateUrl: './natural-person.component.html',
  styleUrls: ['./natural-person.component.css']
})
export class NaturalPersonComponent implements OnInit {

  displayStyle: string = "none";
  idNaturalPerson: string = '';

  constructor(
    private naturalPersonService: NaturalPersonService,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.getCountNaturalPersons();
    this.getNaturalPersons(this.itensPorPagina * (this.paginaAtual - 1), this.itensPorPagina);
  }

  naturalPersons: NaturalPerson[] = [];
  paginaAtual: number = 1;
  itensPorPagina: number = 10;
  totalNaturalPersons: number = 0;

  getNaturalPersons(skip: number, take: number){
    this.naturalPersonService.getNaturalPersons(skip, take).subscribe(
      (res: NaturalPerson[]) => {
        this.naturalPersons = res;
      });
  }

  getCountNaturalPersons(){
    this.naturalPersonService.getCountNaturalPerson().subscribe(
      res => {
        this.totalNaturalPersons = res.totalNaturalPerson;
      }
    );
  }

  pageChangeEvent(event: number) {
      this.paginaAtual = event;
      this.getNaturalPersons(this.itensPorPagina * (this.paginaAtual - 1), this.itensPorPagina);
  }

  goToEdit(id: string): void {
    this.router.navigateByUrl(`naturalPerson/natural-person-edit/${id}`);
  }

  goToInsert(): void {
    this.router.navigateByUrl(`naturalPerson/natural-person-insert/`);
  }

  abreModalDelete(idNaturalPerson: string){
    this.idNaturalPerson = idNaturalPerson;
    this.displayStyle = "block";
  }

  DeleteNaturalPerson(): void {
    this.naturalPersonService.deleteNaturalPersonById(this.idNaturalPerson).subscribe();
    this.displayStyle = "none";
    setTimeout(() => {
      window.location.reload();
    }, 0.5);
  }

  mostraQualificacao(qualification: Qualification): string {
    return VerificaEnum.mostraQualificacao(qualification);
  }
}
