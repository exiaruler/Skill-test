import { Component, Input, OnInit } from '@angular/core';
import {SharedService} from 'src/app/shared.service';

@Component({
  selector: 'app-addclient',
  templateUrl: './addclient.component.html',
  styleUrls: ['./addclient.component.css']
})
export class AddclientComponent implements OnInit {
  
  constructor(private service: SharedService) { }

 @Input()dep:any;
 id:any;
 firstName!:string;
 lastName!: string;
 dateofBirth!:Date;
 
  ngOnInit(): void {
    this.id=this.dep.id;
    this.firstName=this.dep.firstName;
    this.lastName=this.dep.lastName;
    this.dateofBirth=this.dep.dateofBirth;
  }
  addClient(){
  var entry={id:this.id,
    firstName:this.firstName,
    lastName:this.lastName,
    dob:this.dateofBirth
  };
  this.service.addClient(entry).subscribe(res=>{
    alert(res.toString());
  });
  

  }

}
