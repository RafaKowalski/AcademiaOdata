import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProfessorComponent } from './features/professor/professor.component';
import { AlunoComponent } from './features/aluno/aluno.component';

const routes: Routes = [
  {
    path: 'professor',
    component: ProfessorComponent
  },
  {
    path: 'aluno',
    component: AlunoComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
