import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'todo',
    templateUrl: './todo.component.html'
})
export class TodoComponent {

    onClick(input:string){
      console.log(input);
    }

    public todos: Todo[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/todo').subscribe(result => {
            this.todos = result.json() as Todo[];
        }, error => console.error(error));
    }
}

interface Todo {
    id: number;
    task: string;
    done: boolean;
}
