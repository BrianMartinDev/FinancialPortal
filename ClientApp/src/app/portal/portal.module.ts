import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { PortalAccountsComponent } from './portal-accounts/portal-accounts.component';
import { PortalAccountSummaryComponent } from './portal-account-summary/portal-account-summary.component';
import { PortalCardsComponent } from './portal-cards/portal-cards.component';
import { TopNavBarComponent } from './top-nav-bar/top-nav-bar.component';



@NgModule({
  declarations: [
    PortalCardsComponent,
  ],
  imports: [
    CommonModule,
    BrowserModule, RouterModule, FormsModule,

  ]
})
export class PortalModule { }
