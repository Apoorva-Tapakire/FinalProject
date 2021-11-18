import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import routes,{ AppRoutingModule } from './app-routing.module';
import { MyloginService}from './my-login.service';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { ShowCategoryComponent } from './show-category/show-category.component';
import { ShowcategoryService } from './showcategory.service';
import { InsertCategoryComponent } from './insert-category/insert-category.component';
import { HomeComponent } from './home/home.component';
import { UserLoginComponent } from './user-login/user-login.component';
//import { ProductComponent } from './ShowProducts/showproduct.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    ShowCategoryComponent,
    InsertCategoryComponent,
    HomeComponent,
    UserLoginComponent,
    //ProductComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    RouterModule.forRoot(routes),
    FormsModule
  ],
  providers: [MyloginService, ShowcategoryService],
  // bootstrap: [InsertCategoryComponent]
  bootstrap: [AppComponent]
})
export class AppModule {}
