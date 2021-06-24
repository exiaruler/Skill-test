import { NgModule } from '@angular/core';
import { RouterModule, Routes,Router, ActivatedRoute, ParamMap } from '@angular/router';
import {ViewclientComponent} from './client/viewclient/viewclient.component';
import { AddclientComponent } from './client/addclient/addclient.component';
import {UpdateclientComponent} from './client/updateclient/updateclient.component';
const routes: Routes = [
  {path:'client-view',component: ViewclientComponent},
  {path:'client-add',component: AddclientComponent},
  {path:'client-update',component: UpdateclientComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
