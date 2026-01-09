import { Component, signal, ViewEncapsulation } from '@angular/core';
import { Header } from '../header/header';
import { Footer } from '../footer/footer';

import { BookThumbnail } from '../book-thumbnail/book-thumbnail';

@Component({
  selector: 'app-home',
  imports: [Header, Footer, BookThumbnail],
  standalone: true,
  templateUrl: './home-page.html',
  encapsulation: ViewEncapsulation.None,
})
export class HomeComponent {
  protected readonly bookTitle = signal('The Great Gatsby');
  protected readonly bookAuthor = signal('F. Scott Fitzgerald');
  protected readonly bookDescription = signal(
    'A classic novel of the Jazz Age, The Great Gatsby tells the story of the mysterious millionaire Jay Gatsby, his passion for the beautiful Daisy Buchanan, and the dark side of the American Dream.'
  );
}