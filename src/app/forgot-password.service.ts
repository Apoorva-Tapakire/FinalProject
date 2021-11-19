import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ForgotPassword } from 'src/environments/model/UserLogin';

@Injectable({
  providedIn: 'root'
})
export class ForgotPasswordService {
  public api ='https://localhost:44398/api/';
  mystatus:number=0;
  public getapi ='https://localhost:44398/api/';

  constructor(private http:HttpClient) {
    
  } 
  postlogin(forgotpassword:ForgotPassword):number
  {
    let endpoints = "Login/ForgotPassword";
    let loginStatus:boolean = false;
    this.http.post(this.getapi+endpoints,forgotpassword).subscribe(
      (i:any)=> {this.mystatus =i.status;
      console.log("mystatus"+this.mystatus);}
    );
    return this.mystatus;
  }
}
