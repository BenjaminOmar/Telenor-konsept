import React from 'react';
import {View, Text, StyleSheet, ScrollView} from 'react-native';
import {RouteProp} from '@react-navigation/native';
import {StackParamList} from '../../../../../../routing/StackNavigatiorConfig';
import CustomerDetailsDevider from '../../../../../../components/customer/details/CustomerDetailsDevider';
import DetailsCard from '../../../../../../components/customer/details/cards/DetailsCard';
import FinancialCard from '../../../../../../components/customer/details/cards/FinancialCard';

type Props = {
  route: RouteProp<StackParamList, 'CustomerDetails'>;
};

const About: React.FC<Props> = ({route}) => {
  const {customer} = route.params;

  return (
    <View style={styles.container}>
      <ScrollView contentContainerStyle={styles.scrollViewContent}>
        <DetailsCard details={customer} />
        <FinancialCard />
      </ScrollView>
    </View>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
  },
  headerContainer: {
    alignItems: 'center',
    justifyContent: 'center',
    paddingTop: 10,
  },
  headerContent: {
    flexDirection: 'row',
    alignItems: 'center',
  },
  headerText: {
    fontSize: 34,
    fontWeight: 'bold',
    color: '#00ACE7',
  },
  scrollViewContent: {
    padding: 10,
  },
});

export default About;
