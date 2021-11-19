import { Component, OnInit } from '@angular/core';
import { map, pipe } from 'rxjs';
import { categoriesModel } from 'src/Model/categoriesModel';
import { ImageSnippet } from 'src/Model/ImageSnippetModel';
import { ShowcategoryService } from '../showcategory.service';

@Component({
  selector: 'app-insert-category',
  templateUrl: './insert-category.component.html',
  styleUrls: ['./insert-category.component.css']
})
export class InsertCategoryComponent implements OnInit {
   selectedFile: ImageSnippet;
   category: categoriesModel={
     CategoryID:0,
     CategoryName:"",
     Picture:new Image(0,0)
   }
   image1:File;

  constructor(private imageService: ShowcategoryService){}

  processFile(imageInput: any):any {
    const file: File = imageInput.files[0];
    const reader = new FileReader();
    reader.addEventListener('load', (event: any) => {
      this.selectedFile = new ImageSnippet(event.target.result, file);
      this.uploadImage(this.selectedFile.file);
       console.log(this.selectedFile.file);
    //   .subscribe(
    //     (res) => {
        
    //     },
    //     (err) => {
        
    //     })

    });
    reader.readAsDataURL(file);
    reader.onload= ()=>{
      this.selectedFile.src = reader.result as string;
      
    }
      // map(response => {
      //   return new File([], "myImage.png");
      // })
    //);
  }
  ngOnInit(){

  }
  public uploadImage(image: File) {
    const formData = new FormData();
    formData.append('image', image);
    this.image1 = image;
    //return this.http.post(this.postApi, formData);
  }
  AddCategory(catdata:categoriesModel){
    this.category.CategoryID= catdata.CategoryID;
    this.category.CategoryName=catdata.CategoryName;
    this.category.Picture = catdata.Picture;
    this.imageService.postcategorydata(catdata);
    console.log(this.category.CategoryID);
    console.log(this.category);
  }
}
function height(width: any, arg1: number, height: any, arg3: number): HTMLImageElement {
  throw new Error('Function not implemented.');
}

function width(width: any, arg1: number, height: (width: any, arg1: number, height: any, arg3: number) => HTMLImageElement, arg3: number): HTMLImageElement {
  throw new Error('Function not implemented.');

}

