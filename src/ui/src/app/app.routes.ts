import { Routes } from '@angular/router';
import { CheckUserComponent } from './user/check-user/check-user.component';
import { SigninComponent } from './user/signin/signin.component';
import { LoginComponent } from './user/login/login.component';
import { UserComponent } from './user/user.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { EmployeeDirectoryComponent } from './dashboard/dashboard-body/main/employee-directory/employee-directory.component';

export const routes: Routes = [
    {
        path: 'user', 
        component: UserComponent,
        children:[
            {path: 'check-user', component: CheckUserComponent},
            {path: 'sign-in', component: SigninComponent},
            {path: 'login', component: LoginComponent}
        ]
    },
    {path: 'dashboard', component: DashboardComponent},

    {
        path:'dashboard',
        component:DashboardComponent,
        children:[
            {path:'employee-directory',component: EmployeeDirectoryComponent}
        ]
    }


 
];


