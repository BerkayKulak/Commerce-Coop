import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './home.component';
import { SharedModule } from '../shared/shared.module';
import { BasketModule } from '../basket/basket.module';



@NgModule({
  declarations: [
    HomeComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    BasketModule
  ],
  exports:[
    HomeComponent
  ]
})
export class HomeModule { }
