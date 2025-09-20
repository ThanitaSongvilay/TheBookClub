import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HomeComponent } from './home-page/home-page'; // Import your HomeComponent
import { Header } from './header/header';
import { Footer } from './footer/footer';
@Component({
  selector: 'app-root',
  imports: [HomeComponent], // Add HomeComponent here
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('The Book Club');
}