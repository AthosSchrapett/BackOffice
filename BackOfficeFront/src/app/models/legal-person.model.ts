import { Person } from "./person.model";

export class LegalPerson extends Person {
  cnpj: string = '';
  tradeName: string = '';
}
