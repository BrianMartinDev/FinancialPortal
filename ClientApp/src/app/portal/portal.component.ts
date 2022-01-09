import { Component, OnInit } from '@angular/core';
import { PortalService } from './portal.service';

@Component({
  selector: 'app-portal',
  templateUrl: './portal.component.html',
  styles: [
  ]
})
export class PortalComponent implements OnInit {

  constructor(private service: PortalService) { }

  ngOnInit(): void {
    this.service.getCustomerAccount();
  }

}
