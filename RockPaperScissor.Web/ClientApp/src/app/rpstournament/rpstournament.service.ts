import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from "../../environments/environment";
import axios from 'axios';

@Injectable( )
export class RpstournamentService {

  protected readonly API = `${environment.API}`;
  stringjson: string;

  constructor(private http: HttpClient) { }

  async findWinner(jsonString) {
    return await axios.post(this.API + 'rpstournament/', JSON.parse(jsonString));
  }


}
