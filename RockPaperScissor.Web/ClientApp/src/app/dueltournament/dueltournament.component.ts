import { Component, OnInit } from '@angular/core';
import { DueltournamentService } from './dueltournament.service';


@Component({
  selector: 'app-dueltournament',
  templateUrl: './dueltournament.component.html',
  styleUrls: ['./dueltournament.component.css']
})
export class DueltournamentComponent implements OnInit {
  title: "Rps Tournament";
  stringjson: string;
  requestResponse: string;

  constructor(
    public service: DueltournamentService,
  ) { }

  ngOnInit() {
    this.loadJsonString(2);
  }
  async findWinner() {
    this.requestResponse = null;
    try {
      this.requestResponse = 'The winner is: ' + JSON.stringify((await this.service.findWinner(this.stringjson)).data);
    } catch (e) {
      this.requestResponse = e.message + (e.response ? ': ' + e.response.data.Message : '');
    }
  }
  loadJsonString(index: number) {
    switch (index) {
      case 1:
        this.stringjson = JSON.stringify([["Armando", "2"], ["Dave", "5"]]);
        break;
      case 2:
        this.stringjson = JSON.stringify([
          [
            [["Armando", "2"], ["Dave", "5"]],
            [["Richard", "15"], ["Michael", "2"]],
          ],
          [
            [["Allen", "6"], ["Omer", "2"]],
            [["David E.", "7"], ["Richard X.", "1"]]
          ]
        ], null, 2);
        break;
      case 3:
        this.stringjson = JSON.stringify([
          [
            ["Armando", "23"],
            [
              [
                ["Armando2", "2"], ["Dave2", "6"],
              ],
              [
                [["Allen2", "3"], ["Omer2", "1"]],
                [["David E.2", "4"], ["Richard X.2", "112"]]
              ]
            ],
          ],
          [
            [["Allen", "1"], ["Omer", "61"]],
            [["David E.", "1"], ["Richard X.", "1"]]
          ]
        ], null, 2); break;
    }
  }
}
