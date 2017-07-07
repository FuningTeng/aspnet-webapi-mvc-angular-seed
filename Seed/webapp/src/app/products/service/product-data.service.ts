
import { Product } from './../model/product';
import { Injectable } from '@angular/core';
import { Http, Headers } from '@angular/http';
import { environment } from '../../../environments/environment';
import { Subscription, Observable } from 'rxjs/Rx';
import 'rxjs/add/operator/map';

@Injectable()
export class ProductDataService {

  constructor(private http: Http) { console.log('Product-data Service Initialized...'); }

  getProducts() {
    if (false == environment.production) {
       return this.http.get('mock/mock-products.json').map( res => res.json());
    } else {
      return this.http.get('api/products').map(res => res.json());
    }
  }
}
