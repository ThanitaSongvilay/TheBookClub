import { CommonModule } from '@angular/common';
import { Component, ViewEncapsulation } from '@angular/core';
import { BookCard } from "../book-card/book-card";

@Component({
  selector: 'app-book-thumbnail',
  imports: [CommonModule, BookCard],
  standalone: true,
  templateUrl:'./book-thumbnail.html',
  encapsulation: ViewEncapsulation.None,
})
export class BookThumbnail {
    showChild = false;
    onImageClick(): void {
    console.log('Image clicked!');
  }

    openChild(): void {
    this.showChild = true;
  }

  closeChild(): void {
    this.showChild = false;
  }
}
