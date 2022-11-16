import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DepartmentInsertEditComponent } from './department-insert-edit.component';

describe('DepartmentInsertEditComponent', () => {
  let component: DepartmentInsertEditComponent;
  let fixture: ComponentFixture<DepartmentInsertEditComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DepartmentInsertEditComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DepartmentInsertEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
