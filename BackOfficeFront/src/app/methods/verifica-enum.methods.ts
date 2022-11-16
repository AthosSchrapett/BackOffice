import { Qualification } from "../models/enums/qualification.enum";

export class VerificaEnum {
  static mostraQualificacao(qualification: Qualification): string{
    if(qualification === Qualification.Cliente){
      return 'Cliente';
    }

    if(qualification === Qualification.Colaborador){
      return 'Colaborador';
    }

    return 'Fornecedor';
  }
}
