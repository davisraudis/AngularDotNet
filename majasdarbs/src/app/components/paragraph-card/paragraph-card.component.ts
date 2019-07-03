import { Component, Input } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'paragraph-card',
  templateUrl: './paragraph-card.component.html'
})
export class ParagraphCardComponent {
  paragraphText: string = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old.";
  inputValue: string;
  
  addTextToCard(){
    this.paragraphText = this.paragraphText.concat(this.inputValue);
  }
}
