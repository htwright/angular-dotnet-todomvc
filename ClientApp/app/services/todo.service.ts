import {Injectable, Inject} from "@angular/core";
import {Location} from "@angular/common";
import {Todo} from '../components/todo/todo.component';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class TodoService {
  @Inject('BASE_URL') baseUrl:string;
  
  constructor(private http: Http, @Inject('BASE_URL') baseUrl: string, private location: Location){
    console.log('todo service initialized')
    // var BaseUrl:string = baseUrl;
    // console.log(this.getTodos().subscribe(result => result.json()));
  }

  getTodos(){
    // console.log(this.baseUrl)
      return this.http.get('http://localhost:5000/api/todo/todos')
  }

}