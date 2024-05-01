import {View, Text} from 'react-native';
import React from 'react';
import Dashboard from './Dashboard';
import {NavigationContainer} from '@react-navigation/native';
import {createBottomTabNavigator} from '@react-navigation/bottom-tabs';
import BusinessList from './BusinessList';
import Tasks from './Tasks';

const Tab = createBottomTabNavigator();

const Home = () => {
  return (
    <Tab.Navigator initialRouteName="Dashbord">
      <Tab.Screen
        name="Bedriftsliste"
        component={BusinessList}
        options={{headerShown: false}}
      />
      <Tab.Screen
        name="Dashbord"
        component={Dashboard}
        options={{headerShown: false}}
      />
      <Tab.Screen
        name="Oppgaver"
        component={Tasks}
        options={{headerShown: false}}
      />
    </Tab.Navigator>
  );
};

export default Home;
