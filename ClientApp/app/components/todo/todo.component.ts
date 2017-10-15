import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { TodoService } from '../../services/todo.service'

@Component({
    selector: 'todo',
    templateUrl: './todo.component.html',
    providers: [TodoService]
})
export class TodoComponent {

    onClick(input:string){
      console.log(input);
    }



    public todos: Todo[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string, private todoService: TodoService) {
      this.todoService.getTodos().subscribe(result => {
        this.todos = result.json() as Todo[];
      }, error => console.error(error));
    }

    onDelete(todo:Todo):void{
      console.log(todo);
      // Http({method: 'GET', url:baseUrl + 'api/todo/delete/' + todo.id})
    }
}

export interface Todo {
    id: number;
    task: string;
    done: boolean;
}
