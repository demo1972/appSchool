import { AuthService, ConfigStateService, CurrentUserDto } from '@abp/ng.core';
import { UserMenuService } from '@abp/ng.theme.shared';
import { Component } from '@angular/core';

@Component({
  selector: 'app-navbar-component',
  imports: [],
  templateUrl: './navbar-component.html',
  styleUrl: './navbar-component.scss'
})
export class NavbarComponent {
  userInfo:CurrentUserDto;
  currentPage='';
constructor(    protected authService: AuthService,private configState:ConfigStateService){

   this.userInfo = this.configState.getOne("currentUser");

}

logOut(){
  this.authService.logout().subscribe(x=>{

    this.authService.navigateToLogin();
  })
}
}
