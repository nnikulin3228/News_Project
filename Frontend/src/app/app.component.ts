import { Component } from '@angular/core';

import{ HttpClient } from '@angular/common/http';
import { addnews } from './models';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  providers: [HttpClient]
})
export class AppComponent {
  title = 'testNg';
  constructor(public http: HttpClient){
   
  }
}
