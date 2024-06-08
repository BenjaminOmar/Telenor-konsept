import React from 'react';
import {View, Text, StyleSheet, ScrollView} from 'react-native';
import {RouteProp} from '@react-navigation/native';
import {StackParamList} from '../../../routing/StackNavigatiorConfig';
import CustomerDetailsDevider from '../CustomerDetailsDevider';
import DetailsCard from '../cards/DetailsCard';
import FinancialCard from '../cards/FinancialCard';

type DetailsRouteProp = RouteProp<StackParamList, 'CustomerDetails'>;

type Props = {
  route: DetailsRouteProp;
};

const Details: React.FC<Props> = ({route}) => {
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
    paddingBottom: 10,
  },
  headerContent: {
    flexDirection: 'row',
    alignItems: 'center',
  },
  backButton: {
    marginRight: 10,
    marginLeft: -30,
  },
  headerText: {
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

export default Details;
