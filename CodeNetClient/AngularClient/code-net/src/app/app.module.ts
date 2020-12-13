import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TestComponent } from './test/test.component';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { CodeNoteFormComponent } from './code-note-form/code-note-form.component';


export function getBaseUrl() {
   let apiServerUrl = "https://localhost:44373/"
   return apiServerUrl;
}

@NgModule({
  declarations: [
    AppComponent,
    TestComponent,
    CodeNoteFormComponent,
  ],
  imports: [
    FormsModule,
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    CommonModule,
    HttpClientModule,
  ],
  providers:[ { provide: 'BASE_URL', useFactory: getBaseUrl}],
  bootstrap: [AppComponent]
})

export class AppModule { }

