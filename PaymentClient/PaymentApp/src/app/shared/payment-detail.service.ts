// eslint-disable-next-line @typescript-eslint/no-unused-vars
import { Injectable } from '@angular/core';
import { PaymentDetail } from './payment-detail.model';

@Injectable({
  providedIn: 'root'
})
// eslint-disable-next-line @typescript-eslint/no-unused-vars
export class PaymentDetailService {

  // eslint-disable-next-line @typescript-eslint/no-useless-constructor
  constructor() { }
  readonly baseURL = 'http://localhost:44383/api/PaymentDetails'
  formData: PaymentDetail = new PaymentDetail();
}
