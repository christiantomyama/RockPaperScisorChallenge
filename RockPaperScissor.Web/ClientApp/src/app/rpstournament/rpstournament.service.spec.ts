import { TestBed, inject } from '@angular/core/testing';

import { RpstournamentService } from './rpstournament.service';

describe('RpstournamentService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [RpstournamentService]
    });
  });

  it('should be created', inject([RpstournamentService], (service: RpstournamentService) => {
    expect(service).toBeTruthy();
  }));
});
