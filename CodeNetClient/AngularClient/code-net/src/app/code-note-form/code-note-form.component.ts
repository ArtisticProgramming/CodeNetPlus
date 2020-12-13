import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-code-note-form',
  templateUrl: './code-note-form.component.html',
  styleUrls: ['./code-note-form.component.scss']
})

export class CodeNoteFormComponent implements OnInit {
  model:any={};
  
  constructor(
      private http: HttpClient,
      @Inject('BASE_URL') private baseUrl: string) { }
  

  ngOnInit(): void {
    this.model.description ="HELLOOOOOOOOO"

  }

  addCodeNote() {
    
    let url= this.baseUrl+"/api/CodeNote";
    this.http.post<any>(url, this.model)
      .subscribe(result => {
        debugger;
      }, error => console.error(error));
  }

}
