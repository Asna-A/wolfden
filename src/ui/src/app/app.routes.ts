import { Routes } from '@angular/router';
import { CheckUserComponent } from './user/check-user/check-user.component';
import { SigninComponent } from './user/signin/signin.component';
import { LoginComponent } from './user/login/login.component';
import { UserComponent } from './user/user.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { EmployeeDirectoryComponent } from './dashboard/dashboard-body/main/employee-directory/employee-directory.component';
import { MainPageComponent } from './dashboard/dashboard-body/main/main-page/main-page.component';
import { CalendarViewComponent } from './dashboard/dashboard-body/main/attendance-module/calendar-view/calendar-view.component';
import { LeaveDashboardComponent } from './dashboard/dashboard-body/main/leave-management/leave-dashboard/leave-dashboard.component';
import { LeaveHistoryComponent } from './dashboard/dashboard-body/main/leave-management/leave-history/leave-history.component';
import { EmployeeHierarchyTreeComponent } from './employee-hierarchy-tree/employee-hierarchy-tree.component';
import { EmloyeeHierarchyDisplayComponent } from './employee-hierarchy-tree/emloyee-hierarchy-display/emloyee-hierarchy-display.component';
import { MyTeamComponent } from './my-team/my-team.component';
import { EditLeaveTypeComponent } from './dashboard/dashboard-body/main/leave-management/edit-leave-type/edit-leave-type.component';
import { UpdateLeaveBalanceComponent } from './dashboard/dashboard-body/main/leave-management/update-leave-balance/update-leave-balance.component';
import { ProfileComponent } from './profile/profile.component';
import { AddNewLeaveTypeComponent } from './dashboard/dashboard-body/main/leave-management/add-new-leave-type/add-new-leave-type.component';
import { LeaveApplicationComponent } from './dashboard/dashboard-body/main/leave-management/leave-application/leave-application.component';
import { UpdateLeaveSettingsComponent } from './dashboard/dashboard-body/main/leave-management/update-leave-settings/update-leave-settings.component';
import { SubordinateLeaveRequestComponent } from './dashboard/dashboard-body/main/leave-management/subordinate-leave-request/subordinate-leave-request.component';
import { EditLeaveRequestComponent } from './dashboard/dashboard-body/main/leave-management/edit-leave-request/edit-leave-request.component';
import { AddLeaveByAdminForEmployeesComponent } from './dashboard/dashboard-body/main/leave-management/add-leave-by-admin-for-employees/add-leave-by-admin-for-employees.component';



export const routes: Routes = [
 {
        path: 'user', 
        component: UserComponent,
        children:[
            {path: 'check-user', component: CheckUserComponent},
            {path: 'sign-in', component: SigninComponent},
            {path: 'login', component: LoginComponent},
        ]
    },
   


    {
        path:'dashboard',
        component:DashboardComponent,
        children:[
            {path:'main-page',component:MainPageComponent},
            {path:'employee-directory',component: EmployeeDirectoryComponent},
            {path:'leave-dashboard',component:LeaveDashboardComponent},
            {path:'leave-request-history',component:LeaveHistoryComponent},
            { path: 'edit-leave-type', component: EditLeaveTypeComponent },
            { path: 'update-leave-balance', component: UpdateLeaveBalanceComponent },
            {
                path: 'company-hierarchy',
                component: EmployeeHierarchyTreeComponent
            },
            {
                path: 'employee-display',
                component: EmloyeeHierarchyDisplayComponent
            },
            {
                path: 'my-team',
                component: MyTeamComponent
            },
            {
                path:'attendance/calendar',
                component:CalendarViewComponent
            },
            {
                path: 'leave-dashboard',
                component: LeaveDashboardComponent
            },
            {
                path: 'leave-request-history',
                component: LeaveHistoryComponent
            },
        
        
            {
                path: 'attendance/calendar',
                component: CalendarViewComponent
            },
            {
                path: '',
                component: UserComponent
        
            },
            {
                path: 'profile',
                component: ProfileComponent
            },
            {
                path: 'add-new-leave-type',
                component: AddNewLeaveTypeComponent
            },
            {
                path: 'leave-application',
                component: LeaveApplicationComponent
            },
            {
                path: 'update-leave-settings',
                component: UpdateLeaveSettingsComponent
            },
            {
                path: 'subordinate-leave-request',
                component: SubordinateLeaveRequestComponent
            },
            {
                path: 'edit-leave-request',
                component: EditLeaveRequestComponent
            },
            {
                path: 'add-leave-by-admin-for-employees',
                component: AddLeaveByAdminForEmployeesComponent
            }

            
        ]
    },
    { path: '', redirectTo: '/dashboard/main-page', pathMatch: 'full' }, 

 

];


    



