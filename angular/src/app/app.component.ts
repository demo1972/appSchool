import { Component } from '@angular/core';
import { DynamicLayoutComponent, ReplaceableComponentsService } from '@abp/ng.core';
import { LoaderBarComponent } from '@abp/ng.theme.shared';
import { eThemeLeptonXComponents } from '@abp/ng.theme.lepton-x';
import { Login } from './auth/login/login';
import { eAccountComponents } from '@abp/ng.account';
import { Wrapper } from './auth/wrapper/wrapper';
import { LogoComponent } from './shared/logo-component/logo-component';
import { NavbarComponent } from './theme/navbar-component/navbar-component';
import { ToolbarComponent } from './theme/toolbar-component/toolbar-component';

@Component({
  selector: 'app-root',
  template: `
    <abp-loader-bar />
    <abp-dynamic-layout />
  `,
  imports: [LoaderBarComponent, DynamicLayoutComponent],
})
export class AppComponent {
constructor(private replaceableComponents: ReplaceableComponentsService) {

    this.replaceableComponents.add({
      component: Login,
      key: eAccountComponents.Login,
    });
    
    this.replaceableComponents.add({
      component: Wrapper,
    key: eThemeLeptonXComponents.AccountLayout,
    });
    this.replaceableComponents.add({
          component: LogoComponent,
          key: eThemeLeptonXComponents.Logo,
});
this.replaceableComponents.add({
   key: eThemeLeptonXComponents.Navbar,
      component: NavbarComponent
})   

  }
}
