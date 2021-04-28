import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { addnews } from 'src/app/models';
import { HttpClient, HttpHeaders, HttpRequest } from '@angular/common/http';
import { environment } from 'src/environments/environment';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json'
  })
};

@Component({
  selector: 'app-add-news',
  templateUrl: './add-news.component.html',
  styleUrls: ['./add-news.component.css']
})


export class AddNewsComponent implements OnInit {
  news: addnews = new addnews(0, '', '', '', null);
  image : any;

  constructor(public http: HttpClient,
    public router: Router) {
  }

  ngOnInit() {
  }
  upload(files) {
    if (files.length === 0)
      return;
    this.image = files[0];
  }


  Send() {
    this.http.post(environment.hostUrl+"/api/news", this.news).subscribe(
      (res : addnews) => {
        const formData = new FormData();
        formData.append(res.id.toString(), this.image);
        this.http.post(environment.hostUrl+"/api/upload", formData).subscribe(
          res => {
            this.router.navigate(['Home'])
          },
          err => {
            alert("File not upload");
          }
        );
      }
      ,
      err => alert("Form is incorrect")
    );
  }

}
