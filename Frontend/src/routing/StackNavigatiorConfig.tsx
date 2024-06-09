import {CustomerInterface} from '../models/customer/CustomerInterface';

export type StackParamList = {
  Login: undefined;
  Home: undefined;
  CustomerDetails: {customer: CustomerInterface};
};
