export class Account {
  accountID: number;
  balance: number;
  interestRate: number;
  lastAccessTimeStamp: string;
  constructor() {
    this.accountID = 0;
    this.balance = 0;
    this.interestRate = 0;
    this.lastAccessTimeStamp = '';
  }
}
