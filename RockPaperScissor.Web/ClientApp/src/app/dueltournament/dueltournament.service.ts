import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from "../../environments/environment";
import axios from 'axios';

@Injectable( )
export class DueltournamentService {

  private readonly API = `${environment.API}`;
  stringjson: string;

  constructor(private http: HttpClient) { }

  async findWinner(jsonString) {
    let response = await axios.post(this.API + 'dueltournament/', JSON.parse(jsonString));
    return response;
  }


}
