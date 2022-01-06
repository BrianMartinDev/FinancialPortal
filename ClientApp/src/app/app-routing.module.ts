import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PortalSummaryComponent } from './portal/portal-summary/portal-summary.component';
import { PortalComponent } from './portal/portal.component';

const routes: Routes = [{ path: '', component: PortalComponent }];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
