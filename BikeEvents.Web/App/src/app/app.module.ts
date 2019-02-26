import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { HttpModule } from '@angular/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialModule } from './material.module';

import { AppComponent } from './app.component';
import { NavComponent } from './main/nav/nav.component';
import { EventsComponent } from './event/events/events.component';
import { NewEventComponent } from './event/new-event/new-event.component';
import { HomeComponent } from './home/home.component';
import { SigninComponent } from './main/signin/signin.component';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    EventsComponent,
    NewEventComponent,
    HomeComponent,
    SigninComponent
  ],
  imports: [
    MaterialModule,
    BrowserModule,
    AppRoutingModule,
    HttpModule,
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
