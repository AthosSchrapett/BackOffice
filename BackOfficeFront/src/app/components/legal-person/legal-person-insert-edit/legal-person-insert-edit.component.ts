import { PersonType } from './../../../models/enums/person-type.enum';
import { Qualification } from './../../../models/enums/qualification.enum';
import { ViaCep } from '../../../models/viacep.model';
import { ViaCepService } from '../../../services/via-cep.service';
import { LegalPersonService } from '../../../services/legal-person.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { LegalPerson } from 'src/app/models/legal-person.model';
import { FormBuilder, Validators, FormGroup } from '@angular/forms';
import { v4 as uuidv4 } from 'uuid';

@Component({
  selector: 'app-legal-person-insert-edit',
  templateUrl: './legal-person-insert-edit.component.html',
  styleUrls: ['./legal-person-insert-edit.component.css']
})
export class LegalPersonInsertEditComponent implements OnInit {

  idLegalPerson: string = '';
  legalPerson: LegalPerson = new LegalPerson();
  endereco: ViaCep = new ViaCep();
  displayStyle: string = "none";
  modalTitle: string = '';
  telaDeCadastroOuEdicao: string = '';

  qualificacoes = [
    { value: Qualification.Cliente, text: 'Cliente' },
    { value: Qualification.Fornecedor, text: 'Fornecedor' }
  ];

  tipos = [
    { value: PersonType.Legal, text: 'Empresa' }
  ];

  constructor(
    private activatedRoute: ActivatedRoute,
    private formBuilder: FormBuilder,
    private legalPersonService: LegalPersonService,
    private viaCepService: ViaCepService
  ) { }

  ngOnInit(): void {
    this.getLegalPerson();
  }

  getLegalPerson() {
    if(this.activatedRoute.snapshot.url[0].path !== 'legal-person-insert'){
      this.idLegalPerson = this.activatedRoute.snapshot.params["id"];
      this.telaDeCadastroOuEdicao = 'Editar Empresa'

      this.legalPersonService.getLegalPersonById(this.idLegalPerson).subscribe(
        (res: LegalPerson) => {
          this.legalPerson = res;
          this.formLegalPerson.patchValue(this.legalPerson);
        }
      );
    }
    else {
      this.telaDeCadastroOuEdicao = 'Cadastrar Empresa'
      this.formLegalPerson.controls['id'].setValue(uuidv4());
    }
  }

  getEnderecoViaCep(cep: string): void {
    this.viaCepService.getAddressViaCep(cep).subscribe(
      res => {
        this.endereco = res;
        this.formLegalPerson.controls['address'].setValue(this.endereco.logradouro);
        this.formLegalPerson.controls['complement'].setValue(this.endereco.complemento);
        this.formLegalPerson.controls['cidade'].setValue(this.endereco.localidade);
        this.formLegalPerson.controls['uf'].setValue(this.endereco.uf);
        this.formLegalPerson.controls['bairro'].setValue(this.endereco.bairro);
      }
    );
  }

  onSubmit(): void{
    if(this.idLegalPerson !== ''){
      this.legalPersonService.updateLegalPerson(this.formLegalPerson.value).subscribe(
        res => {
          this.openPopup();
        }
      );
    }
    else {
      this.legalPersonService.postLegalPerson(this.formLegalPerson.value).subscribe(
        res => {
          this.openPopup();
        }
      );
    }
  }

  formLegalPerson: FormGroup = this.formBuilder.group({
    id: ['', [Validators.required]],
    nome: ['', [Validators.required]],
    tradeName: ['', [Validators.required]],
    cnpj: ['', [Validators.required]],
    cep: ['', [Validators.required]],
    address: ['', [Validators.required]],
    number: ['', [Validators.required]],
    complement: [''],
    cidade: ['', [Validators.required]],
    bairro: ['', [Validators.required]],
    uf: ['', [Validators.required]],
    type: [0, [Validators.required]],
    qualification: [0, [Validators.required]]
  });

  openPopup() {

    if(this.idLegalPerson === ''){
      this.modalTitle = "Empresa incluída."
    }
    else {
      this.modalTitle = "Empresa editada."
    }

    this.displayStyle = "block";
  }
}
