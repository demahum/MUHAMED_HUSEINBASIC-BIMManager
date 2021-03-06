import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {

  email = '';
  password = '';

  constructor(private http: HttpClient) {}

  login(): void {

    this.http.post<any>('http://localhost:5000/api/auth/login', {
      Email: this.email,
      Password: this.password
    })
      .subscribe((response: any) => console.log(response),
        (err: any) => console.error(err));
  }
}
