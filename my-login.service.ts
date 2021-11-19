import { Injectable } from '@angular/core';
import { cls_LoginModel } from 'src/Model/cls_LoginModel';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { flatten } from '@angular/compiler';
import { Router } from '@angular/router';
import { UserloginModel } from 'src/Model/UserloginModel';
@Injectable({
  providedIn: 'root'
})
export class MyLoginService {

  public api='https://localhost:44315/api/';
  mystatus:number=0;
  public getapi='https://localhost:44315/api/';
  constructor(private http:HttpClient, private r:Router) {

   }
  postlogin(logindata:cls_LoginModel){
    let endpoints="Login/AdminLogin";
    let loginStatus:boolean=false;
    this.http.post(this.getapi+endpoints,logindata).subscribe(
      (i:any) => {console.log(i.status);
        if(i.status==200)
        {this.r.navigate(['/home']);}
        else{
          alert("Please Check Your Credentials")
        }
      }
      );
    
}

afterlogin(logindata:UserloginModel){
  let endpoints="Login/CustomerLogin";
  let loginStatus:boolean=false;
  this.http.post(this.getapi+endpoints,logindata).subscribe(
    (i:any) => {console.log(i.status);
      if(i.status==200)
      {this.r.navigate(['/home']);}
      else{
        alert("Dear User Check your credentials ")
      }
    }
    );
  
}
}
       
     