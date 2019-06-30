import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ParagraphDisplayComponent } from './components/paragraph-display/paragraph-display.component';

const routes: Routes = [
  { path: '', component: ParagraphDisplayComponent },
  { path: '1uzdevums', component: ParagraphDisplayComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
