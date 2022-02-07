import { Component, OnInit } from '@angular/core';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  title = 'E-Commerce';

  constructor() {}

  ngOnInit(): void {
    // this.http.get('https://localhost:44379/api/products').subscribe(
    //   (response: IPagination) => {
    //     this.products = response.data;
    //   },
    //   (error) => {
    //     console.log(error);
    //   }
    // );
  }
}
