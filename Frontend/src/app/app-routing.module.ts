import { NgModule, NO_ERRORS_SCHEMA, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AppComponent } from "./app.component";
import { HomeComponent } from "./home/home.component";
import { AddNewsComponent } from "./add-news/add-news.component";
import { UploadComponent } from './upload/upload.component';

@NgModule({
  imports: [
    RouterModule.forRoot([
      { path: '', component: HomeComponent },
      { path: 'Home', component: HomeComponent },
      { path: 'AddNews', component: AddNewsComponent},
      { path: 'upload', component: UploadComponent}
    ])
  ],
  exports: [
    RouterModule,
  ],
  providers: []
})

export class AppRoutingModule { }