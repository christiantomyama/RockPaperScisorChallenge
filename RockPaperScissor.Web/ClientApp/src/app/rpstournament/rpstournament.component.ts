import { Component, OnInit } from '@angular/core';
import { RpstournamentService } from './rpstournament.service';


@Component({
  selector: 'app-rpstournament',
  templateUrl: './rpstournament.component.html',
  styleUrls: ['./rpstournament.component.css']
})
export class RpstournamentComponent implements OnInit {
  stringjson: string;
  requestResponse: string;

  constructor(
    public service: RpstournamentService,
  ) { }

  ngOnInit() {
    this.loadJsonString(2);
  }
  async findWinner() {
    this.requestResponse = null;
    try {
      this.requestResponse = 'The winner is: ' + JSON.stringify((await this.service.findWinner(this.stringjson)).data);
    } catch (e) {
      this.requestResponse = 'Invalid Json String';
    }
  }
  loadJsonString(index: number) {
    switch (index) {
      case 1:
        this.stringjson = JSON.stringify([["Armando", "P"], ["Dave", "S"]]);
        break;
      case 2:
        this.stringjson = JSON.stringify([
          [
            [["Armando", "P"], ["Dave", "S"]],
            [["Richard", "R"], ["Michael", "S"]],
          ],
          [
            [["Allen", "S"], ["Omer", "P"]],
            [["David E.", "R"], ["Richard X.", "P"]]
          ]
        ], null, 2);
        break;
      case 3:
        this.stringjson = JSON.stringify([
          [
            [["Armando", "P"], ["Dave", "S"]],
            [
              [
                ["Armando2", "P"], ["Dave2", "S"],
              ],
              [
                [["Allen2", "S"], ["Omer2", "P"]],
                [["David E.2", "R"], ["Richard X.2", "P"]]
              ]
            ],
          ],
          [
            [["Allen", "S"], ["Omer", "P"]],
            [["David E.", "R"], ["Richard X.", "P"]]
          ]
        ], null, 2); break;
    }
  }
}
