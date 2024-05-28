import React from 'react';
import {ScrollView, View, Text, StyleSheet} from 'react-native';
import {RouteProp} from '@react-navigation/native';
import {StackParamList} from '../routing/StackNavigatiorConfig';
import DetailsCard from '../components/customer/cards/DetailsCard';

type CustomerDetailsRouteProp = RouteProp<StackParamList, 'CustomerDetails'>;

type Props = {
  route: CustomerDetailsRouteProp;
};

const CustomerDetails: React.FC<Props> = ({route}) => {
  const {customer} = route.params;

  return (
    <View style={styles.container}>
      <Text style={styles.headerText}>{customer.name}</Text>
      <View style={styles.divider} />
      <ScrollView contentContainerStyle={styles.scrollViewContent}>
        <DetailsCard details={customer} />
      </ScrollView>
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
  },
  headerText: {
    textAlign: 'center',
    fontSize: 34,
    fontWeight: 'bold',
    color: '#00ACE7',
  },
  divider: {
    width: '80%',
    height: 3,
    borderRadius: 10,
    alignSelf: 'center',
    backgroundColor: '#CED0CE',
    marginVertical: 5,
  },
  scrollViewContent: {
    padding: 10,
  },
});

export default CustomerDetails;
