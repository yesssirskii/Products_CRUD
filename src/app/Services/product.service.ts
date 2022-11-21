import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Product } from '../Models/product';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})

export class ProductService {
  
  constructor(private http: HttpClient) { }

  // Declaring variable 'api' which grabs the 'apiUrl' variable from the 'environment.ts' file:
  private api = environment.apiUrl;

  // GET method:
  public getProducts(): Observable<Product[]>{
    return this.http.get<Product[]>(this.api + 'getProducts');
  }

  // POST method:
  public addProduct(product: Product): Observable<Product[]>{
    return this.http.post<Product[]>(this.api + 'addProduct/', product);
  }

  // PUT method:
  public updateProduct(id: any){
    return this.http.put<Product[]>(this.api + 'updateProduct?id=' , id);
  }

  // DELETE method:
  public deleteProduct(id: any){
    return this.http.delete<Product[]>(this.api + 'deleteProduct?id=' + id);
  }
}
