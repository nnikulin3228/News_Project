import { Component, OnInit } from '@angular/core';
import { HttpClient} from '@angular/common/http';
import { addnews } from '../models';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  allNews: addnews[];

  constructor(public http: HttpClient) { }

  ngOnInit() {
    this.GetAllNews();
  }

  GetAllNews()
  {
    this.http.get<addnews[]>("http://localhost:5001/api/news").subscribe((data: addnews[])=>{
      this.allNews = data;
    });
  }
  Delete(id : number){
    var WantDelete = confirm ("Do you want to delete?")
    if (WantDelete)
    {
      this.http.delete("http://localhost:5001/api/news/delete/"+id).subscribe(res => this.GetAllNews());
    }
  }
}
