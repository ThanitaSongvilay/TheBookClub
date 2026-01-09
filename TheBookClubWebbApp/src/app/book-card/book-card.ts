import { CommonModule } from '@angular/common';
import { Component, EventEmitter, Output, ViewEncapsulation } from '@angular/core';

@Component({
  selector: 'app-book-card',
  imports: [CommonModule],
  standalone: true,
  templateUrl: './book-card.html',
  encapsulation: ViewEncapsulation.None,
})
export class BookCard {
  @Output() exit = new EventEmitter<void>();

  activeBook = true;

  close(): void {
    this.exit.emit();
  }
}
