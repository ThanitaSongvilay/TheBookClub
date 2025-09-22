import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-book-card',
  imports: [CommonModule],
  standalone: true,
  templateUrl: './book-card.html',
})
export class BookCard {
  activeBook = true;
}
