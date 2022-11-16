import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LegalPersonInsertEditComponent } from './legal-person-insert-edit.component';

describe('LegalPersonEditComponent', () => {
  let component: LegalPersonInsertEditComponent;
  let fixture: ComponentFixture<LegalPersonInsertEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LegalPersonInsertEditComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LegalPersonInsertEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
