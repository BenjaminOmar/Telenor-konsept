import React from 'react';
import {
  ScrollView,
  View,
  Text,
  StyleSheet,
  TouchableOpacity,
} from 'react-native';
import {RouteProp, useNavigation} from '@react-navigation/native';
import {StackParamList} from '../routing/StackNavigatiorConfig';
import DetailsCard from '../components/customer/cards/DetailsCard';
import {NativeStackNavigationProp} from '@react-navigation/native-stack';
import Icon from 'react-native-vector-icons/Ionicons';
import FinancialCard from '../components/customer/cards/FinancialCard';

type CustomerDetailsRouteProp = RouteProp<StackParamList, 'CustomerDetails'>;
type CustomerDetailsNavigationProp = NativeStackNavigationProp<
  StackParamList,
  'CustomerDetails'
>;

type Props = {
  route: CustomerDetailsRouteProp;
};

const CustomerDetails: React.FC<Props> = ({route}) => {
  const {customer} = route.params;
  const navigation = useNavigation<CustomerDetailsNavigationProp>();

  const handleGoBack = () => {
    navigation.goBack();
  };

  return (
    <View style={styles.container}>
      <View style={styles.headerContainer}>
        <View style={styles.headerContent}>
          <TouchableOpacity onPress={handleGoBack} style={styles.backButton}>
            <Icon name="arrow-back" size={34} color="#00ACE7" />
          </TouchableOpacity>
          <Text style={styles.headerText}>{customer.name}</Text>
        </View>
      </View>
      <View style={styles.divider} />
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

export default CustomerDetails;
