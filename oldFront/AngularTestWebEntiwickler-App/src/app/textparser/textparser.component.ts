import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { error } from 'console';
import { response } from 'express';

@Component({
  selector: 'app-textparser',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './textparser.component.html',
  styleUrl: './textparser.component.scss'
})
export class TextparserComponent {
  public strParse:any;
  public _filter:string = '';

  public get filter(){
    return this._filter;
  }

  public set filter(value:string){
    this._filter = value;
    console.log(this._filter);
  }
  constructor(private http:HttpClient){}

  ngOnInit(): void {
    this.getTextParse();
  }

  public getTextParse():void {
    this.http.get('https://localhost:7265/api/TextParse/').subscribe(
      response => this.strParse = response,
      error => console.log(error)
    );
  }
}
