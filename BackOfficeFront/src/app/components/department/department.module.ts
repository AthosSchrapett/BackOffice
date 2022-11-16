import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DepartmentComponent } from './department.component';
import { NgxMaskModule, IConfig } from 'ngx-mask';
import { SharedModule } from '../shared/shared.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NgxPaginationModule } from 'ngx-pagination';
import { DepartmentInsertEditComponent } from './department-insert-edit/department-insert-edit.component';
import { RouterModule } from '@angular/router';
import { DepartmentRouter } from './department.routing';

export const options: Partial<null|IConfig> | (() => Partial<IConfig>) = null;

@NgModule({
  declarations: [
    DepartmentComponent,
    DepartmentInsertEditComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    NgxPaginationModule,
    SharedModule,
    NgxMaskModule.forRoot(),
    RouterModule.forChild(DepartmentRouter)
  ]
})
export class DepartmentModule { }
