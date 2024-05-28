// CustomerDetails.tsx
import React from 'react';
import {View, Text, StyleSheet} from 'react-native';
import {RouteProp} from '@react-navigation/native';
import {NativeStackNavigationProp} from '@react-navigation/native-stack';
import {StackParamList} from '../routing/StackNavigatiorConfig';

type CustomerDetailsRouteProp = RouteProp<StackParamList, 'CustomerDetails'>;

type Props = {
  route: CustomerDetailsRouteProp;
};

const CustomerDetails: React.FC<Props> = ({route}) => {
  const {customer} = route.params;

  return (
    <View style={styles.container}>
      <Text style={styles.name}>Name: {customer.name}</Text>
      <Text style={styles.id}>ID: {customer.customerId}</Text>
      {/* Add more customer details here */}
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: 'center',
    alignItems: 'center',
    padding: 16,
  },
  name: {
    fontSize: 24,
    fontWeight: 'bold',
  },
  id: {
    fontSize: 18,
    marginTop: 8,
  },
});

export default CustomerDetails;
