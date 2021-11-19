import { Component, OnInit } from '@angular/core';
import { ShowcategoryService } from '../showcategory.service';
import { categoriesModel } from 'src/Model/categoriesModel';
@Component({
  selector: 'app-show-category',
  templateUrl: './show-category.component.html',
  styleUrls: ['./show-category.component.css']
})
export class ShowCategoryComponent implements OnInit {
  categorydata: Array<categoriesModel>=[];
  constructor(private s:ShowcategoryService) { }

  ngOnInit(): void {
    this.s.getAllCategories().subscribe(data => {
      this.categorydata = data;
    });
  }

}
