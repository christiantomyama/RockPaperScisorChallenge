import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { RpstournamentComponent } from './rpstournament/rpstournament.component';
import { RpstournamentService } from './rpstournament/rpstournament.service';
//import { RpstournamentComponent } from './rpstournament/rpstournament.component';



@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    RpstournamentComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    HttpModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: RpstournamentComponent, pathMatch: 'full' },
      //{ path: 'rpstournament', component: RpstournamentComponent },
    ])
  ],
  providers: [RpstournamentService],
  bootstrap: [AppComponent]
})
export class AppModule { }
