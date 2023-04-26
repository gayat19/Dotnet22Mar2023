import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {

  username:string="";
  className:string;
  likeStatus:boolean = false;
  constructor() { 
    this.username = "ABC";
    this.className = "glyphicon glyphicon-heart-empty"
  }
  changeLook(){
    console.log("Clicked the heart")
    this.likeStatus = !this.likeStatus;
    // if(this.likeStatus)
    //   this.className = "glyphicon glyphicon-heart";
    // else
    // this.className = "glyphicon glyphicon-heart-empty"
    this.likeStatus?this.className = "glyphicon glyphicon-heart":this.className = "glyphicon glyphicon-heart-empty";
  }
  changeName(un:any){
    this.username = un;
  }
  ngOnInit(): void {
  }

}
