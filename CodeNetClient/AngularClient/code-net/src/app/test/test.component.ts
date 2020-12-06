import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';

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
  
  title = 'HELLOOOOOOOOOOOOOOOOOOOOOOOOOO';

  model :any = {}

  onClickSubmit(name) {
    // alert(name)
    let url= "https://localhost:44373/api/CodeNote";
    this.http.get<any>(url, {})
      .subscribe(result => {
        this.model = result
      }, error => console.error(error));
  }


  // name : String="";
}
