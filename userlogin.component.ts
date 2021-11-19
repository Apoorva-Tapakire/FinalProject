import { Component, OnInit } from '@angular/core';
import { UserloginModel } from 'src/Model/UserloginModel';
import { MyLoginService } from '../my-login.service';
@Component({
  selector: 'app-userlogin',
  templateUrl: './userlogin.component.html',
  styleUrls: ['./userlogin.component.css']
})
export class UserloginComponent implements OnInit {
  Userlogin:UserloginModel={
    EmailId:"",
    Password:""
};

  constructor(private m1:MyLoginService) { }

  ngOnInit(): void {
  }

  loginStatus:number=0;
validate(login:UserloginModel){
  this.m1.afterlogin(login);

}
}
