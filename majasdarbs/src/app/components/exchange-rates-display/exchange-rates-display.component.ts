import { Component, OnInit } from '@angular/core';
import { ExchangeService } from 'src/app/shared/exchange.service';
import { MatSnackBar } from '@angular/material/snack-bar';

const displayedColumns: string[] = ['currency', 'value'];

@Component({
  selector: 'exchange-rates-display',
  templateUrl: './exchange-rates-display.component.html'
})
export class ExchangeRatesDisplayComponent {
  exchanges:any
  loadingData:boolean = false;
  tableData:any
  displayColumns = displayedColumns;

  constructor(private _exchangeService: ExchangeService, private _snackBar: MatSnackBar){
  }

  getExchangeRates(){
    this.loadingData = true;
    this._exchangeService.getExchanges()
      .subscribe(
        data => {
          this.exchanges = data;
          this.initializeRateTableData(this.exchanges);
          this._exchangeService.handleSuccess(data);
          this._snackBar.open("Data has been loaded", "Close", {
            duration: 2000,
        });
        },
        err => {
          this.loadingData = false;
          this._exchangeService.handleError(err);
          this._snackBar.open("Error loading the exchange data", "Close", {
            duration: 2000,
        });
        },
        () => {
          this.loadingData = false;
        });
  }

  initializeRateTableData(exchanges){
    this.tableData = Object.keys(exchanges.rates).map(function(key) {
      return { "currency": key, "value": exchanges.rates[key] }
    });

    console.log(this.tableData);
  }
}
