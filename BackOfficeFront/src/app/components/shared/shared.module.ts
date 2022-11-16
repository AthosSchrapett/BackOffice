import { CommonModule } from '@angular/common';
import { ModalExclusionComponent } from './modal-exclusion/modal-exclusion.component';
import { ModalConfirmationComponent } from './modal-confirmation/modal-confirmation.component';
import { NgModule } from '@angular/core';

@NgModule({
  declarations: [
    ModalConfirmationComponent,
    ModalExclusionComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    ModalConfirmationComponent,
    ModalExclusionComponent
  ]
})
export class SharedModule { }
