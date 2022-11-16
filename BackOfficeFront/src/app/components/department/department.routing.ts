import { DepartmentInsertEditComponent } from './department-insert-edit/department-insert-edit.component';
import { DepartmentComponent } from './department.component';
import { Routes } from '@angular/router';

export const DepartmentRouter: Routes = [
  {
    path: '',
    component: DepartmentComponent
  },
  {
    path: 'department-edit/:id',
    component: DepartmentInsertEditComponent
  },
  {
    path: 'department-insert/',
    component: DepartmentInsertEditComponent
  }
];
