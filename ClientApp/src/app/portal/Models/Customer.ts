import { Address } from "./Address";

export class Customer {
  customerID: number;
  firstName: string;
  lastName: string;
  age: string;
  phoneNumber: string;
  constructor() {
    this.customerID = 0;
    this.firstName = '';
    this.lastName = '';
    this.age = '';
    this.phoneNumber = '';
  }
}
