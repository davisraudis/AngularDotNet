import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ParagraphDisplayComponent } from './components/paragraph-display/paragraph-display.component';
import { ExchangeRatesDisplayComponent } from './components/exchange-rates-display/exchange-rates-display.component';

const routes: Routes = [
  { path: '', component: ParagraphDisplayComponent },
  { path: '1uzdevums', component: ParagraphDisplayComponent },
  { path: '2uzdevums', component:  ExchangeRatesDisplayComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
