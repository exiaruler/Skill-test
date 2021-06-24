import { Component, OnInit } from '@angular/core';
import {SharedService} from 'src/app/shared.service';
@Component({
  selector: 'app-viewclient',
  templateUrl: './viewclient.component.html',
  styleUrls: ['./viewclient.component.css']
})
export class ViewclientComponent implements OnInit {

  constructor(private service:SharedService) { }

  ClientList:any=[];
  
  ngOnInit(): void {
    this.refreshClientList();
    
  }

  deleteClient(clientID: { id: any; }){
    console.log(clientID.id);
    if(confirm('Are you sure?')){
    this.service.deleteClient(clientID.id).subscribe(data=>{
      this.refreshClientList();
    });
  }
  
  }
  
  refreshClientList(){
    this.service.getClients().subscribe(data =>{
      this.ClientList=data;
      console.log(this.ClientList);
    });
  }
}