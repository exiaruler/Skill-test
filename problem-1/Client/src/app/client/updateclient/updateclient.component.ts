import { Component, OnInit,Input } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
import { RouterModule, Routes,Router, ActivatedRoute, ParamMap } from '@angular/router';
@Component({
  selector: 'app-updateclient',
  templateUrl: './updateclient.component.html',
  styleUrls: ['./updateclient.component.css']
})
export class UpdateclientComponent implements OnInit {

  constructor(private service: SharedService, private route:ActivatedRoute) { }

  @Input()dep:any;
  id:any;
  firstName!:string;
  lastName!: string;
  dateofBirth!:Date;
  
   ngOnInit(): void {
    this.service.getClient(ActivatedRoute).subscribe(params => {
      console.log(ActivatedRoute);
     this.id=this.dep.id;
     this.firstName=this.dep.firstName;
     this.lastName=this.dep.lastName;
     this.dateofBirth=this.dep.dateofBirth;
    });
   }
   updateClient(){
   var entry={id:this.id,
     firstName:this.firstName,
     lastName:this.lastName,
     dob:this.dateofBirth
   };
   this.service.updateClient(entry).subscribe(res=>{
     alert(res.toString());
   });
   
 
}
}