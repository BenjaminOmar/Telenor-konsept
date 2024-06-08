import React from 'react';
import {RouteProp, useNavigation} from '@react-navigation/native';
import {StackParamList} from '../routing/StackNavigatiorConfig';
import {NativeStackNavigationProp} from '@react-navigation/native-stack';
import {createMaterialTopTabNavigator} from '@react-navigation/material-top-tabs';
import Details from '../components/customer/customerDetails/Details';
import Tasks from './Tasks';
import {StyleSheet, Text, TouchableOpacity, View} from 'react-native';
import Sales from '../components/customer/customerDetails/Sales';

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

  const Tab = createMaterialTopTabNavigator();

  return (
    <>
      <View style={styles.headerContent}>
        <TouchableOpacity onPress={handleGoBack} style={styles.backButton}>
          <Text>go back</Text>
        </TouchableOpacity>
      </View>
      <Tab.Navigator
        screenOptions={{
          tabBarStyle: styles.tabBarStyle,
          tabBarIndicatorStyle: styles.tabBarIndicatorStyle,
          tabBarActiveTintColor: styles.tabBarActiveTintColor.color,
          tabBarInactiveTintColor: styles.tabBarInactiveTintColor.color,
        }}>
        <Tab.Screen
          name="Om"
          component={Details}
          initialParams={{customer}}
          options={{title: 'Om'}}
        />
        <Tab.Screen name="Oppgaver" component={Tasks} />
        <Tab.Screen name="Salg" component={Sales} />
      </Tab.Navigator>
    </>
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
