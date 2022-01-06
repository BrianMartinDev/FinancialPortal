import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PortalAccountSummaryComponent } from './portal/portal-account-summary/portal-account-summary.component';
import { PortalAccountsComponent } from './portal/portal-accounts/portal-accounts.component';
import { PortalAddTransationComponent } from './portal/portal-add-transation/portal-add-transation.component';
import { PortalSidebarComponent } from './portal/portal-sidebar/portal-sidebar.component';
import { PortalSummaryComponent } from './portal/portal-summary/portal-summary.component';
import { PortalComponent } from './portal/portal.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

@NgModule({
  declarations: [
    AppComponent,
    PortalComponent,
    PortalSidebarComponent,
    PortalAccountSummaryComponent,
    PortalAccountsComponent,
    PortalSummaryComponent,
    PortalAddTransationComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
