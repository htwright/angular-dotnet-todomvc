import { Component, Inject, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { TodoService } from '../../services/todo.service'

@Component({
    selector: 'todo',
    templateUrl: './todo.component.html',
    providers: [TodoService]
})
export class TodoComponent implements OnInit {

    onClick(input:string){
      console.log(input);
    }

    ngOnInit(){
      this.todoService.getTodos().subscribe(result => {
        this.todos = result;
      }, error => console.error(error));

    }


    public todos: Todo[];
    

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string, private todoService: TodoService) {

    }

    onDelete(todo:Todo):void{
      this.todoService.deleteById(todo.id);
    }

    onSubmit(text:string){
      this.todoService.create(text);
    }
}

export interface Todo {
    id: number;
    task: string;
    done: boolean;
}
