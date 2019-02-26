import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { EventsComponent } from './event/events/events.component';
import { NewEventComponent } from './event/new-event/new-event.component';
import { SigninComponent } from './main/signin/signin.component';


const routes: Routes = [
  {path: "", component: HomeComponent},
  {path: "events", component: EventsComponent},
  {path: "newEvent", component: NewEventComponent},
  {path: "signIn", component: SigninComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
