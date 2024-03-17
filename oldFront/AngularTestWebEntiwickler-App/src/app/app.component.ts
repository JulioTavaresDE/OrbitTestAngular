import { Component } from '@angular/core';
import { RouterModule, RouterOutlet } from '@angular/router';
import { TextparserComponent } from './textparser/textparser.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,TextparserComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'AngularTestWebEntiwickler-App';
}
