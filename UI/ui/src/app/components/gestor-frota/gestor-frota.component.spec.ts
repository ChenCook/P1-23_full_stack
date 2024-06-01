import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GestorFrotaComponent } from './gestor-frota.component';

describe('GestorFrotaComponent', () => {
  let component: GestorFrotaComponent;
  let fixture: ComponentFixture<GestorFrotaComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GestorFrotaComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(GestorFrotaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
