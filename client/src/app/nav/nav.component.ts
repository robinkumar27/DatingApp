import { ThrowStmt } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
// import { error } from 'console' causing error ts2307 cannot find module; 
import { AccountService } from '../_services/account.service';


@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model:any ={}
  loggedIn:boolean;
 

  constructor(private accountservice:AccountService) { 
    this.loggedIn=false;
  }

  ngOnInit(): void {

  }
  login()
  {
    this.accountservice.login(this.model).subscribe(
      response=>{
        console.log(response);
        this.loggedIn=true;
      }, error=>{
        console.log(error);//new
      }
      
    )

     console.log(this.model);
  }
  logout()
  {
    this.loggedIn=false;
  }

}
