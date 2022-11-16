import { NaturalPersonInsertEditComponent } from './natural-person-insert-edit/natural-person-insert-edit.component';
import { NaturalPersonComponent } from './natural-person.component';
import { Routes } from '@angular/router';

export const NaturalPersonRouter: Routes = [
  {
    path: '',
    component: NaturalPersonComponent
  },
  {
    path: 'natural-person-edit/:id',
    component: NaturalPersonInsertEditComponent
  },
  {
    path: 'natural-person-insert/',
    component: NaturalPersonInsertEditComponent
  }
];
