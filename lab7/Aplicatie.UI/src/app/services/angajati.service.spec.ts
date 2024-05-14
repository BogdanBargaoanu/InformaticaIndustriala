import { TestBed } from '@angular/core/testing';

import { AngajatiService } from './angajati.service';

describe('AngajatiService', () => {
  let service: AngajatiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AngajatiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
