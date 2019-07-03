import { TestBed, getTestBed } from '@angular/core/testing';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';

import { ExchangeService } from './exchange.service';

describe('ExchangeService', () => {
    let injector: TestBed;
    let service: ExchangeService;
    let httpMock: HttpTestingController;
    
    beforeEach(() => {
      TestBed.configureTestingModule({
        imports: [HttpClientTestingModule],
        providers: [ExchangeService]
      });
      injector = getTestBed();
      service = injector.get(ExchangeService);
      httpMock = injector.get(HttpTestingController);
    });

    describe('#getExchanges', () => {
        it('Should return exchanges', () => {
          service.getExchanges().subscribe(exchanges => {
              console.log(Object.keys(exchanges).length);
            expect(Object.keys(exchanges).length).toBe(321);
          });

          const req = httpMock.expectOne(
            'https://api.exchangeratesapi.io/latest'
          );

          req.flush('');
        });

      });

      
    describe('#getExchanges', () => {
        it('Should handle the error', () => {
            spyOn(service as any, 'handleError');

            service.getExchanges().subscribe(() => { }, error => {
                expect(service['handleError']).toHaveBeenCalled();
            });
        
            const req = httpMock.expectOne('https://api.exchangeratesapi.io/latest');
            req.flush(null, { status: 400, statusText: 'Error' });
        });

      });

      afterEach(() => {
        httpMock.verify();
      });
  });