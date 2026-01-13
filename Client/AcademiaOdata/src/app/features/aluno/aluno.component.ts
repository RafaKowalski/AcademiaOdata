import { Component, inject, OnInit } from '@angular/core';
import { AlunoService } from 'src/app/services/alunoService/aluno.service';

@Component({
  selector: 'app-aluno',
  templateUrl: './aluno.component.html',
  styleUrls: ['./aluno.component.scss']
})
export class AlunoComponent implements OnInit {
  alunos : any[] = [];

  private alunoService = inject(AlunoService);

  ngOnInit(): void {
    this.alunoService.GetAllAlunos().subscribe(alunos => {
      this.alunos = alunos;
    });
  }
}
