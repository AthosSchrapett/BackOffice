import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-modal-exclusion',
  templateUrl: './modal-exclusion.component.html',
  styleUrls: ['./modal-exclusion.component.css']
})
export class ModalExclusionComponent implements OnInit {

  @Input() modalTitle: string = '';
  @Input() displayStyle: string = "none";
  @Output() deleteRequest = new EventEmitter<any>();

  constructor() { }

  ngOnInit(): void {
  }

  deleteConfirm(){
    this.deleteRequest.emit();
  }

  closePopup() {
    this.displayStyle = "none";
  }

}
