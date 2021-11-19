import { Injectable } from '@angular/core';
import { categoriesModel } from 'src/Model/categoriesModel';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { flatten } from '@angular/compiler';
@Injectable({
  providedIn: 'root'
})
export class ShowcategoryService {
  public getApi:string="https://localhost:44331/api/categories/showcategory";
  image1:File;
  public postApi:string="https://localhost:44331/api/categories/InsertNewCategory"
  constructor(private http:HttpClient) { }
  getAllCategories():Observable<Array<categoriesModel>>
  {
   return this.http.get<Array<categoriesModel>>(this.getApi);
  }
  
  public postcategorydata(c:categoriesModel){
    let c1:categoriesModel= new categoriesModel();
    c1.CategoryID =c.CategoryID;
    c1.CategoryName=c.CategoryName;
    c1.Picture= c.Picture;
    console.log("Hello");
    this.http.post(this.postApi, c1);
    
  }


}
