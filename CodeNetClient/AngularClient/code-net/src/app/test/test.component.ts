import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { CodeNote } from './CodeNote'


@Component({
  selector: 'test-root',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.scss']
})

export class TestComponent {

  constructor(
    private http: HttpClient)
    // @Inject('BASE_URL') private baseUrl: string) 
  {
    
  }


  ngOnInit() {
    this.load();
  }
  
  title = 'HELLOOOOOOOOOOOOOOOOOOOOOOOOOO';
  codeNoteModel:CodeNote;

  load() {
    // alert(name)
    let url= "https://localhost:44373/api/CodeNote";
    this.http.get<CodeNote>(url, {})
      .subscribe(result => {
        debugger;
        this.codeNoteModel = result
      }, error => console.error(error));
  }
  // name : String="";
}
