import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map, Observable, timeout } from 'rxjs';

export class Dog{
  private _id:number;
  private _name:string;
  private _description;
  private _maxLife;
  private _urlImage;

constructor(

  id:number,
  name:string,
  description:string,
  maxlife:number,
  urlImage:string
)
{
this._id=id;
this._name=name;
this._description=description;
this._maxLife=maxlife;
this._urlImage=urlImage;

}

public get id():number{return this._id;}
public get name():string{return this._name;}
public get description():string{return this._description;}
public get maxLife():number{return this._maxLife;}
public get urlImage():string{return this._urlImage;}
}

@Injectable({
  providedIn: 'root'
})
export class DogService {

  constructor(private http:HttpClient) { }

  getDogs():Observable<Dog[]>{
    return this.http.get<any[]>("http://localhost:5029/api/Dog")
    .pipe(timeout(2000),map(arreglo=>arreglo.map(
      objeto=>new Dog(
        objeto.id,
        objeto.name,
        objeto.description,
        objeto.maxLife,
        objeto.urlImage

      )
    )))
  }

}
