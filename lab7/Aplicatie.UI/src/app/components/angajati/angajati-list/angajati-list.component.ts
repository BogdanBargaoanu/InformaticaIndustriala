import { Component } from '@angular/core';
import { Angajat } from '../../../models/angajat.model';
import { AngajatiService } from '../../../services/angajati.service';

@Component({
  selector: 'app-angajati-list',
  standalone: true,
  imports: [],
  templateUrl: './angajati-list.component.html',
  styleUrl: './angajati-list.component.css'
})


export class AngajatiListComponent {
  constructor(private serviciuAngajati: AngajatiService) { };
  angajati: Angajat[] = [];
  ngOnInit(): void {
    this.serviciuAngajati.getAllAngajati().subscribe({
      next:(angajati) => console.log(angajati),
      error: (err) => console.log(err)
    }
  )

}
}
