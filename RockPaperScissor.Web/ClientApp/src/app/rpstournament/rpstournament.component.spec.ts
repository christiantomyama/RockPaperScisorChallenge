import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RpstournamentComponent } from './rpstournament.component';

describe('RpstournamentComponent', () => {
  let component: RpstournamentComponent;
  let fixture: ComponentFixture<RpstournamentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RpstournamentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RpstournamentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
