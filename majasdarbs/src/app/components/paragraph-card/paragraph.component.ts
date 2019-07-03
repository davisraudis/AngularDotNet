import { Component, Input } from '@angular/core';

const randomText = [
  " Pirmais random",
  " Otrais random",
  " Trešais random",
  " Ceturtais random"
]

@Component({
  selector: 'paragraph-card',
  templateUrl: './paragraph-card.component.html'
})
export class ParagraphCardComponent {
  @Input() paragraphText: string = "Initial text";

  addTextToCard(){
    this.paragraphText = this.paragraphText.concat(randomText[Math.floor(Math.random()*randomText.length)]);
  }
}
