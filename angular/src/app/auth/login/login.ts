import { Component } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, UntypedFormBuilder, Validators } from '@angular/forms';

import { CommonModule } from '@angular/common';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthService } from '@abp/ng.core';
import { ToasterService } from '@abp/ng.theme.shared';
import { catchError, finalize, throwError } from 'rxjs';
import { LoadingService } from 'src/app/shared/loader/loader.service';

@Component({
  selector: 'app-login',
  imports: [FormsModule, ReactiveFormsModule, CommonModule],
  templateUrl: './login.html',
  styleUrl: './login.scss'
})
export class Login {
  loginForm: FormGroup;
  showPassword = false;
  constructor(
    protected fb: UntypedFormBuilder,
    private router: Router,
    private route: ActivatedRoute,
    protected authService: AuthService,
    protected toasterService: ToasterService,
    protected loaderService:LoadingService
  ) {

    this.loginForm = this.fb.group({
          username: ['', [Validators.required, ]],
          password: ['', [Validators.required, Validators.minLength(6)]],
          rememberMe: [false],
    
    });
  }


  get f() {
    return this.loginForm.controls;
  }
  togglePassword() {
    this.showPassword = !this.showPassword;
  }
  onSubmit() {
    this.loaderService.show()
    if (this.loginForm.invalid) return;


    const { username, password, rememberMe } = this.loginForm.value;

    const redirectUrl = this.route.snapshot.queryParams.returnUrl || "/"

    this.authService
      .login({ username, password, rememberMe, redirectUrl })
      .pipe(
        catchError(err => {
          this.toasterService.error(
            err.error?.error_description ||
            err.error?.error.message ||
            'AbpAccount::DefaultErrorMessage',
            '',
            { life: 7000 },
          );
          this.loaderService.hide();
          return throwError(err);
        }),
        finalize(() => (console.log("Entro"))),
      )
      .subscribe(x=>{

      });

  }
}
