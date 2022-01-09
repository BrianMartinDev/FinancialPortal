export class Address {
  addressID: number;
  streetAddress: string;
  city: string;
  state: string;
  postalCode: string;
  constructor() {
    this.addressID = 0;
    this.streetAddress = '';
    this.city = '';
    this.state = '';
    this.postalCode = '';
  }
}
