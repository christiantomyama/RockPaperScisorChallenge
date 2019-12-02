import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from "../../environments/environment";
import { HttpClientModule } from '@angular/common/http'; import { HttpModule } from '@angular/http';


@Injectable( )
export class RpstournamentService {

  
  private readonly API = `${environment.API}`;

  constructor() { }

  refreshList() {
    return this.API;
  }


}
