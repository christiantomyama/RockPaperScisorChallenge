import { TestBed, inject } from '@angular/core/testing';

import { DueltournamentService } from './dueltournament.service';

describe('DueltournamentService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [DueltournamentService]
    });
  });

  it('should be created', inject([DueltournamentService], (service: DueltournamentService) => {
    expect(service).toBeTruthy();
  }));
});
