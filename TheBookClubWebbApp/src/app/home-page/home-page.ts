import { Component, signal } from '@angular/core';
import { Header } from '../header/header';
import { Footer } from '../footer/footer';

@Component({
  selector: 'app-home',
  imports: [Header, Footer],
  standalone: true,
  templateUrl: './home-page.html',
    // styleUrl: './home-page.css'
})
export class HomeComponent {
  protected readonly bookTitle = signal('The Great Gatsby');
  protected readonly bookAuthor = signal('F. Scott Fitzgerald');
  protected readonly bookDescription = signal(
    'A classic novel of the Jazz Age, The Great Gatsby tells the story of the mysterious millionaire Jay Gatsby, his passion for the beautiful Daisy Buchanan, and the dark side of the American Dream.'
  );
}