import { SharedModule } from './../shared/shared.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NaturalPersonComponent } from './natural-person.component';
import { NaturalPersonInsertEditComponent } from './natural-person-insert-edit/natural-person-insert-edit.component';
import { NgxMaskModule, IConfig } from 'ngx-mask';
import { NgxPaginationModule } from 'ngx-pagination';
import { RouterModule } from '@angular/router';
import { NaturalPersonRouter } from './natural-person.routing';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

export const options: Partial<null|IConfig> | (() => Partial<IConfig>) = null;

@NgModule({
  declarations: [
    NaturalPersonComponent,
    NaturalPersonInsertEditComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    NgxPaginationModule,
    SharedModule,
    NgxMaskModule.forRoot(),
    RouterModule.forChild(NaturalPersonRouter)
  ]
})
export class NaturalPersonModule { }
