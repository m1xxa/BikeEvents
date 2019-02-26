import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.css']
})
export class EventsComponent {

  public events : Event[];
  title = 'Events';

  constructor(http: Http) {
    http.get('https://localhost:5001/api/values/getevents').subscribe(result => {
      this.events = result.json() as Event[];
    }, error => console.error(error));
  }

}

interface Event {
  Title : string;
  Description : string;
}