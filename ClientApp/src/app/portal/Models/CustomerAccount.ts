import { Account } from "./Account";
import { Customer } from "./Customer";

export class CustomerAccount {
  customerAccountID: number;
  Customer: Customer = new Customer;
  Account!: Account;

constructor() {
    this.customerAccountID = 0;

  }
}
