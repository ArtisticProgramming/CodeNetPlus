import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CodeNoteFormComponent } from './code-note-form/code-note-form.component';
import { TestComponent } from './test/test.component';

const routes: Routes = [
  { path: 'test-component', component: TestComponent },
  { path: 'codeNoteRegistration', component: CodeNoteFormComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
