import {Injectable, Inject} from "@angular/core";
import {Location} from "@angular/common";
import {Todo} from '../components/todo/todo.component';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/Rx';
import 'rxjs/add/operator/map';

@Injectable()
export class TodoService {
  @Inject('BASE_URL') baseUrl:string;
  
  constructor(private http: Http, @Inject('BASE_URL') baseUrl: string, private location: Location){
    console.log('todo service initialized')
  }

  getTodos():Observable<Todo[]>{
      return this.http.get('http://localhost:5000/api/todo/todos').map(res => res.json());
  }

  deleteById(id:number){
    return this.http.get('http://localhost:5000/api/todo/delete/' + id.toString());
  }

  create(input:string){
    return this.http.post('http://localhost:5000/api/todo/create/', {input:input});
  }

}