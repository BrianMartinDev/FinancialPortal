import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PortalAccountSummaryComponent } from './portal/portal-account-summary/portal-account-summary.component';
import { PortalAccountsComponent } from './portal/portal-accounts/portal-accounts.component';
import { PortalSidebarComponent } from './portal/portal-sidebar/portal-sidebar.component';
import { PortalSummaryComponent } from './portal/portal-summary/portal-summary.component';
import { PortalComponent } from './portal/portal.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { PortalCardsComponent } from './portal/portal-cards/portal-cards.component';
import { TopNavBarComponent } from './portal/top-nav-bar/top-nav-bar.component';
import { HttpClientModule } from '@angular/common/http';
import { LoginComponent } from './acount/login/login.component';

@NgModule({
  declarations: [
    AppComponent,
    TopNavBarComponent,
    PortalComponent,
    PortalSidebarComponent,
    PortalAccountSummaryComponent,
    PortalAccountsComponent,
    PortalSummaryComponent,
    PortalCardsComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    HttpClientModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
