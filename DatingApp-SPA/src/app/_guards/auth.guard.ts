import { Injectable } from '@angular/core';
import { CanActivate, CanActivateChild, CanLoad, Route, UrlSegment, Router} from '@angular/router';
import { constructDependencies } from '@angular/core/src/di/reflective_provider';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';


@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate, CanActivateChild, CanLoad {
  constructor(private authService: AuthService, private router: Router,
              private alertify: AlertifyService) {}
  canActivate(): boolean  {
    if (this.authService.loggedIn()) {
      return true;
    }
    this.alertify.error('You have no permission');
    this.router.navigate(['/home']);
    return false;

  }
  canActivateChild(): boolean  {
    return true;
  }
  canLoad(
    route: Route,
    segments: UrlSegment[]): boolean {
    return true;
  }
}
