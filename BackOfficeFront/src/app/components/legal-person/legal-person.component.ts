import { LegalPerson } from './../../models/legal-person.model';
import { LegalPersonService } from './../../services/legal-person.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { VerificaEnum } from 'src/app/methods/verifica-enum.methods';
import { Qualification } from 'src/app/models/enums/qualification.enum';

@Component({
  selector: 'app-legal-person',
  templateUrl: './legal-person.component.html',
  styleUrls: ['./legal-person.component.css']
})
export class LegalPersonComponent implements OnInit {

  displayStyle: string = "none";
  idLegalPerson: string = '';

  constructor(
    private legalPersonService: LegalPersonService,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.getCountLegalPersons();
    this.getLegalPersons(this.itensPorPagina * (this.paginaAtual - 1), this.itensPorPagina);
  }

  legalPersons: LegalPerson[] = [];
  paginaAtual: number = 1;
  itensPorPagina: number = 10;
  totalLegalPersons: number = 0;

  getLegalPersons(skip: number, take: number){
    this.legalPersonService.getLegalPersons(skip, take).subscribe(
      (res: LegalPerson[]) => {
        this.legalPersons = res;
      });
  }

  getCountLegalPersons(){
    this.legalPersonService.getCountLegalPerson().subscribe(
      res => {
        this.totalLegalPersons = res.totalLegalPerson;
      }
    );
  }

  pageChangeEvent(event: number) {
      this.paginaAtual = event;
      this.getLegalPersons(this.itensPorPagina * (this.paginaAtual - 1), this.itensPorPagina);
  }

  goToEdit(id: string): void {
    this.router.navigateByUrl(`legalPerson/legal-person-edit/${id}`);
  }

  goToInsert(): void {
    this.router.navigateByUrl(`legalPerson/legal-person-insert/`);
  }

  abreModalDelete(idLegalPerson: string){
    this.idLegalPerson = idLegalPerson;
    this.displayStyle = "block";
  }

  DeleteLegalPerson(): void {
    this.legalPersonService.deleteLegalPersonById(this.idLegalPerson).subscribe();
    this.displayStyle = "none";
    setTimeout(() => {
      window.location.reload();
    }, 0.5);
  }

  mostraQualificacao(qualification: Qualification): string {
    return VerificaEnum.mostraQualificacao(qualification);
  }

}
