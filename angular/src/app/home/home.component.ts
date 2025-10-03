import { Component, inject } from '@angular/core';
import { AuthService, LocalizationPipe } from '@abp/ng.core';
import { BreadCumDto, ToolbarComponent } from "../theme/toolbar-component/toolbar-component";

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
  imports: [LocalizationPipe, ToolbarComponent]
})
export class HomeComponent {
  private authService = inject(AuthService);

  breadcums:BreadCumDto[]=[{
    title:"Inicio",routerLink:'/',active:true

  }]
  get hasLoggedIn(): boolean {
    return this.authService.isAuthenticated
  }

  login() {
    this.authService.navigateToLogin();
  }
}
