import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DueltournamentComponent } from './dueltournament.component';

describe('DueltournamentComponent', () => {
  let component: DueltournamentComponent;
  let fixture: ComponentFixture<DueltournamentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DueltournamentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DueltournamentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
