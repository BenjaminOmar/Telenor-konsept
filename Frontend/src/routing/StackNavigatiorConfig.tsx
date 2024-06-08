import {Customer} from '../models/customer/customer';

export type StackParamList = {
  Login: undefined;
  Home: undefined;
  CustomerDetails: {customer: Customer};
};
