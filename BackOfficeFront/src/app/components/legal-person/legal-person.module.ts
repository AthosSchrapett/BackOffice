import { SharedModule } from './../shared/shared.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LegalPersonComponent } from './legal-person.component';
import { RouterModule } from '@angular/router';
import { LegalPersonRouter } from './legal-person.routing';
import { LegalPersonInsertEditComponent } from './legal-person-insert-edit/legal-person-insert-edit.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgxMaskModule, IConfig } from 'ngx-mask';
import { NgxPaginationModule } from 'ngx-pagination';

export const options: Partial<null|IConfig> | (() => Partial<IConfig>) = null;

@NgModule({
  declarations: [
    LegalPersonComponent,
    LegalPersonInsertEditComponent,
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    NgxPaginationModule,
    SharedModule,
    NgxMaskModule.forRoot(),
    RouterModule.forChild(LegalPersonRouter)
  ]
})
export class LegalPersonModule { }
