import { FormControl } from "@angular/forms";

export interface ICheckForm {

    rfid: FormControl<string | null>;
    employeeCode: FormControl<string | null>;
}
