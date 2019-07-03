import { Injectable } from '@angular/core'
import { HttpClient } from '@angular/common/http';
import { retry, catchError } from 'rxjs/operators';
import { throwError } from 'rxjs';

@Injectable()
export class ExchangeService{

    private url : string = "https://api.exchangeratesapi.io/latest";

    constructor(private http: HttpClient){
    }

    getExchanges(){
        return this.http.get(this.url).pipe(
            catchError(this.handleError)
        );
    }

    handleError(error) {
        return throwError(error.message);
    }

    handleSuccess(data){
    }
}