import { Component, OnInit } from '@angular/core';
import { environment } from '../../environments/environment';

@Component({
  selector: 'lc-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.css']
})
export class TestComponent implements OnInit {
  output: string = '';
  constructor() { }

  ngOnInit() {
    this.output = environment.outputPath;
  }
}
