import { BrowserModule } from '@angular/platform-browser';
import { NoopAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { MatToolbarModule, MatMenuModule, MatIconModule, MatCardModule, MatButtonModule, MatProgressSpinnerModule, MatTableModule, MatSnackBarModule } from '@angular/material';
import { FlexLayoutModule } from '@angular/flex-layout';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './components/header/header.component';
import { ParagraphDisplayComponent } from './components/paragraph-display/paragraph-display.component';
import { ParagraphCardComponent } from './components/paragraph-card/paragraph-card.component';
import { ExchangeRatesDisplayComponent } from './components/exchange-rates-display/exchange-rates-display.component';

import { ExchangeService } from './shared/exchange.service'

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    ParagraphCardComponent,
    ParagraphDisplayComponent,
    ExchangeRatesDisplayComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatToolbarModule,
    MatMenuModule,
    MatIconModule,
    MatCardModule,
    FlexLayoutModule,
    MatButtonModule,
    FormsModule,
    HttpClientModule,
    MatProgressSpinnerModule,
    MatTableModule,
    MatSnackBarModule,
    NoopAnimationsModule
  ],
  providers: [ExchangeService],
  bootstrap: [
    AppComponent
  ]
})
export class AppModule { }
