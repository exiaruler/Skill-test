import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ViewclientComponent } from './client/viewclient/viewclient.component';
import { AddclientComponent } from './client/addclient/addclient.component';
import { UpdateclientComponent } from './client/updateclient/updateclient.component';
import {SharedService} from './shared.service';
import {HttpClientModule} from '@angular/common/http';
import {FormsModule,ReactiveFormsModule} from '@angular/forms';
import { ClientComponent } from './client/client.component';

@NgModule({
  declarations: [
    AppComponent,
    ViewclientComponent,
    AddclientComponent,
    UpdateclientComponent,
    ClientComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
FormsModule
  ],
  providers: [SharedService],
  bootstrap: [AppComponent]
})
export class AppModule { }
