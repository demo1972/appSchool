import { ConfigStateService, CurrentUserDto } from '@abp/ng.core';
import { CommonModule } from '@angular/common';
import { Component, Input } from '@angular/core';

export interface BreadCumDto {
  title:string;
  active:boolean
  routerLink:string
}
@Component({
  selector: 'app-toolbar-component',
  imports: [CommonModule],
  templateUrl: './toolbar-component.html',
  styleUrl: './toolbar-component.scss'
})

export class ToolbarComponent {
  userInfo:CurrentUserDto;
  currentPage = '';
 @Input() breacumbs:BreadCumDto[]=[]
constructor(    private configState:ConfigStateService){

   this.userInfo = this.configState.getOne("currentUser");

}
}
