import { Injectable } from '@angular/core';
import {HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class SharedService {
readonly APIURL="http://localhost:5000/api";

  constructor(private http: HttpClient) { }

  getClients():Observable<any[]>{
    return this.http.get<any[]>(this.APIURL+'/controller');
  }
  getClient(val:any):Observable<any>{
    return this.http.get(this.APIURL+'/controller/'+val);
  }
  addClient(val:any){
  return this.http.post(this.APIURL+'/controller',val);
  }
  updateClient(val:any){
    return this.http.put(this.APIURL+'/controller',val);
  }
  deleteClient(val:any){
    return this.http.delete(this.APIURL+'/controller/'+val);
  }
}
