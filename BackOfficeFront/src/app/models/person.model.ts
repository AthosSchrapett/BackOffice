import { BaseEntity } from './base-entity.model';
import { Qualification } from './enums/qualification.enum';
import { PersonType } from "./enums/person-type.enum"

export class Person extends BaseEntity {
  type: PersonType = PersonType.Legal;
  nome: string = '';
  cep: string = '';
  address: string = '';
  number: string = '';
  complement: string = '';
  cidade: string = '';
  bairro: string = '';
  uf: string = '';
  qualification: Qualification = Qualification.Cliente;
}
