import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PortalAccountSummaryComponent } from './portal/portal-account-summary/portal-account-summary.component';
import { PortalAccountsComponent } from './portal/portal-accounts/portal-accounts.component';
import { PortalSummaryComponent } from './portal/portal-summary/portal-summary.component';
import { PortalComponent } from './portal/portal.component';

const routes: Routes = [
  {
    path: "", component: PortalComponent,
    children: [
        { path: "bankaccounts", component: PortalAccountsComponent },
        { path: "summary", component: PortalSummaryComponent },
        { path: "accounts", component: PortalAccountSummaryComponent },


    ]
},

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
