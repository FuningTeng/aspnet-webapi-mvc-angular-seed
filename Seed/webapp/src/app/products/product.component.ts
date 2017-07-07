import { Product } from './model/product';
import { ProductDataService } from './service/product-data.service';
import { Component, OnInit } from '@angular/core';
import 'rxjs/add/operator/map';
@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {

  products: Product[];
  constructor(private _productService: ProductDataService) { }

  ngOnInit() {
    this._productService.getProducts().subscribe(
      prds => {
        this.products = prds;
      }
    );
  }
}
