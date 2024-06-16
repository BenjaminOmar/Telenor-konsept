// src/components/CustomerDetails.tsx
import React, {useEffect} from 'react';
import {RouteProp, useNavigation} from '@react-navigation/native';
import {createMaterialTopTabNavigator} from '@react-navigation/material-top-tabs';
import {StyleSheet, Text, TouchableOpacity, View} from 'react-native';
import {NativeStackNavigationProp} from '@react-navigation/native-stack';
import {useHeader} from '../../../../../context/HeaderContext';
import Tasks from '../../Tasks';
import Sales from './subPages/Sales';
import About from './subPages/About';
import {CustomerInterface} from '../../../../../models/customer/CustomerInterface';
import Contacts from './subPages/Contacts';

type StackParamList = {
  CustomerDetails: {customer: CustomerInterface};
};

type CustomerDetailsRouteProp = RouteProp<StackParamList, 'CustomerDetails'>;
type CustomerDetailsNavigationProp = NativeStackNavigationProp<
  StackParamList,
  'CustomerDetails'
>;

interface Props {
  route: CustomerDetailsRouteProp;
}

const CustomerDetails: React.FC<Props> = ({route}) => {
  const {customer} = route.params;
  const navigation = useNavigation<CustomerDetailsNavigationProp>();
  const {setHeaderTitle, setShowGoBack, setHandleGoBack} = useHeader();

  useEffect(() => {
    setHeaderTitle(customer.name);
    setShowGoBack(true);
    setHandleGoBack(() => handleGoBack);

    return () => {
      setHeaderTitle('');
      setShowGoBack(false);
      setHandleGoBack(undefined);
    };
  }, [customer, setHeaderTitle, setShowGoBack, setHandleGoBack]);

  const handleGoBack = () => {
    navigation.goBack();
  };

  const Tab = createMaterialTopTabNavigator();

  return (
    <Tab.Navigator
      screenOptions={{
        tabBarStyle: styles.tabBarStyle,
        tabBarIndicatorStyle: styles.tabBarIndicatorStyle,
        tabBarActiveTintColor: styles.tabBarActiveTintColor.color,
        tabBarInactiveTintColor: styles.tabBarInactiveTintColor.color,
      }}>
      <Tab.Screen
        name="Om"
        component={About}
        initialParams={{customer}}
        options={{title: 'Om'}}
      />
      <Tab.Screen
        name="Kontakt"
        component={Contacts}
        initialParams={{customer}}
      />
      <Tab.Screen name="Oppgaver" component={Tasks} />
      <Tab.Screen name="Salg" component={Sales} />
    </Tab.Navigator>
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
  tabBarStyle: {
    backgroundColor: '#F0F0F0',
  },
  tabBarIndicatorStyle: {
    backgroundColor: '#00ACE7',
  },
  tabBarActiveTintColor: {
    color: '#000',
  },
  tabBarInactiveTintColor: {
    color: '#888',
  },
});

export default CustomerDetails;
