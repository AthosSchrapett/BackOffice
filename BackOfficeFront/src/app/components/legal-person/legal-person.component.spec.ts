import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LegalPersonComponent } from './legal-person.component';

describe('LegalPersonComponent', () => {
  let component: LegalPersonComponent;
  let fixture: ComponentFixture<LegalPersonComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LegalPersonComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LegalPersonComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
