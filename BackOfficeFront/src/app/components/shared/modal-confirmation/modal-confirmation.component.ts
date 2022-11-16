import { Router } from '@angular/router';
import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-modal-confirmation',
  templateUrl: './modal-confirmation.component.html',
  styleUrls: ['./modal-confirmation.component.css']
})
export class ModalConfirmationComponent implements OnInit {


  @Input() modalTitle: string = '';
  @Input() displayStyle: string = "none";
  @Input() returnList: string = '';

  constructor(
    private router: Router
  ) { }

  ngOnInit(): void {
  }

  closePopup() {
    this.displayStyle = "none";

    this.router.navigateByUrl(this.returnList);
  }

}
