import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Angajat } from '../models/angajat.model';
//import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class AngajatiService {
  baseApiUrl: string = "https://localhost:7040/"
  constructor(private http: HttpClient) { }

  getAllAngajati() {
    return this.http.get<Angajat[]>(this.baseApiUrl + '/api/angajati');
  }
}
