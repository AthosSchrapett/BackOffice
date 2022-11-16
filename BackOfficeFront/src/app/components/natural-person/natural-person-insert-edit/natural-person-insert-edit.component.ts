import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { PersonType } from 'src/app/models/enums/person-type.enum';
import { Qualification } from 'src/app/models/enums/qualification.enum';
import { NaturalPerson } from 'src/app/models/natural-person.model';
import { ViaCep } from 'src/app/models/viacep.model';
import { NaturalPersonService } from 'src/app/services/natural-person.service';
import { ViaCepService } from 'src/app/services/via-cep.service';
import { v4 as uuidv4 } from 'uuid';

@Component({
  selector: 'app-natural-person-insert-edit',
  templateUrl: './natural-person-insert-edit.component.html',
  styleUrls: ['./natural-person-insert-edit.component.css']
})
export class NaturalPersonInsertEditComponent implements OnInit {

  idNaturalPerson: string = '';
  naturalPerson: NaturalPerson = new NaturalPerson();
  endereco: ViaCep = new ViaCep();
  displayStyle: string = "none";
  modalTitle: string = '';
  telaDeCadastroOuEdicao: string = '';

  qualificacoes = [
    { value: Qualification.Cliente, text: 'Cliente' },
    { value: Qualification.Colaborador, text: 'Colaborador' },
    { value: Qualification.Fornecedor, text: 'Fornecedor' }
  ];

  tipos = [
    { value: PersonType.Natural, text: 'Pessoa Fisica' }
  ];

  constructor(
    private activatedRoute: ActivatedRoute,
    private formBuilder: FormBuilder,
    private naturalPersonService: NaturalPersonService,
    private viaCepService: ViaCepService
  ) { }

  ngOnInit(): void {
    this.getNaturalPerson();
  }

  getNaturalPerson() {
    if(this.activatedRoute.snapshot.url[0].path !== 'natural-person-insert'){
      this.idNaturalPerson = this.activatedRoute.snapshot.params["id"];
      this.telaDeCadastroOuEdicao = 'Editar Pessoa'

      this.naturalPersonService.getNaturalPersonById(this.idNaturalPerson).subscribe(
        (res: NaturalPerson) => {
          this.naturalPerson = res;
          this.formNaturalPerson.patchValue(this.naturalPerson);
        }
      );
    }
    else {
      this.telaDeCadastroOuEdicao = 'Cadastrar Pessoa'
      this.formNaturalPerson.controls['id'].setValue(uuidv4());
    }
  }

  getEnderecoViaCep(cep: string): void {
    this.viaCepService.getAddressViaCep(cep).subscribe(
      res => {
        this.endereco = res;
        this.formNaturalPerson.controls['address'].setValue(this.endereco.logradouro);
        this.formNaturalPerson.controls['complement'].setValue(this.endereco.complemento);
        this.formNaturalPerson.controls['cidade'].setValue(this.endereco.localidade);
        this.formNaturalPerson.controls['uf'].setValue(this.endereco.uf);
        this.formNaturalPerson.controls['bairro'].setValue(this.endereco.bairro);
      }
    );
  }

  onSubmit(): void{
    if(this.idNaturalPerson !== ''){
      this.naturalPersonService.updateNaturalPerson(this.formNaturalPerson.value).subscribe(
        res => {
          this.openPopup();
        }
      );
    }
    else {
      this.naturalPersonService.postNaturalPerson(this.formNaturalPerson.value).subscribe(
        res => {
          this.openPopup();
        }
      );
    }
  }

  formNaturalPerson: FormGroup = this.formBuilder.group({
    id: ['', [Validators.required]],
    nome: ['', [Validators.required]],
    nickname: ['', [Validators.required]],
    cpf: ['', [Validators.required]],
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

    if(this.idNaturalPerson === ''){
      this.modalTitle = "Pessoa incluída."
    }
    else {
      this.modalTitle = "Pessoa editada."
    }

    this.displayStyle = "block";
  }

}
