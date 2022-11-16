import { Routes } from "@angular/router";

export const AppRouter: Routes = [
  {
    path: '',
    redirectTo: 'legalPerson',
    pathMatch: 'full'
  },
  {
    path: 'legalPerson',
    loadChildren: () => import('./components/legal-person/legal-person.module').then(x => x.LegalPersonModule)
  },
  {
    path: 'naturalPerson',
    loadChildren: () => import('./components/natural-person/natural-person.module').then(x => x.NaturalPersonModule)
  },
  {
    path: 'department',
    loadChildren: () => import('./components/department/department.module').then(x => x.DepartmentModule)
  }
]
