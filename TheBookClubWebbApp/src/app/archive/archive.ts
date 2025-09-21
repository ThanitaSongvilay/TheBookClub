import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-archive',
  imports: [CommonModule],
  templateUrl: './archive.html',
})
export class Archive {
  dropdownOpen = false;

  toggleDropdown() {
    this.dropdownOpen = !this.dropdownOpen;
  }
}
