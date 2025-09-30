import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { LoadingService } from './loader.service';

@Component({
  selector: 'app-loader',
  imports: [CommonModule],
  templateUrl: './loader.html',
  styleUrl: './loader.scss'
})
export class Loader {
  constructor(private loaderService:LoadingService){}
 loading$ = this.loaderService.loading$;
}
