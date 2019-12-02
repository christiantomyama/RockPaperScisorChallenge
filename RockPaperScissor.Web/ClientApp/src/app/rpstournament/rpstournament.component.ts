import { Component, OnInit } from '@angular/core';
import { RpstournamentService } from './rpstournament.service';


@Component({
  selector: 'app-rpstournament',
  templateUrl: './rpstournament.component.html',
  styleUrls: ['./rpstournament.component.css']
})
export class RpstournamentComponent implements OnInit {
    stringjson: string;

  constructor(
    public service: RpstournamentService,
  ) { }

  ngOnInit() {
    this.loadJsonString("2");
  }

  loadJsonString(index: string) {
    switch (index) {
      case "1":
        this.stringjson = JSON.stringify([["Armando", "P"], ["Dave", "S"]]);
        break;
      case "2":
        this.stringjson = JSON.stringify([
          [
            [["Armando", "P"], ["Dave", "S"]],
            [["Richard", "R"], ["Michael", "S"]],
          ],
          [
            [["Allen", "S"], ["Omer", "P"]],
            [["David E.", "R"], ["Richard X.", "P"]]
          ]
        ]);
        break;
      case "3":
        //this.stringjson = this.service.refreshList();
        ;

    }
  }
}
