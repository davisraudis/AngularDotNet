import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { MatToolbarModule, MatMenuModule, MatIconModule, MatCardModule, MatButtonModule, MatButton } from '@angular/material';
import { FlexLayoutModule } from '@angular/flex-layout';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './components/header/header.component';
import { ParagraphDisplayComponent } from './components/paragraph-display/paragraph-display.component';
import { ParagraphCardComponent } from './components/paragraph-card/paragraph-card.component';


@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    ParagraphCardComponent,
    ParagraphDisplayComponent
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
    FormsModule
  ],
  providers: [],
  bootstrap: [
    AppComponent
  ]
})
export class AppModule { }
