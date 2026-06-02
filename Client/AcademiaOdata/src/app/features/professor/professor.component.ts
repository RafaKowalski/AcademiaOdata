import { Component, inject, OnInit } from '@angular/core';
import { ProfessorService } from 'src/app/services/professorService/professor.service';

@Component({
  selector: 'app-professor',
  templateUrl: './professor.component.html',
  styleUrls: ['./professor.component.scss']
})
export class ProfessorComponent  implements OnInit {

  professores : any[] = [];
  elements = [
    { teste1 : 'teste1'},
    { teste2 : 'teste2'},
    { teste3 : 'teste3'},
  ]

  private professorService = inject(ProfessorService);

  ngOnInit(): void {
    this.professorService.GetAllProfessores().subscribe(professores => {
      this.professores = professores;
    });

  }
}
