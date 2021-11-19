import { Component, OnInit } from '@angular/core';
import { ForgotPassword } from 'src/environments/model/UserLogin';
import { ForgotPasswordService } from '../forgot-password.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-forgot-password',
  templateUrl: './forgot-password.component.html',
  styleUrls: ['./forgot-password.component.css']
})
export class ForgotPasswordComponent implements OnInit {
  fp:ForgotPassword ={
    EmailId:"",
    Password:""
  };
  constructor(private m1:ForgotPasswordService,private r:Router) { }

  ngOnInit(): void {
  }
  ForgotStatus:number=0;
validate(login:ForgotPassword){
  this.m1.postlogin(login);
  
}
goto()
{
  this.r.navigate(['/login'])
}
}
