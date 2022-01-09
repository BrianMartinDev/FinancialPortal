import { Injectable } from '@angular/core';
import { CustomerAccount } from './Models/CustomerAccount';
import { HttpClient } from '@angular/common/http';
import { Customer } from './Models/Customer';
@Injectable({
  providedIn: 'root',
})
export class PortalService {
  readonly _baseUrl = 'https://localhost:5001/api/Customer';
  list!: Customer[];
  constructor(private http: HttpClient) {
    this.getCustomerAccount();
    console.log(this.list);
  }

  getCustomerAccount() {
    this.http
      .get(this._baseUrl)
      .toPromise()
      .then((result) => ((this.list = result as Customer[]),console.log(this.list) ));
  }
}
