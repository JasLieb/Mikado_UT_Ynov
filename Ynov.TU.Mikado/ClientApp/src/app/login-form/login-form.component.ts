import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';


@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.css']
})
export class LoginFormComponent implements OnInit {
  loginForm: FormGroup;

  constructor(private fb: FormBuilder) { }

  ngOnInit() {
    this.loginForm = this.fb.group({  // Crée une instance de FormGroup
      email: [],                      // Crée une instance de FormControl
      password: [],                   // Crée une instance de FormControl
    });
  }

  login() {
    console.log('Données du formulaire...', this.loginForm);
  }
}
