import { AuthService } from '@abp/ng.core';
import { UserMenuService } from '@abp/ng.theme.shared';
import { Component } from '@angular/core';

@Component({
  selector: 'app-navbar-component',
  imports: [],
  templateUrl: './navbar-component.html',
  styleUrl: './navbar-component.scss'
})
export class NavbarComponent {
constructor(    protected authService: AuthService, ){

}
logOut(){
  this.authService.logout().subscribe(x=>{
    this.authService.navigateToLogin();
  })
}
}
