import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { RpstournamentComponent } from './rpstournament/rpstournament.component';
import { RpstournamentService } from './rpstournament/rpstournament.service';
import { DueltournamentComponent } from './dueltournament/dueltournament.component';
import { DueltournamentService } from './dueltournament/dueltournament.service';



@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    RpstournamentComponent,
    DueltournamentComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    HttpModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: RpstournamentComponent, pathMatch: 'full' },
      { path: 'dueltournament', component: DueltournamentComponent, pathMatch: 'full' },
    ])
  ],
  providers: [RpstournamentService, DueltournamentService],
  bootstrap: [AppComponent]
})
export class AppModule { }
