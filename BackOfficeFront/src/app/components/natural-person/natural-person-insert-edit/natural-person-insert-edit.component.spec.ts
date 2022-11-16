import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NaturalPersonInsertEditComponent } from './natural-person-insert-edit.component';

describe('NaturalPersonInsertEditComponent', () => {
  let component: NaturalPersonInsertEditComponent;
  let fixture: ComponentFixture<NaturalPersonInsertEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NaturalPersonInsertEditComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NaturalPersonInsertEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
