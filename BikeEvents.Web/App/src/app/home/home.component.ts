import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  public events : Event[];
  title = 'Home';

  constructor(http: Http) {
    http.get('https://localhost:5001/api/values/getevents').subscribe(result => {
      this.events = result.json() as Event[];
    }, error => console.error(error));
  }

  ngOnInit() {
    
  }

}

interface Event {
  Title : string;
  Description : string;
  Location : string;
  Picture : string;
  StartTime : string;
}