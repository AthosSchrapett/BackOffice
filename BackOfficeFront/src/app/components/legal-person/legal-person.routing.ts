import { LegalPersonInsertEditComponent } from './legal-person-insert-edit/legal-person-insert-edit.component';
import { LegalPersonComponent } from './legal-person.component';
import { Routes } from '@angular/router';

export const LegalPersonRouter: Routes = [
  {
    path: '',
    component: LegalPersonComponent
  },
  {
    path: 'legal-person-edit/:id',
    component: LegalPersonInsertEditComponent
  },
  {
    path: 'legal-person-insert/',
    component: LegalPersonInsertEditComponent
  }
];
