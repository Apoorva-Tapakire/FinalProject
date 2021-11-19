import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { UserloginComponent } from './userlogin/userlogin.component';


const routes: Routes = [
  {path:'login',component:LoginComponent},
  {path:'Userlogin',component:UserloginComponent}
];

export default routes;

// const routes: Routes = [];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
