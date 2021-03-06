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
      return this.http.get('http://localhost:5000/api/todo/').map(res => res.json());
  }

  deleteById(id:number){
    return this.http.delete('http://localhost:5000/api/todo/' + id.toString()).subscribe(resp => console.log(resp));
  }

  create(input:string){
    return this.http.post('http://localhost:5000/api/todo/',{'input':input}).subscribe(resp => console.log(resp));
  }

  toggle(id:number, done:boolean){
    return this.http.put('http://localhost:5000/api/todo/' + id.toString(), {'done':done}).subscribe(resp => console.log(resp));
  }

}