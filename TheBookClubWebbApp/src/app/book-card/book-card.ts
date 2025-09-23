import { CommonModule } from '@angular/common';
import { Component, ViewEncapsulation } from '@angular/core';

@Component({
  selector: 'app-book-card',
  imports: [CommonModule],
  standalone: true,
  templateUrl: './book-card.html',
  encapsulation: ViewEncapsulation.None,
})
export class BookCard {
  activeBook = true;
}
